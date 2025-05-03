using System.Text;
using System.Text.Json;

namespace PedidoXperto.Logic
{
    public class DataBridge
    {
        #region Datos Cliente
        static public string? SearchClient(string claveCliente)
        {
            var sql = "SELECT CLIENTE_ID FROM CLAVES_CLIENTES WHERE CLAVE_CLIENTE = @c;";
            var rows = new FireBirdHelper().ExecuteSingleColumn(sql, new Dictionary<string, object>
            {
                {"@c", claveCliente}
            });

            // Devuelve el primer valor o null si no existe
            return rows.FirstOrDefault();
        }
        static public string? GetClientName(string cliente_id)
        {
            //var client_id = SearchClient(claveCliente);
            //if (client_id == null)
            //    return null;

            var sql = "SELECT NOMBRE FROM CLIENTES WHERE CLIENTE_ID = @c;";
            var rows = new FireBirdHelper().ExecuteSingleColumn(sql, new Dictionary<string, object>
            {
                {"@c", cliente_id}
            });

            // Devuelve el primer valor o null si no existe
            return rows.FirstOrDefault();
        }
        /// <summary>
        /// Obtiene el descuento de un cliente
        /// </summary>
        /// <param name="cliente_id"></param>
        /// <returns>Descuento por cliente <cliente_id> </returns>
        static public string? GetDiscountByClient(string cliente_id)
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

            return rows.FirstOrDefault();
        }
        #endregion
        #region Datos Articulo
        static public string? GetArticuloId(string claveArticulo)
        {
            var sql = "SELECT ARTICULO_ID FROM CLAVES_ARTICULOS WHERE CLAVE_ARTICULO = @c;";
            var rows = new FireBirdHelper().ExecuteSingleColumn(sql, new Dictionary<string, object>
            {
                {"@c", claveArticulo}
            });

            // Devuelve el primer valor o null si no existe
            return rows.FirstOrDefault();
        }

        /// <summary>
        /// Obtiene el descuento de un articulo
        /// </summary>
        /// <param name="cliente_id"></param>
        /// <returns>Descuento de un articulo_id </returns>
        static public string? GetDiscountByArticle(string articulo_id)
        {
            var sql = "SELECT DESCUENTO FROM DSCTOS_PROMO_ARTS WHERE ARTICULO_ID = @c;";
            var rows = new FireBirdHelper().ExecuteSingleColumn(sql, new Dictionary<string, object>
            {
                {"@c", articulo_id}
            });
            return rows.FirstOrDefault();
        }

        #endregion
        #region Knn
        public static async Task<List<string>> ObtenerRecomendado(string Clave_articulo)
        {
            List<string> rawRecomendaciones = new List<string>();

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // URL del endpoint de tu API FastAPI
                    //string url = "http://localhost:8000/recomendar"; // Asegúrate de que el puerto sea el correcto
                    string url = "https://6e22-187-190-202-34.ngrok-free.app/recomendar";
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
                                rawRecomendaciones.Add(item.ToString());
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

            List<string> recomendaciones = new List<string>();
            for (int i = 0; i < rawRecomendaciones.Count && i < 2; i++)
            {
                recomendaciones.Add(rawRecomendaciones[i].Substring(0, 6));
            }
            return recomendaciones;
        }
        #endregion

    }

}
