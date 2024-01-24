using Fluxus.Domain.Models;
using Fluxus.Domain.ViewModels;
using Fluxus.Domain.Contracts.Databases;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Fluxus.App.Services
{
    public class ServiceOrderService
    {

        private readonly IServiceOrderRepository _repository;


        public ServiceOrderService(IServiceOrderRepository repository)
            => _repository = repository;


        public OperationResult<int> Insert(Order serviceOrder)
        {
            if (serviceOrder == null)
                return OperationResult<int>.FailureResult("Não foi possível incluir a ordem de serviço!");

            if (string.IsNullOrEmpty(serviceOrder.ReferenceCode) || 
                serviceOrder.ReferenceCode == "../..." ||
                string.IsNullOrEmpty(serviceOrder.ServiceId) ||
                string.IsNullOrEmpty(serviceOrder.ProfessionalId))
                return OperationResult<int>.FailureResult("Campos com * são obrigatório");

            int id = _repository.Insert(serviceOrder);
            if (id == 0)
                return OperationResult<int>.FailureResult("Não foi possível inserir a ordem de serviço na base de dados!");
            
            return OperationResult<int>.SuccessResult(id);
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

        public OperationResult Delete(int id)
        {
            var order = _repository.GetById(id);

            if (order.Invoiced)
                return OperationResult.FailureResult("Não é possível excluir uma Ordem de Serviço já faturada!");

            if (!_repository.Delete(id))
                return OperationResult.FailureResult("Não é possível excluir a Ordem de Serviço!");

            return OperationResult.SuccessResult();
        }

        public OperationResult<Order> GetById(int id)
        {
            var serviceOrder = _repository.GetById(id);

            if (serviceOrder == null)
                return OperationResult<Order>.FailureResult("Não foi possível encontrar a Ordem de Serviço!");

            return OperationResult<Order>.SuccessResult(serviceOrder);
        }

        public OperationResult<List<OrdersOpenViewModel>> GetOrdensDoFluxo()
        {
            var orders = _repository.GetIndexOpen();
            if (orders == null)
                return OperationResult<List<OrdersOpenViewModel>>.FailureResult("Não foi possível encontrar as Ordens de Serviço na base dados!");

            return OperationResult<List<OrdersOpenViewModel>>.SuccessResult(orders);
        }

        public OperationResult<List<OrdersIndexViewModel>> GetOpenDone()
        {
            var orders = _repository.GetOpenDone();
            if (orders == null)
                return OperationResult<List<OrdersIndexViewModel>>.FailureResult("Não foi possível encontrar as Ordens de Serviço na base dados!");

            return OperationResult<List<OrdersIndexViewModel>>.SuccessResult(orders);
        }

        public OperationResult<List<OrdersIndexViewModel>> GetOrdensFaturadasDoCodigo(int invoiceId)
        { 
            var orders =_repository.GetClosedByInvoiceId(invoiceId);
            if (orders == null)
                return OperationResult<List<OrdersIndexViewModel>>.FailureResult("Não foi possível encontrar as Ordens de Serviço na base dados!");

            return OperationResult<List<OrdersIndexViewModel>>.SuccessResult(orders);
        }

        public OperationResult<List<OrdersIndexViewModel>> GetOrdensComFiltro(string filter)
        { 
            var orders = _repository.GetFiltered(filter);
            if (orders == null)
                return OperationResult<List<OrdersIndexViewModel>>.FailureResult("Não foi possível encontrar as Ordens de Serviço na base dados!");

            return OperationResult<List<OrdersIndexViewModel>>.SuccessResult(orders);
        }

        public OperationResult<List<ProfessionalNameId>> GetProfessionalByInvoiceId(int invoiceId)
        { 
            var professionals = _repository.GetProfessionalByInvoiceId(invoiceId);
            if (professionals == null)
                return OperationResult<List<ProfessionalNameId>>.FailureResult("Não foi possível encontrar nenhuma profissional na base dados!");

            return OperationResult<List<ProfessionalNameId>>.SuccessResult(professionals);
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

        public OperationResult UpdateInvoiceId(int invoiceId, List<int> orders)
        {
            var updated = _repository.UpdateInvoiceId(invoiceId, orders);
            if (!updated)
                return OperationResult.FailureResult("Não foi possível atualizar as Ordens de Serviço!");

            return OperationResult.SuccessResult();
        }

        public async Task UpdateStatus(int id, string status)
        { 
            await Task.Run(() => _repository.UpdateStatus(id, status)); 
        }

    }

}
