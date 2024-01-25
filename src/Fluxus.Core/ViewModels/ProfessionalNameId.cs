
namespace Fluxus.Core.ViewModels;

public record ProfessionalNameId
{
    public int Id { get; set; }
    public int ProfessionalId
    {
        get => Id;
        set => Id = value;
    }
    public string? Tag { get; set; }
    public string? Nameid { get; set; }
}
