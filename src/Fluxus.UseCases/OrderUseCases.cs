﻿using Fluxus.Core.Models;
using Fluxus.Core;
using Fluxus.Core.Contracts.Databases;
using System.Collections.Generic;
using System.Threading.Tasks;
using Fluxus.Core.Dtos.Orders;
using Fluxus.Core.Dtos.Professionals;

namespace Fluxus.UseCases
{
    public class OrderUseCases
    {

        private readonly IOrderRepository _repository;


        public OrderUseCases(IOrderRepository repository)
            => _repository = repository;


        public OperationResult<long> Insert(Order serviceOrder)
        {
            if (serviceOrder == null)
                return OperationResult<long>.FailureResult("Não foi possível incluir a ordem de serviço!");

            if (string.IsNullOrEmpty(serviceOrder.ReferenceCode) ||
                serviceOrder.ReferenceCode == "../..." ||
                string.IsNullOrEmpty(serviceOrder.ServiceId) ||
                string.IsNullOrEmpty(serviceOrder.ProfessionalId))
                return OperationResult<long>.FailureResult("Campos com * são obrigatório");

            var id = _repository.Insert(serviceOrder);
            if (id == 0)
                return OperationResult<long>.FailureResult("Não foi possível inserir a ordem de serviço na base de dados!");

            return OperationResult<long>.SuccessResult(id);
        }

        public OperationResult Update(Order serviceOrder)
        {
            if (serviceOrder == null)
                return OperationResult<int>.FailureResult("Não foi possível incluir a ordem de serviço!");

            if (string.IsNullOrEmpty(serviceOrder.ReferenceCode) ||
                serviceOrder.ReferenceCode == "../..." ||
                string.IsNullOrEmpty(serviceOrder.ServiceId) ||
                string.IsNullOrEmpty(serviceOrder.ProfessionalId))
                return OperationResult<int>.FailureResult("Campos com * são obrigatório");

            if (!_repository.Update(serviceOrder))
                return OperationResult.FailureResult("Não foi possível alterar a ordem de serviço!");

            return OperationResult.SuccessResult();
        }

        public OperationResult Delete(long id)
        {
            var order = _repository.GetById(id);

            if (order.Invoiced)
                return OperationResult.FailureResult("Não é possível excluir uma Ordem de Serviço já faturada!");

            if (!_repository.Delete(id))
                return OperationResult.FailureResult("Não é possível excluir a Ordem de Serviço!");

            return OperationResult.SuccessResult();
        }

        public OperationResult<Order> GetById(long id)
        {
            var serviceOrder = _repository.GetById(id);

            if (serviceOrder == null)
                return OperationResult<Order>.FailureResult("Não foi possível encontrar a Ordem de Serviço!");

            return OperationResult<Order>.SuccessResult(serviceOrder);
        }

        public OperationResult<List<OrderFlowResponse>> GetOrdensDoFluxo()
        {
            var orders = _repository.GetIndexOpen();
            
            if (orders == null)
                return OperationResult<List<OrderFlowResponse>>.FailureResult("Não foi possível encontrar as Ordens de Serviço na base dados!");

            return OperationResult<List<OrderFlowResponse>>.SuccessResult(orders);
        }

        public OperationResult<List<OrderDoneToInvoiceResponse>> GetOpenDone()
        {
            var orders = _repository.GetOpenDone();
            if (orders == null)
                return OperationResult<List<OrderDoneToInvoiceResponse>>.FailureResult("Não foi possível encontrar as Ordens de Serviço na base dados!");

            return OperationResult<List<OrderDoneToInvoiceResponse>>.SuccessResult(orders);
        }

        public OperationResult<List<OrderInvoicedResponse>> GetOrdensFaturadasDoCodigo(long invoiceId)
        {
            var orders = _repository.GetClosedByInvoiceId(invoiceId);
            if (orders == null)
                return OperationResult<List<OrderInvoicedResponse>>.FailureResult("Não foi possível encontrar as Ordens de Serviço na base dados!");

            return OperationResult<List<OrderInvoicedResponse>>.SuccessResult(orders);
        }

        public OperationResult<List<OrderFilteredResponse>> GetOrdensComFiltro(OrderFilterRequest filter)
        {
            var orders = _repository.GetFiltered(filter);
            if (orders == null)
                return OperationResult<List<OrderFilteredResponse>>.FailureResult("Não foi possível encontrar as Ordens de Serviço na base dados!");

            return OperationResult<List<OrderFilteredResponse>>.SuccessResult(orders);
        }

        public OperationResult<List<ProfessionalTagNameIdResponse>> GetProfessionalByInvoiceId(long invoiceId)
        {
            var professionals = _repository.GetProfessionalByInvoiceId(invoiceId);
            if (professionals == null)
                return OperationResult<List<ProfessionalTagNameIdResponse>>.FailureResult("Não foi possível encontrar nenhuma profissional na base dados!");

            return OperationResult<List<ProfessionalTagNameIdResponse>>.SuccessResult(professionals);
        }

        public OperationResult<List<string>> GetCitiesFromOrders(bool addHeader)
        {
            var cities = _repository.GetCitiesFromOrders();

            if (cities == null)
                return OperationResult<List<string>>.FailureResult("Não foi possível encontrar nenhuma cidade na base dados!");

            if (addHeader)
                cities.Insert(0, "--TODAS--");

            return OperationResult<List<string>>.SuccessResult(cities);
        }

        public OperationResult UpdateInvoiceId(long invoiceId, List<long> orders)
        {
            var updated = _repository.UpdateInvoiceId(invoiceId, orders);
            if (!updated)
                return OperationResult.FailureResult("Não foi possível atualizar as Ordens de Serviço!");

            return OperationResult.SuccessResult();
        }

        public async Task UpdateStatus(long id, int status)
        {
            await Task.Run(() => _repository.UpdateStatus(id, status));
        }

    }

}
