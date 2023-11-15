using Fluxus.Domain.Entities;
using System.Data;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;
using Fluxus.Domain.Records;
using Fluxus.Domain.Interfaces;

namespace Fluxus.Infra.Repositories
{
    public class ServiceOrderRepository : IServiceOrderRepository
    {
        public int Insert(ServiceOrder body)
        {
            string json = JsonConvert.SerializeObject(body);
            return Request.Post("ServiceOrder", json);
        }

        public bool Update(ServiceOrder body)
        {
            string json = JsonConvert.SerializeObject(body);
            return Request.Put("ServiceOrder", json);
        }

        public bool UpdateInvoiceId(int id, int invoiceId)
        {
            return Request.Put("ServiceOrder/UpdateInvoiceId/" + id + "," + invoiceId, string.Empty);
        }

        public async void UpdateStatus(int id, string status)
        {
            await Task.Run(() => Request.Put("ServiceOrder/UpdateStatus/" + id + "," + status, string.Empty));
        }

        public bool Delete(long id)
        {
            return Request.Delete("ServiceOrder/", id.ToString());
        }

        public List<ServiceOrderOpen> GetIndexOpen()
        {
            string json = Request.Get("ServiceOrder/OrdersFlow", string.Empty);
            return JsonConvert.DeserializeObject<List<ServiceOrderOpen>>(json);
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

        public List<ServiceOrderIndex> GetOpenDone()
        {
            string json = Request.Get("ServiceOrder/DoneToInvoice", string.Empty);
            return JsonConvert.DeserializeObject<List<ServiceOrderIndex>>(json);
        }

        public List<ServiceOrderIndex> GetFiltered(string filter)
        {
            string json = Request.Get("ServiceOrder/Filtered/", filter);

            if (json != null)
                return JsonConvert.DeserializeObject<List<ServiceOrderIndex>>(json);

            return null;
        }

        public List<ServiceOrderIndex> GetClosedByInvoiceId(int invoiceId)
        {
            string json = Request.Get("ServiceOrder/Invoiced/", invoiceId.ToString());
            return JsonConvert.DeserializeObject<List<ServiceOrderIndex>>(json);
        }

        public List<ProfessionalNameId> GetProfessionalByInvoiceId(int invoiceId)
        {
            string json = Request.Get("ServiceOrder/Professionals/", invoiceId.ToString());
            return JsonConvert.DeserializeObject<List<ProfessionalNameId>>(json);
        }
    }
}
