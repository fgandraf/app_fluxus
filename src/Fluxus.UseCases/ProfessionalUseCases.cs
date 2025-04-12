using Fluxus.Core.Models;
using Fluxus.Core;
using Fluxus.Core.Contracts.Databases;
using System.Collections.Generic;
using Fluxus.Core.Dtos.Professionals;
using Fluxus.Core.Dtos.Users;

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

        public OperationResult<long> Insert(Professional professional, User user)
        {
            var result = Validate(true, professional, user);
            if (!result.Success)
                return OperationResult<long>.FailureResult(result.Message);

            var professionalRequest = new ProfessionalCreateRequest(professional);

            var professionalId = _professionalRepository.Insert(professionalRequest);
            user.ProfessionalId = professionalId;


            var userRequest = new UserCreateRequest(user);

            var userId = _userRepository.Register(userRequest);

            if (professionalId == 0 || userId == 0)
                return OperationResult<long>.FailureResult("EXC5 - Não foi possível inserir o profissional na base de dados!");

            return OperationResult<long>.SuccessResult(professionalId);
        }

        public OperationResult Update(Professional professional, User user, bool emailUpdated)
        {
            var result = Validate(false, professional, user, emailUpdated);
            if (!result.Success)
                return OperationResult.FailureResult(result.Message);

            var professionalRequest = new ProfessionalUpdateRequest(professional);
            var userRequest = new UserUpdateInfoRequest(user);
            if (userRequest.Password == "0000000000")
                userRequest.Password = null;

            if (!_professionalRepository.Update(professionalRequest) || !_userRepository.UpdateInfo(userRequest))
                return OperationResult.FailureResult("Não foi possível alterar o profissional!");

            return OperationResult.SuccessResult();
        }

        private OperationResult Validate(bool newProfessional, Professional professional, dynamic user, bool emailUpdated = true)
        {
            if (professional == null || user == null)
                return OperationResult.FailureResult("NL0X - Não foi possível inserir ou alterar o profissional!");

            if (string.IsNullOrEmpty(professional.Tag) || string.IsNullOrEmpty(professional.Name) || string.IsNullOrEmpty(user.Email))
                return OperationResult.FailureResult("RQ1 - Campos com * são obrigatório");

            if (user.Password != user.PasswordConfirmation)
                return OperationResult.FailureResult("PNM3 - Senhas não conferem");

            if (user.Password.Length < 6 || user.Password.Length > 20)
                return OperationResult.FailureResult("PMIX2 - Senha precisa ter entre 6 e 20 caractéres");


            if (emailUpdated)
            {
                var usernamelInRepo = _userRepository.GetByUserName(user.Email);
                if (newProfessional && usernamelInRepo != null && usernamelInRepo.Id > 0 || !newProfessional && usernamelInRepo != null && usernamelInRepo.Id != user.Id)
                    return OperationResult.FailureResult("USR4 - Nome de usuário já cadastrado!");
            }
            

            return OperationResult.SuccessResult();
        }

        public OperationResult<Professional> GetById(long id)
        {
            var professional = _professionalRepository.GetById(id);

            if (professional == null)
                return OperationResult<Professional>.FailureResult("Não foi possível encontrar o profissional!");

            return OperationResult<Professional>.SuccessResult(professional);
        }

        public OperationResult<List<ProfessionalIndexResponse>> GetIndex()
        {
            var professionals = _professionalRepository.GetIndex();

            if (professionals == null)
                return OperationResult<List<ProfessionalIndexResponse>>.FailureResult("Não foi possível encontrar profissionais na base dados!");

            return OperationResult<List<ProfessionalIndexResponse>>.SuccessResult(professionals);
        }

        public OperationResult<List<ProfessionalTagNameIdResponse>> GetTagNameid(bool addHeader)
        {
            var professionals = _professionalRepository.GetTagNameid();

            if (professionals == null)
                return OperationResult<List<ProfessionalTagNameIdResponse>>.FailureResult("Não foi possível encontrar profissionais na base de dados!");

            if (addHeader)
                professionals.Insert(0, new ProfessionalTagNameIdResponse { NameId = "--TODOS--" });

            return OperationResult<List<ProfessionalTagNameIdResponse>>.SuccessResult(professionals);
        }
    }
}
