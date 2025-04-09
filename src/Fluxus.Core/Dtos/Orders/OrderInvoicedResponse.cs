using System;

namespace Fluxus.Core.Dtos.Orders;

public record OrderInvoicedResponse
(
    long Id,
    DateTime OrderDate,
    string ReferenceCode,
    long ProfessionalId,
    string Professional,
    string Service,
    string City,
    string CustomerName,
    DateTime SurveyDate,
    DateTime DoneDate,
    long InvoiceId,
    double ServiceAmount,
    double MileageAllowance
);