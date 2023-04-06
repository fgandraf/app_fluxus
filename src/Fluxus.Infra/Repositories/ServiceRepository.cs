using Fluxus.Domain.Entities;
using System.Data;
using Newtonsoft.Json;
using iTextSharp.text;
using System.Collections.Generic;

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

        public bool Delete(int id)
        {
            return Request.Delete("Service/", id.ToString());
        }

        public List<Service> GetAll()
        {
            string json = Request.Get("Service", string.Empty);
            return JsonConvert.DeserializeObject<List<Service>>(json);
        }

        public Service GetById(int id)
        {
            string json = Request.Get("Service/", id.ToString());
            return JsonConvert.DeserializeObject<Service>(json);
        }
    }
}
