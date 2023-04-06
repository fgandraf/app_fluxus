using Newtonsoft.Json;
using Fluxus.Domain.Entities;
using System.Collections.Generic;
using Fluxus.Domain.Struct;

namespace Fluxus.Infra.Repositories
{
    public class BankBranchRepository
    {
        public void Insert(BankBranch body)
        {
            string json = JsonConvert.SerializeObject(body);
            Request.Post("BankBranch", json);
        }

        public void Update(BankBranch body)
        {
            string json = JsonConvert.SerializeObject(body);
            Request.Put("BankBranch", json);
        }

        public bool Delete(int id)
        {
            return Request.Delete("BankBranch/", id.ToString());
        }

        public List<BankBranchIndex> GetIndex()
        {
            string json = Request.Get("BankBranch", string.Empty);
            return JsonConvert.DeserializeObject<List<BankBranchIndex>>(json);
        }

        public BankBranch GetByCode(string agencyCode)
        {
            string json = Request.Get("BankBranch/Contacts/", agencyCode);
            if (json != null)
                return JsonConvert.DeserializeObject<BankBranch>(json);
            return null;
        }

        public BankBranch GetById(int id)
        {
            string json = Request.Get("BankBranch/", id.ToString());
            return  JsonConvert.DeserializeObject<BankBranch>(json);
        }
    }
}
