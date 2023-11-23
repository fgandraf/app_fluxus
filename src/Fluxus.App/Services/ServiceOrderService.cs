using Fluxus.Domain;
using Fluxus.Domain.Entities;
using Fluxus.Domain.Interfaces;
using Fluxus.Domain.Records;
using System.Collections.Generic;
using System.Threading.Tasks;


//WIP

namespace Fluxus.App.Services
{
    public class ServiceOrderService
    {

        private IServiceOrderRepository _repository;
        public ServiceOrder ServiceOrder { get; set; }


        public string Message { get; private set; }



        public ServiceOrderService(IServiceOrderRepository repository)
            => _repository = repository;



        public OperationResult Insert()
        {
            if (ServiceOrder == null || !ServiceOrder.IsValid)
                return OperationResult.FailureResult("Não foi possível incluir a ordem de serviço: " + ServiceOrder?.Message);

            int id = _repository.Insert(ServiceOrder);
            return OperationResult.SuccessResult(id);
        }

        public OperationResult Update()
        {
            if (ServiceOrder == null || !ServiceOrder.IsValid || !_repository.Update(ServiceOrder))
                return OperationResult.FailureResult("Não foi possível alterar a ordem de serviço!\n" + ServiceOrder?.Message);

            return OperationResult.SuccessResult();
        }

        public void UpdateFaturaCod(int id, int invoiceId)
            => _repository.UpdateInvoiceId(id, invoiceId);

        public async Task UpdateStatus(int id, string status)
            => await Task.Run(() => _repository.UpdateStatus(id, status));

        public bool Delete(int id)
        {
            var order = GetBy(id);
            if (order.Invoiced)
            {
                Message = "Não é possível excluir uma Ordem de Serviço já faturada!";
                return false;
            }

            if (_repository.Delete(id))
                return true;


            Message = "Não é possível excluir a Ordem de Serviço!";
            return false;
        }

        public List<ServiceOrderOpen> GetOrdensDoFluxo()
            => _repository.GetIndexOpen();

        public List<ServiceOrderIndex> GetOrdensConcluidasNaoFaturadas()
            => _repository.GetOpenDone();

        public List<ServiceOrderIndex> GetOrdensFaturadasDoCodigo(int invoiceId)
            => _repository.GetClosedByInvoiceId(invoiceId);

        public List<ServiceOrderIndex> GetOrdensComFiltro(string filter)
            => _repository.GetFiltered(filter);

        public List<ProfessionalNameId> GetProfessionalByInvoiceId(int invoiceId)
            => _repository.GetProfessionalByInvoiceId(invoiceId);
            
        public List<string> GetCitiesFromOrders(bool addHeader)
        {
            var cities = _repository.GetCitiesFromOrders();

            if (addHeader)
                cities.Insert(0, "--TODAS--");

            return cities;
        }

        public ServiceOrder GetBy(int id)
            => _repository.GetById(id);

    }

}
