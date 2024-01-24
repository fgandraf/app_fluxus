using Fluxus.Domain.Models;
using Fluxus.Domain.ViewModels;
using System.Collections.Generic;


namespace Fluxus.Domain.Contracts.Databases;

public interface IServiceOrderRepository
{
    public int Insert(Order body);

    public bool Update(Order body);

    bool UpdateInvoiceId(int invoiceId, List<int> orders);

    public void UpdateStatus(int id, string status);

    public bool Delete(long id);

    public List<OrdersOpenViewModel> GetIndexOpen();

    public List<string> GetCitiesFromOrders();

    public Order GetById(int id);

    public List<OrdersIndexViewModel> GetOpenDone();

    public List<OrdersIndexViewModel> GetFiltered(string filter);

    public List<OrdersIndexViewModel> GetClosedByInvoiceId(int invoiceId);

    public List<ProfessionalNameId> GetProfessionalByInvoiceId(int invoiceId);
}
