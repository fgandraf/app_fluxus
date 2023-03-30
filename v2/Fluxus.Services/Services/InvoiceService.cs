using Fluxus.Domain.Entities;
using Fluxus.Infra.Repositories;
using System.Data;


namespace Fluxus.Services
{
    public class InvoiceService
    {

        public int Insert(Invoice body)
            => new InvoiceRepository().Insert(body);


        public void Update(Invoice body)
            => new InvoiceRepository().Update(body);


        public void Delete(int id)
            => new InvoiceRepository().Delete(id);


        public string GetDescription(int id)
            => new InvoiceRepository().GetDescription(id);


        public DataTable GetAll()
            => new InvoiceRepository().GetAll();


        public void PrintPDF(System.Drawing.Image logo, Profile profile, DataTable professionals, DataTable serviceOrders, string path)
            => new ReportRepository().PrintPDF(logo, profile, professionals, serviceOrders, path);


        public bool RemoveOrder(int idServiceOrder, Invoice invoice)
        {
            new ServiceOrderService().UpdateFaturaCod(idServiceOrder, 0);
            new InvoiceService().Update(invoice);
            return true;
        }
    }

}