using System.Data;
using Fluxus.Domain.Entities;
using Fluxus.Infra.Repositories;


namespace Fluxus.Services
{
    public class AgenciaService
    {


        public void Insert(Agencia dado)
        {
            new AgencyRepository().Insert(dado);
        }



        public void Update(long id, Agencia dado)
        {
            new AgencyRepository().Update(id, dado);
        }



        public void Delete(long id)
        {
            new AgencyRepository().Delete(id);
        }



        public DataTable GetAll()
        {
            return new AgencyRepository().GetAll();
        }



        public DataTable BuscarAgencia(string agenciaCodigo)
        {
            return new AgencyRepository().GetByCode(agenciaCodigo);
        }



        public Agencia GetBy(long id)
        {
            return new AgencyRepository().GetById(id);
        }



    }



}
