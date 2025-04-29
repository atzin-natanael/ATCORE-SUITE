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
            Cb_Vendedor.DropDownStyle = ComboBoxStyle.DropDownList;
            // Limpiar y agregar los nombres
            Cb_Vendedor.Items.Clear();
            Cb_Vendedor.Items.AddRange(nombres.ToArray());
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
            return clientId.Length != 6;
        }

        private void Save_Click(object sender, EventArgs e)
        {

        }

        private void txtBox_clienteId_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtBox_clienteNombre.Text != "Cliente no encontrado")
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true;
                    Tabla.Rows.Add();
                    Tabla.Focus();
                }
            }
        }

        private void Tabla_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if(Tabla.CurrentCell != null)
            {
                if (Tabla.CurrentCell.ColumnIndex == 0)
                {
                    if (InvalidText())
                        return;
                    GetFireBirdValue bridge = new();
                    
                    string[] DatosArticulo = new string[2];
                    string descuento = "";
                    DatosArticulo = bridge.BuscarDatosArticulos(Tabla.CurrentCell.Value.ToString());
                    if (DatosArticulo == null)
                    {
                        MessageBox.Show("Artículo no encontrado", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        Tabla.CurrentRow.Cells[1].Value = DatosArticulo[1];
                        Tabla.CurrentRow.Cells[3].Value = DatosArticulo[2];
                        string articulo_id = bridge.GetValue("SELECT ARTICULO_ID FROM CLAVES_ARTICULOS WHERE CLAVE_ARTICULO = '" + DatosArticulo[0] + "';");
                        string cliente_id = bridge.GetValue("SELECT CLIENTE_ID FROM CLAVES_CLIENTES WHERE CLAVE_CLIENTE = '"+txtBox_clienteId.Text+"';");

                        descuento = bridge.GetValue("SELECT POLITICAS_DSCTOS_ART_CLI.DESCUENTO" +
                    "            FROM DIRS_CLIENTES" +
                    "           JOIN CLAVES_CLIENTES ON CLAVES_CLIENTES.CLIENTE_ID = DIRS_CLIENTES.CLIENTE_ID" +
                    "            JOIN PRECIOS_CLI_CLI ON PRECIOS_CLI_CLI.CLIENTE_ID = DIRS_CLIENTES.CLIENTE_ID" +
                    "            JOIN POLITICAS_DSCTOS_ART_CLI ON POLITICAS_DSCTOS_ART_CLI.POLITICA_DSCTO_ART_CLI_ID = PRECIOS_CLI_CLI.POLITICA_DSCTO_ART_CLI_ID" +
                    "           WHERE DIRS_CLIENTES.CLIENTE_ID ='" + cliente_id + "';");
                        string descextra = bridge.GetValue("SELECT DESCUENTO FROM DSCTOS_PROMO_ARTS WHERE ARTICULO_ID = '" + articulo_id + "';");
                        if (descextra == null)
                            Tabla.Rows[Tabla.CurrentCell.RowIndex].Cells[4].Value = 40;
                        else
                        {
                            decimal descuento1Decimal = decimal.Parse(descuento) / 100m; // Usamos 'm' para indicar que es decimal
                            decimal descuento2Decimal = decimal.Parse(descextra) / 100m; // Usamos 'm' para indicar que es decimal

                            // Calcular el descuento total efectivo usando la fórmula
                            decimal descuentoTotal = 1 - ((1 - descuento1Decimal) * (1 - descuento2Decimal));

                            // Convertir a porcentaje y mostrar el resultado
                            decimal porcentajeDescuentoTotal = descuentoTotal * 100;
                            Tabla.Rows[Tabla.CurrentCell.RowIndex].Cells[4].Value = porcentajeDescuentoTotal;
                        }
                        Tabla.Rows[Tabla.CurrentCell.RowIndex].Cells[5].Value = 0;
                        Tabla.CurrentCell = Tabla.CurrentRow.Cells[2];
                        Tabla.BeginEdit(true);
                    }
                }
                else if(Tabla.CurrentCell.ColumnIndex == 2)
                {
                    if (e.RowIndex == Tabla.Rows.Count - 1)
                    {
                        Tabla.Rows.Add();
                    }

                    // Mover a la siguiente fila, columna 0
                    int siguienteFila = e.RowIndex + 1;
                    if (siguienteFila < Tabla.Rows.Count)
                    {
                        Tabla.CurrentCell = Tabla.Rows[siguienteFila].Cells[0];
                        Tabla.BeginEdit(true);
                    }
                }
            }
        }
    }
}
