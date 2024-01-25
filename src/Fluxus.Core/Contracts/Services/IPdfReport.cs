using Fluxus.Core.ViewModels;

namespace Fluxus.Core.Contracts.Services;

public interface IPdfReport
{
    void PrintPdf(PdfReportViewModel model);

}
