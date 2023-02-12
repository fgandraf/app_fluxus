using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;


namespace Fluxus.Infra.Repositories
{

    public class Request
    {
        const string URI = "http://localhost:8080/api/";
        const string TOKEN = "xz8wM6zr2RfF18GBM0B5yrkoo";
        private static string _retorno = null;

        public static async void GetAsync(string model, string parametro)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(URI);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("Token", TOKEN);
                HttpResponseMessage response = await client.GetAsync(model + parametro);


                if (response.IsSuccessStatusCode)
                {
                    _retorno = await response.Content.ReadAsStringAsync();
                }

            }
        }

        public static string GetNew(string model, string parametro)
        {
            GetAsync(model, parametro);
            return _retorno;
        }



            public static string Get(string model, string parametro)
        {
            try
            {
                var request = (HttpWebRequest)WebRequest.Create(URI + model + parametro);
                request.Headers.Add("Token", TOKEN);
                request.Method = "GET";
                request.ContentType = "application/json";
                var response = (HttpWebResponse)request.GetResponse();
                var respondeString = new System.IO.StreamReader(response.GetResponseStream()).ReadToEnd();

                return respondeString;
            }
            catch (Exception)
            {
                return null;
            };
        }

        public static string Delete(string model, string parametro)
        {
            var request = (HttpWebRequest)WebRequest.Create(URI + model + parametro);
            request.Headers.Add("Token", TOKEN);
            request.Method = "DELETE";
            request.ContentType = "application/json";
            var response = (HttpWebResponse)request.GetResponse();
            var respondeString = new System.IO.StreamReader(response.GetResponseStream()).ReadToEnd();

            return respondeString;
        }

        public static string Post(string model, string jsonData)
        {
            var request = (HttpWebRequest)WebRequest.Create(URI + model);
            var data = Encoding.UTF8.GetBytes(jsonData);
            request.Method = "POST";
            request.Headers.Add("Token", TOKEN);
            request.ContentType = "application/json";
            request.ContentLength = data.Length;
            request.GetRequestStream().Write(data, 0, data.Length);
            var response = (HttpWebResponse)request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

            return responseString;
        }

        public static string Put(string model, string jsonData)
        {
            var request = (HttpWebRequest)WebRequest.Create(URI + model);
            var data = Encoding.UTF8.GetBytes(jsonData);
            request.Method = "PUT";
            request.Headers.Add("Token", TOKEN);
            request.ContentType = "application/json";
            request.ContentLength = data.Length;
            request.GetRequestStream().Write(data, 0, data.Length);
            var response = (HttpWebResponse)request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

            return responseString;
        }
    }
}
