namespace Fluxus.Core.Dtos.Users;

public record UserCreateRequest
(
    string Email,
    string Password
);