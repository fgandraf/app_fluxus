using Fluxus.Core.Contracts.Databases;
using System;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;

namespace Fluxus.Infra.Databases.Api
{

    public class HttpConnection : IConnection
    {
        const string URI = "http://FelipeM1Pro:5001/";
        private string TOKEN = string.Empty;

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

                    TOKEN = "Bearer " + response.Content.ReadAsStringAsync().Result;
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
                    httpClient.DefaultRequestHeaders.Add("Authorization", TOKEN);
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


        public bool Put(string model, string json)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    httpClient.BaseAddress = new Uri(URI);
                    httpClient.DefaultRequestHeaders.Add("Authorization", TOKEN);
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
                    httpClient.DefaultRequestHeaders.Add("Authorization", TOKEN);
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


        public int Post(string model, string json)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    httpClient.BaseAddress = new Uri(URI);
                    httpClient.DefaultRequestHeaders.Add("Authorization", TOKEN);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    var response = httpClient.PostAsync(model, content).Result;

                    if (response.IsSuccessStatusCode == false)
                        return 0;

                    //using it while post method can return int or string result
                    //refactor it when type is the same for all results
                    var result = response.Content.ReadAsStringAsync().Result;
                    string digitsOnly = Regex.Replace(result, "[^0-9]", "");
                    return Convert.ToInt32(digitsOnly);
                    //----------------------------------------------------------------
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Connection error: " + ex);
            }
        }


    }

}
