using Fluxus.Core.Dtos.Orders;
using System.Collections.Generic;

namespace Fluxus.Core.Contracts.Services
{
    public interface IExcelReport
    {
        void ExportToExcel(List<OrderFilteredResponse> serviceOrders);
    }
}
