using Fluxus.Core.Models;

namespace Fluxus.Core.Dtos.Services;

public record ServiceUpdateRequest
{
    public long Id { get; set; }
    public string Tag { get; set; } = string.Empty;
    public string? Description { get; set; }
    public double ServiceAmount { get; set; }
    public double MileageAllowance { get; set; }

    public ServiceUpdateRequest(Service service)
    {
        Id = service.Id;
        Tag = service.Tag;
        Description = service.Description;
        ServiceAmount = service.ServiceAmount;
        MileageAllowance = service.MileageAllowance;

    }

    public ServiceUpdateRequest() {}
}