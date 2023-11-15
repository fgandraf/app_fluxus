using Fluxus.Domain.Entities;
using Newtonsoft.Json;
using Fluxus.Domain.Interfaces;

namespace Fluxus.Infra.Repositories
{
    public class ProfileRepository : IProfileRepository
    {
        public int Insert(Profile profile)
        {
            string json = JsonConvert.SerializeObject(profile);
            return Request.Post("Profile", json);
        }

        public bool Update(Profile profile)
        {
            string json = JsonConvert.SerializeObject(profile);
            return Request.Put("Profile", json);
        }

        public Profile GetAll()
        {
            string json = Request.Get("Profile", string.Empty);
            return JsonConvert.DeserializeObject<Profile>(json);
        }

        public Profile GetToPrint()
        {
            string json = Request.Get("Profile/ToPrint", string.Empty);
            return JsonConvert.DeserializeObject<Profile>(json);
        }

        public byte[] GetLogo()
        {
            string json = Request.Get("Profile/Logo", string.Empty);
            
            if (json != null)
                return JsonConvert.DeserializeObject<byte[]>(json);
            else
                return null;
        }

        public string GetTradingName()
        {
            return Request.Get("Profile/TradingName", string.Empty);
        }

    }
}
