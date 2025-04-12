using Fluxus.Core.Models;

namespace Fluxus.Core.Dtos.Services;

public record ServiceCreateRequest
{
    public string Tag { get; set; } = string.Empty;
    public string? Description { get; set; }
    public double ServiceAmount { get; set; }
    public double MileageAllowance { get; set; }

    public ServiceCreateRequest(Service service)
    {
        Tag = service.Tag;
        Description = service.Description;
        ServiceAmount = service.ServiceAmount;
        MileageAllowance = service.MileageAllowance;
        
    }

    public ServiceCreateRequest() {}
}