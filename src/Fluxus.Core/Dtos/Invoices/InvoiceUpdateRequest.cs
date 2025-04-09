namespace Fluxus.Core.Dtos.Invoices;

public record InvoiceUpdateRequest
(
    long Id,
    double SubtotalService,
    double SubtotalMileage,
    double Total
);