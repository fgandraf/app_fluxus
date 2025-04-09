namespace Fluxus.Core.Dtos.Professionals;

public record ProfessionalIndexResponse
{
    public long Id { get; set; }
    public string Tag {  get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Profession { get; set; } = string.Empty;
    public string Phone1 { get; set; } = string.Empty;
};