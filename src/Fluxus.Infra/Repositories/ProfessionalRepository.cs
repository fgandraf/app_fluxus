using Fluxus.Domain.Entities;
using Fluxus.Domain.Interfaces;
using Fluxus.Domain.Structs;
using Newtonsoft.Json;

namespace Fluxus.Infra.Repositories
{
    public class ProfessionalRepository : IProfessionalRepository
    {
        public bool Insert(Professional body)
        {
            string json = JsonConvert.SerializeObject(body);
            int response = Request.Post("Professional", json);
            return response != -1;
        }

        public bool Update(Professional body)
        {
            string json = JsonConvert.SerializeObject(body);
            return Request.Put("Professional", json);
        }

        public bool Delete(int id)
        {
            return Request.Delete("Professional/", id.ToString());
        }

        public string GetIndex()
        {
            return Request.Get("Professional", string.Empty);
        }

        public UserInfo GetUser(string userName)
        {
            var json = Request.Get("Professional/UserInfo/", userName);
            if (json != null)
                return JsonConvert.DeserializeObject<UserInfo>(json);

            return new UserInfo();
        }

        public string GetTagNameid()
        {
            return Request.Get("Professional/TagNameId", string.Empty);
            
        }

        public string GetById(int id)
        {
            return Request.Get("Professional/", id.ToString());
        }
    }


}
