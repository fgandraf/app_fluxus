using System.Net.Http;
using System;
using Newtonsoft.Json;
using Fluxus.Core.Contracts.Services;
using Fluxus.Core.ViewModels;

namespace Fluxus.Infra.Services
{
    public  class ViaCep : ICep
    {
        public AddressViewModel GetCep(string cep)
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
                return new AddressViewModel();
            }

            var result =  JsonConvert.DeserializeObject<dynamic>(json);

            return new AddressViewModel()
            {
                Logradouro = result.logradouro,
                Complemento = result.complemento,
                Bairro = result.bairro,
                Cidade = result.localidade,
                Uf = result.uf
            };





        }


    }
}
