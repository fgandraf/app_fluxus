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


        public OperationResult<int> Insert(Profile profile)
        {
            if (profile == null || !profile.IsValid)
                return OperationResult<int>.FailureResult("Não foi possível incluir o perfil!");


            int id = _repository.Insert(profile);
            return OperationResult<int>.SuccessResult(id);
        }

        public OperationResult Update(Profile profile)
        {
            if (profile == null || !profile.IsValid || !_repository.Update(profile))
                return OperationResult.FailureResult("Não foi possível alterar o perfil!");

            return OperationResult.SuccessResult();
        }

        public OperationResult<Profile> GetById(int id)
        {
            var profile = _repository.GetById(id);

            if (profile == null)
                return OperationResult<Profile>.FailureResult("Não foi possível encontrar o perfil na base dados!");

            return OperationResult<Profile>.SuccessResult(profile);
        }

        public OperationResult<Profile> GetToPrint()
        { 
            var profile = _repository.GetToPrint();

            if (profile == null)
                return OperationResult<Profile>.FailureResult("Não foi possível encontrar o perfil na base dados!");

            return OperationResult<Profile>.SuccessResult(profile);
        }

        public OperationResult<byte[]> GetLogo()
        {
            var logo = _repository.GetLogo();
            if (logo == null)
                return OperationResult<byte[]>.FailureResult("Não foi possível encontrar o logo na base dados!");

            return OperationResult<byte[]>.SuccessResult(logo);
        }

        public OperationResult<string> GetTradingName()
        {
            var tradingName = _repository.GetTradingName();
            if (string.IsNullOrEmpty(tradingName))
                return OperationResult<string>.FailureResult("Não foi possível encontrar o o nome fantasia na base dados!");

            return OperationResult<string>.SuccessResult(tradingName);
        }

    }
}