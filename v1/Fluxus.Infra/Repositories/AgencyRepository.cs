using Newtonsoft.Json;
using System.Data;
using Fluxus.Domain.Entities;


namespace Fluxus.Infra.Repositories
{
    public class AgencyRepository
    {
        public void Insert(Agencia body)
        {
            string json = JsonConvert.SerializeObject(body);
            Request.Post("agencia/post", json);
        }

        public void Update(Agencia body)
        {
            string json = JsonConvert.SerializeObject(body);
            Request.Put("agencia/put/" + body.Id, json);
        }

        public void Delete(long id)
        {
            Request.Delete("agencia/delete/", id.ToString());
        }

        public DataTable GetAll()
        {
            string json = Request.Get("agencia", string.Empty);
            return JsonConvert.DeserializeObject<DataTable>(json);
        }

        public DataTable GetByCode(string agencyCode)
        {
            string json = Request.Get("agencia/getsomeby/", agencyCode);
            return JsonConvert.DeserializeObject<DataTable>(json);
        }

        public Agencia GetById(long id)
        {
            string json = Request.Get("agencia/getby/", id.ToString());
            return  JsonConvert.DeserializeObject<Agencia>(json);
        }
    }
}
