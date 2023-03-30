using Fluxus.Domain.Entities;
using Fluxus.Infra.Repositories;
using Fluxus.Infra.Services;
using System.Data;


namespace Fluxus.App
{
    public class InvoiceApp
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
            => new ReportService().PrintPDF(logo, profile, professionals, serviceOrders, path);


        public bool RemoveOrder(int idServiceOrder, Invoice invoice)
        {
            new ServiceOrderApp().UpdateFaturaCod(idServiceOrder, 0);
            new InvoiceApp().Update(invoice);
            return true;
        }
    }

}