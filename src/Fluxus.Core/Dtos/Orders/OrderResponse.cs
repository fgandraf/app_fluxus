using Fluxus.Core.Enums;
using System;

namespace Fluxus.Core.Dtos.Orders;

public record OrderResponse
(
    long Id,
    string ReferenceCode,
    string BranchId,
    DateTime OrderDate,
    DateTime Deadline,
    long ProfessionalId,
    long ServiceId,
    double ServiceAmount,
    double MileageAllowance,
    bool Siopi,
    string CustomerName,
    string City,
    string ContactName,
    string ContactPhone,
    string Coordinates,
    EStatus Status,
    DateTime? PendingDate,
    DateTime? SurveyDate,
    DateTime? DoneDate,
    string Comments,
    long? InvoiceId,
    bool Invoiced
);