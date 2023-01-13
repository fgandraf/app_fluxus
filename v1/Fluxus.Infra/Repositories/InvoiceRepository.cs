using Fluxus.Domain.Entities;
using Newtonsoft.Json;
using System;
using System.Data;


namespace Fluxus.Infra.Repositories
{
    public class InvoiceRepository
    {
        public long Insert(Fatura body)
        {
            string json = JsonConvert.SerializeObject(body);
            return Convert.ToInt64(Request.Post("fatura/post", json));
        }

        public void Update(Fatura body)
        {
            string json = JsonConvert.SerializeObject(body);
            Request.Put("fatura/puttotals/" + body.Id, json);
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