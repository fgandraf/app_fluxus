namespace Fluxus.Core.Dtos.Services;

public record ServiceResponse
{
    public long Id { get; set; }
    public string Tag { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public double ServiceAmount { get; set; }
    public double MileageAllowance { get; set; }
};