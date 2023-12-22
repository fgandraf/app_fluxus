using Fluxus.Domain.Entities;
using Fluxus.Infra.Repositories.Contracts;
using Newtonsoft.Json;

namespace Fluxus.Infra.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IConnection _connection;

        public UserRepository(IConnection connection)
            => _connection = connection;


        public (bool, string) Login(User model)
        {
            string json = JsonConvert.SerializeObject(model);
            return _connection.Login("v1/users/login", json);
        }

        public int Insert(User model)
        {
            string json = JsonConvert.SerializeObject(model);
            return _connection.Post("v1/users", json);
        }

        public bool Update(User model)
        {
            string json = JsonConvert.SerializeObject(model);
            return _connection.Put("v1/users", json);
        }


        public bool Delete(int id)
        {
            return _connection.Delete("v1/users/", id.ToString());
        }

        public User GetById(int id)
        {
            string json = _connection.Get("v1/users/", id.ToString());
            return JsonConvert.DeserializeObject<User>(json);
        }

        public User GetByUserName(string userName)
        {
            var json = _connection.Get("v1/users/username/", userName);
            if (json != null)
                return JsonConvert.DeserializeObject<User>(json);

            return null;
        }

        public User GetByProfessionalId(int profesionalId)
        {
            var json = _connection.Get("v1/users/professional/", profesionalId.ToString());
            if (json != null)
                return JsonConvert.DeserializeObject<User>(json);

            return null;
        }
    }
}
