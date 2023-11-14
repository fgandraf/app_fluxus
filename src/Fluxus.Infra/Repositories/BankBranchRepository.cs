using Newtonsoft.Json;
using Fluxus.Domain.Entities;
using System.Collections.Generic;
using Fluxus.Domain.Structs;
using Fluxus.Domain.Interfaces;

namespace Fluxus.Infra.Repositories
{
    public class BankBranchRepository : IBankBranchRepository
    {
        public int Insert(BankBranch body)
        {
            string json = JsonConvert.SerializeObject(body);
            return Request.Post("BankBranch", json);
        }

        public bool Update(BankBranch body)
        {
            string json = JsonConvert.SerializeObject(body);
            return Request.Put("BankBranch", json);
        }

        public bool Delete(int id)
        {
            return Request.Delete("BankBranch/", id.ToString());
        }

        public BankBranch GetById(int id)
        {
            string json = Request.Get("BankBranch/", id.ToString());

            if (!string.IsNullOrEmpty(json))
                return JsonConvert.DeserializeObject<BankBranch>(json);

            return null;
        }

        public List<BankBranchIndex> GetIndex()
        {
            string json = Request.Get("BankBranch", string.Empty);
            if (!string.IsNullOrEmpty(json))
                return JsonConvert.DeserializeObject<List<BankBranchIndex>>(json);

            return null;
        }

        public BankBranch GetByCode(string agencyCode)
        {
            string json = Request.Get("BankBranch/Contacts/", agencyCode);
            if (!string.IsNullOrEmpty(json))
                return JsonConvert.DeserializeObject<BankBranch>(json);
            
            return null;
        }
    }
}