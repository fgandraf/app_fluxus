using System;

namespace Fluxus.Core.Dtos.Invoices;

public record InvoiceCreateRequest
{
    public string Description { get; set; } = string.Empty;
    public DateTime IssueDate { get; set; }
    public double SubtotalService { get; set; }
    public double SubtotalMileage { get; set; }
    public double Total {  get; set; }
}

