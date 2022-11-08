using Fluxus.Domain.Entities;
using Fluxus.Infra.Repositories;
using System.Data;


namespace Fluxus.Services
{
    public class ProfissionalService
    {



        public void Insert(Profissional dado)
        {
            new ProfessionalRepository().Insert(dado);
        }



        public void Update(long id, Profissional dado)
        {
            new ProfessionalRepository().Update(id, dado);
        }



        public void Delete(long id)
        {
            new ProfessionalRepository().Delete(id);
        }



        public DataTable ListarProfissionais()
        {
            return new ProfessionalRepository().GetAll();
        }



        public DataTable BuscarUsuario(string nomeDeUsuario)
        {
            return new ProfessionalRepository().GetUser(nomeDeUsuario);
        }



        public DataTable ListarCodigoENomeid(bool adicionaTitulo)
        {
            DataTable dtPro = new ProfessionalRepository().GetCodeNameid();

            if (adicionaTitulo)
            {
                DataRow linha = dtPro.NewRow();
                linha[1] = "--TODOS--";
                dtPro.Rows.InsertAt(linha, 0);
            }

            return dtPro;
        }



        public Profissional GetBy(long id)
        {
            return new ProfessionalRepository().GetById(id);
        }



    }



}
