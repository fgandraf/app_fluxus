namespace Fluxus.Core.Dtos.Services;

public record ServiceCreateRequest
(
    string Tag,
    string Description,
    double ServiceAmount,
    double MileageAllowance
);