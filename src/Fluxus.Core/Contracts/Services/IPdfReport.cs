using Fluxus.Core.Dtos;

namespace Fluxus.Core.Contracts.Services;

public interface IPdfReport
{
    void PrintPdf(PdfReportViewModel model);

}
