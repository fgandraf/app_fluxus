using Fluxus.Core.Models;
using Fluxus.Core.Contracts.Databases;
using Newtonsoft.Json;
using System.Collections.Generic;
using Fluxus.Core.Dtos.Invoices;


namespace Fluxus.Infra.Databases.Api
{
    public class InvoiceRepository : IInvoiceRepository
    {
        private readonly IConnection _connection;

        public InvoiceRepository(IConnection connection)
            => _connection = connection;

        public InvoiceResponse Insert(InvoiceCreateRequest body)
        {
            string json = JsonConvert.SerializeObject(body, Json.Settings);
         
            var response = _connection.PostWithResponse("v2/invoices", json);
            return response == string.Empty ? null : JsonConvert.DeserializeObject<InvoiceResponse>(response);
        }

        public bool Update(InvoiceUpdateRequest body)
        {
            string json = JsonConvert.SerializeObject(body, Json.Settings);
            return _connection.Put("v2/invoices/totals", json);
        }

        public bool Delete(long id)
        {
            return _connection.Delete("v2/invoices/", id.ToString());
        }

        public string GetDescription(long id)
        {
            return _connection.Get("v2/invoices/description/", id.ToString());
        }

        public List<Invoice> GetAll()
        {
            string json = _connection.Get("v2/invoices", string.Empty);
            return json == null ? [] : JsonConvert.DeserializeObject<List<Invoice>>(json);
        }
    }
}