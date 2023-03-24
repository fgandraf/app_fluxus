using Fluxus.Domain.Entities;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.Json;

namespace Fluxus.Infra.Repositories
{
    public class ProfileRepository
    {
        public void Insert(Profile body)
        {
            string json = JsonSerializer.Serialize(body);
            Request.Post("Profile", json);
        }

        public void Update(Profile body)
        {
            string json = JsonSerializer.Serialize(body);
            Request.Put("Profile", json);
        }


        public Profile GetAll()
        {
            string json = Request.Get("Profile", string.Empty);
            Profile profile = JsonSerializer.Deserialize<List<Profile>>(json).ToList().First();
            return profile;
        }

        public DataTable GetToPrint()
        {
            string json = Request.Get("Profile/ToPrint", string.Empty);
            return JsonSerializer.Deserialize<DataTable>(json);
        }

        public string GetName()
        {
            return Request.Get("Profile/TradingName", string.Empty);
        }

    }
}
