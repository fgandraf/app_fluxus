using Fluxus.Domain.Entities;
using Fluxus.Infra.Repositories;
using System.Data;

namespace Fluxus.App
{
    public class ProfessionalApp
    {

        public void Delete(int id)
            => new ProfessionalRepository().Delete(id);


        public DataTable GetAll()
            => new ProfessionalRepository().GetAll();


        public DataTable GetUser(string userName)
            => new ProfessionalRepository().GetUser(userName);

        public Professional GetBy(int id)
            => new ProfessionalRepository().GetById(id);


        public DataTable GetCodeNameid(bool addHeader)
        {
            DataTable dtPro = new ProfessionalRepository().GetTagNameid();

            if (addHeader)
            {
                DataRow linha = dtPro.NewRow();
                linha[2] = "--TODOS--";
                dtPro.Rows.InsertAt(linha, 0);
            }

            return dtPro;
        }

        public string InsertOrUpdate(Professional professional, string passwordConfirmation, string method)
        {
            if (professional.Tag == "" || professional.Name == "" || professional.UserName == "")
                return "Campos com * são obrigatório";


            bool userIsValid = (
                professional.UserName != "" &&
                professional.UserPassword != "" &&
                passwordConfirmation != "" &&
                professional.UserPassword == passwordConfirmation
                );
            if (!userIsValid)
                return "Verifique os campos Nome de Usuário e Senha";


            if (method == "&Adicionar")
            {
                var userExists = new ProfessionalApp().GetUser(professional.UserName);
                if (userExists.Rows.Count > 0)
                    return "Nome de usuário já existente";


                new ProfessionalRepository().Insert(professional);

                if (Logged.ProfessionalId == professional.Tag)
                {
                    Logged.Rt = professional.TechnicianResponsible;
                    Logged.Rl = professional.LegalResponsible;
                }
                return "Dados cadastrados com sucesso!";
            }
            else
            {
                new ProfessionalRepository().Update(professional);

                if (Logged.ProfessionalId == professional.Tag)
                {
                    Logged.Rt = professional.TechnicianResponsible;
                    Logged.Rl = professional.LegalResponsible;
                }
                return "Dados atualizados com sucesso!";
            }

        }

    }
}
