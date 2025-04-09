using System;

namespace Fluxus.Core.Dtos.Professionals;

public record ProfessionalUpdateRequest
(
    long Id,
    string Tag,
    string Name,
    string Cpf,
    DateTime Birthday,
    string Profession,
    string PermitNumber,
    string Association,
    string Phone1,
    string Phone2,
    string Email
);