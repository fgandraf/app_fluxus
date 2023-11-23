using Fluxus.Domain;
using Fluxus.Domain.Entities;
using Fluxus.Domain.Interfaces;

namespace Fluxus.App.Services
{
    public class InvoiceService
    {

        private IInvoiceRepository _invoiceRepository;
        private IServiceOrderRepository _serviceOrderRepository;


        public InvoiceService(IInvoiceRepository invoiceRepository, IServiceOrderRepository serviceOrderRepository)
        { 
            _invoiceRepository = invoiceRepository; 
            _serviceOrderRepository = serviceOrderRepository;
        }


        public OperationResult Insert(Invoice invoice)
        {
            if (invoice == null)
                return OperationResult.FailureResult("Não foi possível incluir a fatura!");

            if (GetDescription(invoice.Id).Success)
                return OperationResult.FailureResult("Fatura já cadastrada!");

            int id = _invoiceRepository.Insert(invoice);
            return OperationResult.SuccessResult(id);
        }

        public OperationResult Update(Invoice invoice)
        {
            if (invoice == null)
                return OperationResult.FailureResult("Não foi possível alterar a fatura!");

            if (!GetDescription(invoice.Id).Success)
                return OperationResult.FailureResult("Fatura não encontrada!");

            if (!_invoiceRepository.Update(invoice))
                return OperationResult.FailureResult("Não foi possível alterar a fatura!");

            return OperationResult.SuccessResult();
        }

        public OperationResult Delete(int id)
        {
            if (!_invoiceRepository.Delete(id))
                return OperationResult.FailureResult("Não foi possível excluir a fatura!");

            return OperationResult.SuccessResult();
        }

        public OperationResult GetDescription(int id)
        {
            var description = _invoiceRepository.GetDescription(id);
            if (string.IsNullOrEmpty(description))
                return OperationResult.FailureResult("Não foi possível excluir a fatura!");

            return OperationResult.SuccessResult(description);
        }

        public OperationResult GetAll()
        { 
            var result = _invoiceRepository.GetAll(); 

            if (result == null)
                return OperationResult.FailureResult("Não foi possível encontrar faturas na base dados!");

            return OperationResult.SuccessResult(result);
        }

        public OperationResult RemoveOrder(int idServiceOrder, Invoice invoice)
        {
            var serviceOrderUpdated = _serviceOrderRepository.UpdateInvoiceId(idServiceOrder, 0);
            var invoiceUpdated = Update(invoice);

            if (!invoiceUpdated.Success && !serviceOrderUpdated)
                return OperationResult.FailureResult("Não foi possível remover a Ordem de Serviço");

            return OperationResult.SuccessResult();
        }
    }
}