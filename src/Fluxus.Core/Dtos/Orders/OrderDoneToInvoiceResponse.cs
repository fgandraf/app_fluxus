using System;

namespace Fluxus.Core.Dtos.Orders;

public record OrderDoneToInvoiceResponse
(
    long Id,
    DateTime OrderDate,
    string ReferenceCode,
    string Professional,
    string Service,
    string City,
    string CustomerName,
    DateTime SurveyDate,
    DateTime DoneDate,
    double ServiceAmount,
    double MileageAllowance
);
