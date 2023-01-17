using Newtonsoft.Json;
using System.Data;
using Fluxus.Domain.Entities;


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
            Request.Put("BankBranch/" + body.Id, json);
        }

        public void Delete(long id)
        {
            Request.Delete("BankBranch/", id.ToString());
        }

        public DataTable GetAll()
        {
            string json = Request.Get("BankBranch", string.Empty);
            return JsonConvert.DeserializeObject<DataTable>(json);
        }

        public DataTable GetByCode(string agencyCode)
        {
            string json = Request.Get("BankBranch/Contacts/", agencyCode);
            if (json != null)
                return JsonConvert.DeserializeObject<DataTable>(json);
            return null;
        }

        public BankBranch GetById(long id)
        {
            string json = Request.Get("BankBranch/", id.ToString());
            return  JsonConvert.DeserializeObject<BankBranch>(json);
        }
    }
}
