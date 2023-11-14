using System;
using System.Net.Http;
using System.Text;

namespace Fluxus.Infra.Repositories
{

    public class Request
    {
        const string URI = "http://FelipeM1Pro:5001/api/";
        const string TOKEN = "xz8wM6zr2RfF18GBM0B5yrkoo";


        public static string Get(string model, string param)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    httpClient.BaseAddress = new Uri(URI);
                    httpClient.DefaultRequestHeaders.Add("Token", TOKEN);
                    var response = httpClient.GetAsync(model + param).Result;

                    if (response.IsSuccessStatusCode)
                        return response.Content.ReadAsStringAsync().Result;
                    else
                        return null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Connection error: " + ex);
            }
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
                    var response = httpClient.PutAsync(model, content).Result;

                    if (response.IsSuccessStatusCode == false)
                        throw new Exception("Request error: " + response.Content.ReadAsStringAsync().Result);

                    return response.IsSuccessStatusCode;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Connection error: " + ex);
            }
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

                    if (response.IsSuccessStatusCode == false)
                        throw new Exception("Request error: " + response.Content.ReadAsStringAsync().Result);

                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Connection error: " + ex);
            }
        }


        public static int Post(string model, string json)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    httpClient.BaseAddress = new Uri(URI);
                    httpClient.DefaultRequestHeaders.Add("Token", TOKEN);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    var response = httpClient.PostAsync(model, content).Result;

                    if (response.IsSuccessStatusCode == false)
                        throw new Exception("Request error: " + response.Content.ReadAsStringAsync().Result);

                    return Convert.ToInt32(response.Content.ReadAsStringAsync().Result);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Connection error: " + ex);
            }
        }

    }

}
