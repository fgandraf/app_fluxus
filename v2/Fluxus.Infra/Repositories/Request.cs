using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;


namespace Fluxus.Infra.Repositories
{

    public class Request
    {
        const string URI = "http://localhost:8080/api/";
        const string TOKEN = "xz8wM6zr2RfF18GBM0B5yrkoo";

        public static string Get(string model, string parametro)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    httpClient.BaseAddress = new Uri(URI);
                    httpClient.DefaultRequestHeaders.Add("Token", TOKEN);

                    var response = httpClient.GetAsync(model + parametro).Result;

                    response.EnsureSuccessStatusCode();

                    return response.Content.ReadAsStringAsync().Result;
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Erro de rede: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }

            return null;
        }

        public static bool Put(string model, string json)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    httpClient.BaseAddress = new Uri(URI);
                    httpClient.DefaultRequestHeaders.Add("Token", TOKEN);

                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    var response = httpClient.PutAsync($"{model}", content).Result;

                    return response.IsSuccessStatusCode;
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Erro de rede: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }

            return false;
        }

        public static bool Delete(string model, string parametro)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    httpClient.BaseAddress = new Uri(URI);
                    httpClient.DefaultRequestHeaders.Add("Token", TOKEN);

                    var response = httpClient.DeleteAsync(model + parametro).Result;

                    return response.IsSuccessStatusCode;
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Erro de rede: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }

            return false;
        }

        public static bool Post(string model, string json)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    httpClient.BaseAddress = new Uri(URI);
                    httpClient.DefaultRequestHeaders.Add("Token", TOKEN);

                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    var response = httpClient.PostAsync(model, content).Result;

                    return response.IsSuccessStatusCode;
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Erro de rede: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }

            return false;
        }
    }
}
