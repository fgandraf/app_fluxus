using Fluxus.Domain.Entities;
using Fluxus.Domain.Enums;
using Fluxus.Domain.Interfaces;

namespace Fluxus.App
{
    public class ProfileService
    {

        private IProfileRepository _repository;
        public Profile Profile { get; set; }


        public string Message { get; private set; }



        public ProfileService(IProfileRepository repository)
            => _repository = repository;



        public int Execute(EnumMethod method)
        {
            if (Profile == null || !IsValid())
                return 0;

            if (method == EnumMethod.Update)
                return Update();
            else
                return Insert();
        }

        private int Insert()
        {
            if (Profile != null)
                return _repository.Insert(Profile);

            Message = "Não foi possível incluir o profissional!";
            return 0;
        }

        private int Update()
        {
            if (Profile != null && _repository.Update(Profile))
                return 1;

            Message = "Não foi possível alterar o profissional!";
            return 0;
        }

        private bool IsValid()
        {
            if (string.IsNullOrEmpty(Profile.Cnpj) || string.IsNullOrEmpty(Profile.TradingName) || string.IsNullOrEmpty(Profile.CompanyName))
            {
                Message = "Campos com * são obrigatório";
                return false;
            }

            return true;
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