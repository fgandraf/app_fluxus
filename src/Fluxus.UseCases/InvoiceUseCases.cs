﻿using Fluxus.Core.Models;
using Fluxus.Core;
using Fluxus.Core.Contracts.Databases;
using System.Collections.Generic;

namespace Fluxus.UseCases
{
    public class InvoiceUseCases
    {

        private readonly IInvoiceRepository _invoiceRepository;
        private readonly IOrderRepository _serviceOrderRepository;


        public InvoiceUseCases(IInvoiceRepository invoiceRepository, IOrderRepository serviceOrderRepository)
        {
            _invoiceRepository = invoiceRepository;
            _serviceOrderRepository = serviceOrderRepository;
        }


        public OperationResult<int> Insert(Invoice invoice)
        {
            if (invoice == null)
                return OperationResult<int>.FailureResult("Não foi possível incluir a fatura!");

            if (GetDescription(invoice.Id).Success)
                return OperationResult<int>.FailureResult("Fatura já cadastrada!");

            int id = _invoiceRepository.Insert(invoice);
            if (id == 0)
                return OperationResult<int>.FailureResult("Não foi possível inserir a fatura na base de dados!");

            return OperationResult<int>.SuccessResult(id);
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

        public OperationResult<string> GetDescription(int id)
        {
            var description = _invoiceRepository.GetDescription(id);
            if (string.IsNullOrEmpty(description))
                return OperationResult<string>.FailureResult("Não foi possível excluir a fatura!");

            return OperationResult<string>.SuccessResult(description);
        }

        public OperationResult<List<Invoice>> GetAll()
        {
            var result = _invoiceRepository.GetAll();

            if (result == null)
                return OperationResult<List<Invoice>>.FailureResult("Não foi possível encontrar faturas na base dados!");

            return OperationResult<List<Invoice>>.SuccessResult(result);
        }

        public OperationResult RemoveOrder(int idServiceOrder, Invoice invoice)
        {
            var serviceOrder = new List<int>();
            serviceOrder.Add(idServiceOrder);

            var serviceOrderUpdated = _serviceOrderRepository.UpdateInvoiceId(0, serviceOrder);
            var invoiceUpdated = Update(invoice);

            if (!invoiceUpdated.Success && !serviceOrderUpdated)
                return OperationResult.FailureResult("Não foi possível remover a Ordem de Serviço");

            return OperationResult.SuccessResult();
        }
    }
}