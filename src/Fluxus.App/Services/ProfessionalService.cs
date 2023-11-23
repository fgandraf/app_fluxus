using Fluxus.Domain;
using Fluxus.Domain.Entities;
using Fluxus.Domain.Interfaces;
using Fluxus.Domain.Records;

namespace Fluxus.App.Services
{
    public class ProfessionalService
    {

        private IProfessionalRepository _repository;
        public Professional Professional { get; set; }
      
        
        public ProfessionalService(IProfessionalRepository repository)
            => _repository = repository;


        public OperationResult Insert(Professional professional)
        {
            if (professional == null || !professional.IsValid)
                return OperationResult.FailureResult("Não foi possível incluir o profissional!");

            var usernamelInRepo = _repository.GetUser(professional.UserName);
            if (usernamelInRepo != null)
                return OperationResult.FailureResult("Nome de usuário já cadastrado!");

            int id = _repository.Insert(professional);
            return OperationResult.SuccessResult(id);
        }

        public OperationResult Update(Professional professional)
        {
            if (professional == null || !professional.IsValid || professional.UserName == null)
                return OperationResult.FailureResult("Não foi possível alterar o profissional!");

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

        public OperationResult GetById(int id)
        {
            var professional = _repository.GetById(id);

            if (professional == null)
                return OperationResult.FailureResult("Não foi possível encontrar o profissional!");

            return OperationResult.SuccessResult(professional);
        }

        public OperationResult GetIndex()
        {
            var professionals = _repository.GetIndex();

            if (professionals == null)
                return OperationResult.FailureResult("Não foi possível encontrar profissionais na base dados!");

            return OperationResult.SuccessResult(professionals);
        }

        public OperationResult GetTagNameid(bool addHeader)
        {
            var professionals = _repository.GetTagNameid();
            
            if (professionals == null)
                return OperationResult.FailureResult("Não foi possível encontrar profissionais na base de dados!");

            if (addHeader)
                professionals.Insert(0, new ProfessionalNameId { Nameid = "--TODOS--" });

            return OperationResult.SuccessResult(professionals);
        }

        public OperationResult GetUserInfo(string userName)
        {
            var userInfo = _repository.GetUser(userName);

            if (userInfo == null)
                return OperationResult.FailureResult("Dados do usuário não encontrados");

            return OperationResult.SuccessResult(userInfo);
        }

    }
}
