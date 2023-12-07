using Fluxus.Domain.Entities;
using System.Data;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;
using Fluxus.Infra.Records;
using Fluxus.Infra.Repositories.Contracts;

namespace Fluxus.Infra.Repositories
{
    public class ServiceOrderRepository : IServiceOrderRepository
    {
        private readonly IConnection _connection;

        public ServiceOrderRepository(IConnection connection)
            => _connection = connection;

        public int Insert(ServiceOrder body)
        {
            string json = JsonConvert.SerializeObject(body);
            return _connection.Post("v1/service-orders", json);
        }

        public bool Update(ServiceOrder body)
        {
            string json = JsonConvert.SerializeObject(body);
            return _connection.Put("v1/service-orders", json);
        }

        public bool UpdateInvoiceId(int id, int invoiceId)
        {
            return _connection.Put("v1/service-orders/update-invoice/" + id + "," + invoiceId, string.Empty);
        }

        public async void UpdateStatus(int id, string status)
        {
            await Task.Run(() => _connection.Put("v1/service-orders/update-status/" + id + "," + status, string.Empty));
        }

        public bool Delete(long id)
        {
            return _connection.Delete("v1/service-orders/", id.ToString());
        }

        public List<ServiceOrderOpen> GetIndexOpen()
        {
            string json = _connection.Get("v1/service-orders/flow", string.Empty);
            return JsonConvert.DeserializeObject<List<ServiceOrderOpen>>(json);
        }

        public List<string> GetCitiesFromOrders()
        {
            List<string> cities = new List<string>();

            string json = _connection.Get("v1/service-orders/cities", string.Empty);
            var table = JsonConvert.DeserializeObject<DataTable>(json);

            for (int i = 0; i < table.Rows.Count; i++)
                cities.Add(table.Rows[i][0].ToString());

            return cities;
        }

        public ServiceOrder GetById(int id)
        {
            string json = _connection.Get("v1/service-orders/", id.ToString());
            return JsonConvert.DeserializeObject<ServiceOrder>(json);
        }

        public List<ServiceOrderIndex> GetOpenDone()
        {
            string json = _connection.Get("v1/service-orders/done-to-invoice", string.Empty);
            return JsonConvert.DeserializeObject<List<ServiceOrderIndex>>(json);
        }

        public List<ServiceOrderIndex> GetFiltered(string filter)
        {
            string json = _connection.Get("v1/service-orders/filtered/", filter);

            if (json != null)
                return JsonConvert.DeserializeObject<List<ServiceOrderIndex>>(json);

            return null;
        }

        public List<ServiceOrderIndex> GetClosedByInvoiceId(int invoiceId)
        {
            string json = _connection.Get("v1/service-orders/invoiced/", invoiceId.ToString());
            return JsonConvert.DeserializeObject<List<ServiceOrderIndex>>(json);
        }

        public List<ProfessionalNameId> GetProfessionalByInvoiceId(int invoiceId)
        {
            string json = _connection.Get("v1/service-orders/professionals/", invoiceId.ToString());
            return JsonConvert.DeserializeObject<List<ProfessionalNameId>>(json);
        }
    }
}
