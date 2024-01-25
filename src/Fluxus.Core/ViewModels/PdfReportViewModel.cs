using System.Collections.Generic;

namespace Fluxus.Core.ViewModels;

public record PdfReportViewModel
{
    public byte[] Logo { get; set; } = new byte[0];
    public string CompanyName { get; set; } = string.Empty;
    public string Cnpj { get; set;} = string.Empty;
    public string ContractNotice { get; set; } = string.Empty;
    public string ContractNumber { get; set; } = string.Empty;

    public List<ProfessionalNameId> Professionals { get; set; } = new();
    public List<OrdersIndexViewModel> Orders { get; set; } = new();

    public string Path { get; set; } = string.Empty;
}
