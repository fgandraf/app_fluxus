using Fluxus.Domain.Entities;
using Newtonsoft.Json;
using System;
using System.Data;


namespace Fluxus.Infra.Repositories
{
    public class InvoiceRepository
    {
        public long Insert(Fatura dado)
        {
            string json = JsonConvert.SerializeObject(dado);
            return Convert.ToInt64(Request.Post("fatura/post", json));
        }

        public void Update(long id, Fatura dado)
        {
            string json = JsonConvert.SerializeObject(dado);
            Request.Put("fatura/puttotals/" + id, json);
        }

        public void Delete(long id)
        {
            Request.Delete("fatura/delete/", id.ToString());
        }

        public string GetDescription(long id)
        {
            return Request.Get("fatura/getdescricao/", id.ToString());
        }

        public DataTable GetAll()
        {
            string json = Request.Get("fatura", string.Empty);
            return JsonConvert.DeserializeObject<DataTable>(json);
        }
    }
}