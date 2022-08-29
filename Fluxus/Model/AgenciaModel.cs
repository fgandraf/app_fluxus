using Fluxus.Model.ENT;
using System.Data;

using MySQL = Fluxus.Data.MySQL;
using Api = Fluxus.Data.Api;


namespace Fluxus.Model
{



    class AgenciaModel
    {



        public void Insert(AgenciaENT dado)
        {
            if (Util.DataSource == "MySQL")
                new MySQL.Agencia().Insert(dado);
            else
                new Api.Agencia().Insert(dado);
        }



        public void Update(long id, AgenciaENT dado)
        {
            if (Util.DataSource == "MySQL")
                new MySQL.Agencia().Update(id, dado);
            else
                new Api.Agencia().Update(id, dado);
        }



        public void Delete(long id)
        {
            if (Util.DataSource == "MySQL")
                new MySQL.Agencia().Delete(id);
            else
                new Api.Agencia().Delete(id);
        }



        public DataTable GetAll()
        {
            if (Util.DataSource == "MySQL")
                return new MySQL.Agencia().GetAll();
            else
                return new Api.Agencia().GetAll();
        }



        public DataTable BuscarAgencia(string agenciaCodigo)
        {
            if (Util.DataSource == "MySQL")
                return new MySQL.Agencia().BuscarAgencia(agenciaCodigo);
            else
                return new Api.Agencia().BuscarAgencia(agenciaCodigo);
        }



        public AgenciaENT GetBy(long id)
        {
            if (Util.DataSource == "MySQL")
                return new MySQL.Agencia().GetBy(id);
            else
                return new Api.Agencia().GetBy(id);
        }



    }



}
