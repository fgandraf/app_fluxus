using Fluxus.Domain;
using Fluxus.Domain.Entities;
using Fluxus.Domain.Interfaces;
using Fluxus.Domain.Records;

namespace Fluxus.App.Services
{
    public class ServiceService
    {

        private IServiceRepository _repository;


        public ServiceService(IServiceRepository repository)
            => _repository = repository;


        public OperationResult Insert(Service service)
        {
            if (service == null || !service.IsValid)
                return OperationResult.FailureResult("Não foi possível incluir a atividade!");

            int id = _repository.Insert(service);
            return OperationResult.SuccessResult(id);
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

        public OperationResult GetById(int id)
        {
            var service = _repository.GetById(id);

            if (service == null)
                return OperationResult.FailureResult("Não foi possível encontrar a atividade!");

            return OperationResult.SuccessResult(service);
        }

        public OperationResult GetAll(bool addHeader)
        {
            var services = _repository.GetAll();

            if (services == null)
                return OperationResult.FailureResult("Não foi possível encontrar atividades na base de dados!");

            if (addHeader)
                services.Insert(0, new ServiceIndex { Tag = "--TODAS--" });
            
            return OperationResult.SuccessResult(services);

        }

    }
}
