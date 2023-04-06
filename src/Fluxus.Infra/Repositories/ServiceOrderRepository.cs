using Fluxus.Domain.Entities;
using Fluxus.Domain.Struct;
using System.Data;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Fluxus.Infra.Repositories
{
    public class ServiceOrderRepository
    {
        public bool Insert(ServiceOrder body)
        {
            string json = JsonConvert.SerializeObject(body);
            Request.Post("ServiceOrder", json);
            return true;
        }

        public bool Update(ServiceOrder body)
        {
            string json = JsonConvert.SerializeObject(body);
            return Request.Put("ServiceOrder", json);
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

        public List<ServiceOrderFlow> GetIndexOpen()
        {
            string json = Request.Get("ServiceOrder/OrdersFlow", string.Empty);
            return JsonConvert.DeserializeObject<List<ServiceOrderFlow>>(json);
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

        public List<string> GetCitiesFromOrders()
        {
            List<string> cities = new List<string>();
            
            string json = Request.Get("ServiceOrder/OrderedCities", string.Empty);
            var table = JsonConvert.DeserializeObject<DataTable>(json);

            for (int i = 0; i < table.Rows.Count; i++)
                cities.Add(table.Rows[i][0].ToString());

            return cities;
        }

        public ServiceOrder GetById(int id)
        {
            string json = Request.Get("ServiceOrder/", id.ToString());
            return JsonConvert.DeserializeObject<ServiceOrder>(json);
        }
    }
}
