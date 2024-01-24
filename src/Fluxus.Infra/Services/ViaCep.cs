using System.Net.Http;
using System;
using Newtonsoft.Json;
using Fluxus.Domain.Contracts.Services;

namespace Fluxus.Infra.Services
{
    public  class ViaCep : ICep
    {
        public dynamic GetCep(string cep)
        {
            string json;

            try
            {
                using (var httpClient = new HttpClient())
                {
                    httpClient.BaseAddress = new Uri("https://viacep.com.br/ws/");
                    var response = httpClient.GetAsync(cep + "/json/").Result;

                    if (response.IsSuccessStatusCode)
                        json = response.Content.ReadAsStringAsync().Result;
                    else
                        json = String.Empty;
                }
            }
            catch
            {
                return String.Empty;
            }

            return JsonConvert.DeserializeObject<dynamic>(json);
        }


    }
}
