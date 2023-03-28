using Fluxus.Domain.Entities;
using Fluxus.Infra.Repositories;
using System.Data;


namespace Fluxus.Services
{
    public class ProfessionalService
    {

        public void Insert(Professional body)
            => new ProfessionalRepository().Insert(body);


        public void Update(Professional body)
            => new ProfessionalRepository().Update(body);


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

        public bool IsValid(string userName, string password, string passwordConfirmation, string currentUserName)
        {
            bool isValid = (
                userName != "" &&
                password != "" &&
                passwordConfirmation != "" &&
                password == passwordConfirmation
                );

            //bool isNotCurrentUser = userName != currentUserName;

            return isValid; //&& isNotCurrentUser;
        }

        public bool UserExists(string userName)
        {
            var dtPro = new ProfessionalService().GetUser(userName);
            if (dtPro.Rows.Count > 0)
                return true;

            return false;
        }

    }
}
