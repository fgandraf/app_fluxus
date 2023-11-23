using Fluxus.Domain;
using Fluxus.Domain.Entities;
using Fluxus.Domain.Interfaces;

namespace Fluxus.App.Services
{
    public class ProfileService
    {

        private IProfileRepository _repository;


        public ProfileService(IProfileRepository repository)
            => _repository = repository;


        public OperationResult Insert(Profile profile)
        {
            if (profile == null || !profile.IsValid)
                return OperationResult.FailureResult("Não foi possível incluir o profissional!");


            int id = _repository.Insert(profile);
            return OperationResult.SuccessResult(id);
        }

        public OperationResult Update(Profile profile)
        {
            if (profile == null || !profile.IsValid || _repository.Update(profile))
                return OperationResult.FailureResult("Não foi possível alterar o profissional!");

            return OperationResult.SuccessResult();
        }

        public OperationResult GetById(int id)
        {
            var profile = _repository.GetById(id);

            if (profile == null)
                return OperationResult.FailureResult("Não foi possível encontrar o perfil na base dados!");

            return OperationResult.SuccessResult(profile);
        }

        public OperationResult GetToPrint()
        { 
            var profile = _repository.GetToPrint();

            if (profile == null)
                return OperationResult.FailureResult("Não foi possível encontrar o perfil na base dados!");

            return OperationResult.SuccessResult(profile);
        }

        public OperationResult GetLogo()
        {
            var logo = _repository.GetLogo();
            if (logo == null)
                return OperationResult.FailureResult("Não foi possível encontrar o logo na base dados!");

            return OperationResult.SuccessResult(logo);
        }

        public OperationResult GetTradingName()
        {
            var tradingName = _repository.GetTradingName();
            if (string.IsNullOrEmpty(tradingName))
                return OperationResult.FailureResult("Não foi possível encontrar o o nome fantasia na base dados!");

            return OperationResult.SuccessResult(tradingName);
        }

    }
}