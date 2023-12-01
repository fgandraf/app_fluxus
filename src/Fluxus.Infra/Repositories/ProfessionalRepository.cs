using Fluxus.Domain.Entities;
using Newtonsoft.Json;
using System.Collections.Generic;
using Fluxus.Infra.Records;
using Fluxus.Infra.Repositories.Contracts;

namespace Fluxus.Infra.Repositories
{
    public class ProfessionalRepository : IProfessionalRepository
    {
        private readonly IConnection _connection;

        public ProfessionalRepository(IConnection connection)
            => _connection = connection;

        public int Insert(Professional body)
        {
            string json = JsonConvert.SerializeObject(body);
            return _connection.Post("v1/professional", json);
        }

        public bool Update(Professional body)
        {
            string json = JsonConvert.SerializeObject(body);
            return _connection.Put("v1/professional", json);
        }

        public bool Delete(int id)
        {
            return _connection.Delete("v1/professional/", id.ToString());
        }

        public Professional GetById(int id)
        {
            string json = _connection.Get("v1/professional/", id.ToString());

            if (!string.IsNullOrEmpty(json))
                return JsonConvert.DeserializeObject<Professional>(json);

            return null;
        }

        public List<ProfessionalIndex> GetIndex()
        {
            string json = _connection.Get("v1/professionals", string.Empty);
            if (!string.IsNullOrEmpty(json))
                return JsonConvert.DeserializeObject<List<ProfessionalIndex>>(json);

            return null;
        }

        public UserInfo GetUser(string userName)
        {
            var json = _connection.Get("v1/professional/user-info/", userName);
            if (json != null)
                return JsonConvert.DeserializeObject<UserInfo>(json);

            return new UserInfo();
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
