using Fluxus.Domain.Entities;
using Fluxus.Infra.Repositories.Contracts;

namespace Fluxus.App.Services
{
    public class ProfileService
    {

        private readonly IProfileRepository _repository;


        public ProfileService(IProfileRepository repository)
            => _repository = repository;


        public OperationResult<int> Insert(Profile profile)
        {
            if (profile == null)
                return OperationResult<int>.FailureResult("Não foi possível incluir o perfil!");

            if (string.IsNullOrEmpty(profile.Cnpj) || string.IsNullOrEmpty(profile.TradingName) || string.IsNullOrEmpty(profile.CompanyName))
                return OperationResult<int>.FailureResult("Campos com * são obrigatório");

            int id = _repository.Insert(profile);
            if (id == 0)
                return OperationResult<int>.FailureResult("Não foi possível inserir o perfil na base de dados!");

            return OperationResult<int>.SuccessResult(id);
        }

        public OperationResult Update(Profile profile)
        {
            if (profile == null)
                return OperationResult.FailureResult("Não foi possível alterar o perfil!");

            if (string.IsNullOrEmpty(profile.Cnpj) || string.IsNullOrEmpty(profile.TradingName) || string.IsNullOrEmpty(profile.CompanyName))
                return OperationResult<int>.FailureResult("Campos com * são obrigatório");

            if (!_repository.Update(profile))
                return OperationResult.FailureResult("Não foi possível alterar o perfil na base dados!");

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