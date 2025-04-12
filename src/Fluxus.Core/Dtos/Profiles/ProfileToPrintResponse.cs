namespace Fluxus.Core.Dtos.Profiles;

public record ProfileToPrintResponse
(
    string Cnpj,
    string CompanyName,
    string ContractNotice,
    string ContractNumber,
    string Logo
);