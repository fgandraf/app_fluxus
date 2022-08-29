using Fluxus.Model.ENT;
using System.Data;

using MySQL = Fluxus.Data.MySQL;
using Api = Fluxus.Data.Api;


namespace Fluxus.Model
{
    class FaturaModel
    {



        public long Insert(FaturaENT dado)
        {
            if (Util.DataSource == "MySQL")
                return new MySQL.Fatura().Insert(dado);
            else
                return new Api.Fatura().Insert(dado);
        }



        public void Update(long id, FaturaENT dado)
        {
            if (Util.DataSource == "MySQL")
                new MySQL.Fatura().Update(id, dado);
            else
                new Api.Fatura().Update(id, dado);
        }



        public void Delete(long id)
        {
            if (Util.DataSource == "MySQL")
                new MySQL.Fatura().Delete(id);
            else
                new Api.Fatura().Delete(id);
        }



        public string DescricaoFatura(long id)
        {
            if (Util.DataSource == "MySQL")
                return new MySQL.Fatura().GetDescricaoById(id);
            else
                return new Api.Fatura().GetDescricaoById(id);
        }



        public DataTable ListarFatura()
        {
            if (Util.DataSource == "MySQL")
                return new MySQL.Fatura().GetAll();
            else
                return new Api.Fatura().GetAll();
        }



    }



}