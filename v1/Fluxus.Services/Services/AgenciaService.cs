using System.Data;
using Fluxus.Domain.Entities;
using Fluxus.Infra.Repositories;


namespace Fluxus.Services
{
    public class AgenciaService
    {


        public void Insert(Agencia body)
        {
            new AgencyRepository().Insert(body);
        }



        public void Update(Agencia body)
        {
            new AgencyRepository().Update(body);
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
