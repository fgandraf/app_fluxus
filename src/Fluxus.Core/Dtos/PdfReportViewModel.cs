using Fluxus.Core.Dtos.Orders;
using Fluxus.Core.Dtos.Professionals;
using System.Collections.Generic;

namespace Fluxus.Core.Dtos;

public record PdfReportViewModel
{
    public byte[] Logo { get; set; } = new byte[0];
    public string CompanyName { get; set; } = string.Empty;
    public string Cnpj { get; set; } = string.Empty;
    public string ContractNotice { get; set; } = string.Empty;
    public string ContractNumber { get; set; } = string.Empty;

    public List<ProfessionalTagNameIdResponse> Professionals { get; set; } = new();
    public List<OrderInvoicedResponse> Orders { get; set; } = new();

    public string Path { get; set; } = string.Empty;
}
