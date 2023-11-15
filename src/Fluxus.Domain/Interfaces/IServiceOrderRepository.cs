using Fluxus.Domain.Entities;
using Fluxus.Domain.Records;
using System.Collections.Generic;


namespace Fluxus.Domain.Interfaces
{
    public interface IServiceOrderRepository
    {
        public int Insert(ServiceOrder body);

        public bool Update(ServiceOrder body);

        public bool UpdateInvoiceId(int id, int invoiceId);

        public void UpdateStatus(int id, string status);

        public bool Delete(long id);

        public List<ServiceOrderOpen> GetIndexOpen();

        public List<string> GetCitiesFromOrders();

        public ServiceOrder GetById(int id);

        public List<ServiceOrderIndex> GetOpenDone();

        public List<ServiceOrderIndex> GetFiltered(string filter);

        public List<ServiceOrderIndex> GetClosedByInvoiceId(int invoiceId);

        public List<ProfessionalNameId> GetProfessionalByInvoiceId(int invoiceId);
    }
}
