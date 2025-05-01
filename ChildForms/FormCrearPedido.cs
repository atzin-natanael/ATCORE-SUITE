using System.Data;
using System.Web;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using PedidoXperto.ChildClases;
using PedidoXperto.Logic;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace PedidoXperto.ChildForms
{
    public partial class FormCrearPedido : Form
    {
        public FormCrearPedido()
        {
            InitializeComponent();
            CargarVendedores();
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
            if (InvalidText())
                return;

            Data bridge = new();

            var data = bridge.GetClientName(txtBox_clienteId.Text);

            if (data == null)
            {
                txtBox_clienteNombre.Text = "Cliente no encontrado";
            }
            else
                txtBox_clienteNombre.Text = data;
        }

        private bool InvalidText()
        {
            var clientId = txtBox_clienteId.Text;
            return string.IsNullOrWhiteSpace(clientId) || clientId.Length > 6;
        }
        private void Save_Click(object sender, EventArgs e)
        {

        }
        public Tuple<decimal, decimal>  Sumartabla()
        {
            decimal sumatoria = 0;
            decimal sumatoriaDescuento = 0;
            decimal cantidad = 0;
            Tuple<decimal, decimal> descuentos = new(0, 0);
            for (int i = 0; i < Tabla.Rows.Count; i++)
            {
                if (Tabla.Rows.Count >= 1)
                {
                    if (Tabla.Rows[i].Cells[5].Value != null)
                    {
                        cantidad = decimal.Parse(Tabla.Rows[i].Cells[2].Value.ToString());
                        if(cantidad <= 0)
                            continue;
                        sumatoria += cantidad * decimal.Parse(Tabla.Rows[i].Cells[3].Value.ToString());
                        sumatoriaDescuento += cantidad * decimal.Parse(Tabla.Rows[i].Cells[3].Value.ToString()) * (decimal.Parse(Tabla.Rows[i].Cells[4].Value.ToString()) / 100);
                    }
                }
            }
            descuentos = new(sumatoria* 1.16m, sumatoriaDescuento * 1.16m);
            return descuentos;
        }
        
        public void ActualizarPrecios()
        {
            Tuple<decimal, decimal> resultados = Sumartabla();
            precioTotal.Text = "$ " + Math.Round(resultados.Item1, 2);
            valorDescuento.Text = "$ " + Math.Round(resultados.Item2, 2);
            precioConDescuento.Text = "$ " + Math.Round(resultados.Item1 - resultados.Item2 , 2);
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
        
        private void CalcularDescuento(string _clave_articulo)
        {
            string articulo_id = new Data().GetArticuloId(_clave_articulo);
            string cliente_id = new Data().SearchClient(txtBox_clienteId.Text);

            Tuple<string, string> descuentos = new Data().GetDiscount(cliente_id, articulo_id);
            if (descuentos.Item2 == null)//Descuento por cliente
                Tabla.Rows[Tabla.CurrentCell.RowIndex].Cells[4].Value = descuentos.Item1;
            else //Descuento por cliente
            {
                decimal descuento1Decimal = decimal.Parse(descuentos.Item1) / 100m; // Descuento por cliente
                decimal descuento2Decimal = decimal.Parse(descuentos.Item2) / 100m; // Descuento por artículo

                // Calcular el descuento total efectivo usando la fórmula
                decimal descuentoTotal = 1 - ((1 - descuento1Decimal) * (1 - descuento2Decimal));

                // Convertir a porcentaje y mostrar el resultado
                decimal porcentajeDescuentoTotal = descuentoTotal * 100;
                Tabla.Rows[Tabla.CurrentCell.RowIndex].Cells[4].Value = porcentajeDescuentoTotal;
            }
        }

        private async void LlenarDatos()
        {
            if (InvalidText())
                return;
            GetFireBirdValue bridge = new();

            string[] DatosArticulo = new string[2];
            string descuento = "";
            string codigoBarras = "";
            if(GlobalSettings.Instance.Crear_clave != null)
            {
                codigoBarras = GlobalSettings.Instance.Crear_clave;
                GlobalSettings.Instance.Crear_clave = null;
            }
            else
            {
                codigoBarras = Tabla.CurrentCell.Value.ToString();
            }
            DatosArticulo = bridge.BuscarDatosArticulos(codigoBarras);
            if (DatosArticulo == null)
            {
                MessageBox.Show("Artículo no encontrado", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string CLAVE_ARTICULO = DatosArticulo[0];
                Tabla.EndEdit();
                Tabla.CurrentRow.Cells[0].Value = CLAVE_ARTICULO;
                Tabla.CurrentRow.Cells[1].Value = DatosArticulo[1]; //NOMBRE
                Tabla.CurrentRow.Cells[3].Value = DatosArticulo[2]; //PRECIO
                //IA
                string codigoenviado = Tabla.Rows[Tabla.CurrentCell.RowIndex].Cells[0].Value.ToString();
                List<string> resultado = await Data.ObtenerRecomendado(codigoenviado);
                string[] InfoArt = bridge.BuscarDatosArticulos(resultado[0]);
                string[] InfoArt2 = bridge.BuscarDatosArticulos(resultado[1]);
                TablaRecomendados.Rows.Add(resultado[0], InfoArt[1]);
                TablaRecomendados.Rows.Add(resultado[1], InfoArt2[1]);
                //CODIGO1.Text = resultado.Count > 0 ? resultado[0] : "";
                //CODIGO2.Text = resultado.Count > 1 ? resultado[1] : "";

                CalcularDescuento(CLAVE_ARTICULO);
          
                Tabla.Rows[Tabla.CurrentCell.RowIndex].Cells[5].Value = 0;//precio total
                Tabla.CurrentCell = Tabla.CurrentRow.Cells[2]; //cantidad
                Tabla.BeginEdit(true);
            }
        }

        private void Tabla_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (Tabla.CurrentCell != null)
            {
                if (Tabla.CurrentCell.ColumnIndex == 0)//Es cuando llena la celda de clave_articulo
                {
                    LlenarDatos();//LLena la tabla con los datos
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
                        decimal precio = decimal.Parse(Tabla.Rows[Tabla.CurrentCell.RowIndex].Cells[3].Value.ToString());
                        decimal cantidad = decimal.Parse(Tabla.Rows[Tabla.CurrentCell.RowIndex].Cells[2].Value.ToString());
                        decimal descuentoind = decimal.Parse(Tabla.Rows[Tabla.CurrentCell.RowIndex].Cells[4].Value.ToString());

                        decimal total = precio * cantidad;
                        decimal descuentoAplicado = total * (descuentoind / 100);  // Conviertes el descuento a un porcentaje
                        decimal totalConDescuento = total - descuentoAplicado;
                        Tabla.Rows[Tabla.CurrentCell.RowIndex].Cells[5].Value = totalConDescuento;
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

        

        private void Tabla_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                if (Tabla.CurrentCell != null && Tabla.CurrentCell.ColumnIndex == 1)
                {
                    string valorCelda = Tabla.CurrentCell.EditedFormattedValue?.ToString() ?? "";
                    string query = $@"
                    SELECT CLAVES_ARTICULOS.CLAVE_ARTICULO, ARTICULOS.NOMBRE, PRECIOS_ARTICULOS.PRECIO  
                    FROM ARTICULOS
                    JOIN CLAVES_ARTICULOS ON CLAVES_ARTICULOS.ARTICULO_ID = ARTICULOS.ARTICULO_ID
                    JOIN PRECIOS_ARTICULOS ON PRECIOS_ARTICULOS.ARTICULO_ID = ARTICULOS.ARTICULO_ID
                    WHERE CLAVES_ARTICULOS.ROL_CLAVE_ART_ID = '17'
                    AND PRECIOS_ARTICULOS.PRECIO_EMPRESA_ID = '42'";
                    string[] parametros = valorCelda.Split(' ');
                    foreach (string parametro in parametros)
                    {
                        query += $@"AND ARTICULOS.NOMBRE LIKE '%{parametro}%' ";
                    }
                    query += ";";

                    SearchMenu buscar = new SearchMenu(query);
                    buscar.Txt_Codigo.Text = valorCelda;
                    //buscar.Tabla.Rows.Clear();
                    buscar.Tabla.Focus();
                    buscar.ShowDialog();

                    e.Handled = true; // Opcional, previene otros efectos
                    if (GlobalSettings.Instance.Crear_clave != null)
                    {
                        LlenarDatos();
                        Tabla.CurrentCell = Tabla.Rows[Tabla.CurrentCell.RowIndex].Cells[2];
                        Tabla.BeginEdit(true);
                    }
                }
            }
            if (e.Control && e.KeyCode == Keys.Delete)  // Verifica que Ctrl + Supr se presionen
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
