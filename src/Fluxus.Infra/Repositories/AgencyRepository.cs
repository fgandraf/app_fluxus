using Newtonsoft.Json;
using System.Data;
using Fluxus.Domain.Entities;


namespace Fluxus.Infra.Repositories
{
    public class AgencyRepository
    {
        public void Insert(Agencia dado)
        {
            string json = JsonConvert.SerializeObject(dado);
            Request.Post("agencia/post", json);
        }

        public void Update(long id, Agencia dado)
        {
            string json = JsonConvert.SerializeObject(dado);
            Request.Put("agencia/put/" + id, json);
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

        public DataTable GetByCode(string agenciaCodigo)
        {
            string json = Request.Get("agencia/getsomeby/", agenciaCodigo);
            return JsonConvert.DeserializeObject<DataTable>(json);
        }

        public Agencia GetById(long id)
        {
            string json = Request.Get("agencia/getby/", id.ToString());
            return  JsonConvert.DeserializeObject<Agencia>(json);
        }
    }
}
