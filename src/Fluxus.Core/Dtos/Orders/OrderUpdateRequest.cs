using System;

namespace Fluxus.Core.Dtos.Orders;

public record OrderUpdateRequest
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
    int Status,
    DateTime PendingDate,
    DateTime SurveyDate,
    DateTime DoneDate,
    string Comments,
    bool Invoiced,
    long InvoiceId
);