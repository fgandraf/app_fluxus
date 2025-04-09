using Fluxus.Core.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using Fluxus.Core.Contracts.Databases;
using Fluxus.Core.Dtos.Services;

namespace Fluxus.Infra.Databases.Api
{
    public class ServiceRepository : IServiceRepository
    {
        private readonly IConnection _connection;

        public ServiceRepository(IConnection connection)
            => _connection = connection;

        public long Insert(Service body)
        {
            string json = JsonConvert.SerializeObject(body, Json.Settings);
            return _connection.Post("v2/services", json);
        }

        public bool Update(Service body)
        {
            string json = JsonConvert.SerializeObject(body, Json.Settings);
            return _connection.Put("v2/services", json);
        }

        public bool Delete(long id)
        {
            return _connection.Delete("v2/services/", id.ToString());
        }

        public Service GetById(long id)
        {
            string json = _connection.Get("v2/services/", id.ToString());
            return JsonConvert.DeserializeObject<Service>(json);
        }

        public List<ServiceResponse> GetAll()
        {
            string json = _connection.Get("v2/services", string.Empty);
            return json == null ? [] : JsonConvert.DeserializeObject<List<ServiceResponse>>(json);
        }

    }
}
