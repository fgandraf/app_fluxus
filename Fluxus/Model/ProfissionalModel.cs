using Fluxus.Model.ENT;
using System.Data;

using MySQL = Fluxus.Data.MySQL;
using Api = Fluxus.Data.Api;


namespace Fluxus.Model
{
    class ProfissionalModel
    {



        public void Insert(ProfissionalENT dado)
        {
            if (Util.DataSource == "MySQL")
                new MySQL.Profissional().Insert(dado);
            else
                new Api.Profissional().Insert(dado);
        }



        public void Update(long id, ProfissionalENT dado)
        {
            if (Util.DataSource == "MySQL")
                new MySQL.Profissional().Update(id, dado);
            else
                new Api.Profissional().Update(id, dado);
        }



        public void Delete(long id)
        {
            if (Util.DataSource == "MySQL")
                new MySQL.Profissional().Delete(id);
            else
                new Api.Profissional().Delete(id);
        }



        public DataTable ListarProfissionais()
        {
            if (Util.DataSource == "MySQL")
                return new MySQL.Profissional().GetAll();
            else
                return new Api.Profissional().GetAll();
        }



        public DataTable BuscarUsuario(string nomeDeUsuario)
        {
            if (Util.DataSource == "MySQL")
                return new MySQL.Profissional().GetUserInfoBy(nomeDeUsuario);
            else
                return new Api.Profissional().GetUserInfoBy(nomeDeUsuario);
        }



        public DataTable ListarCodigoENomeid(bool adicionaTitulo)
        {
            DataTable dtPro = new DataTable();

            if (Util.DataSource == "MySQL")
                dtPro = new MySQL.Profissional().GetCodigoENomeid();
            else
                dtPro = new Api.Profissional().GetCodigoENomeid();

            if (adicionaTitulo)
            {
                DataRow linha = dtPro.NewRow();
                linha[1] = "--TODOS--";
                dtPro.Rows.InsertAt(linha, 0);
            }
            
            return dtPro;

        }



        public ProfissionalENT GetBy(long id)
        {
            if (Util.DataSource == "MySQL")
                return new MySQL.Profissional().GetBy(id);
            else
                return new Api.Profissional().GetBy(id);
        }



    }



}
