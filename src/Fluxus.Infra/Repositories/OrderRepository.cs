using Fluxus.Domain.Entities;
using Newtonsoft.Json;
using System.Data;
using System.Threading.Tasks;


namespace Fluxus.Infra.Repositories
{
    public class OrderRepository
    {
        public void Insert(Os dado)
        {
            string json = JsonConvert.SerializeObject(dado);
            Request.Post("os/post", json);
        }

        public void Update(long id, Os dado)
        {
            string json = JsonConvert.SerializeObject(dado);
            Request.Put("os/put/" + id, json);
        }

        public void UpdateFaturaCod(long id, long fatura_cod)
        {
            Request.Put("os/updatefaturacod/" + id + "," + fatura_cod, string.Empty);
        }

        public async void UpdateStatus(long id, string status)
        {
            await Task.Run(() => Request.Put("os/updatestatus/" + id + "," + status, string.Empty));
        }

        public void Delete(long id)
        {
            Request.Delete("os/delete/", id.ToString());
        }

        public DataTable GetIndexOpen()
        {
            string json = Request.Get("os/getordensdofluxo", string.Empty);
            return JsonConvert.DeserializeObject<DataTable>(json);
        }

        public DataTable GetOpenDone()
        {
            string json = Request.Get("os/getordensconcluidasafaturar", string.Empty);
            return JsonConvert.DeserializeObject<DataTable>(json);
        }

        public DataTable GetClosedByInvoiceId(long fatura_cod)
        {
            string json = Request.Get("os/getordensfaturadas/", fatura_cod.ToString());
            return JsonConvert.DeserializeObject<DataTable>(json);
        }

        public DataTable GetFiltered(string filtro)
        {
            string json = Request.Get("os/getfiltered/", filtro);
            return JsonConvert.DeserializeObject<DataTable>(json);
        }

        public DataTable GetProfessionalByInvoiceId(long fatura_cod)
        {
            string json = Request.Get("os/getprofissionaisdafatura/", fatura_cod.ToString());
            return JsonConvert.DeserializeObject<DataTable>(json);
        }

        public DataTable GetCitiesFromOrders()
        {
            string json = Request.Get("os/getcidadesdasordens", string.Empty);
            return JsonConvert.DeserializeObject<DataTable>(json);
        }

        public Os GetById(long id)
        {
            string json = Request.Get("os/getby/", id.ToString());
            return JsonConvert.DeserializeObject<Os>(json);
        }
    }
}
