using Fluxus.Core.Models;
using Fluxus.Core;
using Fluxus.Core.ViewModels;
using Fluxus.Core.Contracts.Databases;
using System.Collections.Generic;

namespace Fluxus.UseCases
{
    public class ProfessionalUseCases
    {

        private readonly IProfessionalRepository _professionalRepository;
        private readonly IUserRepository _userRepository;
        public Professional Professional { get; set; }


        public ProfessionalUseCases(IProfessionalRepository professionalRepository, IUserRepository userRepository)
        {
            _professionalRepository = professionalRepository;
            _userRepository = userRepository;
        }

        public OperationResult<int> Insert(Professional professional, User user)
        {
            var result = Validate(true, professional, user);
            if (!result.Success)
                return OperationResult<int>.FailureResult(result.Message);

            int professionalId = _professionalRepository.Insert(professional);
            user.ProfessionalId = professionalId;
            int userId = _userRepository.Insert(user);

            if (professionalId == 0 || userId == 0)
                return OperationResult<int>.FailureResult("EXC5 - Não foi possível inserir o profissional na base de dados!");

            return OperationResult<int>.SuccessResult(professionalId);
        }

        public OperationResult Update(Professional professional, User user)
        {
            var result = Validate(false, professional, user);
            if (!result.Success)
                return OperationResult.FailureResult(result.Message);

            if (!_professionalRepository.Update(professional) || !_userRepository.Update(user))
                return OperationResult.FailureResult("Não foi possível alterar o profissional!");

            return OperationResult.SuccessResult();
        }

        private OperationResult Validate(bool newProfessional, Professional professional, User user)
        {
            if (professional == null || user == null)
                return OperationResult.FailureResult("NL0X - Não foi possível inserir ou alterar o profissional!");

            if (string.IsNullOrEmpty(professional.Tag) || string.IsNullOrEmpty(professional.Name) || string.IsNullOrEmpty(user.UserName))
                return OperationResult.FailureResult("RQ1 - Campos com * são obrigatório");

            if (user.UserPassword != user.UserPasswordConfirmation)
                return OperationResult.FailureResult("PNM3 - Senhas não conferem");

            var usernamelInRepo = _userRepository.GetByUserName(user.UserName);
            if (newProfessional && usernamelInRepo != null && usernamelInRepo.Id > 0 || !newProfessional && usernamelInRepo != null && usernamelInRepo.Id != user.Id)
                return OperationResult.FailureResult("USR4 - Nome de usuário já cadastrado!");

            return OperationResult.SuccessResult();
        }

        public OperationResult Delete(int id)
        {
            var user = _userRepository.GetByProfessionalId(id);

            var userDeleted = _userRepository.Delete(user.Id);
            var professionalDeleted = _professionalRepository.Delete(id);

            if (!userDeleted && !professionalDeleted)
                return OperationResult.FailureResult("Não foi possível excluir o profissional!");

            return OperationResult.SuccessResult();
        }

        public OperationResult<Professional> GetById(int id)
        {
            var professional = _professionalRepository.GetById(id);

            if (professional == null)
                return OperationResult<Professional>.FailureResult("Não foi possível encontrar o profissional!");

            return OperationResult<Professional>.SuccessResult(professional);
        }

        public OperationResult<List<ProfessionalsIndexViewModel>> GetIndex()
        {
            var professionals = _professionalRepository.GetIndex();

            if (professionals == null)
                return OperationResult<List<ProfessionalsIndexViewModel>>.FailureResult("Não foi possível encontrar profissionais na base dados!");

            return OperationResult<List<ProfessionalsIndexViewModel>>.SuccessResult(professionals);
        }

        public OperationResult<List<ProfessionalNameId>> GetTagNameid(bool addHeader)
        {
            var professionals = _professionalRepository.GetTagNameid();

            if (professionals == null)
                return OperationResult<List<ProfessionalNameId>>.FailureResult("Não foi possível encontrar profissionais na base de dados!");

            if (addHeader)
                professionals.Insert(0, new ProfessionalNameId { Nameid = "--TODOS--" });

            return OperationResult<List<ProfessionalNameId>>.SuccessResult(professionals);
        }
    }
}
