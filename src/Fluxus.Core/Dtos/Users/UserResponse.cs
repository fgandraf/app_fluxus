using Fluxus.Core.Enums;

namespace Fluxus.Core.Dtos.Users;

public record UserResponse
(
    long Id,
    string Email,
    long? ProfessionalId,
    bool Active,
    bool LegalResponsible,
    bool TechnicianResponsible,
    EUserRole Role
);