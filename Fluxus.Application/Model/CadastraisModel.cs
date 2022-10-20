using Fluxus.Model.ENT;
using System.Data;
using Api = Fluxus.Data.Api;


namespace Fluxus.Model
{
    class CadastraisModel
    {



        public void Insert(CadastraisENT dado)
        {
            new Api.Cadastrais().Insert(dado);
        }



        public void Update(CadastraisENT dado)
        {
            new Api.Cadastrais().Update(dado);
        }



        public CadastraisENT ListarCadastrais()
        {
            return new Api.Cadastrais().GetAll();
        }



        public DataTable DadosParaImpressao()
        {
            return new Api.Cadastrais().GetToPrint();
        }



        public string GetFantasia()
        {
            return new Api.Cadastrais().GetFantasia();
        }



    }



}
