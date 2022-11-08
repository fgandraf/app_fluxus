using System.IO;
using System.Net;
using System.Text;

namespace Fluxus.Infra.Repositories
{
    public class Request
    {
        private static string _uri = "http://localhost:5000/api/";
        private static string _token = "xz8wM6zr2RfF18GBM0B5yrkoo";

        public static string Get(string model, string parametro)
        {
            var request = (HttpWebRequest)WebRequest.Create(_uri + model + parametro);
            request.Headers.Add("Token", _token);
            request.Method = "GET";
            request.ContentType = "application/json";
            var response = (HttpWebResponse)request.GetResponse();
            var respondeString = new System.IO.StreamReader(response.GetResponseStream()).ReadToEnd();

            return respondeString;
        }

        public static string Delete(string model, string parametro)
        {
            var request = (HttpWebRequest)WebRequest.Create(_uri + model + parametro);
            request.Headers.Add("Token", _token);
            request.Method = "DELETE";
            request.ContentType = "application/json";
            var response = (HttpWebResponse)request.GetResponse();
            var respondeString = new System.IO.StreamReader(response.GetResponseStream()).ReadToEnd();

            return respondeString;
        }

        public static string Post(string model, string jsonData)
        {
            var request = (HttpWebRequest)WebRequest.Create(_uri + model);
            var data = Encoding.UTF8.GetBytes(jsonData);
            request.Method = "POST";
            request.Headers.Add("Token", _token);
            request.ContentType = "application/json";
            request.ContentLength = data.Length;
            request.GetRequestStream().Write(data, 0, data.Length);
            var response = (HttpWebResponse)request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

            return responseString;
        }

        public static string Put(string model, string jsonData)
        {
            var request = (HttpWebRequest)WebRequest.Create(_uri + model);
            var data = Encoding.UTF8.GetBytes(jsonData);
            request.Method = "PUT";
            request.Headers.Add("Token", _token);
            request.ContentType = "application/json";
            request.ContentLength = data.Length;
            request.GetRequestStream().Write(data, 0, data.Length);
            var response = (HttpWebResponse)request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

            return responseString;
        }
    }
}
