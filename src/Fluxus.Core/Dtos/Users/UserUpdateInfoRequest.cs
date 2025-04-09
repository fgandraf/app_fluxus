namespace Fluxus.Core.Dtos.Users;

public record UserUpdateInfoRequest
(
    long Id,
    string Email,
    string Password
);