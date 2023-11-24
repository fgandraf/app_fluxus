using Fluxus.Domain;
using Fluxus.Domain.Entities;
using Fluxus.Domain.Interfaces;
using System.Threading.Tasks;

namespace Fluxus.App.Services
{
    public class ServiceOrderService
    {

        private IServiceOrderRepository _repository;


        public ServiceOrderService(IServiceOrderRepository repository)
            => _repository = repository;


        public OperationResult Insert(ServiceOrder serviceOrder)
        {
            if (serviceOrder == null || !serviceOrder.IsValid)
                return OperationResult.FailureResult("Não foi possível incluir a ordem de serviço!");

            int id = _repository.Insert(serviceOrder);
            return OperationResult.SuccessResult(id);
        }

        public OperationResult Update(ServiceOrder serviceOrder)
        {
            if (serviceOrder == null || !serviceOrder.IsValid || !_repository.Update(serviceOrder))
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

        public OperationResult GetById(int id)
        {
            var serviceOrder = _repository.GetById(id);

            if (serviceOrder == null)
                return OperationResult.FailureResult("Não foi possível encontrar a Ordem de Serviço!");

            return OperationResult.SuccessResult(serviceOrder);
        }

        public OperationResult GetOrdensDoFluxo()
        {
            var orders = _repository.GetIndexOpen();
            if (orders == null)
                return OperationResult.FailureResult("Não foi possível encontrar as Ordens de Serviço na base dados!");

            return OperationResult.SuccessResult(orders);
        }

        public OperationResult GetOpenDone()
        {
            var orders = _repository.GetOpenDone();
            if (orders == null)
                return OperationResult.FailureResult("Não foi possível encontrar as Ordens de Serviço na base dados!");

            return OperationResult.SuccessResult(orders);
        }

        public OperationResult GetOrdensFaturadasDoCodigo(int invoiceId)
        { 
            var orders =_repository.GetClosedByInvoiceId(invoiceId);
            if (orders == null)
                return OperationResult.FailureResult("Não foi possível encontrar as Ordens de Serviço na base dados!");

            return OperationResult.SuccessResult(orders);
        }

        public OperationResult GetOrdensComFiltro(string filter)
        { 
            var orders = _repository.GetFiltered(filter);
            if (orders == null)
                return OperationResult.FailureResult("Não foi possível encontrar as Ordens de Serviço na base dados!");

            return OperationResult.SuccessResult(orders);
        }

        public OperationResult GetProfessionalByInvoiceId(int invoiceId)
        { 
            var professionals = _repository.GetProfessionalByInvoiceId(invoiceId);
            if (professionals == null)
                return OperationResult.FailureResult("Não foi possível encontrar nenhuma profissional na base dados!");

            return OperationResult.SuccessResult(professionals);
        }

        public OperationResult GetCitiesFromOrders(bool addHeader)
        {
            var cities = _repository.GetCitiesFromOrders();
            
            if (cities == null)
                return OperationResult.FailureResult("Não foi possível encontrar nenhuma cidade na base dados!");

            if (addHeader)
                cities.Insert(0, "--TODAS--");

            return OperationResult.SuccessResult(cities);
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
