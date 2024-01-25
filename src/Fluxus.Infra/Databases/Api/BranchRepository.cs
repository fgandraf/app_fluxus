using Newtonsoft.Json;
using Fluxus.Core.Models;
using System.Collections.Generic;
using Fluxus.Core.Contracts.Databases;
using Fluxus.Core.ViewModels;

namespace Fluxus.Infra.Databases.Api
{

    public class BranchRepository : IBranchRepository
    {
        private readonly IConnection _connection;

        public BranchRepository(IConnection connection)
            => _connection = connection;

        public int Insert(Branch body)
        {
            string json = JsonConvert.SerializeObject(body);
            return _connection.Post("v1/bank-branches", json);
        }

        public bool Update(Branch body)
        {
            string json = JsonConvert.SerializeObject(body);
            return _connection.Put("v1/bank-branches", json);
        }

        public bool Delete(string id)
        {
            return _connection.Delete("v1/bank-branches/", id.ToString());
        }

        public Branch GetById(string id)
        {
            string json = _connection.Get("v1/bank-branches/", id.ToString());

            if (!string.IsNullOrEmpty(json))
                return JsonConvert.DeserializeObject<Branch>(json);

            return null;
        }

        public List<BranchesIndexViewModel> GetIndex()
        {
            string json = _connection.Get("v1/bank-branches", string.Empty);
            if (!string.IsNullOrEmpty(json))
                return JsonConvert.DeserializeObject<List<BranchesIndexViewModel>>(json);

            return null;
        }

        public Branch GetContacts(string agencyCode)
        {
            string json = _connection.Get("v1/bank-branches/contacts/", agencyCode);
            if (!string.IsNullOrEmpty(json))
                return JsonConvert.DeserializeObject<Branch>(json);

            return null;
        }

    }
}