using Fluxus.Domain.Entities;
using Fluxus.Infra.Repositories;
using System.Data;


namespace Fluxus.Services
{
    public class ProfissionalService
    {



        public void Insert(Professional body)
        {
            new ProfessionalRepository().Insert(body);
        }



        public void Update(Professional body)
        {
            new ProfessionalRepository().Update(body);
        }



        public void Delete(long id)
        {
            new ProfessionalRepository().Delete(id);
        }



        public DataTable GetAll()
        {
            return new ProfessionalRepository().GetAll();
        }



        public DataTable GetUser(string userName)
        {
            return new ProfessionalRepository().GetUser(userName);
        }



        public DataTable ListarCodigoENomeid(bool addHeader)
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



        public Professional GetBy(long id)
        {
            return new ProfessionalRepository().GetById(id);
        }



    }



}
