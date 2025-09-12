using FirebirdSql.Data.FirebirdClient;
using ATCORE_SUITE.ChildClases;
using System.Data;

namespace ATCORE_SUITE.Logic
{
    public class FireBirdHelper
    {
        private string _connectionString;

        public FireBirdHelper(string? connectionString = null)
        {
            if (connectionString == null)//Conexion por defecto
                _connectionString = GlobalSettings.Instance.StringConnection;
            else
                _connectionString = connectionString;
        }

        /// <summary>
        /// Para queries que solo requieran obtener una columna
        /// </summary>
        /// <param name="query"></param>
        /// <returns>Columna de datos almacenada como strings</returns>
        /// <exception cref="Exception"></exception>
        public HashSet<string> ExecuteSingleColumn(string sqlQuery, IDictionary<string, object>? parameters = null)
        {
            if (string.IsNullOrWhiteSpace(sqlQuery))
                throw new ArgumentException("SQL no puede ser vacío.", nameof(sqlQuery));

            var result = new HashSet<string>();
            using var conn = new FbConnection(_connectionString);
            conn.Open();

            using var cmd = new FbCommand(sqlQuery, conn);
            if (parameters != null)
                foreach (var p in parameters)
                    cmd.Parameters.AddWithValue(p.Key, p.Value);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                // Asume que la columna 0 es string
                result.Add(reader.GetString(0));
            }
                        return result;
            return result;
        }

        /// <summary>
        /// Para queries que devuelvan una tabla mas compleja
        /// </summary>
        /// <param name="query"></param>
        /// <returns>Datatable automapeado</returns>
        /// <exception cref="Exception"></exception>
        public DataTable ExecuteTable(string sqlQuery, IDictionary<string, object>? parameters = null)
        {
            if (string.IsNullOrWhiteSpace(sqlQuery))
                throw new ArgumentException("SQL no puede ser vacío.", nameof(sqlQuery));

            var dt = new DataTable();
            using var conn = new FbConnection(_connectionString);
            conn.Open();

            using var cmd = new FbCommand(sqlQuery, conn);
            if (parameters != null)
                foreach (var p in parameters)
                    cmd.Parameters.AddWithValue(p.Key, p.Value);

            using var adapter = new FbDataAdapter(cmd);
            adapter.Fill(dt);

            return dt;
        }
    }
}
