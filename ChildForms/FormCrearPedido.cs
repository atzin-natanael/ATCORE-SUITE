using System.Data;
using System.Web;
using FirebirdSql.Data.FirebirdClient;
using PedidoXperto.ChildClases;
using PedidoXperto.Logic;

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
                    string query = "SELECT ARTICULO_ID FROM CLAVES_ARTICULOS WHERE CLAVE_ARTICULO = '" + Tabla.CurrentRow.Cells[0].Value.ToString() + "'";
                    var data = bridge.GetValue(query);
                    var descripcion = bridge.GetValue("SELECT NOMBRE FROM ARTICULOS WHERE ARTICULO_ID = '" + data + "'");

                    if (descripcion == null)
                    {
                        MessageBox.Show("Articulo no encontrado");
                    }
                    else
                    {
                        Tabla.CurrentRow.Cells[1].Value = descripcion;
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
