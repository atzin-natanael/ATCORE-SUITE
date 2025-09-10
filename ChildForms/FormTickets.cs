using ATCORE_SUITE.ChildClases;
using ATCORE_SUITE.Logic;
using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace ATCORE_SUITE.ChildForms
{
    public partial class FormTickets : Form
    {
        List<ArticuloTicketIsla> Articulos = new List<ArticuloTicketIsla>();
        List<ArticuloTicketArte> ArticulosArte = new List<ArticuloTicketArte>();

        public FormTickets()
        {
            InitializeComponent();
            GlobalSettings.Instance.StringConnection = "User=SYSDBA;Password=C0r1b423;Database=D:\\Microsip datos\\PAPELERIA CORIBA CORNEJO.fdb;DataSource=192.168.0.11;Port=3050;Dialect=3;Charset=UTF8;";
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
        public class ArticuloTicketIsla
        {
            public string Codigo { get; set; }

            public int Saltos { get; set; }

            public string Descripcion { get; set; }

            public decimal Solicitado { get; set; }

            public string Nota { get; set; }

            public decimal Existencia { get; set; }
        }
        public class ArticuloTicketArte
        {
            public string Codigo { get; set; }
            public int Saltos { get; set; }
            public string Descripcion { get; set; }
            public decimal Solicitado { get; set; }
            public string Nota { get; set; }
            public decimal Existencia { get; set; }
        }


        public string Descripcion(string codigo)
        {
            FbConnection fbConnection = new FbConnection(GlobalSettings.Instance.StringConnection);
            try
            {
                fbConnection.Open();
                FbDataReader fbDataReader = new FbCommand("SELECT * FROM ARTICULOS WHERE ARTICULO_ID = '" + codigo + "';", fbConnection).ExecuteReader();
                if (fbDataReader.Read())
                {
                    return fbDataReader.GetString(1);
                }
                return "Artículo sin descripción";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se perdió la conexión :( , contacta a 06 o intenta de nuevo", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                MessageBox.Show(ex.ToString());
                return "Artículo sin descripción";
            }
            finally
            {
                fbConnection.Close();
            }
        }

        public bool Ubicacion(string codigo)
        {
            FbConnection fbConnection = new FbConnection(GlobalSettings.Instance.StringConnection);
            try
            {
                fbConnection.Open();
                FbDataReader fbDataReader = new FbCommand("SELECT * FROM NIVELES_ARTICULOS WHERE ARTICULO_ID = " + codigo + ";", fbConnection).ExecuteReader();
                while (fbDataReader.Read())
                {
                    string @string = fbDataReader.GetString(3);
                    if (@string != "" && @string[0] == 'I' && @string[1] == 'S' && @string[2] == 'L' && @string[3] == 'A')
                    {
                        return true;
                    }
                }
                fbDataReader.Close();
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se perdió la conexión :( , contacta a 06 o intenta de nuevo", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                MessageBox.Show(ex.ToString());
                return false;
            }
            finally
            {
                fbConnection.Close();
            }
        }

        public decimal Existencia(string codigo)
        {
            FbConnection fbConnection = new FbConnection(GlobalSettings.Instance.StringConnection);
            try
            {
                fbConnection.Open();
                FbCommand fbCommand = new FbCommand("EXIVAL_ART", fbConnection);
                fbCommand.CommandType = CommandType.StoredProcedure;
                fbCommand.Parameters.Add("V_ARTICULO_ID", FbDbType.Integer).Value = codigo;
                fbCommand.Parameters.Add("V_ALMACEN_ID", FbDbType.Integer).Value = 108404;
                fbCommand.Parameters.Add("V_FECHA", FbDbType.Date).Value = DateTime.Today;
                fbCommand.Parameters.Add("V_ES_ULTIMO_COSTO", FbDbType.Char).Value = 'S';
                fbCommand.Parameters.Add("V_SUCURSAL_ID", FbDbType.Integer).Value = 0;
                FbParameter value = new FbParameter("ARTICULO_ID", FbDbType.Numeric)
                {
                    Direction = ParameterDirection.Output
                };
                fbCommand.Parameters.Add(value);
                FbParameter value2 = new FbParameter("EXISTENCIAS", FbDbType.Numeric)
                {
                    Direction = ParameterDirection.Output
                };
                fbCommand.Parameters.Add(value2);
                fbCommand.ExecuteNonQuery();
                Convert.ToInt32(fbCommand.Parameters[6].Value);
                FbCommand fbCommand2 = new FbCommand("EXIVAL_ART", fbConnection);
                fbCommand2.CommandType = CommandType.StoredProcedure;
                fbCommand2.Parameters.Add("V_ARTICULO_ID", FbDbType.Integer).Value = codigo;
                fbCommand2.Parameters.Add("V_ALMACEN_ID", FbDbType.Integer).Value = 108403;
                fbCommand2.Parameters.Add("V_FECHA", FbDbType.Date).Value = DateTime.Today;
                fbCommand2.Parameters.Add("V_ES_ULTIMO_COSTO", FbDbType.Char).Value = 'S';
                fbCommand2.Parameters.Add("V_SUCURSAL_ID", FbDbType.Integer).Value = 0;
                FbParameter value3 = new FbParameter("ARTICULO_ID", FbDbType.Numeric)
                {
                    Direction = ParameterDirection.Output
                };
                fbCommand2.Parameters.Add(value3);
                FbParameter value4 = new FbParameter("EXISTENCIAS", FbDbType.Numeric)
                {
                    Direction = ParameterDirection.Output
                };
                fbCommand2.Parameters.Add(value4);
                fbCommand2.ExecuteNonQuery();
                return Convert.ToInt32(fbCommand2.Parameters[6].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se perdió la conexión :( , contacta a 06 o intenta de nuevo", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                MessageBox.Show(ex.ToString());
                return 0m;
            }
            finally
            {
                fbConnection.Close();
            }
        }

        public int Saltos(string Nota)
        {
            string[] array = Nota.Split('\n');
            if (Nota == string.Empty)
            {
                return 0;
            }
            return array.Length;
        }

        public void Imprimir()
        {
            printDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
                printDocument1.Print();
                Articulos.Clear();
                if (MessageBox.Show("¡SE HA MANDADO A IMPRIMIR!\n¿Deseas realizar otra impresión?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Txt_Pedido.Select(0, Txt_Pedido.Text.Length);
                    Txt_Pedido.Focus();
                }
                else
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
            }
        }
        public void ImprimirArte()
        {
            printDialog1.Document = printDocument2;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument2.Print();
                printDocument2.Print();
                ArticulosArte.Clear();
                if (MessageBox.Show("¡SE HA MANDADO A IMPRIMIR!\n¿Deseas realizar otra impresión?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Txt_Pedido.Select(0, Txt_Pedido.Text.Length);
                    Txt_Pedido.Focus();
                }
                else
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
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            using (Font font = new Font("Arial", 20f, FontStyle.Bold))
            {
                e.Graphics.DrawString(Txt_Pedido.Text, font, Brushes.Black, new PointF(80f, 0f));
            }
            Image image = new Bitmap(Image.FromFile("C:\\Img\\logo.png"), new Size(60, 35));
            e.Graphics.DrawImage(image, new PointF(0f, 0f));
            int num = 40;
            for (int i = 0; i < Articulos.Count; i++)
            {
                using (Font font3 = new Font("Arial", 10f, FontStyle.Bold))
                {
                    if (i > 0)
                    {
                        e.Graphics.DrawString("_____________________________________________________________", font3, Brushes.Black, new PointF(0f, num - 25));
                    }
                    if (Articulos[i].Existencia == 0m)
                    {
                        e.Graphics.DrawString(Articulos[i].Codigo, new Font("Arial", 10f, FontStyle.Strikeout), Brushes.Black, new PointF(0f, num));
                    }
                    else
                    {
                        e.Graphics.DrawString(Articulos[i].Codigo, font3, Brushes.Black, new PointF(0f, num));
                    }
                    if (Articulos[i].Solicitado.ToString().Length > 3)
                    {
                        e.Graphics.DrawString(Articulos[i].Solicitado.ToString(), font3, Brushes.Black, new PointF(252f, num));
                    }
                    else
                    {
                        e.Graphics.DrawString(Articulos[i].Solicitado.ToString(), font3, Brushes.Black, new PointF(260f, num));
                    }
                }
                Rectangle rectangle = new Rectangle(51, num, 220, 50);
                using (StringFormat format = new StringFormat())
                {
                    if (Articulos[i].Existencia == 0m)
                    {
                        e.Graphics.DrawString(Articulos[i].Descripcion, new Font("Arial", 8f, FontStyle.Strikeout), Brushes.Black, rectangle, format);
                    }
                    else
                    {
                        e.Graphics.DrawString(Articulos[i].Descripcion, new Font("Arial", 8f, FontStyle.Regular), Brushes.Black, rectangle, format);
                    }
                }
                using (Font font4 = new Font("Arial", 7f, FontStyle.Regular))
                {
                    if (Articulos[i].Saltos >= 1)
                    {
                        e.Graphics.DrawString(Articulos[i].Nota, font4, Brushes.Black, new PointF(51f, num + 30));
                        num += Articulos[i].Saltos * 5;
                    }
                    else
                    {
                        num -= 20;
                    }
                }
                num += 70;
            }
            using (Font font2 = new Font("Arial", 10f, FontStyle.Bold))
            {
                e.Graphics.DrawString(DateTime.Now.ToString(" yyyy-MM-dd"), font2, Brushes.Black, new PointF(200f, num + 110));
            }
            using Font font5 = new Font("Arial", 10f, FontStyle.Bold);
            e.Graphics.DrawString("      ___________       ___________  ", font5, Brushes.Black, new PointF(0f, num + 70));
            e.Graphics.DrawString("          Entregó                Recibió    ", font5, Brushes.Black, new PointF(0f, num + 90));
        }

        private void BtnImprimirIsla_Click(object sender, EventArgs e)
        {
            if (Txt_Pedido.Text == string.Empty)
            {
                MessageBox.Show("Pedido no ingresado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Imprimir();
        }
        public void ObtenerArticulosIsla()
        {
            FbConnection con = new FbConnection(GlobalSettings.Instance.StringConnection);
            con.Open();
            string Docto_id = GetFireBirdValue.GetValue("SELECT DOCTO_VE_ID FROM DOCTOS_VE WHERE FOLIO = '" + Txt_Pedido.Text + "' AND TIPO_DOCTO = 'P'; ");
            if (string.IsNullOrEmpty(Docto_id))
            {
                MessageBox.Show("Folio no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                return;
            }
            FbDataReader fbDataReader2 = new FbCommand("SELECT * FROM DOCTOS_VE_DET  WHERE DOCTO_VE_ID =" + Docto_id + ";", con).ExecuteReader();
            while (fbDataReader2.Read())
            {
                string @string = fbDataReader2.GetString(3);
                bool num3 = Ubicacion(@string);
                string descripcion = Descripcion(@string);
                decimal existencia = Existencia(@string);
                int saltos = Saltos(fbDataReader2.GetString(18));
                if (num3)
                {
                    ArticuloTicketIsla item = new ArticuloTicketIsla
                    {
                        Codigo = fbDataReader2.GetString(2),
                        Descripcion = descripcion,
                        Solicitado = fbDataReader2.GetDecimal(4),
                        Existencia = existencia,
                        Saltos = saltos,
                        Nota = fbDataReader2.GetString(18)
                    };
                    Articulos.Add(item);
                }
            }
            Lb_articulosIsla.Text = "Total de artículos: " + Articulos.Count;
            fbDataReader2.Close();
            con.Close();
        }
        public void ObtenerArticulosArte()
        {
            FbConnection con = new FbConnection(GlobalSettings.Instance.StringConnection);
            con.Open();
            string Docto_id = GetFireBirdValue.GetValue("SELECT DOCTO_VE_ID FROM DOCTOS_VE WHERE FOLIO = '" + Txt_Pedido.Text + "' AND TIPO_DOCTO = 'P'; ");
            if (string.IsNullOrEmpty(Docto_id))
            {
                con.Close();
                return;
            }
            FbDataReader fbDataReader2 = new FbCommand("SELECT * FROM DOCTOS_VE_DET  WHERE DOCTO_VE_ID =" + Docto_id + ";", con).ExecuteReader();
            while (fbDataReader2.Read())
            {
                string @string = fbDataReader2.GetString(3);
                string codigo = fbDataReader2.GetString(2);
                bool num3 = Ubicacion(@string);
                string descripcion = Descripcion(@string);
                decimal existencia = Existencia(@string);
                int saltos = Saltos(fbDataReader2.GetString(18));
                if (codigo.StartsWith("300") || codigo.StartsWith("301") || codigo.StartsWith("304"))
                {
                    ArticuloTicketArte item = new ArticuloTicketArte
                    {
                        Codigo = fbDataReader2.GetString(2),
                        Descripcion = descripcion,
                        Solicitado = fbDataReader2.GetDecimal(4),
                        Existencia = existencia,
                        Saltos = saltos,
                        Nota = fbDataReader2.GetString(18)
                    };
                    ArticulosArte.Add(item);
                }
            }
            Lb_articulosArte.Text = "Total de artículos: " + ArticulosArte.Count;
            fbDataReader2.Close();
            con.Close();
        }
        private void Txt_Pedido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Articulos.Clear();
                ArticulosArte.Clear();
                ObtenerArticulosIsla();
                GlobalSettings.Instance.Largo = 150;
                GlobalSettings.Instance.Largo += Articulos.Count * 55;
                for (int i = 0; i < Articulos.Count; i++)
                {
                    GlobalSettings.Instance.Largo += Articulos[i].Saltos * 10;
                }
                //printDocument1.DefaultPageSettings.PaperSize = new PaperSize("CustomSize", 300, GlobalSettings.Instance.Largo);
                //printPreviewControl1.InvalidatePreview();
                printPreviewControl1.Document = printDocument1;
                ObtenerArticulosArte();
                GlobalSettings.Instance.Largo = 150;
                GlobalSettings.Instance.Largo += ArticulosArte.Count * 55;
                for (int i = 0; i < ArticulosArte.Count; i++)
                {
                    GlobalSettings.Instance.Largo += ArticulosArte[i].Saltos * 10;
                }
                //printDocument2.DefaultPageSettings.PaperSize = new PaperSize("CustomSize", 300, GlobalSettings.Instance.Largo);
                //printPreviewControl2.InvalidatePreview();
                printPreviewControl2.Document = printDocument2;
            }
        }

        private void BtnImprimirArte_Click(object sender, EventArgs e)
        {
            if (Txt_Pedido.Text == string.Empty)
            {
                MessageBox.Show("Pedido no ingresado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            ImprimirArte();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void printDocument2_PrintPage(object sender, PrintPageEventArgs e)
        {
            int num = 30;
            using (Font font = new Font("Arial", 20f, FontStyle.Bold))
            {
                e.Graphics.DrawString(Txt_Pedido.Text, font, Brushes.Black, new PointF(80f, 0f));
            }
            Image image = new Bitmap(Image.FromFile("C:\\Img\\logo.png"), new Size(60, 35));
            e.Graphics.DrawImage(image, new PointF(0f, 0f));
            for (int i = 0; i < ArticulosArte.Count; i++)
            {
                using (Font font3 = new Font("Arial", 10f, FontStyle.Bold))
                {
                    if (i > 0)
                    {
                        e.Graphics.DrawString("______________________________________", font3, Brushes.Black, new PointF(0f, num - 25));
                    }
                    if (ArticulosArte[i].Existencia == 0m)
                    {
                        e.Graphics.DrawString(ArticulosArte[i].Codigo, new Font("Arial", 10f, FontStyle.Strikeout), Brushes.Black, new PointF(0f, num));
                    }
                    else
                    {
                        e.Graphics.DrawString(ArticulosArte[i].Codigo, font3, Brushes.Black, new PointF(0f, num));
                    }
                    if (ArticulosArte[i].Solicitado.ToString().Length > 3)
                    {
                        e.Graphics.DrawString(ArticulosArte[i].Solicitado.ToString(), font3, Brushes.Black, new PointF(252f, num));
                    }
                    else
                    {
                        e.Graphics.DrawString(ArticulosArte[i].Solicitado.ToString(), font3, Brushes.Black, new PointF(260f, num));
                    }
                }
                Rectangle rectangle = new Rectangle(51, num, 220, 25);
                using (StringFormat format = new StringFormat())
                {
                    if (ArticulosArte[i].Existencia == 0m)
                    {
                        e.Graphics.DrawString(ArticulosArte[i].Descripcion, new Font("Arial", 8f, FontStyle.Strikeout), Brushes.Black, rectangle, format);
                    }
                    else
                    {
                        e.Graphics.DrawString(ArticulosArte[i].Descripcion, new Font("Arial", 8f, FontStyle.Regular), Brushes.Black, rectangle, format);
                    }
                }
                using (Font font4 = new Font("Arial", 7f, FontStyle.Regular))
                {
                    if (ArticulosArte[i].Saltos >= 1)
                    {
                        e.Graphics.DrawString(ArticulosArte[i].Nota, font4, Brushes.Black, new PointF(51f, num + 30));
                        num += ArticulosArte[i].Saltos * 5;
                    }
                    else
                    {
                        num -= 20;
                    }
                }
                num += 70;
            }
            using (Font font2 = new Font("Arial", 10f, FontStyle.Bold))
            {
                e.Graphics.DrawString(DateTime.Now.ToString(" yyyy-MM-dd"), font2, Brushes.Black, new PointF(200f, num + 110));
            }
            using Font font5 = new Font("Arial", 10f, FontStyle.Bold);
            e.Graphics.DrawString("      ___________       ___________  ", font5, Brushes.Black, new PointF(0f, num + 70));
            e.Graphics.DrawString("          Entregó                Recibió    ", font5, Brushes.Black, new PointF(0f, num + 90));
        }

        private void Titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
