using Fluxus.Domain.Entities;
using Fluxus.Infra.Records;
using Fluxus.Infra.Repositories.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Fluxus.App.Services
{
    public class ServiceOrderService
    {

        private readonly IServiceOrderRepository _repository;


        public ServiceOrderService(IServiceOrderRepository repository)
            => _repository = repository;


        public OperationResult<int> Insert(ServiceOrder serviceOrder)
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

        public OperationResult Update(ServiceOrder serviceOrder)
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

        public OperationResult<ServiceOrder> GetById(int id)
        {
            var serviceOrder = _repository.GetById(id);

            if (serviceOrder == null)
                return OperationResult<ServiceOrder>.FailureResult("Não foi possível encontrar a Ordem de Serviço!");

            return OperationResult<ServiceOrder>.SuccessResult(serviceOrder);
        }

        public OperationResult<List<ServiceOrderOpen>> GetOrdensDoFluxo()
        {
            var orders = _repository.GetIndexOpen();
            if (orders == null)
                return OperationResult<List<ServiceOrderOpen>>.FailureResult("Não foi possível encontrar as Ordens de Serviço na base dados!");

            return OperationResult<List<ServiceOrderOpen>>.SuccessResult(orders);
        }

        public OperationResult<List<ServiceOrderIndex>> GetOpenDone()
        {
            var orders = _repository.GetOpenDone();
            if (orders == null)
                return OperationResult<List<ServiceOrderIndex>>.FailureResult("Não foi possível encontrar as Ordens de Serviço na base dados!");

            return OperationResult<List<ServiceOrderIndex>>.SuccessResult(orders);
        }

        public OperationResult<List<ServiceOrderIndex>> GetOrdensFaturadasDoCodigo(int invoiceId)
        { 
            var orders =_repository.GetClosedByInvoiceId(invoiceId);
            if (orders == null)
                return OperationResult<List<ServiceOrderIndex>>.FailureResult("Não foi possível encontrar as Ordens de Serviço na base dados!");

            return OperationResult<List<ServiceOrderIndex>>.SuccessResult(orders);
        }

        public OperationResult<List<ServiceOrderIndex>> GetOrdensComFiltro(string filter)
        { 
            var orders = _repository.GetFiltered(filter);
            if (orders == null)
                return OperationResult<List<ServiceOrderIndex>>.FailureResult("Não foi possível encontrar as Ordens de Serviço na base dados!");

            return OperationResult<List<ServiceOrderIndex>>.SuccessResult(orders);
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

        public OperationResult UpdateFaturaCod(int id, int invoiceId)
        {
            var updated = _repository.UpdateInvoiceId(id, invoiceId);
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
