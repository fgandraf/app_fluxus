using Fluxus.Core.Models;
using Newtonsoft.Json;
using Fluxus.Core.Contracts.Databases;
using System.Runtime.CompilerServices;
using Fluxus.Core.Dtos.Profiles;

namespace Fluxus.Infra.Databases.Api
{
    public class ProfileRepository : IProfileRepository
    {
        private readonly IConnection _connection;

        public ProfileRepository(IConnection connection)
            => _connection = connection;

        public long Insert(Profile profile)
        {
            string json = JsonConvert.SerializeObject(profile, Json.Settings);
            return _connection.Post("v2/profiles", json);
        }

        public bool Update(Profile profile)
        {
            string json = JsonConvert.SerializeObject(profile, Json.Settings);
            return _connection.Put("v2/profiles", json);
        }

        public Profile GetById(long id)
        {
            string json = _connection.Get("v2/profiles", string.Empty);
            if (json == null)
                return null;

            return JsonConvert.DeserializeObject<Profile>(json);
        }

        public Profile GetToPrint()
        {
            string json = _connection.Get("v2/profiles/to-print", string.Empty);
            return JsonConvert.DeserializeObject<Profile>(json);
        }

        public ProfileLogoResponse GetLogo()
        {
            string json = _connection.Get("v2/profiles/logo", string.Empty);
            if (json == null)
                return null;

            return JsonConvert.DeserializeObject<ProfileLogoResponse>(json);
        }

        public ProfileTradingNameResponse GetTradingName()
        {
            string json = _connection.Get("v2/profiles/trading-name", string.Empty);
            return json == null ?  null : JsonConvert.DeserializeObject<ProfileTradingNameResponse>(json);
        }

        public bool UpdateLogo(object model)
        {
            string json = JsonConvert.SerializeObject(model, Json.Settings);
            return _connection.Put("v2/profiles/logo", json);
        }
    }
}
