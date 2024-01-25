using Fluxus.Core.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using Fluxus.Core.ViewModels;
using Fluxus.Core.Contracts.Databases;

namespace Fluxus.Infra.Databases.Api
{
    public class ServiceRepository : IServiceRepository
    {
        private readonly IConnection _connection;

        public ServiceRepository(IConnection connection)
            => _connection = connection;

        public int Insert(Service body)
        {
            string json = JsonConvert.SerializeObject(body);
            return _connection.Post("v1/services", json);
        }

        public bool Update(Service body)
        {
            string json = JsonConvert.SerializeObject(body);
            return _connection.Put("v1/services", json);
        }

        public bool Delete(int id)
        {
            return _connection.Delete("v1/services/", id.ToString());
        }

        public Service GetById(int id)
        {
            string json = _connection.Get("v1/services/", id.ToString());
            return JsonConvert.DeserializeObject<Service>(json);
        }

        public List<ServicesIndexViewModel> GetAll()
        {
            string json = _connection.Get("v1/services", string.Empty);
            return JsonConvert.DeserializeObject<List<ServicesIndexViewModel>>(json);
        }

    }
}
