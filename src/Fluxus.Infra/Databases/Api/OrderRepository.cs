using Fluxus.Core.Models;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;
using Fluxus.Core.Contracts.Databases;
using Fluxus.Core.Dtos.Orders;
using Fluxus.Core.Dtos.Professionals;

namespace Fluxus.Infra.Databases.Api
{
    public class OrderRepository : IOrderRepository
    {
        private readonly IConnection _connection;

        public OrderRepository(IConnection connection)
            => _connection = connection;

        public long Insert(OrderCreateRequest body)
        {
            string json = JsonConvert.SerializeObject(body, Json.Settings);
            return _connection.Post("v2/orders", json);
        }

        public bool Update(OrderUpdateRequest body)
        {
            string json = JsonConvert.SerializeObject(body, Json.Settings);
            return _connection.Put("v2/orders", json);
        }

        public bool UpdateInvoiceId(long invoiceId, List<long> orders)
        {
            string json = JsonConvert.SerializeObject(orders, Json.Settings);
            return _connection.Put("v2/orders/update-invoice/" + invoiceId, json);
        }

        public async void UpdateStatus(long id, int status)
        {
            await Task.Run(() => _connection.Put("v2/orders/update-status/" + id + "," + status, string.Empty));
        }

        public bool Delete(long id)
        {
            return _connection.Delete("v2/orders/", id.ToString());
        }

        public List<OrderFlowResponse> GetIndexOpen()
        {
            string json = _connection.Get("v2/orders/flow", string.Empty);
            return json == null ? [] : JsonConvert.DeserializeObject<List<OrderFlowResponse>>(json);
        }

        public List<string> GetCitiesFromOrders()
        {
            var json = _connection.Get("v2/orders/cities", string.Empty);
            return json == null ? [] : JsonConvert.DeserializeObject<List<string>>(json);
        }

        public OrderResponse GetById(long id)
        {
            string json = _connection.Get("v2/orders/", id.ToString());
            return JsonConvert.DeserializeObject<OrderResponse>(json);
        }

        public List<OrderDoneToInvoiceResponse> GetOpenDone()
        {
            string json = _connection.Get("v2/orders/done-to-invoice", string.Empty);
            return json == null ? [] : JsonConvert.DeserializeObject<List<OrderDoneToInvoiceResponse>>(json);
        }

        public List<OrderFilteredResponse> GetFiltered(OrderFilterRequest body)
        {
            string request = JsonConvert.SerializeObject(body);
            var response = _connection.GetWithBody("v2/orders/filtered", request);
            return response == null ? [] : JsonConvert.DeserializeObject<List<OrderFilteredResponse>>(response);
        }

        public List<OrderInvoicedResponse> GetClosedByInvoiceId(long invoiceId)
        {
            string json = _connection.Get("v2/orders/invoiced/", invoiceId.ToString());
            return json == null ? [] : JsonConvert.DeserializeObject<List<OrderInvoicedResponse>>(json);
        }

        public List<ProfessionalTagNameIdResponse> GetProfessionalByInvoiceId(long invoiceId)
        {
            string json = _connection.Get("v2/orders/professionals/", invoiceId.ToString());
            return json == null ? [] : JsonConvert.DeserializeObject<List<ProfessionalTagNameIdResponse>>(json);
        }
    }
}
