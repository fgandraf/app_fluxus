using Fluxus.Core.Contracts.Databases;
using Fluxus.Core.Dtos.Users;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace Fluxus.Infra.Databases.Api
{

    public class HttpConnection : IConnection
    {
        const string URI = "http://FelipeM1Pro:8080/";
        private UserTokenResponse TOKEN;

        public (bool, string) Login(string model, string json)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    httpClient.BaseAddress = new Uri(URI);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    var response = httpClient.PostAsync(model, content).Result;

                    if (response.IsSuccessStatusCode == false)
                        return (false, response.Content.ReadAsStringAsync().Result);

                    var jsonResponse = response.Content.ReadAsStringAsync().Result;
                    TOKEN = JsonConvert.DeserializeObject<UserTokenResponse>(jsonResponse);
                    var tokenString = "Bearer " + TOKEN.Token;
                    TOKEN.Token = tokenString;
                    return (true, string.Empty);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Connection error: " + ex);
            }
        }

        public string Get(string model, string param)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    httpClient.BaseAddress = new Uri(URI);
                    httpClient.DefaultRequestHeaders.Add("Authorization", TOKEN.Token);
                    var response = httpClient.GetAsync(model + param).Result;

                    if (!response.IsSuccessStatusCode)
                        return null;

                    return response.Content.ReadAsStringAsync().Result;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Connection error: " + ex);
            }
        }

        public string GetWithBody(string endpoint, string jsonBody)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    httpClient.BaseAddress = new Uri(URI);
                    httpClient.DefaultRequestHeaders.Add("Authorization", TOKEN.Token);

                    // Criar a mensagem de requisição manualmente
                    var request = new HttpRequestMessage
                    {
                        Method = HttpMethod.Get,
                        RequestUri = new Uri(httpClient.BaseAddress, endpoint),
                        Content = new StringContent(jsonBody, Encoding.UTF8, "application/json")
                    };

                    var response = httpClient.SendAsync(request).Result;

                    if (!response.IsSuccessStatusCode)
                        throw new Exception($"Request error: {response.StatusCode} - {response.Content.ReadAsStringAsync().Result}");

                    return response.Content.ReadAsStringAsync().Result;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Connection error: {ex.Message}", ex);
            }
        }


        public bool Put(string model, string json)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    httpClient.BaseAddress = new Uri(URI);
                    httpClient.DefaultRequestHeaders.Add("Authorization", TOKEN.Token);
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


        public bool Delete(string model, string param)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    httpClient.BaseAddress = new Uri(URI);
                    httpClient.DefaultRequestHeaders.Add("Authorization", TOKEN.Token);
                    var response = httpClient.DeleteAsync(model + param).Result;

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


        public long Post(string model, string json)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    httpClient.BaseAddress = new Uri(URI);
                    httpClient.DefaultRequestHeaders.Add("Authorization", TOKEN.Token);

                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    var response = httpClient.PostAsync(model, content).Result;

                    if (response.IsSuccessStatusCode == false)
                        return 0;

                    var result = response.Content.ReadAsStringAsync().Result;
                    var objResult = JsonConvert.DeserializeObject<dynamic>(result);
                    
                    return Convert.ToInt64(objResult.id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Connection error: " + ex);
            }
        }


        public string PostWithResponse(string endpoint, string json)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    httpClient.BaseAddress = new Uri(URI);
                    httpClient.DefaultRequestHeaders.Accept.Clear();
                    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    httpClient.DefaultRequestHeaders.Add("Authorization", TOKEN.Token);

                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    var response = httpClient.PostAsync(endpoint, content).Result;

                    if (!response.IsSuccessStatusCode)
                    {
                        // Logar o conteúdo do erro para debug
                        var errorContent = response.Content.ReadAsStringAsync().Result;
                        Console.WriteLine($"Error: {response.StatusCode} - {errorContent}");
                        return string.Empty;
                    }

                    return response.Content.ReadAsStringAsync().Result;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.ToString()}");
                throw new Exception("Connection error: " + ex.Message);
            }
        }

    }
}
