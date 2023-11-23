using Fluxus.Domain;
using Fluxus.Domain.Entities;
using Fluxus.Domain.Interfaces;

//WIP

namespace Fluxus.App.Services
{
    public class ProfileService
    {

        private IProfileRepository _repository;
        public Profile Profile { get; set; }


        public string Message { get; private set; }



        public ProfileService(IProfileRepository repository)
            => _repository = repository;


        public OperationResult Insert()
        {
            if (Profile == null || !Profile.IsValid)
                return OperationResult.FailureResult("Não foi possível incluir o profissional!\n" + Profile?.Message);


            int id = _repository.Insert(Profile);
            return OperationResult.SuccessResult(id);
        }

        public OperationResult Update()
        {
            if (Profile == null || !Profile.IsValid || _repository.Update(Profile))
                return OperationResult.FailureResult("Não foi possível alterar o profissional!\n" + Profile?.Message);

            return OperationResult.SuccessResult();
        }


        public Profile GetAll()
            => _repository.GetAll();

        public Profile GetToPrint()
            => _repository.GetToPrint();

        public byte[] GetLogo()
            => _repository.GetLogo();

        public string GetTradingName()
            => _repository.GetTradingName();

    }
}