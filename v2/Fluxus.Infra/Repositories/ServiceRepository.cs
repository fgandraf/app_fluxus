using Fluxus.Domain.Entities;
using System.Data;
using Newtonsoft.Json;


namespace Fluxus.Infra.Repositories
{
    public class ServiceRepository
    {
        public void Insert(Service body)
        {
            string json = JsonConvert.SerializeObject(body);
            Request.Post("Service", json);
        }

        public void Update(Service body)
        {
            string json = JsonConvert.SerializeObject(body);
            Request.Put("Service", json);
        }

        public void Delete(int id)
        {
            Request.Delete("Service/", id.ToString());
        }

        public DataTable GetAll()
        {
            string json = Request.Get("Service", string.Empty);
            return JsonConvert.DeserializeObject<DataTable>(json);
        }

        public Service GetById(int id)
        {
            string json = Request.Get("Service/", id.ToString());
            return JsonConvert.DeserializeObject<Service>(json);
        }
    }
}
