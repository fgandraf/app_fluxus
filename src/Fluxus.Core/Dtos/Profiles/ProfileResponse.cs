using System;

namespace Fluxus.Core.Dtos.Profiles;

public record ProfileResponse
(
    long Id,
    string Cnpj,
    string TradingName,
    string CompanyName,
    string StateId,
    string CityId,
    string Address,
    string Complement,
    string District,
    string City,
    string Zip,
    string State,
    DateTime EstablishmentDate,
    string Phone1,
    string Phone2,
    string Email,
    string BankAccountName,
    string BankAccountType,
    string BankAccountBranch,
    string BankAccountDigit,
    string BankAccountNumber,
    string ContractorName,
    string ContractNotice,
    string ContractNumber,
    DateTime ContractEstablished,
    DateTime ContractStart,
    DateTime ContractEnd,
    string logo
);