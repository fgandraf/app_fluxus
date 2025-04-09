using Fluxus.Core.Models;
using Fluxus.Core;
using Fluxus.Core.Contracts.Databases;
using Microsoft.VisualBasic;
using System;

namespace Fluxus.UseCases
{
    public class ProfileUseCases
    {

        private readonly IProfileRepository _repository;


        public ProfileUseCases(IProfileRepository repository)
            => _repository = repository;


        public OperationResult<long> Insert(Profile profile)
        {
            if (profile == null)
                return OperationResult<long>.FailureResult("Não foi possível incluir o perfil!");

            if (string.IsNullOrEmpty(profile.Cnpj) || string.IsNullOrEmpty(profile.TradingName) || string.IsNullOrEmpty(profile.CompanyName))
                return OperationResult<long>.FailureResult("Campos com * são obrigatório");

            var id = _repository.Insert(profile);
            if (id == 0)
                return OperationResult<long>.FailureResult("Não foi possível inserir o perfil na base de dados!");

            return OperationResult<long>.SuccessResult(id);
        }

        public OperationResult Update(Profile profile)
        {
            if (profile == null)
                return OperationResult.FailureResult("Não foi possível alterar o perfil!");

            if (string.IsNullOrEmpty(profile.Cnpj) || string.IsNullOrEmpty(profile.TradingName) || string.IsNullOrEmpty(profile.CompanyName))
                return OperationResult<long>.FailureResult("Campos com * são obrigatório");

            if (!_repository.Update(profile))
                return OperationResult.FailureResult("Não foi possível alterar o perfil na base dados!");

            return OperationResult.SuccessResult();
        }

        public OperationResult UpdateLogo(object model)
        {
            if (model == null)
                return OperationResult.FailureResult("Não foi possível alterar o logo!");

            if (!_repository.UpdateLogo(model))
                return OperationResult.FailureResult("Não foi possível alterar o logo na base dados!");

            return OperationResult.SuccessResult();
        }

        public OperationResult<Profile> GetById(long id)
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

            return OperationResult<byte[]>.SuccessResult(Convert.FromBase64String(logo.Base64Image));
        }

        public OperationResult<string> GetTradingName()
        {
            var tradingName = _repository.GetTradingName();
            if (string.IsNullOrEmpty(tradingName.TradingName))
                return OperationResult<string>.FailureResult("Não foi possível encontrar o o nome fantasia na base dados!");

            return OperationResult<string>.SuccessResult(tradingName.TradingName);
        }

    }
}