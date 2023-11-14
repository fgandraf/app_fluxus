using Fluxus.Domain.Entities;
using Fluxus.Domain.Interfaces;
using Newtonsoft.Json;
using System.Collections.Generic;


namespace Fluxus.Infra.Repositories
{
    public class InvoiceRepository : IInvoiceRepository
    {
        public int Insert(Invoice body)
        {
            string json = JsonConvert.SerializeObject(body);
            return Request.Post("Invoice", json);
        }

        public bool Update(Invoice body)
        {
            string json = JsonConvert.SerializeObject(body);
            return Request.Put("Invoice/Totals", json);
        }

        public bool Delete(int id)
        {
            return Request.Delete("Invoice/", id.ToString());
        }

        public string GetDescription(int id)
        {
            return Request.Get("Invoice/Description/", id.ToString());
        }

        public List<Invoice> GetAll()
        {
            string json = Request.Get("Invoice", string.Empty);
            if (!string.IsNullOrEmpty(json))
                return JsonConvert.DeserializeObject<List<Invoice>>(json);

            return null;
        }
    }
}