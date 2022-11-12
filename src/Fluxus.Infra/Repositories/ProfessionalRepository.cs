using Fluxus.Domain.Entities;
using Newtonsoft.Json;
using System.Data;


namespace Fluxus.Infra.Repositories
{
    public class ProfessionalRepository
    {
        public void Insert(Profissional body)
        {
            string json = JsonConvert.SerializeObject(body);
            Request.Post("profissional/post", json);
        }

        public void Update(Profissional body)
        {
            string json = JsonConvert.SerializeObject(body);
            Request.Put("profissional/put/" + body.Id, json);
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

        public DataTable GetUser(string userName)
        {
            string json = Request.Get("profissional/getuserinfo/", userName);
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
