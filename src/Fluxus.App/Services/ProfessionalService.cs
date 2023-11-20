using Fluxus.Domain.Entities;
using Fluxus.Domain.Interfaces;
using Fluxus.Domain.Records;
using System.Collections.Generic;

namespace Fluxus.App.Services
{
    public class ProfessionalService
    {

        private IProfessionalRepository _repository;
        public Professional Professional { get; set; }
        

        public string Message { get; private set; }


        
        public ProfessionalService(IProfessionalRepository repository)
            => _repository = repository;



        public int Insert()
        {
            if (Professional != null && IsValid())
                return _repository.Insert(Professional);

            Message = "Não foi possível incluir o profissional!";
            return 0;
        }

        public int Update()
        {
            if (Professional != null && IsValid() && _repository.Update(Professional))
                return 1;

            Message = "Não foi possível alterar o profissional!";
            return 0;
        }

        private bool IsValid()
        {
            if (string.IsNullOrEmpty(Professional.Tag) || string.IsNullOrEmpty(Professional.Name) || string.IsNullOrEmpty(Professional.UserName))
            {
                Message = "Campos com * são obrigatório";
                return false;
            }


            if (!Professional.PasswordMatch())
            {
                Message = "Senhas não conferem!";
                return false;
            }


            var user = _repository.GetUser(Professional.UserName);
            var usernameExists = !string.IsNullOrWhiteSpace(user.UserName);
            if (Professional.Id == 0 && usernameExists)
            {
                Message = "Nome de usuário já existe.";
                return false;
            }

            return true;
        }

        public bool Delete(int id)
        {
            if (_repository.Delete(id))
                return true;

            Message = "Não foi possível excluir o profissional!";
            return false;
        }
            
        public Professional GetById(int id)
        {
            var professional = _repository.GetById(id);
            
            if (professional != null)
                return professional;

            Message = "Não foi possível encontrar o profissional!";
            return null;
        }

        public List<ProfessionalIndex> GetIndex()
        {
            var professionals = _repository.GetIndex();

            if (professionals != null)
                return professionals;
               
            Message = "Não foi possível encontrar profissionais na base de dados!";
            return null;
        }

        public List<ProfessionalNameId> GetTagNameid(bool addHeader)
        {
            var professionals = _repository.GetTagNameid();
            
            if (professionals != null)
            {
                if (addHeader)
                    professionals.Insert(0, new ProfessionalNameId { Nameid = "--TODOS--" });
                return professionals;
            }

            Message = "Não foi possível encontrar profissionais na base de dados!";
            return null;
        }

        public UserInfo GetUser(string userName)
        {
            return _repository.GetUser(userName);
        }

    }
}
