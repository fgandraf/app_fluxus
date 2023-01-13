using Fluxus.Domain.Entities;
using Newtonsoft.Json;
using System.Data;


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
            Request.Put("Service/" + body.Id, json);
        }

        public void Delete(long id)
        {
            Request.Delete("Service/", id.ToString());
        }

        public DataTable GetAll()
        {
            string json = Request.Get("Service", string.Empty);
            return JsonConvert.DeserializeObject<DataTable>(json);
        }

        public Service GetById(long id)
        {
            string json = Request.Get("Service/", id.ToString());
            return JsonConvert.DeserializeObject<Service>(json);
        }
    }
}
