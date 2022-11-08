using Fluxus.Domain.Entities;
using Newtonsoft.Json;
using System.Data;


namespace Fluxus.Infra.Repositories
{
    public class ProfessionalRepository
    {
        public void Insert(Profissional dado)
        {
            string json = JsonConvert.SerializeObject(dado);
            Request.Post("profissional/post", json);
        }

        public void Update(long id, Profissional dado)
        {
            string json = JsonConvert.SerializeObject(dado);
            Request.Put("profissional/put/" + id, json);
        }

        public void Delete(long id)
        {
            Request.Delete("profissional/delete/", id.ToString());
        }

        public DataTable GetAll()
        {
            string json = Request.Get("profissional", string.Empty);
            return JsonConvert.DeserializeObject<DataTable>(json);
        }

        public DataTable GetUser(string nomeDeUsuario)
        {
            string json = Request.Get("profissional/getuserinfo/", nomeDeUsuario);
            return JsonConvert.DeserializeObject<DataTable>(json);
        }

        public DataTable GetCodeNameid()
        {
            string json = Request.Get("profissional/getcodigoenomeid", string.Empty);
            return JsonConvert.DeserializeObject<DataTable>(json);
        }

        public Profissional GetById(long id)
        {
            string json = Request.Get("profissional/getby/", id.ToString());
            return JsonConvert.DeserializeObject<Profissional>(json);
        }
    }
}
