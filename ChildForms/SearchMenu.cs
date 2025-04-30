using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using PedidoXperto.ChildClases;

namespace PedidoXperto.ChildForms
{
    public partial class SearchMenu : Form
    {
        string query = string.Empty;
        public SearchMenu(string querie)
        {
            InitializeComponent();
            query = querie;
            CargarQuery();
        }
        public void CargarQuery()
        {
            FbConnection con = new FbConnection(GlobalSettings.Instance.StringConnection);
            try
            {
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

        }
    }
}
