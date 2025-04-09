using Fluxus.Core.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using Fluxus.Core.Contracts.Databases;
using Fluxus.Core.Dtos.Professionals;

namespace Fluxus.Infra.Databases.Api
{
    public class ProfessionalRepository : IProfessionalRepository
    {
        private readonly IConnection _connection;

        public ProfessionalRepository(IConnection connection)
            => _connection = connection;

        public long Insert(Professional body)
        {
            string json = JsonConvert.SerializeObject(body, Json.Settings);
            return _connection.Post("v2/professionals", json);
        }

        public bool Update(Professional body)
        {
            string json = JsonConvert.SerializeObject(body, Json.Settings);
            return _connection.Put("v2/professionals", json);
        }

        public bool Delete(long id)
        {
            return _connection.Delete("v2/professionals/", id.ToString());
        }

        public Professional GetById(long id)
        {
            string json = _connection.Get("v2/professionals/", id.ToString());

            if (!string.IsNullOrEmpty(json))
                return JsonConvert.DeserializeObject<Professional>(json);

            return null;
        }

        public List<ProfessionalIndexResponse> GetIndex()
        {
            string json = _connection.Get("v2/professionals", string.Empty);
            return json == null ? [] : JsonConvert.DeserializeObject<List<ProfessionalIndexResponse>>(json);
        }

        public List<ProfessionalTagNameIdResponse> GetTagNameid()
        {
            string json = _connection.Get("v2/professionals/tag-name-id", string.Empty);
            return json == null ? [] : JsonConvert.DeserializeObject<List<ProfessionalTagNameIdResponse>>(json);
        }
    }
}
