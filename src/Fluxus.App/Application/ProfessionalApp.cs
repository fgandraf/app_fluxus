using Fluxus.Domain.Entities;
using Fluxus.Infra.Repositories;
using Microsoft.Office.Interop.Excel;
using System.Collections.Generic;
using System.Data;

namespace Fluxus.App
{
    public class ProfessionalApp
    {
        public string Message { get; private set; }

        public bool InsertOrUpdate(Professional professional, string passwordConfirmation, string method)
        {
            if (professional.Tag == "" || professional.Name == "" || professional.UserName == "")
            {
                Message = "Campos com * são obrigatório";
                return false;
            }

            bool userIsValid = (
                professional.UserName != "" &&
                professional.UserPassword != "" &&
                passwordConfirmation != "" &&
                professional.UserPassword == passwordConfirmation
                );
            if (!userIsValid)
            {
                Message = "Verifique os campos Nome de Usuário e Senha";
                return false;
            }


            if (method == "&Adicionar")
            {
                var user = new ProfessionalApp().GetUser(professional.UserName, string.Empty);
                if (!string.IsNullOrEmpty(user.UserName))
                {
                    Message = "Nome de usuário já existente";
                    return false;
                }

                new ProfessionalRepository().Insert(professional);
            }
            else
            {
                new ProfessionalRepository().Update(professional);
            }

            if (Logged.ProfessionalId == professional.Id)
            {
                Logged.Rt = professional.TechnicianResponsible;
                Logged.Rl = professional.LegalResponsible;
            }
            return true;
        }

        public bool Delete(int id)
        {
            var success = new ProfessionalRepository().Delete(id);

            if (success)
                return true;
            else
            {
                Message = "Não foi possível excluir o profissional.";
                return false;
            }
        }

        public List<dynamic> GetIndex()
            => new ProfessionalRepository().GetIndex();


        public dynamic GetUser(string userName, string password)
        {
            var user = new ProfessionalRepository().GetUser(userName);

            if (user == null)
            {
                Message = "Usuário não encontrado";
                return user;
            }

            if (user.UserPassword != password || user.UserActive == false)
            {
                Message = "Senha incorreta ou usuário não está ativo";
                return user;
            }

            return user;
        }

        public Professional GetBy(int id)
            => new ProfessionalRepository().GetById(id);


        public List<Professional> GetCodeNameid(bool addHeader)
        {
            var professional = new ProfessionalRepository().GetTagNameid();

            if (addHeader)
                professional.Insert(0, new Professional { Nameid = "--TODOS--" });

            return professional;
        }



    }
}
