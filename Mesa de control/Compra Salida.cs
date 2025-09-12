using ATCORE_SUITE.ChildClases;
using ATCORE_SUITE.ChildForms;
using ATCORE_SUITE.Logic;
using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATCORE_SUITE.Mesa_de_control
{
    public partial class Compra_Salida : Form
    {
        List<List<string>> ArticulosCompra = new List<List<string>>();
        public Compra_Salida()
        {
            InitializeComponent();

        }
        public class ArticuloCompra
        {
            public string Id { get; set; }  // El identificador único (automático si no se especifica)
            public string Clave { get; set; }
            public string Nombre { get; set; }
            public string Precio { get; set; }
            public string Cantidad { get; set; }
            public string Articulo_Id { get; set; }

        }
        private void Exit_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is MainForm form2)
                {
                    form2.ExitMain.Visible = true;
                    break;
                }
            }
            this.Close();
        }

        private void TxtFolio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Tabla.Visible = true;
                LbFolio.Visible = false;
                TxtFolio.Visible = false;
                Exportar.Visible = true;
                CargarGrid();
                e.SuppressKeyPress = true; // Evita el sonido de error al presionar Enter
            }
        }
        string CambioFolio()
        {
            string folio = TxtFolio.Text;
            string Pr = folio.Substring(0, 3);
            string Last = folio.Substring(3);
            string patch = "";
            int restante = 9 - folio.Length;
            while (restante >= 1)
            {
                patch += "0";
                restante--;
            }
            return Pr + patch + Last;
        }
        private void CargarGrid()
        {
            if (TxtFolio.Text != string.Empty)
            {
                string folioMod = CambioFolio();
                GetFireBirdValue GetFireBirdValue = new GetFireBirdValue();
                char Mvto = 'E';
                //cambiar
                if (GlobalSettings.Instance.Ip == "192.168.0.11")
                {
                    Mvto = 'S';
                }

                string query = "SELECT * FROM DOCTOS_IN WHERE FOLIO = '" + folioMod + "' AND NATURALEZA_CONCEPTO = '" + Mvto + "';";
                string Docto_In_Id = GetFireBirdValue.GetValue(GlobalSettings.Instance.StringConnection, query);
                if (Docto_In_Id == null)
                {
                    MessageBox.Show("No se encontró el folio ingresado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Tabla.Rows.Clear();
                    ArticulosCompra.Clear();
                    Tabla.Visible = false;
                    LbFolio.Visible = true;
                    TxtFolio.Visible = true;
                    Exportar.Visible = false;
                    TxtFolio.Text = "";
                    TxtFolio.Focus();
                    return;
                }
                FbConnection con = new FbConnection(GlobalSettings.Instance.StringConnection);
                try
                {
                    con.Open();
                    //valida si esta trabajando en hidalgo o coriba
                    query = "SELECT CLAVE_ARTICULO, ARTICULO_ID, UNIDADES, COSTO_UNITARIO FROM DOCTOS_IN_DET WHERE DOCTO_IN_ID = '" + Docto_In_Id + "' AND TIPO_MOVTO = '" + Mvto + "';";
                    FbCommand command = new FbCommand(query, con);
                    FbDataReader reader = command.ExecuteReader();
                    int id = 0;
                    while (reader.Read())
                    {
                        id++;
                        string articulo_id = reader.GetString(1);
                        query = "SELECT NOMBRE FROM ARTICULOS WHERE ARTICULO_ID = '" + articulo_id + "';";
                        string nombre = GetFireBirdValue.GetValue(GlobalSettings.Instance.StringConnection, query);
                        Tabla.Rows.Add(id, reader.GetString(0), nombre, reader.GetString(2));
                        //ADD LISTA
                        List<string> ArticuloC = new List<string>();
                        ArticuloC.Add(id.ToString());
                        ArticuloC.Add(reader.GetString(0));
                        ArticuloC.Add(nombre);
                        ArticuloC.Add(reader.GetString(3));
                        ArticuloC.Add(reader.GetString(2));
                        ArticulosCompra.Add(ArticuloC);
                    }
                    Tabla.ClearSelection();
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
        }
        public void Guardar(List<List<string>> ArticulosCompra)
        {
            if (ArticulosCompra.Count == 0)
            {
                MessageBox.Show("No hay artículos para exportar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DateTime? fecha = null;
            string id_new = GetFireBirdValue.GetCloudValue("SELECT MAX(DOCTOS_IN_ID) FROM DOCTOS_IN");
            if (id_new == null || id_new == "")
            {
                id_new = "0";
            }
            int id_new_int = int.Parse(id_new) + 1;
            var repetido = GetFireBirdValue.GetCloudValue2("SELECT DOCTOS_IN_ID ,REPETIDO FROM DOCTOS_IN WHERE FOLIO = '" + TxtFolio.Text + "'");
            if (repetido.Item1 != null && repetido.Item1 != "")
            {
                DialogResult result = MessageBox.Show("Se ha detectado que ya has exportado a la nube este Folio\n ¿Deseas continuar con la exportación?", "Exportar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }
                int valorep = int.Parse(repetido.Item2) + 1;
                string query = "UPDATE DOCTOS_IN SET REPETIDO = @Repetido_valor WHERE DOCTOS_IN_ID = '" + repetido.Item1 + "'";
                GetFireBirdValue.InsertCloudValue(query, valorep.ToString());
                TxtFolio.Text = TxtFolio.Text + "-" + valorep;
            }
            GetFireBirdValue.InsertCloudValueDocto_in(id_new_int, TxtFolio.Text, 'N', DateTime.Now, fecha, 'C');
            foreach (var articulo in ArticulosCompra)
            {
                string id_new2 = GetFireBirdValue.GetCloudValue("SELECT MAX(DOCTOS_IN_DET_ID) FROM DOCTOS_IN_DET");
                if (id_new2 == null || id_new2 == "")
                {
                    id_new2 = "0";
                }
                int id_new_int2 = int.Parse(id_new2) + 1;
                GetFireBirdValue.InsertCloudValueDocto_det_in(id_new_int2, id_new_int, int.Parse(articulo[0]), articulo[1], articulo[2], decimal.Parse(articulo[3]), int.Parse(articulo[4]));
            }
            ArticulosCompra.Clear();
            Mensaje mensaje = new Mensaje();
            mensaje.LblTitulo.Text = "Éxito";
            mensaje.Texto.Text = "Articulos exportados correctamente";
            mensaje.Texto.SelectionAlignment = HorizontalAlignment.Center;
            mensaje.LblTitulo.ForeColor = System.Drawing.Color.Green;
            mensaje.ShowDialog();
        }
        private void Exportar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Deseas exportar los artículos?", "Exportar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }
            Guardar(ArticulosCompra);
            Tabla.Rows.Clear();
            ArticulosCompra.Clear();
            Tabla.Visible = false;
            LbFolio.Visible = true;
            TxtFolio.Visible = true;
            Exportar.Visible = false;
            TxtFolio.Text = "";
            TxtFolio.Focus();
        }

        private void LbFolio_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Tabla_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
