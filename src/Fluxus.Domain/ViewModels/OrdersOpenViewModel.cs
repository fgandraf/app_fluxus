using Fluxus.Domain.Enums;

namespace Fluxus.Domain.ViewModels;

public record OrdersOpenViewModel
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public EStatus Status { get; set; }
    public string? ProfessionalId { get; set; }
}
