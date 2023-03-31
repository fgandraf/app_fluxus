using Newtonsoft.Json;
using System.Data;
using Fluxus.Domain.Entities;
using iTextSharp.text;
using System.Collections.Generic;

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

        public void Delete(int id)
        {
            Request.Delete("BankBranch/", id.ToString());
        }

        public List<BankBranch> GetAll()
        {
            string json = Request.Get("BankBranch", string.Empty);
            return JsonConvert.DeserializeObject<List<BankBranch>>(json);
        }

        public DataTable GetByCode(string agencyCode)
        {
            string json = Request.Get("BankBranch/Contacts/", agencyCode);
            if (json != null)
                return JsonConvert.DeserializeObject<DataTable>(json);
            return null;
        }

        public BankBranch GetById(int id)
        {
            string json = Request.Get("BankBranch/", id.ToString());
            return  JsonConvert.DeserializeObject<BankBranch>(json);
        }
    }
}
