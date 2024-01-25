using Fluxus.Core.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using Fluxus.Core.ViewModels;
using Fluxus.Core.Contracts.Databases;

namespace Fluxus.Infra.Databases.Api
{
    public class ProfessionalRepository : IProfessionalRepository
    {
        private readonly IConnection _connection;

        public ProfessionalRepository(IConnection connection)
            => _connection = connection;

        public int Insert(Professional body)
        {
            string json = JsonConvert.SerializeObject(body);
            return _connection.Post("v1/professionals", json);
        }

        public bool Update(Professional body)
        {
            string json = JsonConvert.SerializeObject(body);
            return _connection.Put("v1/professionals", json);
        }

        public bool Delete(int id)
        {
            return _connection.Delete("v1/professionals/", id.ToString());
        }

        public Professional GetById(int id)
        {
            string json = _connection.Get("v1/professionals/", id.ToString());

            if (!string.IsNullOrEmpty(json))
                return JsonConvert.DeserializeObject<Professional>(json);

            return null;
        }

        public List<ProfessionalsIndexViewModel> GetIndex()
        {
            string json = _connection.Get("v1/professionals", string.Empty);
            if (!string.IsNullOrEmpty(json))
                return JsonConvert.DeserializeObject<List<ProfessionalsIndexViewModel>>(json);

            return null;
        }

        public List<ProfessionalNameId> GetTagNameid()
        {
            string json = _connection.Get("v1/professionals/tag-name-id", string.Empty);
            List<ProfessionalNameId> professionals;

            if (!string.IsNullOrEmpty(json))
            {
                professionals = JsonConvert.DeserializeObject<List<ProfessionalNameId>>(json);
                return professionals;
            }

            return null;
        }
    }
}
