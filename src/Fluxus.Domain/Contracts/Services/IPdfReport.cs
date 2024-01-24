using Fluxus.Domain.ViewModels;

namespace Fluxus.Domain.Contracts.Services;

public interface IPdfReport
{
    void PrintPdf(PdfReportViewModel model);

}
