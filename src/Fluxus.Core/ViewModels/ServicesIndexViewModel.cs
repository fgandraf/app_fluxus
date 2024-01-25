
namespace Fluxus.Core.ViewModels;


public record ServicesIndexViewModel
{
    public int Id { get; set; }
    public string Tag { get; set; }
    public string Description { get; set; }
    public decimal ServiceAmount { get; set; }
    public decimal MileageAllowance { get; set; }
    
}
