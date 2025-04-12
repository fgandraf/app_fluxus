using System;

namespace Fluxus.Core.Dtos.Invoices;
public record InvoiceResponse
(
    long Id,
    string Description,
    DateTime IssueDate,
    double SubtotalService,
    double SubtotalMileage,
    double Total
);