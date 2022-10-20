using Fluxus.Model.ENT;
using System.Data;
using Api = Fluxus.Data.Api;


namespace Fluxus.Model
{
    class FaturaModel
    {



        public long Insert(FaturaENT dado)
        {
            return new Api.Fatura().Insert(dado);
        }



        public void Update(long id, FaturaENT dado)
        {
            new Api.Fatura().Update(id, dado);
        }



        public void Delete(long id)
        {
            new Api.Fatura().Delete(id);
        }



        public string DescricaoFatura(long id)
        {
            return new Api.Fatura().GetDescricaoById(id);
        }



        public DataTable ListarFatura()
        {
            return new Api.Fatura().GetAll();
        }



    }



}