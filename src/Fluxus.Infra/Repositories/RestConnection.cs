using Fluxus.Infra.Repositories.Contracts;
using RestSharp;
using System;

namespace Fluxus.Infra.Repositories
{
    public class RestConnection : IConnection
    {
        const string URI = "http://FelipeM1Pro:5001/";
        const string TOKEN = "xz8wM6zr2RfF18GBM0B5yrkoo";


        public bool Delete(string model, string param)
        {
            try
            {
                var client = new RestClient(URI);
                var request = new RestRequest(model + param, Method.Delete);
                request.AddHeader("Token", TOKEN);

                var response = client.Execute(request);

                if (!response.IsSuccessful)
                    throw new Exception("Request error: " + response.Content);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Connection error: " + ex.Message, ex);
            }
        }

        public string Get(string model, string param)
        {
            try
            {
                var client = new RestClient(URI);
                var request = new RestRequest(model + param, Method.Get);
                request.AddHeader("Token", TOKEN);

                var response = client.Execute(request);

                if (response.IsSuccessful)
                    return response.Content;
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Connection error: " + ex.Message, ex);
            }
        }

        public int Post(string model, string json)
        {
            try
            {
                var client = new RestClient(URI);
                var request = new RestRequest(model, Method.Post);
                request.AddHeader("Token", TOKEN);
                request.AddHeader("Content-Type", "application/json");
                request.AddParameter("application/json", json, ParameterType.RequestBody);

                var response = client.Execute(request);

                if (!response.IsSuccessful)
                    return 0;

                return Convert.ToInt32(response.Content);
            }
            catch (Exception ex)
            {
                throw new Exception("Connection error: " + ex.Message, ex);
            }
        }

        public bool Put(string model, string json)
        {
            try
            {
                var client = new RestClient(URI);
                var request = new RestRequest(model, Method.Put);
                request.AddHeader("Token", TOKEN);
                request.AddHeader("Content-Type", "application/json");
                request.AddParameter("application/json", json, ParameterType.RequestBody);

                var response = client.Execute(request);

                if (!response.IsSuccessful)
                    throw new Exception("Request error: " + response.Content);

                return response.IsSuccessful;
            }
            catch (Exception ex)
            {
                throw new Exception("Connection error: " + ex.Message, ex);
            }
        }
    }
}
