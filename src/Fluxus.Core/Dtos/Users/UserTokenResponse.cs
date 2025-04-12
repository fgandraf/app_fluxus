namespace Fluxus.Core.Dtos.Users;

public record UserTokenResponse
{
    public string Token { get; set; } = string.Empty;
};