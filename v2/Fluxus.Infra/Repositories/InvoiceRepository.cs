using Fluxus.Domain.Entities;
using Newtonsoft.Json;
using System;
using System.Data;


namespace Fluxus.Infra.Repositories
{
    public class InvoiceRepository
    {
        public int Insert(Invoice body)
        {
            string json = JsonConvert.SerializeObject(body);
            return Convert.ToInt32(Request.Post("Invoice", json));
        }

        public void Update(Invoice body)
        {
            string json = JsonConvert.SerializeObject(body);
            Request.Put("Invoice/Totals/" + body.Id, json);
        }

        public void Delete(long id)
        {
            Request.Delete("Invoice/", id.ToString());
        }

        public string GetDescription(long id)
        {
            return Request.Get("Invoice/Description/", id.ToString());
        }

        public DataTable GetAll()
        {
            string json = Request.Get("Invoice", string.Empty);
            return JsonConvert.DeserializeObject<DataTable>(json);
        }
    }
}