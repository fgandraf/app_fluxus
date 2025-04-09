namespace Fluxus.Core.Dtos.Users;

public record UserLoginRequest
(
    string email,
    string password
);