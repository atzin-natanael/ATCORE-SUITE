using FirebirdSql.Data.FirebirdClient;
using PedidoXperto.ChildClases;
using PedidoXperto.Logic;

namespace PedidoXperto.ChildForms
{
    public partial class FormCrearPedido : Form
    {
        private decimal descuentoPorCliente = -1;
        public enum ColTabla
        {
            CodigoBarras = 0,
            Descripcion = 1,
            Cantidad = 2,
            Precio = 3,
            Descuento = 4,
            Total = 5
        }
        public FormCrearPedido()
        {
            InitializeComponent();
            CargarVendedores();
            descuentoPorCliente = 0;
        }
        public void CargarComboBox(List<List<string>> vendedores)
        {
            var nombres = new List<string>();
            foreach (var vendedor in vendedores)
            {
                nombres.Add(vendedor[1]);
            }
            // Limpiar y agregar los nombres
            Cb_Vendedor.Items.Clear();
            Cb_Vendedor.Items.AddRange(nombres.ToArray());

            // Configurar autocompletado
            Cb_Vendedor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Cb_Vendedor.AutoCompleteSource = AutoCompleteSource.CustomSource;
            Cb_Vendedor.AutoCompleteCustomSource = new AutoCompleteStringCollection();
            Cb_Vendedor.AutoCompleteCustomSource.AddRange(nombres.ToArray());
        }
        public void CargarVendedores()
        {
            List<List<string>> vendedores = new List<List<string>>();
            FbConnection con = new FbConnection(GlobalSettings.Instance.StringConnection);
            try
            {
                con.Open();
                string query = "SELECT VENDEDOR_ID, NOMBRE FROM VENDEDORES WHERE OCULTO = 'N'";
                FbCommand command = new FbCommand(query, con);
                FbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    List<string> vendedor = new List<string>();
                    vendedor.Add(reader.GetString(0));
                    vendedor.Add(reader.GetString(1));
                    vendedores.Add(vendedor);
                }
                CargarComboBox(vendedores);
                reader.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Se perdió la conexión :( , contacta a 06 o intenta de nuevo", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.ToString());
                return;
            }
            finally
            {
                con.Close();
            }
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBox_clienteId_TextChanged(object sender, EventArgs e)
        {
            if (InvalidText(txtBox_clienteId.Text))
                return;


            var data = DataBridge.GetClientName(txtBox_clienteId.Text);

            if (data == null)
            {
                txtBox_clienteNombre.Text = "Cliente no encontrado";
            }
            else
            {
                txtBox_clienteNombre.Text = data;
                //Obtiene el descuento por cliente una sola vez
                descuentoPorCliente = decimal.Parse(DataBridge.GetDiscountByClient(txtBox_clienteId.Text) ?? "-1");
            }
        }

        private bool InvalidText(string codigo, int minLength = 6)
        {
            return string.IsNullOrWhiteSpace(codigo) || codigo.Length < minLength;
        }
        private void Save_Click(object sender, EventArgs e)
        {

        }

        public Tuple<decimal, decimal> CalcularTotalesTabla()
        {
            // Verifica si la tabla tiene filas/articulos
            if (Tabla.Rows.Count < 1)
                return new(0, 0);

            decimal totalPrecio = 0;
            decimal totalDescuento = 0;
            decimal cantidad, precio;

            for (int i = 0; i < Tabla.Rows.Count; i++)
            {
                if (Tabla.Rows[i].Cells[(int)ColTabla.Total].Value == null) continue; //Valor nulo? no deberia ser posible

                cantidad = decimal.Parse(Tabla.Rows[i].Cells[(int)ColTabla.Cantidad].Value.ToString() ?? "0");
                precio = decimal.Parse(Tabla.Rows[i].Cells[(int)ColTabla.Precio].Value.ToString() ?? "0");

                if (cantidad <= 0 || precio <= 0) continue;

                totalPrecio += cantidad * precio;
                totalDescuento += cantidad * precio * (decimal.Parse(Tabla.Rows[i].Cells[(int)ColTabla.Descuento].Value.ToString()) / 100);
            }
            return new(totalPrecio * 1.16m, totalDescuento * 1.16m);
        }

        public void ActualizarPrecios()
        {
            Tuple<decimal, decimal> totales = CalcularTotalesTabla();
            precioTotal.Text = "$ " + Math.Round(totales.Item1, 2);
            valorDescuento.Text = "$ " + Math.Round(totales.Item2, 2);
            precioConDescuento.Text = "$ " + Math.Round(totales.Item1 - totales.Item2, 2);
        }

        private void txtBox_clienteId_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtBox_clienteNombre.Text != "Cliente no encontrado")
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true;
                    Tabla.Rows.Add();
                    Tabla.Rows[Tabla.CurrentCell.RowIndex].Height = 40;
                    Tabla.Focus();
                }
            }
        }

        /// <summary>
        /// Calcula el descuento por cliente y por artículo
        /// descuento por cliente ya debe tener un valor valido a este punto
        /// </summary>
        /// <param name="_articulo_id"></param>
        private void CalcularDescuentoArticulo(string _articulo_id)
        {
            decimal _descuentoPorArticulo = decimal.Parse(DataBridge.GetDiscountByArticle(_articulo_id) ?? "-1");

            // Calcular el descuento total efectivo usando la fórmula
            decimal _descuentoTotal =
            1 - (
                (1 - (descuentoPorCliente != decimal.MinusOne ? descuentoPorCliente / 100m : 0m))//Si hay descuento por cliente, se aplica
                *
                (1 - (_descuentoPorArticulo != decimal.MinusOne ? _descuentoPorArticulo : 0m))//Si hay descuento por articulo, se aplica
                );

            _descuentoTotal *= 100; // Convertir a porcentaje y mostrar el resultado
            Tabla.Rows[Tabla.CurrentCell.RowIndex].Cells[(int)ColTabla.Descuento].Value = _descuentoTotal;
        }

        private async void LlenarDatosArticulo()
        {
            string codigoBarras = Tabla.CurrentCell.Value.ToString();
            if (GlobalSettings.Instance.Crear_clave != null)
            {
                codigoBarras = GlobalSettings.Instance.Crear_clave;
                GlobalSettings.Instance.Crear_clave = null;
            }

            if (InvalidText(Tabla.CurrentCell.Value.ToString()))
                return;

            GetFireBirdValue bridge = new();

            string[] DatosArticulo = new string[2];

            DatosArticulo = bridge.BuscarDatosArticulos(codigoBarras);

            if (DatosArticulo != null)
            {
                string CLAVE_ARTICULO = DatosArticulo[0];
                string articulo_id = DataBridge.GetArticuloId(CLAVE_ARTICULO);
                Tabla.EndEdit();
                Tabla.CurrentRow.Cells[0].Value = CLAVE_ARTICULO;
                Tabla.CurrentRow.Cells[1].Value = DatosArticulo[1]; //NOMBRE
                Tabla.CurrentRow.Cells[3].Value = DatosArticulo[2]; //PRECIO
                //IA
                string codigoenviado = Tabla.Rows[Tabla.CurrentCell.RowIndex].Cells[0].Value.ToString();
                List<string> resultado = await DataBridge.ObtenerRecomendado(codigoenviado);
                string[] InfoArt = bridge.BuscarDatosArticulos(resultado[0]);
                string[] InfoArt2 = bridge.BuscarDatosArticulos(resultado[1]);
                TablaRecomendados.Rows.Add(resultado[0], InfoArt[1]);
                TablaRecomendados.Rows.Add(resultado[1], InfoArt2[1]);
                //CODIGO1.Text = resultado.Count > 0 ? resultado[0] : "";
                //CODIGO2.Text = resultado.Count > 1 ? resultado[1] : "";

                CalcularDescuentoArticulo(articulo_id);

                Tabla.Rows[Tabla.CurrentCell.RowIndex].Cells[(int)ColTabla.Total].Value = 0;
                Tabla.CurrentCell = Tabla.CurrentRow.Cells[(int)ColTabla.Cantidad];
                Tabla.BeginEdit(true);
            }
            else
                MessageBox.Show("Artículo no encontrado", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Tabla_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (Tabla.CurrentCell != null)
            {
                if (Tabla.CurrentCell.ColumnIndex == 0)//Es cuando llena la celda de clave_articulo
                {
                    LlenarDatosArticulo();//Llena los datos de un articulo
                }
                else if (Tabla.CurrentCell.ColumnIndex == 2 && Tabla.CurrentCell.Value != null)
                {
                    //if (e.RowIndex == Tabla.Rows.Count - 1)
                    //{
                    //    Tabla.Rows.Add();
                    //}

                    //// Mover a la siguiente fila, columna 0
                    //int siguienteFila = e.RowIndex + 1;
                    //if (siguienteFila < Tabla.Rows.Count)
                    //{
                    //    Tabla.CurrentCell = Tabla.Rows[siguienteFila].Cells[0];
                    //    Tabla.BeginEdit(true);
                    //}
                    if (Tabla.CurrentCell.Value.ToString() != string.Empty && decimal.Parse(Tabla.CurrentCell.Value.ToString()) > 0)
                    {
                        decimal precio = decimal.Parse(Tabla.Rows[Tabla.CurrentCell.RowIndex].Cells[(int)ColTabla.Precio].Value.ToString());
                        decimal cantidad = decimal.Parse(Tabla.Rows[Tabla.CurrentCell.RowIndex].Cells[(int)ColTabla.Cantidad].Value.ToString());
                        decimal descuentoind = decimal.Parse(Tabla.Rows[Tabla.CurrentCell.RowIndex].Cells[(int)ColTabla.Descuento].Value.ToString());

                        decimal total = precio * cantidad;
                        decimal descuentoAplicado = total * (descuentoind / 100m);  // Conviertes el descuento a un porcentaje
                        Tabla.Rows[Tabla.CurrentCell.RowIndex].Cells[(int)ColTabla.Total].Value = total - descuentoAplicado;
                        ActualizarPrecios();
                        if ((Tabla.CurrentCell.RowIndex) + 1 == Tabla.Rows.Count)
                        {
                            Tabla.Rows.Add();
                            Tabla.Rows[Tabla.CurrentCell.RowIndex + 1].Height = 40;
                            Tabla.CurrentCell = Tabla.Rows[Tabla.CurrentCell.RowIndex + 1].Cells[0];
                        }
                    }
                }

            }
        }

        private void Cb_Vendedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void DesplegarSearchmenu()
        {
            string parametros = Tabla.CurrentCell.EditedFormattedValue?.ToString() ?? "";
            if (parametros == string.Empty)//Si esta vacio no disparamos nada
                return;

            SearchMenu buscar = new SearchMenu(parametros);

            //buscar.Tabla.Rows.Clear();
            buscar.Tabla.Focus();
            buscar.ShowDialog();

            if (GlobalSettings.Instance.Crear_clave != null)
            {
                LlenarDatosArticulo();
                Tabla.CurrentCell = Tabla.Rows[Tabla.CurrentCell.RowIndex].Cells[(int)ColTabla.Cantidad];
                Tabla.BeginEdit(true);
            }
        }

        private void Tabla_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                if (Tabla.CurrentCell != null && Tabla.CurrentCell.ColumnIndex == 1)
                {
                    DesplegarSearchmenu();
                    e.Handled = true; // Opcional, previene otros efectos
                }
            }
            else if (e.Control && e.KeyCode == Keys.Delete)  // Verifica que Ctrl + Supr se presionen
            {
                if (Tabla.CurrentRow != null)  // Verifica si hay una fila seleccionada
                {
                    // Elimina la fila seleccionada
                    Tabla.Rows.Remove(Tabla.CurrentRow);
                    ActualizarPrecios();
                }
            }
        }



        private void Tabla_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is TextBox tb)
            {
                // Evita suscripciones múltiples
                tb.KeyDown -= Tabla_KeyDown;
                tb.KeyDown += Tabla_KeyDown;
            }
        }
    }
}
