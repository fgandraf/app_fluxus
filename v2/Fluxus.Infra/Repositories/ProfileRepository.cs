using Fluxus.Domain.Entities;
using Newtonsoft.Json;
using System.Data;


namespace Fluxus.Infra.Repositories
{
    public class ProfileRepository
    {
        public void Insert(Profile body)
        {
            string json = JsonConvert.SerializeObject(body);
            Request.Post("Profile", json);
        }

        public void Update(Profile body)
        {
            string json = JsonConvert.SerializeObject(body);
            Request.Put("Profile", json);
        }

        public DataTable GetAll()
        {
            string json = Request.Get("Profile", string.Empty);
            return JsonConvert.DeserializeObject<DataTable>(json);
        }

        public DataTable GetToPrint()
        {
            string json = Request.Get("Profile/ToPrint", string.Empty);
            return JsonConvert.DeserializeObject<DataTable>(json);
        }

        public string GetName()
        {
            return Request.Get("Profile/TradingName", string.Empty);
        }
        
    }
}
