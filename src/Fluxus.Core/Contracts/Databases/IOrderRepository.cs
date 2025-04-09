using Fluxus.Core.Dtos.Orders;
using Fluxus.Core.Dtos.Professionals;
using Fluxus.Core.Models;
using System.Collections.Generic;


namespace Fluxus.Core.Contracts.Databases;

public interface IOrderRepository
{
    public long Insert(Order body);

    public bool Update(Order body);

    bool UpdateInvoiceId(long invoiceId, List<long> orders);

    public void UpdateStatus(long id, int status);

    public bool Delete(long id);

    public List<OrderFlowResponse> GetIndexOpen();

    public List<string> GetCitiesFromOrders();

    public Order GetById(long id);

    public List<OrderDoneToInvoiceResponse> GetOpenDone();

    public List<OrderFilteredResponse> GetFiltered(OrderFilterRequest filter);

    public List<OrderInvoicedResponse> GetClosedByInvoiceId(long invoiceId);

    public List<ProfessionalTagNameIdResponse> GetProfessionalByInvoiceId(long invoiceId);
}
