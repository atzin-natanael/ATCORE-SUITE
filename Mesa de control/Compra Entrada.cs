using ATCORE_SUITE.ChildClases;
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
using static ATCORE_SUITE.Mesa_de_control.Compra_Salida;
using ApiBas = ATCORE_SUITE.ApiMspBasicaExt;
using ApiInv = ATCORE_SUITE.ApiMspInventExt;
using ATCORE_SUITE.ChildForms;

namespace ATCORE_SUITE.Mesa_de_control
{
    public partial class Compra_Entrada : Form
    {
        List<List<string>> ArticulosCompraE = new List<List<string>>();
        string Docto_In_Id = "";
        public Compra_Entrada()
        {
            InitializeComponent();
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
        public void UpdateCloudDB()
        {
            GetFireBirdValue.UpdateCloudValueDocto_in(int.Parse(Docto_In_Id));
        }
        private void Importar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro que deseas realizar la entrada? \n ¿Deseas continuar?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Cancel)
            {
                return;
            }
            int conecta = GetFireBirdValue.ConectaBD();
            if (conecta == 1)
            {
                //culiacan
                ApiBas.DBConnected(GlobalSettings.Instance.Bd);
                ApiInv.SetDBInventarios(GlobalSettings.Instance.Bd);
                DateTime fecha = DateTime.Now;
                int ErrorFolio2 = 0;
                //int ErrorFolio2 = ApiInv.NuevaEntrada(25, 108405, fecha.ToString(), "", GlobalSettings.Instance.nameFile, 0);
                //for (int i = 0; i < ArticulosCargados.Count; ++i)
                //{
                //    int articulo_id = Art_Id(ArticulosCargados[i][1].ToString());
                //    int Renglon = ApiInv.RenglonEntrada(articulo_id, double.Parse(ArticulosCargados[i][4].ToString()), double.Parse(ArticulosCargados[i][3].ToString()), 0);
                //}
                //int final = ApiInv.AplicaEntrada();
                //if (final == 0)
                //{
                //    ArticulosCargados.Clear();
                //    FormMensaje formentry2 = new FormMensaje();
                //    MensajeFormAceptar(formentry2, formentry2.labelCaption, formentry2.labelText, formentry2.PictureMensaje);
                //    Tabla.Rows.Clear();
                //    Tabla.Visible = false;
                //    Importar.Visible = false;
                //    labelSelect.Visible = true;
                //    BtnAbrir.Visible = true;
                //    GlobalSettings.Instance.nameFile = "";
                //    ApiBas.DBDisconnect(GlobalSettings.Instance.Bd);

                //int ErrorFolio = ApiVe.NuevoPedido(Fecha, "IP", int.Parse(Cliente_Id), Dir_Consig_Id, Almacen_Id,"", Tipo_Desc,Descuento,"",Descripcion,Vendedor_Id, 0, 0, Moneda_Id);
                //CAMBIAR DESPUES
                //if (TxtFolio.Text.Contains("HTE"))
                //    ErrorFolio2 = ApiInv.NuevaSalida(36, 108401, 108402, fecha.ToString(), "","Salida de Compra: "+ TxtFolio.Text, 0);
                if (GlobalSettings.Instance.Ip == "192.168.0.11")
                {
                    ErrorFolio2 = ApiInv.NuevaSalida(36, 108401, 108402, fecha.ToString(), "", "Salida de Compra: " + TxtFolio.Text, 0);
                    for (int i = 0; i < ArticulosCompraE.Count; ++i)
                    {
                        string artic = GetFireBirdValue.GetValue("SELECT ARTICULO_ID FROM CLAVES_ARTICULOS WHERE CLAVE_ARTICULO = '" + ArticulosCompraE[i][1].ToString() + "';");
                        int Renglon = ApiInv.RenglonSalida(int.Parse(artic), double.Parse(ArticulosCompraE[i][3].ToString()), 0, 0);
                    }
                    int final = ApiInv.AplicaSalida();
                    if (final == 0)
                    {
                        UpdateCloudDB();
                        ArticulosCompraE.Clear();
                        Mensaje mensaje = new Mensaje();
                        mensaje.LblTitulo.Text = "Éxito";
                        mensaje.Texto.Text = "La salida se ha realizado correctamente";
                        mensaje.Texto.SelectionAlignment = HorizontalAlignment.Center;
                        mensaje.LblTitulo.ForeColor = System.Drawing.Color.Green;
                        mensaje.ShowDialog();
                        Tabla.Rows.Clear();
                        TxtFolio.Visible = true;
                        Tabla.Visible = false;
                        Importar.Visible = false;
                        TxtFolio.Focus();
                        //Cb_Sucursal.Visible = false;
                        ApiBas.DBDisconnect(GlobalSettings.Instance.Bd);
                    }
                    else if (final == 3)
                    {
                        Mensaje mensaje = new Mensaje();
                        mensaje.LblTitulo.Text = "Error";
                        mensaje.LblTitulo.ForeColor = System.Drawing.Color.Red;
                        mensaje.Texto.Text = "No se pudo realizar la salida por existencia insuficiente\n";
                        for (int i = 0; i < ArticulosCompraE.Count; ++i)
                        {
                            string ArtId = DataBridge.GetArticuloId(ArticulosCompraE[i][1].ToString());
                            string ExArt = DataBridge.GetExistencia(ArtId, "108401");
                            if (int.Parse(ExArt) < int.Parse(ArticulosCompraE[i][3]))
                            {
                                mensaje.Texto.Text += ArticulosCompraE[i][1] + " --- " + ArticulosCompraE[i][3] + " de " + ExArt + " disponibles" + "\n";
                            }
                        }
                        mensaje.Texto.SelectionAlignment = HorizontalAlignment.Center;
                        mensaje.ShowDialog();
                        ArticulosCompraE.Clear();
                        Tabla.Rows.Clear();
                        TxtFolio.Visible = true;
                        Tabla.Visible = false;
                        Importar.Visible = false;
                        TxtFolio.Focus();
                        //Cb_Sucursal.Visible = false;
                        ApiBas.DBDisconnect(GlobalSettings.Instance.Bd);
                    }
                    else
                    {
                        ArticulosCompraE.Clear();
                        Mensaje mensaje = new Mensaje();
                        mensaje.LblTitulo.Text = "Error";
                        mensaje.LblTitulo.ForeColor = System.Drawing.Color.Red;
                        mensaje.Texto.Text = "No se pudo completar al operación";
                        mensaje.Texto.SelectionAlignment = HorizontalAlignment.Center;
                        mensaje.ShowDialog();
                        Tabla.Rows.Clear();
                        TxtFolio.Visible = true;
                        Tabla.Visible = false;
                        Importar.Visible = false;
                        TxtFolio.Focus();
                        //Cb_Sucursal.Visible = false;
                        ApiBas.DBDisconnect(GlobalSettings.Instance.Bd);
                    }
                }
                else
                {

                    ErrorFolio2 = ApiInv.NuevaEntrada(25, 108402, fecha.ToString(), "", "Entrada de Compra: " + TxtFolio.Text, 0);
                    for (int i = 0; i < ArticulosCompraE.Count; ++i) { 
                        string artic = GetFireBirdValue.GetValue("SELECT ARTICULO_ID FROM CLAVES_ARTICULOS WHERE CLAVE_ARTICULO = '" + ArticulosCompraE[i][1].ToString() + "';");
                        int Renglon = ApiInv.RenglonEntrada(int.Parse(artic), double.Parse(ArticulosCompraE[i][3].ToString()), double.Parse(ArticulosCompraE[i][4].ToString()), 0);
                    }
                    int final = ApiInv.AplicaEntrada();
                if (final == 0)
                    {
                    UpdateCloudDB();
                    ArticulosCompraE.Clear();
                    Mensaje mensaje = new Mensaje();
                    mensaje.LblTitulo.Text = "Éxito";
                    mensaje.Texto.Text = "La entrada se ha realizado correctamente";
                    mensaje.Texto.SelectionAlignment = HorizontalAlignment.Center;
                    mensaje.LblTitulo.ForeColor = System.Drawing.Color.Green;
                    mensaje.ShowDialog();
                    Tabla.Rows.Clear();
                    TxtFolio.Visible = true;
                    Tabla.Visible = false;
                    Importar.Visible = false;
                    TxtFolio.Focus();
                    //Cb_Sucursal.Visible = false;
                    ApiBas.DBDisconnect(GlobalSettings.Instance.Bd);
                }
                else
                {
                    ArticulosCompraE.Clear();
                    Mensaje mensaje = new Mensaje();
                    mensaje.LblTitulo.Text = "Error";
                    mensaje.LblTitulo.ForeColor = System.Drawing.Color.Red;
                    mensaje.Texto.Text = "No se pudo completar al operación";
                    mensaje.Texto.SelectionAlignment = HorizontalAlignment.Center;
                    mensaje.ShowDialog();
                    Tabla.Rows.Clear();
                    TxtFolio.Visible = true;
                    Tabla.Visible = false;
                    Importar.Visible = false;
                    TxtFolio.Focus();
                    //Cb_Sucursal.Visible = false;
                    ApiBas.DBDisconnect(GlobalSettings.Instance.Bd);
                }

                }
            }
        }
        private void CargarGrid()
        {
            if (TxtFolio.Text != string.Empty)
            {
                string coriba = "PTS";
                if (GlobalSettings.Instance.Ip == "192.168.0.11")
                {
                    coriba = "HTE";
                }
                string query = "SELECT DOCTOS_IN_ID, REPETIDO FROM DOCTOS_IN WHERE FOLIO LIKE '"+coriba+"%' AND FOLIO = '" + TxtFolio.Text + "' AND TIPO_DOCTO = 'C';";
                var documento = GetFireBirdValue.GetCloudValue2(query);
                if (documento.Item1 == null && documento.Item1 == null)
                {
                    MessageBox.Show("No se encontró el folio ingresado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                    TxtFolio.Focus();
                }

                if (documento.Item2.ToString() != "0")
                {
                    MessageBox.Show("El folio ingresado ya ha sido exportado en " + documento.Item2.ToString() + " ocasiones", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    query = "SELECT DOCTOS_IN_ID FROM DOCTOS_IN WHERE FOLIO = '" + TxtFolio.Text + "-" + documento.Item2 + "';";
                    Docto_In_Id = GetFireBirdValue.GetCloudValue(query);
                    query = "SELECT FECHA_INGRESADO, INGRESADO FROM DOCTOS_IN WHERE DOCTOS_IN_ID = '" + Docto_In_Id + "';";
                    var documento2 = GetFireBirdValue.GetCloudValue2Date(query);
                    if (documento2.Item2.ToString() == "S")
                    {
                        string fecha = documento2.Item1.ToString();
                        MessageBox.Show("El último folio repetido ya tiene entrada, la fecha de entrada fue: " + fecha.Substring(0, 10), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                        TxtFolio.Focus();
                    }
                }
                else if (documento.Item2.ToString() == "0")
                {
                    query = "SELECT FECHA_INGRESADO, INGRESADO FROM DOCTOS_IN WHERE DOCTOS_IN_ID = '" + documento.Item1.ToString() + "';";
                    var documento2 = GetFireBirdValue.GetCloudValue2Date(query);
                    if (documento2.Item2.ToString() == "S")
                    {
                        string fecha = documento2.Item1.ToString();
                        MessageBox.Show("No puedes dar entrada dos veces a un mismo folio, la fecha de entrada fue: "+ fecha.Substring(0,10), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                        TxtFolio.Focus();
                    }
                    Docto_In_Id = documento.Item1.ToString();

                }
                else
                {
                    Docto_In_Id = documento.Item1.ToString();
                }
               
                query = "SELECT ID, CLAVE, NOMBRE, CANTIDAD, PRECIO FROM DOCTOS_IN_DET WHERE DOCTO_IN_ID = '" + Docto_In_Id + "'";
                var ListaArticulos = GetFireBirdValue.GetCloudValueList(query);
                if (ListaArticulos.Count == 0)
                {
                    MessageBox.Show("No se encontraron artículos para el folio ingresado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Tabla.Visible = false;
                    LbFolio.Visible = true;
                    TxtFolio.Visible = true;
                    Importar.Visible = false;
                    return;
                }
                Tabla.Visible = true;
                LbFolio.Visible = false;
                TxtFolio.Visible = false;
                Importar.Visible = true;
                foreach (var articulo in ListaArticulos)
                {

                    Tabla.Rows.Add(articulo[0], articulo[1], articulo[2], articulo[3]);
                    //ADD LISTA
                    List<string> ArticuloC = new List<string>
                        {
                            articulo[0],
                            articulo[1],
                            articulo[2],
                            articulo[3],
                            articulo[4]
                        };
                    ArticulosCompraE.Add(ArticuloC);

                }
                Tabla.ClearSelection();
            }
        }
        private void TxtFolio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CargarGrid();
                e.SuppressKeyPress = true; // Evita el sonido de error al presionar Enter
            }
        }

        private void Tabla_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                if (Tabla.CurrentRow.Cells[0].Value != null)
                {
                    Existencias existencias = new Existencias();
                    string articuloid = DataBridge.GetArticuloId(Tabla.CurrentRow.Cells[1].Value.ToString());
                    string Exalmacen = DataBridge.GetExistencia(articuloid, "108401");
                    string Extienda = DataBridge.GetExistencia(articuloid, "108403");
                    existencias.Descripcion.Text = Tabla.CurrentRow.Cells[2].Value.ToString();
                    existencias.ExistenciaAlmacen.Text = Exalmacen;
                    existencias.ExistenciaTienda.Text = Extienda;
                    existencias.ShowDialog();
                    e.Handled = true; // Opcional, previene otros efectos
                }
            }
        }
    }
}
