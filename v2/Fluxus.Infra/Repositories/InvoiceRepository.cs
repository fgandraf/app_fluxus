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
            Request.Put("Invoice/Totals", json);
        }

        public void Delete(int id)
        {
            Request.Delete("Invoice/", id.ToString());
        }

        public string GetDescription(int id)
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