using FirebirdSql.Data.FirebirdClient;
using PedidoXperto.ChildClases;

namespace PedidoXperto.ChildForms
{
    public partial class SearchMenu : Form
    {
        public SearchMenu(string parametros)
        {
            InitializeComponent();
            Txt_Nombre.Text = parametros;
            CargarQuery(parametros);
        }
        public void CargarQuery(string parametros)
        {
            FbConnection con = new FbConnection(GlobalSettings.Instance.StringConnection);
            try
            {
                string[] arrayParametros = parametros.Split(' ');
                string query = $@"
                    SELECT CLAVES_ARTICULOS.CLAVE_ARTICULO, ARTICULOS.NOMBRE, PRECIOS_ARTICULOS.PRECIO  
                    FROM ARTICULOS
                    JOIN CLAVES_ARTICULOS ON CLAVES_ARTICULOS.ARTICULO_ID = ARTICULOS.ARTICULO_ID
                    JOIN PRECIOS_ARTICULOS ON PRECIOS_ARTICULOS.ARTICULO_ID = ARTICULOS.ARTICULO_ID
                    WHERE CLAVES_ARTICULOS.ROL_CLAVE_ART_ID = '17'
                    AND PRECIOS_ARTICULOS.PRECIO_EMPRESA_ID = '42'";
                
                foreach (string parametro in arrayParametros)
                {
                    query += $@"AND ARTICULOS.NOMBRE LIKE '%{parametro}%' ";
                }
                
                query += ";";

                con.Open();
                FbCommand commando = new FbCommand(query, con);

                // Objeto para leer los datos obtenidos
                FbDataReader reader = commando.ExecuteReader();
                while (reader.Read())
                {
                    // Acceder a los valores de cada columna por su índice o nombre
                    string codigo = reader.GetString(0);
                    string nombre = reader.GetString(1);
                    string precio = reader.GetString(2);
                    Tabla.Rows.Add(codigo, nombre, precio);

                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se perdió la conexión :( , contacta a 06 o intenta de nuevo", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.ToString());
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

        private void Buscar_Click(object sender, EventArgs e)
        {
            if(Txt_Nombre.Text != string.Empty)
            {

            }
        }

        private void Tabla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = Tabla.Rows[e.RowIndex];
                GlobalSettings.Instance.Crear_clave = row.Cells[0].Value.ToString();//codigo principal
                this.Close();
            }
        }
    }
}
