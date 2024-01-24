using Fluxus.Domain.Models;
using Fluxus.Domain.Contracts.Databases;
using Newtonsoft.Json;
using System;

namespace Fluxus.Infra.Databases.Api
{
    public class UserRepository : IUserRepository
    {
        private readonly IConnection _connection;

        public UserRepository(IConnection connection)
            => _connection = connection;


        public (bool, string) Login(object model)
        {
            string json = JsonConvert.SerializeObject(model);
            return _connection.Login("v1/accounts/login", json);
        }

        public int Insert(User model)
        {
            string json = JsonConvert.SerializeObject(model);
            return _connection.Post("v1/accounts", json);
        }

        public bool Update(User model)
        {
            string json = JsonConvert.SerializeObject(model);
            return _connection.Put("v1/accounts", json);
        }


        public bool Delete(int id)
        {
            return _connection.Delete("v1/accounts/", id.ToString());
        }

        public User GetById(int id)
        {
            string json = _connection.Get("v1/accounts/", id.ToString());
            return JsonConvert.DeserializeObject<User>(json);
        }

        public User GetByUserName(string userName)
        {
            var json = _connection.Get("v1/accounts/username/", userName);
            if (json != null)
                return JsonConvert.DeserializeObject<User>(json);

            return null;
        }

        public User GetByProfessionalId(int profesionalId)
        {
            var json = _connection.Get("v1/accounts/professional/", profesionalId.ToString());
            if (json != null)
                return JsonConvert.DeserializeObject<User>(json);

            return null;
        }
    }
}
