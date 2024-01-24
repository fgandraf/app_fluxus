using Fluxus.Domain.Models;
using Fluxus.Domain.Contracts.Databases;
using Newtonsoft.Json;
using System.Collections.Generic;


namespace Fluxus.Infra.Databases.Api
{
    public class InvoiceRepository : IInvoiceRepository
    {
        private readonly IConnection _connection;

        public InvoiceRepository(IConnection connection)
            => _connection = connection;

        public int Insert(Invoice body)
        {
            string json = JsonConvert.SerializeObject(body);
            return _connection.Post("v1/invoices", json);
        }

        public bool Update(Invoice body)
        {
            string json = JsonConvert.SerializeObject(body);
            return _connection.Put("v1/invoices/totals", json);
        }

        public bool Delete(int id)
        {
            return _connection.Delete("v1/invoices/", id.ToString());
        }

        public string GetDescription(int id)
        {
            return _connection.Get("v1/invoices/description/", id.ToString());
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