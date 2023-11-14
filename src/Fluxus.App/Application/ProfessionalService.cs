using Fluxus.Domain.Entities;
using Fluxus.Domain.Interfaces;
using Fluxus.Domain.Structs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Fluxus.App.Application
{
    public class ProfessionalService
    {

        private IProfessionalRepository _repository;
        public Professional Professional { get; set; }
        

        public string Message { get; private set; }


        
        public ProfessionalService(IProfessionalRepository repository)
            => _repository = repository;




        public bool Execute(string method)
        {
            if (Professional == null || !IsValid())
                return false;

            if (method == "Alterar")
                return Update();
            else
                return Insert();
        }

        private bool Insert()
        {
            if (Professional != null && _repository.Insert(Professional))
                return true;

            Message = "Não foi possível incluir o profissional!";
            return false;
        }
        private bool Update()
        {
            if (Professional != null && _repository.Update(Professional))
                return true;

            Message = "Não foi possível alterar o profissional!";
            return false;
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
            string json = _repository.GetById(id);

            if (!string.IsNullOrEmpty(json))
                 return JsonConvert.DeserializeObject<Professional>(json);
                 
            Message = "Não foi possível encontrar o profissional!";
            return null;
        }

        public List<ProfessionalIndex> GetIndex()
        {
            string json = _repository.GetIndex();
            if (!string.IsNullOrEmpty(json))
                return JsonConvert.DeserializeObject<List<ProfessionalIndex>>(json);

            Message = "Não foi possível encontrar profissionais na base de dados!";
            return null;
        }
        public List<ProfessionalNameId> GetTagNameid(bool addHeader)
        {
            string json = _repository.GetTagNameid();
            List<ProfessionalNameId> professionals;

            if (!string.IsNullOrEmpty(json))
            {
                professionals = JsonConvert.DeserializeObject<List<ProfessionalNameId>>(json);

                if (addHeader)
                    professionals.Insert(0, new ProfessionalNameId { NameId = "--TODOS--" });

                return professionals;
            }

            Message = "Não foi possível encontrar profissionais na base de dados!";
            return null;
        }

    }
}
