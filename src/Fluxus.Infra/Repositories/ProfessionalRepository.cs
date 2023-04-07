using Fluxus.Domain.Entities;
using Newtonsoft.Json;
using System.Collections.Generic;


namespace Fluxus.Infra.Repositories
{
    public class ProfessionalRepository
    {
        public void Insert(Professional body)
        {
            string json = JsonConvert.SerializeObject(body);
            Request.Post("Professional", json);
        }

        public void Update(Professional body)
        {
            string json = JsonConvert.SerializeObject(body);
            Request.Put("Professional", json);
        }

        public bool Delete(int id)
        {
            return Request.Delete("Professional/", id.ToString());
        }

        public List<dynamic> GetIndex()
        {
            string json = Request.Get("Professional", string.Empty);
            return JsonConvert.DeserializeObject<List<dynamic>>(json);
        }

        public dynamic GetUser(string userName)
        {
            var json = Request.Get("Professional/UserInfo/", userName);
            if (json != null)
                return JsonConvert.DeserializeObject<dynamic>(json);

            return null;
        }

        public List<Professional> GetTagNameid()
        {
            string json = Request.Get("Professional/TagNameId", string.Empty);
            return JsonConvert.DeserializeObject<List<Professional>>(json);
        }

        public Professional GetById(int id)
        {
            string json = Request.Get("Professional/", id.ToString());
            return JsonConvert.DeserializeObject<Professional>(json);
        }
    }
}
