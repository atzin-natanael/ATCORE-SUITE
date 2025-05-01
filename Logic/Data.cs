using System.Text.Json;
using System.Text;
using PedidoXperto.ChildClases;

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

        public string? GetArticuloId(string claveArticulo)
        {
            var sql = "SELECT ARTICULO_ID FROM CLAVES_ARTICULOS WHERE CLAVE_ARTICULO = @c;";
            var rows = new FireBirdHelper().ExecuteSingleColumn(sql, new Dictionary<string, object>
            {
                {"@c", claveArticulo}
            });

            // Devuelve el primer valor o null si no existe
            return rows.FirstOrDefault();
        }
        public Tuple<string, string>? GetDiscount(string cliente_id, string articulo_id)
        {
            var sql = "SELECT POLITICAS_DSCTOS_ART_CLI.DESCUENTO" +
            "            FROM DIRS_CLIENTES" +
            "           JOIN CLAVES_CLIENTES ON CLAVES_CLIENTES.CLIENTE_ID = DIRS_CLIENTES.CLIENTE_ID" +
            "            JOIN PRECIOS_CLI_CLI ON PRECIOS_CLI_CLI.CLIENTE_ID = DIRS_CLIENTES.CLIENTE_ID" +
            "            JOIN POLITICAS_DSCTOS_ART_CLI ON POLITICAS_DSCTOS_ART_CLI.POLITICA_DSCTO_ART_CLI_ID = PRECIOS_CLI_CLI.POLITICA_DSCTO_ART_CLI_ID" +
            "           WHERE DIRS_CLIENTES.CLIENTE_ID =  @c;";
            var rows = new FireBirdHelper().ExecuteSingleColumn(sql, new Dictionary<string, object>
            {
                {"@c", cliente_id}
            });

            // Devuelve el primer valor o null si no existe
            sql = "SELECT DESCUENTO FROM DSCTOS_PROMO_ARTS WHERE ARTICULO_ID = @c;";
            var rows2 = new FireBirdHelper().ExecuteSingleColumn(sql, new Dictionary<string, object>
            {
                {"@c", articulo_id}
            });     
            Tuple<string, string> discount = new Tuple<string, string>(rows.FirstOrDefault(), rows2.FirstOrDefault());
            return discount;
        }
        public static async Task<List<string>> ObtenerRecomendado(string Clave_articulo)
        {
            List<string> recomendaciones = new List<string>();

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // URL del endpoint de tu API FastAPI
                    //string url = "http://localhost:8000/recomendar"; // Asegúrate de que el puerto sea el correcto
                    string url = "https://6d21-2806-2f0-5501-dbb5-621a-ac67-498e-d10.ngrok-free.app/recomendar";
                    // Construcción del cuerpo en JSON
                    var payload = new { clave_articulo = int.Parse(Clave_articulo) };
                    string jsonPayload = System.Text.Json.JsonSerializer.Serialize(payload);
                    var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

                    // Envío de la solicitud POST
                    HttpResponseMessage response = await client.PostAsync(url, content);

                    if (response.IsSuccessStatusCode)
                    {
                        // Leer respuesta y deserializar
                        string jsonResponse = await response.Content.ReadAsStringAsync();

                        using (JsonDocument doc = JsonDocument.Parse(jsonResponse))
                        {
                            JsonElement root = doc.RootElement;
                            JsonElement recomendacionesJson = root.GetProperty("recomendaciones");

                            foreach (JsonElement item in recomendacionesJson.EnumerateArray())
                            {
                                recomendaciones.Add(item.ToString());
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error al obtener recomendaciones: " + response.ReasonPhrase);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Excepción: " + ex.Message);
            }

            // Devolver solo los primeros dos si hay más
            return recomendaciones.Count >= 2
                ? recomendaciones.GetRange(0, 2)
                : recomendaciones;
        }

    }

}
