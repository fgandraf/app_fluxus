using Fluxus.Domain.Entities;

namespace Fluxus.Infra.Repositories.Contracts;

public interface IUserRepository
{
    public int Insert(User model);
    public bool Update(User model);
    public bool Delete(int id);
    public User GetByUserName(string userName);
    public User GetByProfessionalId(int profesionalId);
    public User GetById(int id);
}