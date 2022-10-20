using Fluxus.Model.ENT;
using System.Data;
using Api = Fluxus.Data.Api;


namespace Fluxus.Model
{
    class ProfissionalModel
    {



        public void Insert(ProfissionalENT dado)
        {
            new Api.Profissional().Insert(dado);
        }



        public void Update(long id, ProfissionalENT dado)
        {
            new Api.Profissional().Update(id, dado);
        }



        public void Delete(long id)
        {
            new Api.Profissional().Delete(id);
        }



        public DataTable ListarProfissionais()
        {
            return new Api.Profissional().GetAll();
        }



        public DataTable BuscarUsuario(string nomeDeUsuario)
        {
            return new Api.Profissional().GetUserInfoBy(nomeDeUsuario);
        }



        public DataTable ListarCodigoENomeid(bool adicionaTitulo)
        {
            DataTable dtPro = new DataTable();

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
            return new Api.Profissional().GetBy(id);
        }



    }



}
