using Fluxus.Domain.Entities;
using Fluxus.Infra.Repositories.Contracts;
using Newtonsoft.Json;
using System.Collections.Generic;


namespace Fluxus.Infra.Repositories
{
    public class InvoiceRepository : IInvoiceRepository
    {
        private readonly IConnection _connection;

        public InvoiceRepository(IConnection connection)
            => _connection = connection;

        public int Insert(Invoice body)
        {
            string json = JsonConvert.SerializeObject(body);
            return _connection.Post("v1/invoice", json);
        }

        public bool Update(Invoice body)
        {
            string json = JsonConvert.SerializeObject(body);
            return _connection.Put("v1/invoice/totals", json);
        }

        public bool Delete(int id)
        {
            return _connection.Delete("v1/invoice/", id.ToString());
        }

        public string GetDescription(int id)
        {
            return _connection.Get("v1/invoice/description/", id.ToString());
        }

        public List<Invoice> GetAll()
        {
            string json = _connection.Get("v1/invoices", string.Empty);
            if (!string.IsNullOrEmpty(json))
                return JsonConvert.DeserializeObject<List<Invoice>>(json);

            return null;
        }
    }
}