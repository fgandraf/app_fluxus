using Newtonsoft.Json;
using Fluxus.Core.Models;
using System.Collections.Generic;
using Fluxus.Core.Contracts.Databases;
using Fluxus.Core.Dtos.Branches;

namespace Fluxus.Infra.Databases.Api
{

    public class BranchRepository : IBranchRepository
    {
        private readonly IConnection _connection;

        public BranchRepository(IConnection connection)
            => _connection = connection;

        public long Insert(BranchCreateRequest body)
        {
            string json = JsonConvert.SerializeObject(body, Json.Settings);
            return _connection.Post("v2/branches", json);
        }

        public bool Update(BranchUpdateRequest body)
        {
            string json = JsonConvert.SerializeObject(body, Json.Settings);
            return _connection.Put("v2/branches", json);
        }

        public bool Delete(string id)
        {
            return _connection.Delete("v2/branches/", id.ToString());
        }

        public Branch GetById(string id)
        {
            string json = _connection.Get("v2/branches/", id.ToString());

            if (!string.IsNullOrEmpty(json))
                return JsonConvert.DeserializeObject<Branch>(json);

            return null;
        }

        public List<BranchIndexResponse> GetIndex()
        {
            string json = _connection.Get("v2/branches", string.Empty);
            return json == null ? [] : JsonConvert.DeserializeObject<List<BranchIndexResponse>>(json);
        }

        public BranchIndexResponse GetContacts(string agencyCode)
        {
            string json = _connection.Get("v2/branches/contacts/", agencyCode);
            if (!string.IsNullOrEmpty(json))
                return JsonConvert.DeserializeObject<BranchIndexResponse>(json);

            return null;
        }

    }
}