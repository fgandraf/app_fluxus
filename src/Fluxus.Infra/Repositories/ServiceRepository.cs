using Fluxus.Domain.Entities;
using Fluxus.Domain.Interfaces;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Fluxus.Infra.Repositories
{
    public class ServiceRepository : IServiceRepository
    {
        public int Insert(Service body)
        {
            string json = JsonConvert.SerializeObject(body);
            return Request.Post("Service", json);
        }

        public bool Update(Service body)
        {
            string json = JsonConvert.SerializeObject(body);
            return Request.Put("Service", json);
        }

        public bool Delete(int id)
        {
            return Request.Delete("Service/", id.ToString());
        }

        public Service GetById(int id)
        {
            string json = Request.Get("Service/", id.ToString());
            return JsonConvert.DeserializeObject<Service>(json);
        }

        public List<Service> GetAll()
        {
            string json = Request.Get("Service", string.Empty);
            return JsonConvert.DeserializeObject<List<Service>>(json);
        }

    }
}
