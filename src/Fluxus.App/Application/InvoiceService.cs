using Fluxus.Domain.Entities;
using Fluxus.Domain.Enums;
using Fluxus.Domain.Interfaces;
using Fluxus.Infra.Services;
using System.Collections.Generic;
using System.Data;


namespace Fluxus.App
{
    public class InvoiceService
    {

        private IInvoiceRepository _repository;
        public Invoice Invoice { get; set; }


        public string Message { get; private set; }



        public InvoiceService(IInvoiceRepository repository)
            => _repository = repository;



        public int Execute(EnumMethod method)
        {
            if (Invoice == null || !IsValid())
                return 0;

            if (method == EnumMethod.Update)
                return Update();
            else
                return Insert();
        }

        public int Insert()
        {
            if (Invoice != null)
                return _repository.Insert(Invoice);

            Message = "Não foi possível incluir a fatura";
            return 0;
        }

        private int Update()
        {
            if (Invoice != null && _repository.Update(Invoice))
                return 1;

            Message = "Não foi possível alterar a fatura!";
            return 0;
        }

        private bool IsValid()
        {
            var invoiceDescription = _repository.GetDescription(Invoice.Id);
            var invoiceExists = !string.IsNullOrWhiteSpace(invoiceDescription);

            if (Invoice.Id == 0 && invoiceExists)
            {
                Message = "Fatura já cadastrada.";
                return false;
            }

            return true;
        }

        public bool Delete(int id)
        {
            if (_repository.Delete(id))
                return true;

            Message = "Não foi possível excluir a fatura!";
            return false;
        }

        public string GetDescription(int id)
            => _repository.GetDescription(id);

        public List<Invoice> GetAll()
            => _repository.GetAll();

        public void PrintPDF(System.Drawing.Image logo, Profile profile, DataTable professionals, DataTable serviceOrders, string path)
            => new ReportService().PrintPDF(logo, profile, professionals, serviceOrders, path);

        public bool RemoveOrder(int idServiceOrder, Invoice invoice)
        {
            new ServiceOrderApp().UpdateFaturaCod(idServiceOrder, 0);
            Invoice = invoice;
            int response = Execute(EnumMethod.Update);

            if (response > 0)
                return true;
            
            Message = "Não foi possível remover a Ordem de Serviço";
            return false;
        }
    }
}