using Fluxus.Core.ViewModels;
using System.Collections.Generic;

namespace Fluxus.Core.Contracts.Services
{
    public interface IExcelReport
    {
        void ExportToExcel(List<OrdersIndexViewModel> serviceOrders);
    }
}
