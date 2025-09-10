using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;
using ATCORE_SUITE.ChildClases;
using MySql.Data.MySqlClient;
using MySqlConnector;
using ApiBas = ATCORE_SUITE.ApiMspBasicaExt;
using ApiInv = ATCORE_SUITE.ApiMspInventExt;
using System.Data;

namespace ATCORE_SUITE.Logic
{
    public class GetFireBirdValue
    {
        public static string GetValue(string query) 
        {
            FbConnection con = new FbConnection(GlobalSettings.Instance.StringConnection);
            try
            {
                con.Open();
                FbCommand command = new FbCommand(query, con);
                FbDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return reader.GetString(0);
                }
                else
                {
                    return null;
                }

            }
            catch
            {
                MessageBox.Show("Se perdió la conexión :( , contacta a 06 o intenta de nuevo", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                con.Close();
            }
        }
        public static List<List<string>> GetCloudValueList(string query)
        {
            List<List<string>> datos = new List<List<string>>();
            using var conn = new MySql.Data.MySqlClient.MySqlConnection(GlobalSettings.Instance.StringConnectionCloud);
            try
            {
                conn.Open();
                string sql = query;
                using var cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                //cmd.Parameters.AddWithValue("@id", "324852");
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    List<string> fila = new List<string>();
                    fila.Add(reader.GetInt32(0).ToString());
                    fila.Add(reader.GetString(1));
                    fila.Add(reader.GetString(2));
                    fila.Add(reader.GetInt32(3).ToString());
                    fila.Add(reader.GetDecimal(4).ToString());
                    datos.Add(fila);
                }
                return datos;
            }
            catch
            {
                //MessageBox.Show("Se perdió la conexión :( , contacta a 06 o intenta de nuevo", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public static int ConectaBD()
        {

            ApiBas.SetErrorHandling(0, 0);
            if (GlobalSettings.Instance.Bd == 0)
                GlobalSettings.Instance.Bd = ApiBas.NewDB();
            //Objeto transaccion
            GlobalSettings.Instance.Trn = ApiBas.NewTrn(GlobalSettings.Instance.Bd, 3);
            string path = GlobalSettings.Instance.Ip + ":" + GlobalSettings.Instance.Direccion;
            int conecta = ApiBas.DBConnect(GlobalSettings.Instance.Bd, path, GlobalSettings.Instance.User, GlobalSettings.Instance.Pw);
            StringBuilder obtieneError = new StringBuilder(1000);
            int codigoError = ApiBas.GetLastErrorMessage(obtieneError);
            String mensajeError = codigoError.ToString();
            if (codigoError > 0)
            {
                MessageBox.Show(obtieneError.ToString());
                return 0;
            }
            else
            {
                return 1;
            }

        }
        public static string GetCloudValue(string query)
        {
            using var conn = new MySql.Data.MySqlClient.MySqlConnection(GlobalSettings.Instance.StringConnectionCloud);
            try
            {
                conn.Open();
                using var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn);
                //cmd.Parameters.AddWithValue("@id", "324852");
                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return reader.GetInt32(0).ToString();
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                //MessageBox.Show("Se perdió la conexión :( , contacta a 06 o intenta de nuevo", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public static (string, string) GetCloudValue2(string query)
        {
            using var conn = new MySql.Data.MySqlClient.MySqlConnection(GlobalSettings.Instance.StringConnectionCloud);
            try
            {
                conn.Open();
                using var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn);
                //cmd.Parameters.AddWithValue("@id", "324852");
                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return (reader.GetInt32(0).ToString() , reader.GetInt32(1).ToString());

                }
                else
                {
                    return (null,null);
                }
            }
            catch
            {
                //MessageBox.Show("Se perdió la conexión :( , contacta a 06 o intenta de nuevo", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (null, null);
            }
            finally
            {
                conn.Close();
            }
        }
        public static (string?, string?) GetCloudValue2Date(string query)
        {
            using var conn = new MySql.Data.MySqlClient.MySqlConnection(GlobalSettings.Instance.StringConnectionCloud);
            try
            {
                conn.Open();
                using var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn);
                //cmd.Parameters.AddWithValue("@id", "324852");
                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    var dateValue = reader.IsDBNull(0) ? (DateTime?)null : reader.GetDateTime(0);
                    var charValue = reader.IsDBNull(1) ? (char?)null : reader.GetChar(1);

                    return (dateValue?.ToString(), charValue?.ToString());

                }
                else
                {
                    return (null, null);
                }
            }
            catch
            {
                //MessageBox.Show("Se perdió la conexión :( , contacta a 06 o intenta de nuevo", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (null, null);
            }
            finally
            {
                conn.Close();
            }
        }
        public static void InsertCloudValueDocto_in(int doctos_in_id, string folio, char ingresado, DateTime fecha_creacion, DateTime? fecha_ingresado, char Tipo)
        {
            using var conn = new MySql.Data.MySqlClient.MySqlConnection(GlobalSettings.Instance.StringConnectionCloud);
            try
            {
                conn.Open();
                string query = "INSERT INTO DOCTOS_IN (DOCTOS_IN_ID, FOLIO, INGRESADO, FECHA_CREACION, FECHA_INGRESADO, TIPO_DOCTO)" +
                "VALUES (@doctos_in_id, @folio, @ingresado, @fecha_creacion, @fecha_ingresado, @tipo)";
                using var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@doctos_in_id", doctos_in_id);
                cmd.Parameters.AddWithValue("@folio", folio);
                cmd.Parameters.AddWithValue("@ingresado", ingresado);
                cmd.Parameters.AddWithValue("@fecha_creacion", fecha_creacion);
                cmd.Parameters.AddWithValue("@fecha_ingresado", fecha_ingresado);
                cmd.Parameters.AddWithValue("@tipo", Tipo);

                int filasAfectadas = cmd.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    //MessageBox.Show("Registro insertado correctamente.");
                }
                else
                {
                    MessageBox.Show("No se encontró el registro a actualizar.");
                }
            }
            catch
            {
                MessageBox.Show("Se perdió la conexión :( , contacta a 06 o intenta de nuevo", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                conn.Close();
            }
        }
        public static void InsertCloudValue(string query, string valor)
        {
            using var conn = new MySql.Data.MySqlClient.MySqlConnection(GlobalSettings.Instance.StringConnectionCloud);
            try
            {
                conn.Open();
                using var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Repetido_valor", int.Parse(valor));
                int filasAfectadas = cmd.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    //MessageBox.Show("Registro insertado correctamente.");
                }
                else
                {
                    MessageBox.Show("No se encontró el registro a actualizar.");
                }
            }
            catch
            {
                MessageBox.Show("Se perdió la conexión :( , contacta a 06 o intenta de nuevo", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                conn.Close();
            }
        }
        public static void InsertCloudValueDocto_det_in(int doctos_in_det_id, int docto_in_id, int id, string clave, string nombre, decimal precio, int cantidad)
        {
            using var conn = new MySql.Data.MySqlClient.MySqlConnection(GlobalSettings.Instance.StringConnectionCloud);
            try
            {
                conn.Open();
                string query = "INSERT INTO DOCTOS_IN_DET (DOCTOS_IN_DET_ID, DOCTO_IN_ID,  ID,  CLAVE, NOMBRE, PRECIO, CANTIDAD)" +
                "VALUES (@doctos_in_det_id, @docto_in_id,  @id,  @clave, @nombre, @precio, @cantidad)";
                using var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@doctos_in_det_id", doctos_in_det_id);
                cmd.Parameters.AddWithValue("@docto_in_id", docto_in_id);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@clave", clave);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@precio", precio);
                cmd.Parameters.AddWithValue("@cantidad", cantidad);

                int filasAfectadas = cmd.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    //MessageBox.Show("Registro insertado correctamente.");
                }
                else
                {
                    MessageBox.Show("No se encontró el registro a actualizar.");
                }
            }
            catch
            {
                MessageBox.Show("Se perdió la conexión :( , contacta a 06 o intenta de nuevo", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                conn.Close();
            }
        }
        public static void UpdateCloudValueDocto_in(int doctos_in_id)
        {
            using var conn = new MySql.Data.MySqlClient.MySqlConnection(GlobalSettings.Instance.StringConnectionCloud);
            try
            {
                conn.Open();
                string query = "UPDATE DOCTOS_IN SET INGRESADO = @Ingresado, FECHA_INGRESADO = @Fecha WHERE DOCTOS_IN_ID = @Doctos_in_id;";
                using var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Doctos_in_id", doctos_in_id);
                cmd.Parameters.AddWithValue("@Ingresado", 'S');
                cmd.Parameters.AddWithValue("@Fecha", DateTime.Now);

                int filasAfectadas = cmd.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    //MessageBox.Show("Registro insertado correctamente.");
                }
                else
                {
                    MessageBox.Show("No se encontró el registro a actualizar.");
                }
            }
            catch
            {
                MessageBox.Show("Se perdió la conexión :( , contacta a 06 o intenta de nuevo", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                conn.Close();
            }
        }
        public string[] BuscarDatosArticulos(string Clave_articulo)
        {
            string articulo_id = "", nombre = "", clave_principal = "", preciolista = "", impuestoid = "", impuesto ="0";

            FbConnection con = new FbConnection(GlobalSettings.Instance.StringConnection);
            try
            {
                con.Open();
                string query = "SELECT ARTICULO_ID FROM CLAVES_ARTICULOS WHERE CLAVE_ARTICULO = '" + Clave_articulo + "'";
                FbCommand command = new FbCommand(query, con);
                FbDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    articulo_id = reader.GetString(0);
                }
                else
                {
                    return null;
                }
                preciolista = GetValue("SELECT PRECIO FROM PRECIOS_ARTICULOS WHERE ARTICULO_ID = '" + articulo_id + "' AND PRECIO_EMPRESA_ID = '42';");
                string queryc = "SELECT CLAVE_ARTICULO FROM CLAVES_ARTICULOS WHERE ARTICULO_ID = '" + articulo_id + "' AND ROL_CLAVE_ART_ID = '17'";
                FbCommand commandc = new FbCommand(queryc, con);
                FbDataReader readerc = commandc.ExecuteReader();
                if (readerc.Read())
                {
                    clave_principal = readerc.GetString(0);
                }
                else
                {
                    return null;
                }
                impuestoid = GetValue("SELECT IMPUESTO_ID FROM IMPUESTOS_ARTICULOS WHERE ARTICULO_ID = '" + articulo_id + "';");
                impuesto = GetValue("SELECT PCTJE_IMPUESTO FROM IMPUESTOS WHERE IMPUESTO_ID = '" + impuestoid + "';");
                string queryb = "SELECT NOMBRE FROM ARTICULOS WHERE ARTICULO_ID = '" + articulo_id + "'";
                FbCommand commandb = new FbCommand(queryb, con);
                FbDataReader readerb = commandb.ExecuteReader();
                if (readerb.Read())
                {
                    nombre = readerb.GetString(0);
                    return new string[] { clave_principal, nombre, preciolista, impuesto };
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se perdió la conexión :( , contacta a 06 o intenta de nuevo", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.ToString());
                return null;
            }
            finally
            {
                con.Close();
            }
        }
        public string[] GetImpuestoArticulo(string Clave_articulo)
        {
           
                string articulo_id = GetValue("SELECT ARTICULO_ID FROM CLAVES_ARTICULOS WHERE CLAVE_ARTICULO = '" + Clave_articulo + "';");
                string impuestoid = GetValue("SELECT IMPUESTO_ID FROM IMPUESTOS_ARTICULOS WHERE ARTICULO_ID = '" + articulo_id + "';");
                string impuesto = GetValue("SELECT PCTJE_IMPUESTO FROM IMPUESTOS WHERE IMPUESTO_ID = '" + impuestoid + "';");
                return new string[] {impuesto };
        }
    }
}
