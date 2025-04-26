namespace PedidoXperto.Logic
{
    public class Data
    {
        public string? SearchClient(string claveCliente)
        {
            var sql = "SELECT CLIENTE_ID FROM CLAVES_CLIENTES WHERE CLAVE_CLIENTE = @c;";
            var rows = new FireBirdHelper().ExecuteSingleColumn(sql, new Dictionary<string, object>
            {
                {"@c", claveCliente}
            });

            // Devuelve el primer valor o null si no existe
            return rows.FirstOrDefault();
        }
        public string? GetClientName(string claveCliente)
        {
            var client_id = SearchClient(claveCliente);
            if (client_id == null)
                return null;

            var sql = "SELECT NOMBRE FROM CLIENTES WHERE CLIENTE_ID = @c;";
            var rows = new FireBirdHelper().ExecuteSingleColumn(sql, new Dictionary<string, object>
            {
                {"@c", client_id}
            });

            // Devuelve el primer valor o null si no existe
            return rows.FirstOrDefault();
        }
    }

}
