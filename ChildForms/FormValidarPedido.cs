using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Drawing.Charts;
using FirebirdSql.Data.FirebirdClient;
using PedidoXperto.ChildClases;
using SpreadsheetLight;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PedidoXperto.ChildForms
{
    public partial class FormValidarPedido : Form
    {
        List<string> nombresArray = new();
        private List<string> nombresValor = new() { };
        List<Articulo> Articulos = new();
        public FormValidarPedido()
        {
            InitializeComponent();
            //pedidos = new Pedido();
            Leer_Datos();
            Cb_Surtidor.SelectedIndex = -1;
            Cb_Surtidor.DropDownHeight = 250;
            TxtPedido.Select();
            Tabla.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            CargarExcel();
            TxtPedido.Focus();
            TxtPedido.Select();
            //ModuloIA();
        }

        public void CargarExcel()
        {
            string filePath = "C:\\clavesSurtido\\Claves.xlsx";
            //string filePath = "C:\\clavesSurtido\\Claves.xlsx";
            using (SLDocument documento = new SLDocument(filePath))
            {
                int filas = documento.GetWorksheetStatistics().NumberOfRows;
                for (int i = 2; i < filas + 1; ++i)
                {
                    GlobalSettings.Instance.Excluidos.Add(documento.GetCellValueAsString("A" + i));
                }
                documento.CloseWithoutSaving();
            }


        }
        public void Leer_Datos()
        {
            nombresArray.Clear();
            nombresValor.Clear();
            //string filePath = "\\\\192.168.0.2\\C$\\clavesSurtido\\Claves.xlsx";

            //string filePath = "\\\\SRVPRINCIPAL\\clavesSurtido\\Claves.xlsx";
            string filePath = "C:\\clavesSurtido\\Claves.xlsx";
            using (SLDocument documento = new SLDocument(filePath))
            {
                int filas = documento.GetWorksheetStatistics().NumberOfRows;
                for (int i = 2; i < filas + 1; ++i)
                {
                    string temp_name = documento.GetCellValueAsString("A" + i);
                    string temp_value = documento.GetCellValueAsString("B" + i);
                    string temp_status = documento.GetCellValueAsString("C" + i);
                    string name = temp_name + " " + temp_value;
                    nombresArray.Add(name);
                    nombresValor.Add(temp_status);
                }
                documento.CloseWithoutSaving();
            }
            Cb_Surtidor.DataSource = nombresArray;
            Cb_Surtidor.AutoCompleteMode = AutoCompleteMode.Append;
            Cb_Surtidor.AutoCompleteSource = AutoCompleteSource.CustomSource;
            Cb_Surtidor.AutoCompleteCustomSource.AddRange(nombresArray.ToArray());
            //Cb_Vendedor.DataSource = nombresArray;  // Asignar el array de nombres al DataSource
            //Cb_Vendedor.AutoCompleteMode = AutoCompleteMode.Append;  // Configurar el modo de autocompletar
            //Cb_Vendedor.AutoCompleteSource = AutoCompleteSource.CustomSource;  // Establecer la fuente personalizada para autocompletar
            //Cb_Vendedor.AutoCompleteCustomSource.AddRange(nombresArray.ToArray());  // Agregar los elementos del array al autocompletar

            //Cb_Empacador.Text = "";
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public decimal Impuesto(string Articulo_Id)
        {
            FbConnection con3 = new FbConnection(GlobalSettings.Instance.StringConnection);
            try
            {
                con3.Open();
                string Clave_Impuesto = "";
                string impuesto = "";
                string query3 = "SELECT * FROM IMPUESTOS_ARTICULOS WHERE ARTICULO_ID = '" + Articulo_Id + "'";
                FbCommand command3 = new FbCommand(query3, con3);
                FbDataReader reader3 = command3.ExecuteReader();
                if (reader3.Read())
                {
                    Clave_Impuesto = reader3.GetString(2);
                    //MessageBox.Show(GlobalSettings.Instance.Clave_impuesto);
                }
                reader3.Close();
                //QUERI 4 PARA BUSCAR IMPORTE DEL ARTICULO

                string query4 = "SELECT * FROM IMPUESTOS WHERE IMPUESTO_ID = '" + Clave_Impuesto + "'";
                FbCommand command4 = new FbCommand(query4, con3);
                FbDataReader reader4 = command4.ExecuteReader();
                if (reader4.Read())
                {
                    impuesto = reader4.GetString(2);

                }
                reader4.Close();
                if (impuesto == "16% IVA ")
                    return (decimal)1.16;
                else if (impuesto == "IEPS 8%")
                    return (decimal)1.08;
                else
                    return 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se perdió la conexión :( , contacta a 06 o intenta de nuevo", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.ToString());
                return (decimal)1.16;
            }
            finally
            {
                con3.Close();
            }
        }
        private void BtnPedido_Click(object sender, EventArgs e)
        {
            if (Tabla.Rows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Primero termina el pedido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (TxtPedido.Text == string.Empty)
            {
                DialogResult result = MessageBox.Show("Pedido no ingresado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Articulos.Clear();
            GlobalSettings.Instance.Name = TxtPedido.Text;
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            GlobalSettings.Instance.filepath = desktopPath + "\\" + TxtPedido.Text + ".txt";
            string Folio_Mod = TxtPedido.Text;
            if (Folio_Mod[1] == 'O' || Folio_Mod[1] == 'E' || Folio_Mod[1] == 'P' || Folio_Mod[1] == 'M' || Folio_Mod[1] == 'A')
            {
                int cont = 9 - Folio_Mod.Length;
                string prefix = Folio_Mod.Substring(0, 2);
                string suffix = Folio_Mod.Substring(2);
                string patch = "";
                for (int i = 0; i < cont; i++)
                {
                    patch = patch + "0";
                }
                Folio_Mod = prefix + patch + suffix;
            }
            else if (Folio_Mod[0] == 'P')
            {
                int cont = 9 - Folio_Mod.Length;
                string prefix = Folio_Mod.Substring(0, 1);
                string suffix = Folio_Mod.Substring(1);
                string patch = "";
                for (int i = 0; i < cont; i++)
                {
                    patch = patch + "0";
                }
                Folio_Mod = prefix + patch + suffix;
            }

            FbConnection con = new FbConnection(GlobalSettings.Instance.StringConnection);
            try
            {
                con.Open();
                string query0 = "SELECT * FROM DOCTOS_VE WHERE FOLIO = '" + Folio_Mod + "' AND TIPO_DOCTO = 'P';";
                FbCommand command = new FbCommand(query0, con);
                bool Find = false;
                // Objeto para leer los datos obtenidos
                FbDataReader reader0 = command.ExecuteReader();
                if (reader0.Read())
                {
                    GlobalSettings.Instance.status = reader0.GetString(18);
                    GlobalSettings.Instance.FolioId = reader0.GetString(0);
                    GlobalSettings.Instance.Docto_Ve_Id = GlobalSettings.Instance.FolioId;
                    GlobalSettings.Instance.Importe_Total = reader0.GetDecimal(26);
                    GlobalSettings.Instance.VendedorId = reader0.GetString(40);
                    GlobalSettings.Instance.Desc_extra = reader0.GetDecimal(16);
                    GlobalSettings.Instance.Desc_extra_importe = reader0.GetDecimal(17);
                    GlobalSettings.Instance.Vendedor = reader0.GetString(40);
                    Find = true;
                }
                else
                {
                    Find = false;
                }
                reader0.Close();
                if (Find == false)
                {
                    MessageBox.Show("FOLIO NO ENCONTRADO");
                    return;
                }
                else
                {
                    Cancelado.Visible = false;
                    Cargar.Visible = false;
                }
                if (GlobalSettings.Instance.status == "S")
                {
                    MessageBox.Show("Este pedido ya está facturado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (GlobalSettings.Instance.status == "C")
                {
                    MessageBox.Show("Este pedido está cancelado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string query1 = "SELECT * FROM DOCTOS_VE_DET  WHERE DOCTO_VE_ID =" + GlobalSettings.Instance.FolioId + ";";
                FbCommand command1 = new FbCommand(query1, con);
                FbDataReader reader1 = command1.ExecuteReader();

                while (reader1.Read())
                {
                    Articulo variables = new Articulo
                    {
                        Codigo = reader1.GetString(2),
                        ArticuloId = reader1.GetString(3),
                        Descripcion = "0",
                        Solicitado = reader1.GetDecimal(4),
                        Importe_neto_articulo = reader1.GetDecimal(8),
                        Descuento_porcentaje = reader1.GetDecimal(9),
                        Descuento_extra_individual = reader1.GetDecimal(12),
                        Importe_total_articuloeliminado = reader1.GetDecimal(15),
                        Recibido = 0,
                        Nota = reader1.GetString(18),
                        Id = reader1.GetInt32(20),
                        Pendiente = reader1.GetDecimal(4)
                    };
                    Articulos.Add(variables);
                    //GlobalSettings.Instance.ListaContador.Add(variables.Codigo);
                    //int repeticiones = GlobalSettings.Instance.ListaContador.Count(c => c == variables.Codigo);
                    //if (repeticiones > 1)
                    //{
                    //    MessageBox.Show("Codigo repetido: " + variables.Codigo);
                    //    variables.Contador +=1; 
                    //}

                }
                reader1.Close();
                for (int i = 0; i < Articulos.Count; ++i)
                {
                    decimal imp = Impuesto(Articulos[i].ArticuloId);
                    if (imp == 1.16m)
                    {
                        GlobalSettings.Instance.Impuesto_real += Articulos[i].Importe_total_articuloeliminado * 0.16m;
                    }
                    GlobalSettings.Instance.Importe_real += Articulos[i].Importe_total_articuloeliminado;
                }
                //Inicio vendedor
                string querynew = "SELECT * FROM VENDEDORES WHERE VENDEDOR_ID = '" + GlobalSettings.Instance.VendedorId + "';";
                FbCommand commandonew = new FbCommand(querynew, con);

                // Objeto para leer los datos obtenidos
                FbDataReader readernew = commandonew.ExecuteReader();
                if (readernew.Read())
                {
                    GlobalSettings.Instance.Vendedora = readernew.GetString(1);
                }
                readernew.Close();
                //fin

                string query = "SELECT * FROM CLAVES_ARTICULOS ORDER BY CLAVE_ARTICULO_ID";
                FbCommand commando = new FbCommand(query, con);

                // Objeto para leer los datos obtenidos
                FbDataReader reader = commando.ExecuteReader();
                while (reader.Read())
                {
                    // Acceder a los valores de cada columna por su índice o nombre
                    string temp = reader.GetString(2);
                    string col2 = reader.GetString(1);
                    for (int i = 0; i < Articulos.Count; ++i)
                    {
                        if (Articulos[i].Codigo == col2 && Articulos[i].Clave == null)
                        {
                            GlobalSettings.Instance.OficialCodigo.Add(temp);
                            Articulos[i].Clave = temp.ToString();
                        }

                    }
                }
                reader.Close();
                for (int i = 0; i < Articulos.Count; ++i)
                {
                    string queryprecio = "SELECT * FROM PRECIOS_ARTICULOS WHERE ARTICULO_ID = '" + Articulos[i].Clave + "' AND PRECIO_EMPRESA_ID = '42'";
                    FbCommand commandp = new FbCommand(queryprecio, con);
                    FbDataReader readerp = commandp.ExecuteReader();
                    if (readerp.Read())
                    {
                        //GlobalSettings.Instance.Clave_articulo_id = reader12.GetString(2);
                        Articulos[i].Importe = readerp.GetDecimal(3);
                    }
                    readerp.Close();
                }


                //reader2.Close();
                string query3 = "SELECT * FROM ARTICULOS ORDER BY ARTICULO_ID";
                FbCommand command3 = new FbCommand(query3, con);
                FbDataReader reader3 = command3.ExecuteReader();

                // Iterar sobre los registros y mostrar los valores
                while (reader3.Read())
                {
                    string columna11 = reader3.GetString(0);
                    string descripcion = reader3.GetString(1);
                    decimal CajaCompra = reader3.GetDecimal(12);
                    for (int i = 0; i < Articulos.Count; ++i)
                    {
                        if (columna11 == GlobalSettings.Instance.OficialCodigo[i])
                        {
                            for (int j = 0; j < Articulos.Count; ++j)
                            {
                                if (GlobalSettings.Instance.OficialCodigo[i].ToString() == Articulos[j].Clave)
                                {
                                    Articulos[j].Descripcion = descripcion;
                                }
                            }
                            break;
                        }

                    }
                }
                reader3.Close();

                for (int i = 0; i < Articulos.Count; ++i)
                {
                    GlobalSettings.Instance.Articuloid = Articulos[i].ArticuloId;
                    Ubicacion(i);
                }

                DataGridViewRowCollection rows = Tabla.Rows;
                string comentario;
                for (int i = 0; i < Articulos.Count; ++i)
                {
                    //AL AGREGAR AL PEDIDO
                    if (Articulos[i].Codigo.Length > 6)
                    {
                        FbConnection con3 = new FbConnection(GlobalSettings.Instance.StringConnection);
                        try
                        {
                            con3.Open();
                            string query12 = "SELECT * FROM CLAVES_ARTICULOS WHERE ARTICULO_ID = '" + Articulos[i].Clave + "' AND ROL_CLAVE_ART_ID = '17'";
                            FbCommand command12 = new FbCommand(query12, con3);
                            FbDataReader reader12 = command12.ExecuteReader();
                            if (reader12.Read())
                            {
                                //GlobalSettings.Instance.Clave_articulo_id = reader12.GetString(2);
                                Articulos[i].Codigo = reader12.GetString(1);
                            }
                            else
                            {
                                MessageBox.Show("Código no encontrado", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                TxtCodigo.Focus();
                                TxtCodigo.Select(0, TxtCodigo.Text.Length);
                                return;
                            }
                            reader12.Close();


                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Se perdió la conexión :( , contacta a 06 o intenta de nuevo", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            MessageBox.Show(ex.ToString());
                            return;
                        }
                        finally
                        {
                            con3.Close();
                        }
                    }
                    if (Articulos[i].Nota != "")
                    {
                        comentario = "Ver";
                    }
                    else
                    {
                        comentario = string.Empty;
                    }
                    rows.Add(Articulos[i].Id, Articulos[i].Codigo, Articulos[i].Descripcion, Articulos[i].Solicitado, Articulos[i].Recibido, comentario, Articulos[i].Pendiente);
                    Tabla.Rows[i].Height = 45;
                    GlobalSettings.Instance.Renglones = Tabla.RowCount;
                    Lb_renglones.Text = GlobalSettings.Instance.Renglones.ToString();
                }
                for (int i = 0; i < Tabla.Columns.Count; i++)
                {
                    if (i != 8)
                    {
                        Tabla.Columns[i].ReadOnly = true;
                    }
                }
                Tabla.Columns[1].DefaultCellStyle.Font = new System.Drawing.Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
                Tabla.Columns[0].DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
                GlobalSettings.Instance.OficialCodigo.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se perdió la conexión :( , contacta a 06 o intenta de nuevo", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.ToString());
                return;
            }
            finally
            {
                Tabla.ClearSelection();
                Cb_Surtidor.Focus();
                con.Close();
            }
        }

        private void BtnCodigo_Click(object sender, EventArgs e)
        {
            if (Tabla.RowCount > 0)
            {
                if (TxtCodigo.Text != string.Empty)
                {
                    if (TxtCodigo.Text.Length == 6)
                    {
                        bool encontrado = false;
                        //clave
                        List<decimal> LUnidades = new List<decimal>();
                        List<decimal> LRecibido = new List<decimal>();
                        List<int> index = new List<int>();
                        GlobalSettings.Instance.Contador_Codigos = 0;
                        for (int i = 0; i < Articulos.Count; ++i)
                        {
                            //DataGridViewRow fila = Tabla.Rows[i];
                            string valorColumna = Articulos[i].Codigo;
                            if (valorColumna == TxtCodigo.Text)
                            {
                                LUnidades.Add(Articulos[i].Solicitado);
                                LRecibido.Add(Articulos[i].Recibido);
                                index.Add(i);
                                GlobalSettings.Instance.Contador_Codigos += 1;
                                //MessageBox.Show(GlobalSettings.Instance.Contador_Codigos.ToString());
                            }
                        }
                        bool bander = false;
                        if (GlobalSettings.Instance.Contador_Codigos > 1)
                        {
                            bander = true;
                            for (int i = 0; i < index.Count; ++i)
                            {
                                if (LUnidades[i] != LRecibido[i])
                                {
                                    if (i == 0)
                                        bander = false;
                                    GlobalSettings.Instance.Contador_Codigos = index[i];
                                    break;
                                }
                                GlobalSettings.Instance.Contador_Codigos = index[i];
                            }

                        }
                        for (int i = 0; i < Articulos.Count; ++i)
                        {
                            if (bander == true)
                                i = GlobalSettings.Instance.Contador_Codigos;
                            if (Articulos[i].Codigo == TxtCodigo.Text)
                            {
                                FbConnection con4 = new FbConnection(GlobalSettings.Instance.StringConnection);
                                try
                                {
                                    con4.Open();
                                    string query00 = "SELECT * FROM CLAVES_ARTICULOS WHERE CLAVE_ARTICULO = '" + TxtCodigo.Text + "';";
                                    FbCommand command00 = new FbCommand(query00, con4);
                                    FbDataReader reader00 = command00.ExecuteReader();
                                    if (reader00.Read())
                                    {
                                        GlobalSettings.Instance.Contenido = reader00.GetDecimal(4);
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Se perdió la conexión :( , contacta a 06 o intenta de nuevo", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    MessageBox.Show(ex.ToString());
                                    return;
                                }
                                finally
                                {
                                    con4.Close();
                                }
                                Tabla.FirstDisplayedScrollingRowIndex = i;
                                GlobalSettings.Instance.Current = i;
                                Tabla.ClearSelection();
                                Tabla.Rows[GlobalSettings.Instance.Current].Cells[0].Selected = true;
                                Tabla.Rows[GlobalSettings.Instance.Current].Cells[1].Selected = true;
                                encontrado = true;
                                //red mode
                                if (BtnPedido.BackColor == System.Drawing.Color.Red || BtnPedido.BackColor == System.Drawing.Color.Fuchsia || BtnPedido.BackColor == System.Drawing.Color.HotPink)
                                {
                                    ejecutar(GlobalSettings.Instance.Contenido, GlobalSettings.Instance.Current);
                                    return;
                                }
                                Menu Control = new Menu();
                                Control.FuncionRecibir(TxtCodigo.Text, Articulos[i].Descripcion, Articulos[i].Solicitado, Articulos[i].Recibido, i, Articulos[i].Nota);
                                Control.EnviarVariableEvent += new Menu.EnviarVariableDelegate(ejecutar);
                                Control.Show();
                                return;
                            }
                        }
                        if (encontrado == false)
                        {
                            //ReproducirSonido("C:\\Windows\\Media\\Windows Critical Stop.wav");
                            //MessageBox.Show("Código no encontrado en el pedido", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            //TxtCodigo.Focus();
                            //TxtCodigo.Select(0, TxtCodigo.Text.Length);
                            //return;
                            GlobalSettings.Instance.lastchance = true;
                        }
                    }
                    if (TxtCodigo.Text.Length > 6 || GlobalSettings.Instance.lastchance == true)
                    {
                        FbConnection con3 = new FbConnection(GlobalSettings.Instance.StringConnection);
                        try
                        {
                            GlobalSettings.Instance.Contador_Codigos = 0;
                            string template;
                            con3.Open();
                            string query12 = "SELECT * FROM CLAVES_ARTICULOS WHERE CLAVE_ARTICULO = '" + TxtCodigo.Text + "';";
                            FbCommand command121 = new FbCommand(query12, con3);
                            FbDataReader reader121 = command121.ExecuteReader();
                            if (reader121.Read())
                            {
                                //GlobalSettings.Instance.Clave_articulo_id = reader12.GetString(2);
                                template = reader121.GetString(2);
                                GlobalSettings.Instance.Contenido = reader121.GetDecimal(4);
                            }
                            else
                            {
                                MessageBox.Show("Código no encontrado", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                TxtCodigo.Focus();
                                TxtCodigo.Select(0, TxtCodigo.Text.Length);
                                return;
                            }
                            reader121.Close();
                            string variableclave;
                            string query122 = "SELECT * FROM CLAVES_ARTICULOS WHERE ARTICULO_ID = '" + template + "' AND ROL_CLAVE_ART_ID = '17'";
                            FbCommand command122 = new FbCommand(query122, con3);
                            FbDataReader reader122 = command122.ExecuteReader();
                            if (reader122.Read())
                            {
                                //GlobalSettings.Instance.Clave_articulo_id = reader12.GetString(2);
                                TxtCodigo.Text = reader122.GetString(1);
                                //if (TxtCodigo.Text.Length > 6)
                                //{
                                //    string Cod_Mod = TxtCodigo.Text;
                                //    do
                                //    {
                                //        int tam = Cod_Mod.Length;
                                //        Cod_Mod = Cod_Mod.Remove(tam - 1);
                                //    } while (Cod_Mod.Length > 6);
                                //    TxtCodigo.Text = Cod_Mod;
                                //}

                            }
                            reader122.Close();
                            bool encontrado = false;
                            //clave
                            List<decimal> LUnidades = new List<decimal>();
                            List<decimal> LRecibido = new List<decimal>();
                            List<int> index = new List<int>();
                            for (int i = 0; i < Articulos.Count; ++i)
                            {
                                //DataGridViewRow fila = Tabla.Rows[i];
                                string valorColumna = Articulos[i].Codigo;
                                if (valorColumna == TxtCodigo.Text)
                                {
                                    LUnidades.Add(Articulos[i].Solicitado);
                                    LRecibido.Add(Articulos[i].Recibido);
                                    index.Add(i);
                                    GlobalSettings.Instance.Contador_Codigos += 1;
                                    //MessageBox.Show(GlobalSettings.Instance.Contador_Codigos.ToString());
                                }
                            }
                            bool bander = false;
                            if (GlobalSettings.Instance.Contador_Codigos > 1)
                            {
                                bander = true;
                                for (int i = 0; i < index.Count; ++i)
                                {
                                    if (LUnidades[i] != LRecibido[i])
                                    {
                                        if (i == 0)
                                            bander = false;
                                        GlobalSettings.Instance.Contador_Codigos = index[i];
                                        break;
                                    }
                                    GlobalSettings.Instance.Contador_Codigos = index[i];
                                }

                            }
                            else if (GlobalSettings.Instance.Contador_Codigos == 0)
                            {
                                MessageBox.Show("Código no relacionado al pedido", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                TxtCodigo.Focus();
                                TxtCodigo.Select(0, TxtCodigo.Text.Length);
                                return;
                            }

                            for (int i = 0; i < Articulos.Count; ++i)
                            {
                                if (bander == true)
                                    i = GlobalSettings.Instance.Contador_Codigos;
                                if (Articulos[i].Codigo == TxtCodigo.Text)
                                {
                                    encontrado = true;
                                    Menu Control = new Menu();
                                    //MOD
                                    Tabla.FirstDisplayedScrollingRowIndex = i;
                                    GlobalSettings.Instance.Current = i;
                                    Tabla.ClearSelection();
                                    Tabla.Rows[GlobalSettings.Instance.Current].Cells[0].Selected = true;
                                    Tabla.Rows[GlobalSettings.Instance.Current].Cells[1].Selected = true;
                                    //red mode
                                    if (BtnPedido.BackColor == System.Drawing.Color.Red || BtnPedido.BackColor == System.Drawing.Color.Fuchsia || BtnPedido.BackColor == System.Drawing.Color.HotPink)
                                    {
                                        ejecutar(GlobalSettings.Instance.Contenido, GlobalSettings.Instance.Current);
                                        return;
                                    }
                                    Control.FuncionRecibir(TxtCodigo.Text, Articulos[i].Descripcion, Articulos[i].Solicitado, Articulos[i].Recibido, i, Articulos[i].Nota);
                                    Control.EnviarVariableEvent += new Menu.EnviarVariableDelegate(ejecutar);
                                    Control.Show();
                                    return;
                                }
                                //modificar
                            }
                            if (encontrado == false)
                            {
                                MessageBox.Show("Código no relacionado al pedido", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                TxtCodigo.Focus();
                                TxtCodigo.Select(0, TxtCodigo.Text.Length);
                                return;
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Se perdió la conexión :( , contacta a 06 o intenta de nuevo", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            MessageBox.Show(ex.ToString());
                            return;
                        }
                        finally
                        {
                            con3.Close();
                            GlobalSettings.Instance.lastchance = false;
                        }
                        //MessageBox.Show("Todo en orden");
                    }
                }
            }
        }
        public void ejecutar(decimal cantidad, int id)
        {
            if (GlobalSettings.Instance.Editar == true)
            {
                DialogResult result = MessageBox.Show("¿Estás seguro que deseas editar este artículo?\n ¿Deseas continuar?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Cancel)
                {
                    GlobalSettings.Instance.Editar = false;
                    TxtCodigo.Focus();
                    TxtCodigo.Select(0, TxtCodigo.Text.Length);
                    return;
                }

            }
            else
            {
                if (cantidad + Articulos[id].Recibido > Articulos[id].Solicitado)
                {
                    DialogResult result = MessageBox.Show("Te estás pasando la cantidad solicitada \n ¿Deseas continuar?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    if (result == DialogResult.Cancel)
                    {
                        TxtCodigo.Focus();
                        TxtCodigo.Select(0, TxtCodigo.Text.Length);
                        return;
                    }
                }
            }
            bool banderaincompleto = false;
            bool temporal = false;
            bool temporal2 = false;
            decimal prueba;
            bool bandera = false;
            bool regresar = false;
            if (GlobalSettings.Instance.Editar == true)
            {
                prueba = Articulos[id].Solicitado - cantidad;
                if (Articulos[id].Pendiente == 0 && prueba != 0)
                    temporal2 = true;
                if (prueba == 0 && Articulos[id].Recibido > 0)
                    temporal = true;
                if (prueba == 0)
                    bandera = true;
                if ((prueba) >= 1 && Articulos[id].Recibido == 0)
                    banderaincompleto = true;
                if (Articulos[id].Recibido > 0 && cantidad == 0)
                    temporal = true;
                if (prueba < 0 && Articulos[id].Recibido > 0)
                    regresar = true;
                if (prueba < 0 && Articulos[id].Recibido == Articulos[id].Solicitado)
                    bandera = true;
                if (prueba < 0 && Articulos[id].Recibido == 0)
                    bandera = true;
                if (prueba == 0 && Articulos[id].Recibido > Articulos[id].Solicitado)
                {
                    bandera = false;
                    temporal = false;
                }
                if (prueba < 0 && Articulos[id].Recibido == Articulos[id].Solicitado)
                {
                    temporal = false;
                    bandera = false;
                    temporal2 = false;
                    regresar = false;
                }
                Articulos[id].Recibido = cantidad;
                Articulos[id].Pendiente = Articulos[id].Solicitado - cantidad;
                GlobalSettings.Instance.Editar = false;

            }
            else
            {
                prueba = Articulos[id].Pendiente - cantidad;
                if (prueba == 0 && Articulos[id].Recibido > 0)
                    temporal = true;
                if (prueba == 0)
                    bandera = true;
                if ((prueba) >= 1 && Articulos[id].Recibido == 0)
                    banderaincompleto = true;
                Articulos[id].Recibido += cantidad;
                Articulos[id].Pendiente -= cantidad;
            }
            if (Articulos[id].Pendiente < 0)
                Articulos[id].Pendiente = 0;
            List<int> ListaTabla = new List<int>();
            if (bandera == true)
            {
                GlobalSettings.Instance.Renglones--;
                Lb_renglones.Text = GlobalSettings.Instance.Renglones.ToString();
                bandera = false;
            }
            if (temporal == true)
            {
                GlobalSettings.Instance.Incompletos--;
                Lb_Incompletos.Text = GlobalSettings.Instance.Incompletos.ToString();
                GlobalSettings.Instance.Renglones++;
                Lb_renglones.Text = GlobalSettings.Instance.Renglones.ToString();
                bandera = false;
            }
            if (regresar == true)
            {
                GlobalSettings.Instance.Incompletos--;
                Lb_Incompletos.Text = GlobalSettings.Instance.Incompletos.ToString();
                regresar = false;
            }
            if (temporal2 == true)
            {
                GlobalSettings.Instance.Incompletos++;
                Lb_Incompletos.Text = GlobalSettings.Instance.Incompletos.ToString();
            }

            //ORDENAR
            for (int i = 0; i < Articulos.Count; ++i)
            {
                ListaTabla.Add(int.Parse(Tabla.Rows[i].Cells[0].Value.ToString()));
            }
            Tabla.Rows.Clear();
            DataGridViewRowCollection rows = Tabla.Rows;
            string comentario;
            for (int i = 0; i < Articulos.Count; ++i)
            {
                int a = 1;
                if (ListaTabla[i] != i + 1)
                {
                    a = ListaTabla[i] - i;
                }
                if (Articulos[ListaTabla[i] - a].Nota != "")
                {
                    comentario = "Ver";
                }
                else
                {
                    comentario = string.Empty;
                }
                rows.Add(Articulos[ListaTabla[i] - a].Id, Articulos[ListaTabla[i] - a].Codigo, Articulos[ListaTabla[i] - a].Descripcion, Articulos[ListaTabla[i] - a].Solicitado, Articulos[ListaTabla[i] - a].Recibido, comentario, Articulos[ListaTabla[i] - a].Pendiente);
                Tabla.Rows[i].Height = 45;
                DataGridViewRow row = Tabla.Rows[i];
                if (Articulos[ListaTabla[i] - a].Solicitado - Articulos[ListaTabla[i] - a].Recibido > 0 && Articulos[ListaTabla[i] - a].Recibido != 0)
                {
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.LightBlue;
                    if (banderaincompleto == true && temporal == false)
                    {
                        GlobalSettings.Instance.Incompletos++;
                        Lb_Incompletos.Text = GlobalSettings.Instance.Incompletos.ToString();
                        banderaincompleto = false;
                        GlobalSettings.Instance.Renglones--;
                        Lb_renglones.Text = GlobalSettings.Instance.Renglones.ToString();
                        bandera = false;
                    }
                }
                else if (Articulos[ListaTabla[i] - a].Solicitado - Articulos[ListaTabla[i] - a].Recibido == 0)
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
                else if (Articulos[ListaTabla[i] - a].Solicitado - Articulos[ListaTabla[i] - a].Recibido < 0)
                {
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                    row.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
                }
            }
            //if (bandera == true)
            //{
            //    GlobalSettings.Instance.Renglones--;
            //    Lb_renglones.Text = GlobalSettings.Instance.Renglones.ToString();
            //    bandera = false;
            //}
            Tabla.FirstDisplayedScrollingRowIndex = GlobalSettings.Instance.Current;
            Tabla.ClearSelection();
            Tabla.Rows[GlobalSettings.Instance.Current].Cells[0].Selected = true;
            Tabla.Rows[GlobalSettings.Instance.Current].Cells[1].Selected = true;
            TxtCodigo.Text = string.Empty;
            ListaTabla.Clear();
            TxtCodigo.Focus();
        }
        public void Ubicacion(int index)
        {
            FbConnection con = new FbConnection(GlobalSettings.Instance.StringConnection);
            try
            {
                con.Open();
                string query4 = "SELECT * FROM NIVELES_ARTICULOS WHERE ARTICULO_ID = " + GlobalSettings.Instance.Articuloid + ";";
                FbCommand command4 = new FbCommand(query4, con);
                FbDataReader reader4 = command4.ExecuteReader();

                // Iterar sobre los registros y mostrar los valores
                while (reader4.Read())
                {
                    string columna3 = reader4.GetString(3);
                    string columna2 = reader4.GetString(2);
                    if (columna3 != "")
                    {
                        if (columna2 == "108403")
                            Articulos[index].Ubicacion += "TIENDA:  " + columna3 + "\n";
                        if (columna2 == "108402")
                            Articulos[index].Ubicacion += "ALMACÉN:  " + columna3 + "\n";
                        if (columna2 == "108401")
                            Articulos[index].Ubicacion += "ISLA:  " + columna3 + "\n";
                    }
                    //if (columna3 != "")
                    //{
                    //    if (columna2 == "108405")
                    //       Articulos[index].Ubicacion += "CULIACÁN:  " + columna3 + "\n";

                    //}

                }
                if (Articulos[index].Ubicacion == null)
                {
                    Articulos[index].Ubicacion = "No tiene registrada una ubicación";
                }
                reader4.Close();

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

        private void TxtPedido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                BtnPedido.Focus();
            }
        }

        private void BtnPedido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Cb_Surtidor.Focus();
            }
        }

        private void Cb_Surtidor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                TxtCodigo.Focus();
            }
        }

        private void TxtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                BtnCodigo.Focus();
            }
        }

        private void Cb_Surtidor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }
    }
}
