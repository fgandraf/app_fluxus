using Fluxus.Core.Dtos.Users;
using Fluxus.Core.Models;

namespace Fluxus.Core.Contracts.Databases;

public interface IUserRepository
{
    public (bool,string) Login(UserLoginRequest model);
    public long Register(User model);
    public bool UpdateInfo(User model);
    public bool UpdateConfig(User model);
    public UserResponse Activate(long id);
    public UserResponse Deactivate(long id);
    public UserResponse UpgradePermission(long id);
    public UserResponse DowngradePermission(long id);
    public bool Delete(long id);
    public UserResponse GetByUserName(string userName);
    public User GetByProfessionalId(long profesionalId);
    public User GetById(long id);
}