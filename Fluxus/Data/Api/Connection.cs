using System.IO;
using System.Net;
using System.Text;

namespace Fluxus.Data.Api
{
    class Connection
    {
        public static string URI = "http://localhost:8080/api/";
        //public static string URI = "http://191.239.253.8:8080/api/";  --Endereço Azure
        public static string TOKEN = "xz8wM6zr2RfF18GBM0B5yrkoo";



        private static string RequestGET_DELETE(string model, string parametro, string metodo)
        {
            var request = (HttpWebRequest)WebRequest.Create(URI + model + parametro);
            request.Headers.Add("Token", TOKEN);
            request.Method = metodo;
            request.ContentType = "application/json";
            var response = (HttpWebResponse)request.GetResponse();
            var respondeString = new System.IO.StreamReader(response.GetResponseStream()).ReadToEnd();

            return respondeString;
        }




        public static string RequestPUT_POST(string model, string jsonData, string metodo)
        {
            var request = (HttpWebRequest)WebRequest.Create(URI + model);
            var data = Encoding.UTF8.GetBytes(jsonData);
            request.Method = metodo;
            request.Headers.Add("Token", TOKEN);
            request.ContentType = "application/json";
            request.ContentLength = data.Length;

            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }
            var response = (HttpWebResponse)request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

            return responseString;

        }


        public static string RequestGET(string model, string parametro)
        {
            return RequestGET_DELETE(model, parametro, "GET");
        }


        public static string RequestDELETE(string model, string parametro)
        {
            return RequestGET_DELETE(model, parametro, "DELETE");
        }


        public static string RequestPOST(string model, string jsonData)
        {
            return RequestPUT_POST(model, jsonData, "POST");
        }


        public static string RequestPUT(string model, string jsonData)
        {
            return RequestPUT_POST(model, jsonData, "PUT");
        }


    }
}
