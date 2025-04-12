using Fluxus.Core.Models;
using Fluxus.Core.Contracts.Databases;
using Newtonsoft.Json;
using Fluxus.Core.Dtos.Users;
using Newtonsoft.Json.Serialization;

namespace Fluxus.Infra.Databases.Api
{
    public class UserRepository : IUserRepository
    {
        private readonly IConnection _connection;

        public UserRepository(IConnection connection)
            => _connection = connection;


        public (bool, string) Login(UserLoginRequest model)
        {
            string json = JsonConvert.SerializeObject(model, Json.Settings);
            return _connection.Login("v2/users/login", json);
        }

        public long Register(UserCreateRequest model)
        {
            string json = JsonConvert.SerializeObject(model, Json.Settings);
            return _connection.Post("v2/users/register", json);
        }

        public bool UpdateInfo(UserUpdateInfoRequest model)
        {
            string json = JsonConvert.SerializeObject(model, Json.Settings);
            return _connection.Put("v2/users/update-info", json);
        }

        public bool UpdateConfig(User model)
        {
            string json = JsonConvert.SerializeObject(model, Json.Settings);
            return _connection.Put("v2/users/update-config", json);
        }

        public User GetById(long id)
        {
            string json = _connection.Get("v2/users/", id.ToString());
            return JsonConvert.DeserializeObject<User>(json);
        }

        public UserResponse GetByUserName(string userName)
        {
            var serializerSettings = new JsonSerializerSettings();
            serializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            var json = _connection.Get("v2/users/username/", userName);
            if (json != null)
                return JsonConvert.DeserializeObject<UserResponse>(json, serializerSettings);

            return null;
        }

        public User GetByProfessionalId(long profesionalId)
        {
            var json = _connection.Get("v2/users/professional/", profesionalId.ToString());
            if (json != null)
                return JsonConvert.DeserializeObject<User>(json);

            return null;
        }

        public UserResponse Activate(long id)
        {
            throw new System.NotImplementedException();
        }

        public UserResponse Deactivate(long id)
        {
            throw new System.NotImplementedException();
        }

        public UserResponse UpgradePermission(long id)
        {
            throw new System.NotImplementedException();
        }

        public UserResponse DowngradePermission(long id)
        {
            throw new System.NotImplementedException();
        }
    }
}
