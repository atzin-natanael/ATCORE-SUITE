using ATCORE_SUITE.ChildClases;
using ATCORE_SUITE.Logic;
using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Office2013.Excel;
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
using static ATCORE_SUITE.Surtido.FormExportarIsi;
using static System.Runtime.InteropServices.JavaScript.JSType;
using ApiBas = ApisMicrosip.ApiMspBasicaExt;
using ApiCom = ApisMicrosip.ApiMspComprasExt;
using Apiven = ApisMicrosip.ApiMspVentasExt;

namespace ATCORE_SUITE.Surtido
{
    public partial class FormExportarIsi : Form
    {
        private List<Articulo> Articulos = new List<Articulo>();
        public FormExportarIsi()
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

        private void Txt_Pedido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                  Exportar(Txt_Pedido.Text);
            }
        }
        public void Exportar( string pedido)
        {
            if (!(pedido != string.Empty))
            {
                return;
            }
            string text = pedido;
            //if (text[0] == 'I' && text[1] == 'P')
            //{
            //    int num = 9 - text.Length;
            //    string text2 = text.Substring(0, 2);
            //    string text3 = text.Substring(2);
            //    string text4 = "";
            //    for (int i = 0; i < num; i++)
            //    {
            //        text4 += "0";
            //    }
            //    text = text2 + text4 + text3;
            //}
            //else
            //{
            //    MessageBox.Show("No es pedido de Isi Office", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            //    return;
            //}
            FbConnection fbConnection = new FbConnection(GlobalSettings.Instance.StringConnection);
            try
            {
                fbConnection.Open();
                string Docto_ve_id = "";
                string fecha = "";
                int cliente_id = 0;
                int dir_consig_id = 0;
                double descuento = 0.0;
                string tipoDscto = "";
                string via_embarque_id = "";
                string cond_pago_id = "";
                string descripcion = "";
                int vendedorId = 0;
                int almacenId = 0;
                int monedaId = 0;
                string clave_cliente = "";
                string cmdText = "SELECT * FROM DOCTOS_VE WHERE FOLIO = '" + text + "'";
                FbCommand fbCommand = new FbCommand(cmdText, fbConnection);
                FbDataReader fbDataReader = fbCommand.ExecuteReader();
                if (fbDataReader.Read())
                {
                    Docto_ve_id = fbDataReader.GetString(0);
                    fecha = fbDataReader.GetString(5);
                    clave_cliente = fbDataReader.GetString(7);
                    cliente_id = fbDataReader.GetInt32(8);
                    dir_consig_id = fbDataReader.GetInt32(10);
                    almacenId = fbDataReader.GetInt32(11);
                    monedaId = fbDataReader.GetInt32(13);
                    tipoDscto = fbDataReader.GetString(15);
                    descuento = fbDataReader.GetDouble(16);
                    descripcion = fbDataReader.GetString(25);
                    vendedorId = fbDataReader.GetInt32(40);
                    via_embarque_id = fbDataReader.GetString(42);
                    cond_pago_id = fbDataReader.GetString(37);
                }
                fbDataReader.Close();
                string cmdText2 = "SELECT * FROM LIBRES_PED_VE WHERE DOCTO_VE_ID = '" + Docto_ve_id + "'";
                FbCommand fbCommand2 = new FbCommand(cmdText2, fbConnection);
                FbDataReader fbDataReader2 = fbCommand2.ExecuteReader();
                if (fbDataReader2.Read() && fbDataReader2.GetString(6) == "1")
                {
                    MessageBox.Show("!Pedido ya exportado!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    this.Close();
                    return;
                }
                //if (clave_cliente != "109737")
                //{
                //    MessageBox.Show("!El pedido no está a nombre de Isi Office!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                //    this.Close();
                //    return;
                //}
                fbDataReader2.Close();
                string cmdText3 = "SELECT * FROM DOCTOS_VE_DET WHERE DOCTO_VE_ID = '" + Docto_ve_id + "'";
                FbCommand fbCommand3 = new FbCommand(cmdText3, fbConnection);
                FbDataReader fbDataReader3 = fbCommand3.ExecuteReader();
                List<List<string>> list = new List<List<string>>();
                while (fbDataReader3.Read())
                {
                    string articulo_id = fbDataReader3.GetString(3);
                    List<string> list2 = new List<string>();
                    if (fbDataReader3.GetString(9) != "0")
                    {
                        MessageBox.Show("!Pedido tiene descuentos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        this.Close();
                        return;
                    }
                    list2.Add(articulo_id);
                    list2.Add(fbDataReader3.GetString(4));
                    list2.Add(fbDataReader3.GetString(8));
                    list2.Add(fbDataReader3.GetString(9));
                    list2.Add(fbDataReader3.GetString(18));
                    list.Add(list2);
                }
                fbDataReader3.Close();
                string nombre = "";
                string cmdText4 = "SELECT * FROM VIAS_EMBARQUE WHERE VIA_EMBARQUE_ID = '" + via_embarque_id + "'";
                FbCommand fbCommand4 = new FbCommand(cmdText4, fbConnection);
                FbDataReader fbDataReader4 = fbCommand4.ExecuteReader();
                if (fbDataReader4.Read())
                {
                    nombre = fbDataReader4.GetString(1);
                }
                fbDataReader4.Close();
                string nombre2 = "";
                string cmdText5 = "SELECT * FROM CONDICIONES_PAGO WHERE COND_PAGO_ID = '" + cond_pago_id + "'";
                FbCommand fbCommand5 = new FbCommand(cmdText5, fbConnection);
                FbDataReader fbDataReader5 = fbCommand5.ExecuteReader();
                if (fbDataReader5.Read())
                {
                    nombre2 = fbDataReader5.GetString(1);
                }
                fbDataReader5.Close();
                string query = "SELECT NUMERO_CLIENTE FROM LIBRES_PED_VE WHERE DOCTO_VE_ID = '" + Docto_ve_id + "'";
                string clave =  GetFireBirdValue.GetValue(GlobalSettings.Instance.StringConnection, query);
                query = "SELECT CLIENTE_ID FROM CLAVES_CLIENTES WHERE CLAVE_CLIENTE = '" + clave + "'";
                string cliente_id_isi = GetFireBirdValue.GetValue(GlobalSettings.Instance.IsiStringConnection, query);
                int num5 = GetFireBirdValue.ConectaBD(GlobalSettings.Instance.IsiStringConnection);
                if (num5 != 1)
                {
                    return;
                }
                ApiBas.DBConnected(GlobalSettings.Instance.Bd);
                Apiven.SetDBVentas(GlobalSettings.Instance.Bd);
                int DoctoId = Apiven.NuevoPedido(fecha, "ISI", int.Parse(cliente_id_isi), 0, almacenId, "", tipoDscto, descuento, "", descripcion, vendedorId, 0, 0, monedaId);
                switch (DoctoId)
                {
                    case 1:
                        MessageBox.Show("Base de datos aun no establecida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        break;
                    case 2:
                        MessageBox.Show("Conexión a la base de datos aun no establecida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        break;
                    case 3:
                        MessageBox.Show("Documento en proceso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        break;
                    case 4:
                        MessageBox.Show("Fecha del pedido incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        break;
                    case 5:
                        MessageBox.Show("Formato de folio incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        break;
                    case 6:
                        MessageBox.Show("Formato de serie de folio incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        break;
                    case 7:
                        MessageBox.Show("Serie de folio inexistente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        break;
                    case 8:
                        MessageBox.Show("No se maneja consecutivo de folio sin serie.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        break;
                    case 9:
                        MessageBox.Show("Cliente inexistente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        break;
                    case 10:
                        MessageBox.Show("Consignatario inexistente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        break;
                    case 11:
                        MessageBox.Show("Almacén inexistente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        break;
                    case 12:
                        MessageBox.Show("Fecha de entrega incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        break;
                    case 13:
                        MessageBox.Show("Fecha de entrega anterior a la fecha del pedido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        break;
                    case 14:
                        MessageBox.Show("Tipo de descuento incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        break;
                    case 15:
                        MessageBox.Show("Descuento incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        break;
                    case 16:
                        MessageBox.Show("Vendedor inexistente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        break;
                    case 17:
                        MessageBox.Show("Impuesto sustituido debe ser diferente al sustituto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        break;
                    case 18:
                        MessageBox.Show("Impuesto sustituido no especificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        break;
                    case 19:
                        MessageBox.Show("Impuesto sustituto no especificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        break;
                    case 20:
                        MessageBox.Show("Impuesto sustituido inexistente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        break;
                    case 21:
                        MessageBox.Show("Impuesto sustituto inexistente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        break;
                    case 22:
                        MessageBox.Show("Impuesto sustituido es una retención.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        break;
                    case 23:
                        MessageBox.Show("Impuesto sustituto es una retención.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        break;
                    case 24:
                        MessageBox.Show("Pedido ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        break;
                    case 25:
                        MessageBox.Show("La orden de compra excede el valor máximo de caracteres permitido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        break;
                    case 26:
                        MessageBox.Show("Fecha del pedido es menor a la fecha de última eliminación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        break;
                    case 27:
                        MessageBox.Show("Moneda inexistente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        break;
                    case 28:
                        MessageBox.Show("El almacén no tiene una sucursal asignada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        break;
                    case 29:
                        MessageBox.Show("No es posible asignar folios de manera manual cuando la empresa opera con sucursales.\r\nConfigure el consecutivo de los folios de los documentos en las Preferencias de la empresa del sistema.\r\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        break;
                    case 98:
                        MessageBox.Show("Alguno de los datos foráneos del pedido está siendo modificado por otro usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        break;
                    case 99:
                        MessageBox.Show("Error de Api Básica.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        break;
                    case 0:
                        {
                            int n= Apiven.GetDoctoVeId(ref DoctoId);
                            for (int k = 0; k < list.Count; k++)
                            {
                                if (Apiven.RenglonPedido(int.Parse(list[k][0]), double.Parse(list[k][1]), double.Parse(list[k][2]), double.Parse(list[k][3]), list[k][4]) != 0)
                                {
                                    MessageBox.Show("PROBLEMAS CON LOS RENGLONES", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                    return;
                                }
                            }
                            int exito = Apiven.AplicaPedido();
                            if (exito != 0)
                            {
                                MessageBox.Show("PROBLEMAS CON GENERAR EL PEDIDO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                break;
                            }
                            query = "SELECT * FROM VIAS_EMBARQUE WHERE NOMBRE = '" + nombre + "';";
                            string via = GetFireBirdValue.GetValue(GlobalSettings.Instance.StringConnection, query);
                            query = "SELECT * FROM CONDICIONES_PAGO WHERE NOMBRE = '" + nombre2 + "';";
                            string condiciones = GetFireBirdValue.GetValue(GlobalSettings.Instance.StringConnection, query);
                            UpdatePrecios(Docto_ve_id);
                            UpdateIndividual(DoctoId, int.Parse(via), int.Parse(condiciones));
                            DateTime fechaC = DateTime.Now;
                            int num6 = ApiCom.SetDBCompras(GlobalSettings.Instance.Bd);
                            switch (ApiCom.NuevaCompra(fechaC.ToString(), "", 2070869, almacenId, tipoDscto, 0.0, 1.0, Txt_Pedido.Text, descripcion, 0.0, 0.0, 0.0, 813250, 0, 0))
                            {
                                case 1:
                                    MessageBox.Show("Base de datos aun no establecida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                    break;
                                case 2:
                                    MessageBox.Show("Conexión a la base de datos aun no establecida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                    break;
                                case 3:
                                    MessageBox.Show("Documento en proceso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                    break;
                                case 4:
                                    MessageBox.Show("Fecha de la compra incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                    break;
                                case 5:
                                    MessageBox.Show("Formato de folio incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                    break;
                                case 6:
                                    MessageBox.Show("Formato de serie de folio incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                    break;
                                case 7:
                                    MessageBox.Show("Serie de folio inexistente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                    break;
                                case 8:
                                    MessageBox.Show("No se maneja consecutivo de folio sin serie.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                    break;
                                case 9:
                                    MessageBox.Show("Proveedor inexistente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                    break;
                                case 10:
                                    MessageBox.Show("Almacén inexistente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                    break;
                                case 11:
                                    MessageBox.Show("El folio de la factura del proveedor no fue indicado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                    break;
                                case 12:
                                    MessageBox.Show("La factura excede el valor máximo de caracteres permitido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                    break;
                                case 13:
                                    MessageBox.Show("El tipo de cambio solo se puede definir para proveedores extranjeros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                    break;
                                case 14:
                                    MessageBox.Show("Tipo de cambio incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                    break;
                                case 15:
                                    MessageBox.Show("Importe del flete incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                    break;
                                case 16:
                                    MessageBox.Show("El importe del flete no puede ser asignado, ya que el artículo de fletes no esta definido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                    break;
                                case 17:
                                    MessageBox.Show("Importe de otros cargos incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                    break;
                                case 18:
                                    MessageBox.Show("El importe de otros cargos no puede ser asignado, ya que el artículo de otros cargos no esta definido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                    break;
                                case 19:
                                    MessageBox.Show("Tipo de descuento incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                    break;
                                case 20:
                                    MessageBox.Show("Descuento incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                    break;
                                case 21:
                                    MessageBox.Show("El importe de gastos aduanales está incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                    break;
                                case 22:
                                    MessageBox.Show("El importe de gastos aduanales sólo se puede asignar cuando el proveedor es extranjero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                    break;
                                case 23:
                                    MessageBox.Show("Impuesto sustituido debe ser diferente al sustituto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                    break;
                                case 24:
                                    MessageBox.Show("Impuesto sustituido no especificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                    break;
                                case 25:
                                    MessageBox.Show("Impuesto sustituto no especificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                    break;
                                case 26:
                                    MessageBox.Show("Impuesto sustituido inexistente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                    break;
                                case 27:
                                    MessageBox.Show("Impuesto sustituto inexistente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                    break;
                                case 28:
                                    MessageBox.Show("Impuesto sustituido es una retención.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                    break;
                                case 29:
                                    MessageBox.Show("Impuesto sustituto es una retención.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                    break;
                                case 30:
                                    MessageBox.Show("Compra ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                    break;
                                case 31:
                                    MessageBox.Show("Condición de pago inexistente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                    break;
                                case 32:
                                    MessageBox.Show("Fecha de la compra es menor a la fecha de última eliminación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                    break;
                                case 33:
                                    MessageBox.Show("El almacén no tiene una sucursal asignada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                    break;
                                case 34:
                                    MessageBox.Show("No es posible asignar folios de manera manual cuando la empresa opera con sucursales.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                    break;
                                case 98:
                                    MessageBox.Show("Alguno de los datos foráneos de la orden están siendo modificado por otro usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                    break;
                                case 99:
                                    MessageBox.Show("Error de Api Básica.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                    break;
                                case 0:
                                    {
                                        for (int l = 0; l < list.Count; l++)
                                        {
                                            query= "SELECT * FROM CLAVES_ARTICULOS WHERE CLAVE_ARTICULO = '" + list[l][0] + "' AND ROL_CLAVE_ART_ID= '17';";
                                            string articulo2 = GetFireBirdValue.GetValue(GlobalSettings.Instance.IsiStringConnection, query);
                                            query = "SELECT * FROM CLAVES_ARTICULOS WHERE CLAVE_ARTICULO = '" + articulo2 + "' AND ROL_CLAVE_ART_ID= '17';";
                                            string articulo_id = GetFireBirdValue.GetValue(GlobalSettings.Instance.StringConnection, query);
                                            double precioUnitario = double.Parse(Costos(articulo_id).ToString()) * 0.52;

                                            int num7 = ApiCom.RenglonCompra(int.Parse(list[l][0]), double.Parse(list[l][1]), precioUnitario, double.Parse(list[l][3]), list[l][4], "V");
                                        }
                                        switch (ApiCom.AplicaCompra())
                                        {
                                            case 1:
                                                MessageBox.Show("No hay compra en proceso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                                break;
                                            case 2:
                                                MessageBox.Show("No se han registrado renglones a la compra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                                break;
                                            case 3:
                                                MessageBox.Show("Los datos del proveedor eventual no se han registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                                break;
                                            case 4:
                                                MessageBox.Show("Descuento extra excede al total de la compra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                                break;
                                            case 5:
                                                MessageBox.Show("Algunos números de serie están repetidos en el documento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                                break;
                                            case 6:
                                                MessageBox.Show("Los datos del pedimento no han sido indicados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                                break;
                                            case 7:
                                                MessageBox.Show("Al proveedor eventual sólo es posible comprarle de contado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                                break;
                                            case 8:
                                                MessageBox.Show("No se puede aplicar el documento debido a  que algunos números de serie están duplicados en\r\n      el almacén.\r\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                                break;
                                            case 9:
                                                MessageBox.Show("El número de factura del proveedor ya está registrado en Cuentas por pagar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                                break;
                                            case 98:
                                                MessageBox.Show("Alguno de los datos foráneos de la orden están siendo modificado por otro usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                                break;
                                            case 99:
                                                MessageBox.Show("Error de Api Básica.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                                break;
                                            case 0:
                                                MessageBox.Show("Exportación Exitosa", "Great", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                                ApiBas.DBDisconnect(GlobalSettings.Instance.Bd);
                                                Close();
                                                break;
                                        }
                                        break;
                                    }
                            }
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se perdió la conexión :( , contacta a 06 o intenta de nuevo", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                fbConnection.Close();
            }
        }
        public void UpdateIndividual(int Folio, int Via, int Condiciones)
        {
            FbConnection fbConnection = new FbConnection(GlobalSettings.Instance.IsiStringConnection);
            try
            {
                fbConnection.Open();
                string cmdText = "UPDATE DOCTOS_VE SET COND_PAGO_ID = @Cond, VIA_EMBARQUE_ID = @Via  WHERE DOCTO_VE_ID = '" + Folio + "';";
                FbCommand fbCommand = new FbCommand(cmdText, fbConnection);
                fbCommand.Parameters.AddWithValue("@Via", Via);
                fbCommand.Parameters.AddWithValue("@Cond", Condiciones);
                if (fbCommand.ExecuteNonQuery() == 0)
                {
                    MessageBox.Show("No se pudo actualizar la vía y condición de pago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
                string cmdText2 = "INSERT INTO LIBRES_PED_VE (DOCTO_VE_ID, PEDIDO) VALUES (@Folio, @Pedido)";
                FbCommand fbCommand2 = new FbCommand(cmdText2, fbConnection);
                fbCommand2.Parameters.AddWithValue("@Folio", Folio);
                fbCommand2.Parameters.AddWithValue("@Pedido", Txt_Pedido.Text);
                try
                {
                    if (fbCommand2.ExecuteNonQuery() == 0)
                    {
                        MessageBox.Show("No se pudo insertar el registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en libres " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            catch (Exception ex2)
            {
                MessageBox.Show("Se perdió la conexión :( , contacta a 06 o intenta de nuevo", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                MessageBox.Show(ex2.ToString());
            }
            finally
            {
                fbConnection.Close();
            }
        }
        public decimal Costos(string articulo_id)
        {
            FbConnection fbConnection = new FbConnection("User=" + GlobalSettings.Instance.User + ";Password=" + GlobalSettings.Instance.Pw + ";Database=" + GlobalSettings.Instance.Direccion + ";DataSource=" + GlobalSettings.Instance.Ip + ";Port=" + GlobalSettings.Instance.Puerto + ";Dialect=3;Charset=UTF8;");
            try
            {
                fbConnection.Open();
                string cmdText = "SELECT * FROM PRECIOS_ARTICULOS WHERE ARTICULO_ID = '" + articulo_id + "' AND PRECIO_EMPRESA_ID = '42'";
                FbCommand fbCommand = new FbCommand(cmdText, fbConnection);
                FbDataReader fbDataReader = fbCommand.ExecuteReader();
                if (fbDataReader.Read())
                {
                    decimal @decimal = fbDataReader.GetDecimal(3);
                    fbDataReader.Close();
                    return @decimal;
                }
                return 0m;
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
        public class Articulo
        {
            public string Id { get; set; }

            public string Codigo { get; set; }

            public string Articulo_id { get; set; }

            public decimal Unidades { get; set; }

            public decimal Precio { get; set; }

            public decimal Total { get; set; }

            public decimal Precio_Lista { get; set; }
        }
        public void UpdatePrecios(string Docto_id)
        {
            FbConnection fbConnection = new FbConnection("User=" + GlobalSettings.Instance.User + ";Password=" + GlobalSettings.Instance.Pw + ";Database=" + GlobalSettings.Instance.Direccion + ";DataSource=" + GlobalSettings.Instance.Ip + ";Port=" + GlobalSettings.Instance.Puerto + ";Dialect=3;Charset=UTF8;");
            try
            {
                fbConnection.Open();
                string cmdText = "SELECT * FROM DOCTOS_VE_DET WHERE DOCTO_VE_ID = '" + Docto_id + "'";
                FbCommand fbCommand = new FbCommand(cmdText, fbConnection);
                FbDataReader fbDataReader = fbCommand.ExecuteReader();
                while (fbDataReader.Read())
                {
                    decimal num = Costos(fbDataReader.GetString(3));
                    Articulo item = new Articulo
                    {
                        Id = fbDataReader.GetString(0),
                        Codigo = fbDataReader.GetString(2),
                        Articulo_id = fbDataReader.GetString(3),
                        Unidades = fbDataReader.GetDecimal(4),
                        Precio = fbDataReader.GetDecimal(8),
                        Precio_Lista = num * 0.52m,
                        Total = fbDataReader.GetDecimal(15)
                    };
                    Articulos.Add(item);
                }
                fbDataReader.Close();
                for (int i = 0; i < Articulos.Count; i++)
                {
                    string cmdText2 = "UPDATE DOCTOS_VE_DET SET PRECIO_UNITARIO = @Precio, PRECIO_TOTAL_NETO = @Total  WHERE DOCTO_VE_ID = '" + Docto_id + "' AND DOCTO_VE_DET_ID = '" + Articulos[i].Id + "';";
                    FbCommand fbCommand2 = new FbCommand(cmdText2, fbConnection);
                    fbCommand2.Parameters.AddWithValue("@Precio", Articulos[i].Precio_Lista);
                    fbCommand2.Parameters.AddWithValue("@Total", Articulos[i].Precio_Lista * Articulos[i].Unidades);
                    if (fbCommand2.ExecuteNonQuery() == 0)
                    {
                        MessageBox.Show("No se pudo actualizar la vía y condición de pago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        return;
                    }
                }
                SumarTotales(Docto_id);
                string cmdText3 = "UPDATE LIBRES_PED_VE SET Exportado = @Exportado WHERE DOCTO_VE_ID = @DoctoId;";
                FbCommand fbCommand3 = new FbCommand(cmdText3, fbConnection);
                fbCommand3.Parameters.AddWithValue("@Exportado", "1");
                fbCommand3.Parameters.AddWithValue("@DoctoId", Docto_id);
                try
                {
                    if (fbCommand3.ExecuteNonQuery() == 0)
                    {
                        MessageBox.Show("No se pudo insertar el registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en libres " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            catch (Exception ex2)
            {
                MessageBox.Show("Se perdió la conexión :( , contacta a 06 o intenta de nuevo", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                MessageBox.Show(ex2.ToString());
            }
            finally
            {
                fbConnection.Close();
            }
        }
        public decimal ImpuestoC(string Articulo_Id)
        {
            FbConnection fbConnection = new FbConnection("User=" + GlobalSettings.Instance.User + ";Password=" + GlobalSettings.Instance.Pw + ";Database=" + GlobalSettings.Instance.Direccion + ";DataSource=" + GlobalSettings.Instance.Ip + ";Port=" + GlobalSettings.Instance.Puerto + ";Dialect=3;Charset=UTF8;");
            try
            {
                fbConnection.Open();
                string text = "";
                string text2 = "";
                string cmdText = "SELECT * FROM IMPUESTOS_ARTICULOS WHERE ARTICULO_ID = '" + Articulo_Id + "'";
                FbCommand fbCommand = new FbCommand(cmdText, fbConnection);
                FbDataReader fbDataReader = fbCommand.ExecuteReader();
                if (fbDataReader.Read())
                {
                    text = fbDataReader.GetString(2);
                }
                fbDataReader.Close();
                string cmdText2 = "SELECT * FROM IMPUESTOS WHERE IMPUESTO_ID = '" + text + "'";
                FbCommand fbCommand2 = new FbCommand(cmdText2, fbConnection);
                FbDataReader fbDataReader2 = fbCommand2.ExecuteReader();
                if (fbDataReader2.Read())
                {
                    text2 = fbDataReader2.GetString(2);
                }
                fbDataReader2.Close();
                if (text2 == "16% IVA ")
                {
                    return 1.16m;
                }
                if (text2 == "IEPS 8%")
                {
                    return 1.08m;
                }
                return 0m;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se perdió la conexión :( , contacta a 06 o intenta de nuevo", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                MessageBox.Show(ex.ToString());
                return 1.16m;
            }
            finally
            {
                fbConnection.Close();
            }
        }
        public void SumarTotales(string Docto_id)
        {
            FbConnection fbConnection = new FbConnection("User=" + GlobalSettings.Instance.User + ";Password=" + GlobalSettings.Instance.Pw + ";Database=" + GlobalSettings.Instance.Direccion + ";DataSource=" + GlobalSettings.Instance.Ip + ";Port=" + GlobalSettings.Instance.Puerto + ";Dialect=3;Charset=UTF8;");
            try
            {
                fbConnection.Open();
                string cmdText = "SELECT * FROM DOCTOS_VE_DET WHERE DOCTO_VE_ID = '" + Docto_id + "';";
                FbCommand fbCommand = new FbCommand(cmdText, fbConnection);
                FbDataReader fbDataReader = fbCommand.ExecuteReader();
                decimal d = default(decimal);
                decimal num = default(decimal);
                decimal num2 = default(decimal);
                decimal num3 = default(decimal);
                string text = "";
                decimal num4 = default(decimal);
                decimal num5 = default(decimal);
                decimal num6 = default(decimal);
                string text2 = "";
                decimal num7 = default(decimal);
                decimal num8 = default(decimal);
                decimal num9 = default(decimal);
                decimal num10 = default(decimal);
                decimal num11 = default(decimal);
                decimal num12 = default(decimal);
                decimal num13 = default(decimal);
                decimal num14 = default(decimal);
                while (fbDataReader.Read())
                {
                    decimal num15 = default(decimal);
                    decimal num16 = default(decimal);
                    decimal num17 = default(decimal);
                    decimal num18 = default(decimal);
                    decimal num19 = default(decimal);
                    decimal num20 = default(decimal);
                    text = fbDataReader.GetString(0);
                    text2 = fbDataReader.GetString(3);
                    num7 = ImpuestoC(text2);
                    num16 = fbDataReader.GetDecimal(4);
                    num15 = fbDataReader.GetDecimal(8);
                    num17 = fbDataReader.GetDecimal(9);
                    decimal num21 = num17 / 100m;
                    num20 = num16 * num15 * num21;
                    num19 = num16 * num15 - num20;
                    num18 = num16 * num15 - num20;
                    if (num7 != 0m)
                    {
                        decimal num22 = num19;
                        decimal num23 = num19;
                        decimal num24 = default(decimal);
                        num24 = Math.Round(num22, 2);
                        int num25 = (int)(Math.Floor(num22 * 1000m) % 10m);
                        if (num25 == 5)
                        {
                            num22 = Math.Truncate(num22 * 100m) / 100m;
                            decimal num26 = num23 - num22;
                            if (num26 > 0.005m)
                            {
                                num22 = num24;
                            }
                        }
                        if (num7 == 1.16m)
                        {
                            num9 += num22;
                        }
                        else if (num7 == 1.08m)
                        {
                            num10 += num22;
                        }
                    }
                    num5 = num19;
                    decimal num27 = default(decimal);
                    num27 = Math.Round(num5, 2);
                    int num28 = (int)(Math.Floor(num5 * 1000m) % 10m);
                    if (num28 == 5)
                    {
                        num5 = Math.Truncate(num5 * 100m) / 100m;
                        decimal num29 = num19 - num5;
                        if (num29 > 0.005m)
                        {
                            num5 = num27;
                        }
                    }
                    decimal num30 = Math.Round(num5, 2);
                    d += num30;
                    num6 = Math.Round(num19, 3);
                    num += num6;
                }
                num8 = num9 * 0.16m;
                num8 += num10 * 0.08m;
                ModificarTotales(Docto_id, Math.Round(d, 2), num8);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se perdió la conexión :( , contacta a 06 o intenta de nuevo", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                fbConnection.Close();
            }
        }

        public void ModificarTotales(string Docto_id, decimal importe, decimal impuestos)
        {
            int num = (int)(Math.Floor(impuestos * 1000m) % 10m);
            if (num == 5)
            {
                impuestos = Math.Ceiling(impuestos * 100m) / 100m;
            }
            FbConnection fbConnection = new FbConnection("User=" + GlobalSettings.Instance.User + ";Password=" + GlobalSettings.Instance.Pw + ";Database=" + GlobalSettings.Instance.Direccion + ";DataSource=" + GlobalSettings.Instance.Ip + ";Port=" + GlobalSettings.Instance.Puerto + ";Dialect=3;Charset=UTF8;");
            try
            {
                fbConnection.Open();
                string cmdText = "UPDATE DOCTOS_VE SET IMPORTE_NETO = @Importe, TOTAL_IMPUESTOS= @Impuestos, COND_PAGO_ID = '425752' WHERE DOCTO_VE_ID = '" + Docto_id + "';";
                FbCommand fbCommand = new FbCommand(cmdText, fbConnection);
                fbCommand.Parameters.AddWithValue("@Importe", Math.Round(importe, 2));
                fbCommand.Parameters.AddWithValue("@Impuestos", Math.Round(impuestos, 2));
                if (fbCommand.ExecuteNonQuery() == 0)
                {
                    MessageBox.Show("No se pudo actualizar el importe");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se perdió la conexión :( , contacta a 06 o intenta de nuevo", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                fbConnection.Close();
            }
        }

    }
}
