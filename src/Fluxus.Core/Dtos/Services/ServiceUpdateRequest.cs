namespace Fluxus.Core.Dtos.Services;

public record ServiceUpdateRequest
(
    long Id,
    string Tag,
    string Description,
    double ServiceAmount,
    double MileageAllowance
);