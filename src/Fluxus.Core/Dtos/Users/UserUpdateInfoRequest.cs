using Fluxus.Core.Models;

namespace Fluxus.Core.Dtos.Users;

public record UserUpdateInfoRequest
{
    public long Id {  get; set; }
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;

    public UserUpdateInfoRequest(User user)
    {
        Id = user.Id;
        Email = user.Email;
        Password = user.Password;
    }
}