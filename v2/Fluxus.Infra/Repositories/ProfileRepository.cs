using Fluxus.Domain.Entities;
using System.Data;
using Newtonsoft.Json;

namespace Fluxus.Infra.Repositories
{
    public class ProfileRepository
    {
        public void Insert(Profile profile)
        {
            string json = JsonConvert.SerializeObject(profile);
            Request.Post("Profile", json);
        }

        public void Update(Profile profile)
        {
            string json = JsonConvert.SerializeObject(profile);
            Request.Put("Profile", json);
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
            return JsonConvert.DeserializeObject<byte[]>(json);
        }

        public string GetName()
        {
            return Request.Get("Profile/TradingName", string.Empty);
        }

    }
}
