namespace PedidoXperto.Logic
{
    public class Data
    {
        private readonly FireBirdHelper _db;
        /// <summary>
        /// Conexion por defecto declarada en GlobalSettings
        /// </summary>
        public Data() : this(ChildClases.GlobalSettings.Instance.StringConnection) { }

        /// <summary>
        /// Constructor para crear una instancia de Data con una cadena de conexión específica.
        /// </summary>
        /// <param name="connectionString"></param>
        public Data(string connectionString)
        {
            _db = new FireBirdHelper(connectionString);
        }
        public string? SearchClient(string claveCliente)
        {
            var sql = "SELECT CLIENTE_ID FROM CLAVES_CLIENTES WHERE CLAVE_CLIENTE = @c";
            var rows = _db.ExecuteSingleColumn(sql, new Dictionary<string, object>
            {
                {"@c", claveCliente}
            });

            // Devuelve el primer valor o null si no existe
            return rows.FirstOrDefault();
        }
    }

}
