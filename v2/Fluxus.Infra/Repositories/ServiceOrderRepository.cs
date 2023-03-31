using Fluxus.Domain.Entities;
using Fluxus.Domain.Struct;
using System.Data;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.Collections.Generic;
using System;
using System.ComponentModel;

namespace Fluxus.Infra.Repositories
{
    public class ServiceOrderRepository
    {
        public void Insert(ServiceOrder body)
        {
            string json = JsonConvert.SerializeObject(body);
            Request.Post("ServiceOrder", json);
        }

        public void Update(ServiceOrder body)
        {
            string json = JsonConvert.SerializeObject(body);
            Request.Put("ServiceOrder", json);
        }

        public void UpdateInvoiceId(int id, int invoiceId)
        {
            Request.Put("ServiceOrder/UpdateInvoiceId/" + id + "," + invoiceId, string.Empty);
        }

        public async void UpdateStatus(int id, string status)
        {
            await Task.Run(() => Request.Put("ServiceOrder/UpdateStatus/" + id + "," + status, string.Empty));
        }

        public void Delete(long id)
        {
            Request.Delete("ServiceOrder/", id.ToString());
        }

        public List<ServiceOrder> GetIndexOpen()
        {
            string json = Request.Get("ServiceOrder/OrdersFlow", string.Empty);
            return JsonConvert.DeserializeObject<List<ServiceOrder>>(json);
        }

        public DataTable GetIndexOpenEmTabela()
        {
            string json = Request.Get("ServiceOrder/OrdersFlow", string.Empty);
            return JsonConvert.DeserializeObject<DataTable>(json);
        }

        public DataTable GetOpenDone()
        {
            string json = Request.Get("ServiceOrder/DoneToInvoice", string.Empty);
            return JsonConvert.DeserializeObject<DataTable>(json);
        }

        public DataTable GetClosedByInvoiceId(int invoiceId)
        {
            string json = Request.Get("ServiceOrder/Invoiced/", invoiceId.ToString());
            return JsonConvert.DeserializeObject<DataTable>(json);
        }

        public List<ServiceOrderFiltered> GetFiltered(string filter)
        {
            string json = Request.Get("ServiceOrder/Filtered/", filter);

            if (json != null)
                return JsonConvert.DeserializeObject<List<ServiceOrderFiltered>>(json);

            return null;
        }

        public DataTable GetProfessionalByInvoiceId(int invoiceId)
        {
            string json = Request.Get("ServiceOrder/Professionals/", invoiceId.ToString());
            return JsonConvert.DeserializeObject<DataTable>(json);
        }

        public DataTable GetCitiesFromOrders()
        {
            string json = Request.Get("ServiceOrder/OrderedCities", string.Empty);
            return JsonConvert.DeserializeObject<DataTable>(json);
        }

        public ServiceOrder GetById(int id)
        {
            string json = Request.Get("ServiceOrder/", id.ToString());
            return JsonConvert.DeserializeObject<ServiceOrder>(json);
        }
    }
}
