using Fluxus.Model.ENT;
using System.Data;
using Api = Fluxus.Data.Api;


namespace Fluxus.Model
{



    class AgenciaModel
    {



        public void Insert(AgenciaENT dado)
        {
            new Api.Agencia().Insert(dado);
        }



        public void Update(long id, AgenciaENT dado)
        {
            new Api.Agencia().Update(id, dado);
        }



        public void Delete(long id)
        {
            new Api.Agencia().Delete(id);
        }



        public DataTable GetAll()
        {
            return new Api.Agencia().GetAll();
        }



        public DataTable BuscarAgencia(string agenciaCodigo)
        {
            return new Api.Agencia().BuscarAgencia(agenciaCodigo);
        }



        public AgenciaENT GetBy(long id)
        {
            return new Api.Agencia().GetBy(id);
        }



    }



}
