using Fluxus.Domain.Entities;
using Fluxus.Domain.Interfaces;
using Fluxus.Domain.Structs;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Fluxus.Infra.Repositories
{
    public class ProfessionalRepository : IProfessionalRepository
    {
        public int Insert(Professional body)
        {
            string json = JsonConvert.SerializeObject(body);
            return Request.Post("Professional", json);
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

        public Professional GetById(int id)
        {
            string json = Request.Get("Professional/", id.ToString());

            if (!string.IsNullOrEmpty(json))
                return JsonConvert.DeserializeObject<Professional>(json);

            return null;
        }

        public List<ProfessionalIndex> GetIndex()
        {
            string json = Request.Get("Professional", string.Empty);
            if (!string.IsNullOrEmpty(json))
                return JsonConvert.DeserializeObject<List<ProfessionalIndex>>(json);

            return null;
        }

        public UserInfo GetUser(string userName)
        {
            var json = Request.Get("Professional/UserInfo/", userName);
            if (json != null)
                return JsonConvert.DeserializeObject<UserInfo>(json);

            return new UserInfo();
        }

        public List<ProfessionalNameId> GetTagNameid()
        {
            string json = Request.Get("Professional/TagNameId", string.Empty);
            List<ProfessionalNameId> professionals;

            if (!string.IsNullOrEmpty(json))
            {
                professionals = JsonConvert.DeserializeObject<List<ProfessionalNameId>>(json);
                return professionals;
            }

            return null;
        }
    }
}
