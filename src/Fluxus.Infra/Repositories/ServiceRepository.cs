using Fluxus.Domain.Entities;
using Newtonsoft.Json;
using System.Collections.Generic;
using Fluxus.Infra.Records;
using Fluxus.Infra.Repositories.Contracts;

namespace Fluxus.Infra.Repositories
{
    public class ServiceRepository : IServiceRepository
    {
        private readonly IConnection _connection;

        public ServiceRepository(IConnection connection)
            => _connection = connection;

        public int Insert(Service body)
        {
            string json = JsonConvert.SerializeObject(body);
            return _connection.Post("v1/service", json);
        }

        public bool Update(Service body)
        {
            string json = JsonConvert.SerializeObject(body);
            return _connection.Put("v1/service", json);
        }

        public bool Delete(int id)
        {
            return _connection.Delete("v1/service/", id.ToString());
        }

        public Service GetById(int id)
        {
            string json = _connection.Get("v1/service/", id.ToString());
            return JsonConvert.DeserializeObject<Service>(json);
        }

        public List<ServiceIndex> GetAll()
        {
            string json = _connection.Get("v1/services", string.Empty);
            return JsonConvert.DeserializeObject<List<ServiceIndex>>(json);
        }

    }
}
