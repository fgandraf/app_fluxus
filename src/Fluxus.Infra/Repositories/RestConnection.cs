using Fluxus.Infra.Repositories.Contracts;
using RestSharp;
using System;
using System.Text.RegularExpressions;

namespace Fluxus.Infra.Repositories
{
    public class RestConnection : IConnection
    {
        const string URI = "http://FelipeM1Pro:5001/";
        private string TOKEN = String.Empty;


        public (bool, string) Login(string model, string json)
        {
            try
            {
                var client = new RestClient(URI);
                var request = new RestRequest(model, Method.Post);
                request.AddHeader("Content-Type", "application/json");
                request.AddParameter("application/json", json, ParameterType.RequestBody);

                var response = client.Execute(request);

                if (!response.IsSuccessful)
                    return (false, response.Content.Trim('\"'));

                TOKEN = "Bearer " + response.Content.Trim('\"');
                return (true, string.Empty);
            }
            catch (Exception ex)
            {
                throw new Exception("Connection error: " + ex.Message, ex);
            }
        }


        public bool Delete(string model, string param)
        {
            try
            {
                var client = new RestClient(URI);
                var request = new RestRequest(model + param, Method.Delete);
                request.AddHeader("Authorization", TOKEN);

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
                request.AddHeader("Authorization", TOKEN);

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
                request.AddHeader("Authorization", TOKEN);
                request.AddHeader("Content-Type", "application/json");
                request.AddParameter("application/json", json, ParameterType.RequestBody);

                var response = client.Execute(request);

                if (!response.IsSuccessful)
                    return 0;

                //using it while post method can return int or string result
                //refactor it when type is the same for all results
                var result = response.Content;
                string digitsOnly = Regex.Replace(result, "[^0-9]", "");
                return Convert.ToInt32(digitsOnly);
                //----------------------------------------------------------------
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
                request.AddHeader("Authorization", TOKEN);
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
