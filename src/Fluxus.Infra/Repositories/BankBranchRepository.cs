using Newtonsoft.Json;
using Fluxus.Domain.Entities;
using System.Collections.Generic;
using Fluxus.Infra.Records;
using Fluxus.Infra.Repositories.Contracts;

namespace Fluxus.Infra.Repositories
{
    
    public class BankBranchRepository : IBankBranchRepository
    {
        private readonly IConnection _connection;

        public BankBranchRepository(IConnection connection)
            => _connection = connection;

        public int Insert(BankBranch body)
        {
            string json = JsonConvert.SerializeObject(body);
            return _connection.Post("v1/bank-branch", json);
        }

        public bool Update(BankBranch body)
        {
            string json = JsonConvert.SerializeObject(body);
            return _connection.Put("v1/bank-branch", json);
        }

        public bool Delete(string id)
        {
            return _connection.Delete("v1/bank-branch/", id.ToString());
        }

        public BankBranch GetById(string id)
        {
            string json = _connection.Get("v1/bank-branch/", id.ToString());

            if (!string.IsNullOrEmpty(json))
                return JsonConvert.DeserializeObject<BankBranch>(json);

            return null;
        }

        public List<BankBranchIndex> GetIndex()
        {
            string json = _connection.Get("v1/bank-branches", string.Empty);
            if (!string.IsNullOrEmpty(json))
                return JsonConvert.DeserializeObject<List<BankBranchIndex>>(json);

            return null;
        }

        public BankBranch GetContacts(string agencyCode)
        {
            string json = _connection.Get("v1/bank-branch/contacts/", agencyCode);
            if (!string.IsNullOrEmpty(json))
                return JsonConvert.DeserializeObject<BankBranch>(json);
            
            return null;
        }

    }
}