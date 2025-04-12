namespace Fluxus.Core.Dtos.Professionals;

public record ProfessionalTagNameIdResponse
{
    public long Id { get; set; }
    public long ProfessionalId
    {
        get => Id;
        set => Id = value;
    }
    public string Tag { get; set; } = string.Empty;
    public string NameId { get; set; } = string.Empty;
}