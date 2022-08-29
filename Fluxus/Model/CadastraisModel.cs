using Fluxus.Model.ENT;
using System.Data;

using MySQL = Fluxus.Data.MySQL;
using Api = Fluxus.Data.Api;


namespace Fluxus.Model
{
    class CadastraisModel
    {



        public void Insert(CadastraisENT dado)
        {
            if (Util.DataSource == "MySQL")
                new MySQL.Cadastrais().Insert(dado);
            else
                new Api.Cadastrais().Insert(dado);
        }



        public void Update(CadastraisENT dado)
        {
            if (Util.DataSource == "MySQL")
                new MySQL.Cadastrais().Update(dado);
            else
                new Api.Cadastrais().Update(dado);
        }



        public CadastraisENT ListarCadastrais()
        {
            if (Util.DataSource == "MySQL")
                return new MySQL.Cadastrais().GetAll();
            else
                return new Api.Cadastrais().GetAll();
        }



        public DataTable DadosParaImpressao()
        {
            if (Util.DataSource == "MySQL")
                return new MySQL.Cadastrais().GetToPrint();
            else
                return new Api.Cadastrais().GetToPrint();
        }



        public string GetFantasia()
        {
            if (Util.DataSource == "MySQL")
                return new MySQL.Cadastrais().GetFantasia();
            else
                return new Api.Cadastrais().GetFantasia();
        }



    }



}
