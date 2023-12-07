using Fluxus.Domain.Entities;
using Fluxus.Infra.Records;
using Fluxus.Infra.Repositories.Contracts;
using System.Collections.Generic;

namespace Fluxus.App.Services
{
    public class ProfessionalService
    {

        private readonly IProfessionalRepository _repository;
        public Professional Professional { get; set; }
      
        
        public ProfessionalService(IProfessionalRepository repository)
            => _repository = repository;


        public OperationResult<int> Insert(Professional professional)
        {
            if (professional == null)
                return OperationResult<int>.FailureResult("Não foi possível inserir o profissional!");

            if (string.IsNullOrEmpty(professional.Tag) || string.IsNullOrEmpty(professional.Name) || string.IsNullOrEmpty(professional.UserName))
                return OperationResult<int>.FailureResult("Campos com * são obrigatório");

            if (professional.UserPassword != professional.UserPasswordConfirmation)
                return OperationResult<int>.FailureResult("Senhas não conferem");

            var user = _repository.GetUser(professional.UserName);
            if (user.Id != 0)
                return OperationResult<int>.FailureResult("Nome de usuário já cadastrado!");

            int id = _repository.Insert(professional);
            if (id == 0)
                return OperationResult<int>.FailureResult("Não foi possível inserir o profissional na base de dados!");

            return OperationResult<int>.SuccessResult(id);
        }

        public OperationResult Update(Professional professional)
        {
            if (professional == null)
                return OperationResult.FailureResult("Não foi possível alterar o profissional!");

            if (string.IsNullOrEmpty(professional.Tag) || string.IsNullOrEmpty(professional.Name) || string.IsNullOrEmpty(professional.UserName))
                return OperationResult.FailureResult("Campos com * são obrigatório");

            if (professional.UserPassword != professional.UserPasswordConfirmation)
                return OperationResult.FailureResult("Senhas não conferem");

            var usernamelInRepo = _repository.GetUser(professional.UserName);
            if (usernamelInRepo != null && usernamelInRepo.Id != professional.Id)
                return OperationResult.FailureResult("Nome de usuário já cadastrado!");

            if (!_repository.Update(professional))
                return OperationResult.FailureResult("Não foi possível alterar o profissional!");
            
            return OperationResult.SuccessResult();
        }

        public OperationResult Delete(int id)
        {
            if (!_repository.Delete(id))
                return OperationResult.FailureResult("Não foi possível excluir o profissional!");

            return OperationResult.SuccessResult();
        }

        public OperationResult<Professional> GetById(int id)
        {
            var professional = _repository.GetById(id);

            if (professional == null)
                return OperationResult<Professional>.FailureResult("Não foi possível encontrar o profissional!");

            return OperationResult<Professional>.SuccessResult(professional);
        }

        public OperationResult<List<ProfessionalIndex>> GetIndex()
        {
            var professionals = _repository.GetIndex();

            if (professionals == null)
                return OperationResult<List<ProfessionalIndex>>.FailureResult("Não foi possível encontrar profissionais na base dados!");

            return OperationResult<List<ProfessionalIndex>>.SuccessResult(professionals);
        }

        public OperationResult<List<ProfessionalNameId>> GetTagNameid(bool addHeader)
        {
            var professionals = _repository.GetTagNameid();
            
            if (professionals == null)
                return OperationResult<List<ProfessionalNameId>>.FailureResult("Não foi possível encontrar profissionais na base de dados!");

            if (addHeader)
                professionals.Insert(0, new ProfessionalNameId { Nameid = "--TODOS--" });

            return OperationResult<List<ProfessionalNameId>>.SuccessResult(professionals);
        }

        public OperationResult<UserInfo> GetUserInfo(string userName)
        {
            var userInfo = _repository.GetUser(userName);

            if (userInfo == null)
                return OperationResult<UserInfo>.FailureResult("Dados do usuário não encontrados");

            return OperationResult<UserInfo>.SuccessResult(userInfo);
        }

    }
}
