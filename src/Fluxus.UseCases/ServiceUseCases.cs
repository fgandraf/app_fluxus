using Fluxus.Core.Models;
using Fluxus.Core;
using Fluxus.Core.Contracts.Databases;
using System.Collections.Generic;
using Fluxus.Core.Dtos.Services;

namespace Fluxus.UseCases
{
    public class ServiceUseCases
    {

        private readonly IServiceRepository _repository;


        public ServiceUseCases(IServiceRepository repository)
            => _repository = repository;


        public OperationResult<long> Insert(Service service)
        {
            if (service == null)
                return OperationResult<long>.FailureResult("Não foi possível incluir a atividade!");

            if (string.IsNullOrEmpty(service.Tag))
                return OperationResult<long>.FailureResult("Campos com * são obrigatório");

            var id = _repository.Insert(service);
            if (id == 0)
                return OperationResult<long>.FailureResult("Não foi possível inserir a atividade na base de dados!");

            return OperationResult<long>.SuccessResult(id);
        }

        public OperationResult Update(Service service)
        {
            if (service == null)
                return OperationResult.FailureResult("Não foi possível alterar a atividade!");

            if (string.IsNullOrEmpty(service.Tag))
                return OperationResult<long>.FailureResult("Campos com * são obrigatório");

            if (!_repository.Update(service))
                return OperationResult.FailureResult("Não foi possível alterar a atividade na base de dados!");

            return OperationResult.SuccessResult();
        }

        public OperationResult Delete(long id)
        {
            if (!_repository.Delete(id))
                return OperationResult.FailureResult("Não foi possível excluir a atividade!");

            return OperationResult.SuccessResult();
        }

        public OperationResult<Service> GetById(long id)
        {
            var service = _repository.GetById(id);

            if (service == null)
                return OperationResult<Service>.FailureResult("Não foi possível encontrar a atividade!");

            return OperationResult<Service>.SuccessResult(service);
        }

        public OperationResult<List<ServiceResponse>> GetAll(bool addHeader)
        {
            var services = _repository.GetAll();

            if (services == null)
                return OperationResult<List<ServiceResponse>>.FailureResult("Não foi possível encontrar atividades na base de dados!");

            if (addHeader)
                services.Insert(0, new ServiceResponse { Tag = "--TODAS--" });

            return OperationResult<List<ServiceResponse>>.SuccessResult(services);

        }

    }
}
