﻿namespace Fluxus.Core.Dtos.Branches;

public record BranchUpdateRequest
(
    string Id,
    string Name,
    string Address,
    string Complement,
    string District,
    string City,
    string Zip,
    string State,
    string ContactName,
    string Phone1,
    string Phone2,
    string Email
);