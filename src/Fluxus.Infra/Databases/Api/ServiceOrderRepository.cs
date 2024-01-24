using Fluxus.Domain.Models;
using System.Data;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;
using Fluxus.Domain.ViewModels;
using Fluxus.Domain.Contracts.Databases;

namespace Fluxus.Infra.Databases.Api
{
    public class ServiceOrderRepository : IServiceOrderRepository
    {
        private readonly IConnection _connection;

        public ServiceOrderRepository(IConnection connection)
            => _connection = connection;

        public int Insert(Order body)
        {
            string json = JsonConvert.SerializeObject(body);
            return _connection.Post("v1/service-orders", json);
        }

        public bool Update(Order body)
        {
            string json = JsonConvert.SerializeObject(body);
            return _connection.Put("v1/service-orders", json);
        }

        public bool UpdateInvoiceId(int invoiceId, List<int> orders)
        {
            string json = JsonConvert.SerializeObject(orders);
            return _connection.Put("v1/service-orders/update-invoice/" + invoiceId, json);
        }

        public async void UpdateStatus(int id, string status)
        {
            await Task.Run(() => _connection.Put("v1/service-orders/update-status/" + id + "," + status, string.Empty));
        }

        public bool Delete(long id)
        {
            return _connection.Delete("v1/service-orders/", id.ToString());
        }

        public List<OrdersOpenViewModel> GetIndexOpen()
        {
            string json = _connection.Get("v1/service-orders/flow", string.Empty);
            return JsonConvert.DeserializeObject<List<OrdersOpenViewModel>>(json);
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

        public Order GetById(int id)
        {
            string json = _connection.Get("v1/service-orders/", id.ToString());
            return JsonConvert.DeserializeObject<Order>(json);
        }

        public List<OrdersIndexViewModel> GetOpenDone()
        {
            string json = _connection.Get("v1/service-orders/done-to-invoice", string.Empty);
            return JsonConvert.DeserializeObject<List<OrdersIndexViewModel>>(json);
        }

        public List<OrdersIndexViewModel> GetFiltered(string filter)
        {
            string json = _connection.Get("v1/service-orders/filtered/", filter);

            if (json != null)
                return JsonConvert.DeserializeObject<List<OrdersIndexViewModel>>(json);

            return null;
        }

        public List<OrdersIndexViewModel> GetClosedByInvoiceId(int invoiceId)
        {
            string json = _connection.Get("v1/service-orders/invoiced/", invoiceId.ToString());
            return JsonConvert.DeserializeObject<List<OrdersIndexViewModel>>(json);
        }

        public List<ProfessionalNameId> GetProfessionalByInvoiceId(int invoiceId)
        {
            string json = _connection.Get("v1/service-orders/professionals/", invoiceId.ToString());
            return JsonConvert.DeserializeObject<List<ProfessionalNameId>>(json);
        }
    }
}
