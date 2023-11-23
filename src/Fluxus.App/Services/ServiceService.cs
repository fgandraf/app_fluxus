using Fluxus.Domain;
using Fluxus.Domain.Entities;
using Fluxus.Domain.Interfaces;
using Fluxus.Domain.Records;

//WIP

namespace Fluxus.App.Services
{
    public class ServiceService
    {

        private IServiceRepository _repository;
        public Service Service { get; set; }


        public string Message { get; private set; }



        public ServiceService(IServiceRepository repository)
            => _repository = repository;


        public OperationResult Insert()
        {
            if (Service == null || !Service.IsValid)
                return OperationResult.FailureResult("Não foi possível incluir a atividade!\n" + Service?.Message);


            int id = _repository.Insert(Service);
            return OperationResult.SuccessResult(id);
        }

        public OperationResult Update()
        {
            if (Service == null || !Service.IsValid || !_repository.Update(Service))
                return OperationResult.FailureResult("Não foi possível alterar a atividade!\n" + Service?.Message);

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
