﻿using System;

namespace Fluxus.Core.Dtos.Professionals;

public record ProfessionalCreateRequest
(
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