using Fluxus.Domain;
using Fluxus.Domain.Entities;
using Fluxus.Domain.Interfaces;
using System.Collections.Generic;
using System.Data;

//WIP

namespace Fluxus.App.Services
{
    public class InvoiceService
    {

        private IInvoiceRepository _repository;
        private IServiceOrderRepository _serviceOrderRepository;
        public Invoice Invoice { get; set; }


        public string Message { get; private set; }



        public InvoiceService(IInvoiceRepository repository, IServiceOrderRepository serviceOrderRepository)
        { 
            _repository = repository; 
            _serviceOrderRepository = serviceOrderRepository;
        }


        public OperationResult Insert()
        {
            if (Invoice == null || !IsValid())
                return OperationResult.FailureResult("Não foi possível incluir a fatura\n" + Invoice?.Message);


            int id = _repository.Insert(Invoice);
            return OperationResult.SuccessResult(id);
        }

        public OperationResult Update()
        {
            if (Invoice == null || !IsValid() || _repository.Update(Invoice))
                return OperationResult.FailureResult("Não foi possível alterar a fatura!\n" + Invoice?.Message);

            return OperationResult.SuccessResult();
        }

        private bool IsValid()
        {
            int id = (int)(Invoice.Id != null ? Invoice.Id : 0);
            var invoiceDescription = _repository.GetDescription(id);
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
            _serviceOrderRepository.UpdateInvoiceId(idServiceOrder, 0);
            
            Invoice = invoice;

            var response = Update();

            if (response.Success)
                return true;
            
            Message = "Não foi possível remover a Ordem de Serviço";
            return false;
        }
    }
}