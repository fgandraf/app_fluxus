namespace Fluxus.Core.Dtos.Profiles;

public record ProfileLogoResponse
{
    public string Base64Image {  get; set; } = string.Empty;
}