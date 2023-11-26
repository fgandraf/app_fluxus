using Fluxus.Domain.Entities;
using Fluxus.Infra.Interfaces;
using Fluxus.Infra.Records;
using System.Collections.Generic;

namespace Fluxus.App.Services
{
    public class ServiceService
    {

        private IServiceRepository _repository;


        public ServiceService(IServiceRepository repository)
            => _repository = repository;


        public OperationResult<int> Insert(Service service)
        {
            if (service == null || !service.IsValid)
                return OperationResult<int>.FailureResult("Não foi possível incluir a atividade!");

            int id = _repository.Insert(service);
            return OperationResult<int>.SuccessResult(id);
        }

        public OperationResult Update(Service service)
        {
            if (service == null || !service.IsValid || !_repository.Update(service))
                return OperationResult.FailureResult("Não foi possível alterar a atividade!");

            return OperationResult.SuccessResult();
        }

        public OperationResult Delete(int id)
        {
            if (!_repository.Delete(id))
                return OperationResult.FailureResult("Não foi possível excluir a atividade!");

            return OperationResult.SuccessResult();
        }

        public OperationResult<Service> GetById(int id)
        {
            var service = _repository.GetById(id);

            if (service == null)
                return OperationResult<Service>.FailureResult("Não foi possível encontrar a atividade!");

            return OperationResult<Service>.SuccessResult(service);
        }

        public OperationResult<List<ServiceIndex>> GetAll(bool addHeader)
        {
            var services = _repository.GetAll();

            if (services == null)
                return OperationResult<List<ServiceIndex>>.FailureResult("Não foi possível encontrar atividades na base de dados!");

            if (addHeader)
                services.Insert(0, new ServiceIndex { Tag = "--TODAS--" });
            
            return OperationResult<List<ServiceIndex>>.SuccessResult(services);

        }

    }
}
