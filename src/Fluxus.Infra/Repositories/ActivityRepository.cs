using Fluxus.Domain.Entities;
using Newtonsoft.Json;
using System.Data;


namespace Fluxus.Infra.Repositories
{
    public class ActivityRepository
    {
        public void Insert(Atividade dado)
        {
            string json = JsonConvert.SerializeObject(dado);
            Request.Post("atividade/post", json);
        }

        public void Update(long id, Atividade dado)
        {
            string json = JsonConvert.SerializeObject(dado);
            Request.Put("atividade/put/", json);
        }

        public void Delete(long id)
        {
            Request.Delete("atividade/delete/", id.ToString());
        }

        public DataTable GetAll()
        {
            string json = Request.Get("atividade", string.Empty);
            return JsonConvert.DeserializeObject<DataTable>(json);
        }

        public Atividade GetById(long id)
        {
            string json = Request.Get("atividade/getby/", id.ToString());
            return JsonConvert.DeserializeObject<Atividade>(json);
        }
    }
}
