using Fluxus.Core.Models;
using Fluxus.Core;
using Fluxus.Core.ViewModels;
using Fluxus.Core.Contracts.Databases;
using System.Collections.Generic;

namespace Fluxus.UseCases
{
    public class ServiceUseCases
    {

        private readonly IServiceRepository _repository;


        public ServiceUseCases(IServiceRepository repository)
            => _repository = repository;


        public OperationResult<int> Insert(Service service)
        {
            if (service == null)
                return OperationResult<int>.FailureResult("Não foi possível incluir a atividade!");

            if (string.IsNullOrEmpty(service.Tag))
                return OperationResult<int>.FailureResult("Campos com * são obrigatório");

            int id = _repository.Insert(service);
            if (id == 0)
                return OperationResult<int>.FailureResult("Não foi possível inserir a atividade na base de dados!");

            return OperationResult<int>.SuccessResult(id);
        }

        public OperationResult Update(Service service)
        {
            if (service == null)
                return OperationResult.FailureResult("Não foi possível alterar a atividade!");

            if (string.IsNullOrEmpty(service.Tag))
                return OperationResult<int>.FailureResult("Campos com * são obrigatório");

            if (!_repository.Update(service))
                return OperationResult.FailureResult("Não foi possível alterar a atividade na base de dados!");

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

        public OperationResult<List<ServicesIndexViewModel>> GetAll(bool addHeader)
        {
            var services = _repository.GetAll();

            if (services == null)
                return OperationResult<List<ServicesIndexViewModel>>.FailureResult("Não foi possível encontrar atividades na base de dados!");

            if (addHeader)
                services.Insert(0, new ServicesIndexViewModel { Tag = "--TODAS--" });

            return OperationResult<List<ServicesIndexViewModel>>.SuccessResult(services);

        }

    }
}
