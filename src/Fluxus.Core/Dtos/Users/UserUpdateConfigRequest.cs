namespace Fluxus.Core.Dtos.Users;

public record UserUpdateConfigRequest
(
    long Id,
    long ProfessionalId,
    bool TechnicianResponsible,
    bool LegalResponsible
);