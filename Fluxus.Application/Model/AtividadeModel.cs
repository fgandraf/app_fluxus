using Fluxus.Model.ENT;
using System.Data;
using Api = Fluxus.Data.Api;


namespace Fluxus.Model
{
    class AtividadeModel
    {



        public void Insert(AtividadeENT dado)
        {
            new Api.Atividade().Insert(dado);
        }



        public void Update(long id, AtividadeENT dado)
        {
            new Api.Atividade().Update(id, dado);
        }



        public void Delete(long id)
        {
            new Api.Atividade().Delete(id);
        }



        public DataTable ListarAtividades(bool adicionaTitulo)
        {
            DataView dvAtividades = new DataView();
            dvAtividades = new DataView(new Api.Atividade().GetAll());

            DataTable dtAtividades = dvAtividades.ToTable("Selected", false, "id", "codigo", "descricao", "valor_atividade", "valor_deslocamento");
            if (adicionaTitulo)
            {
                DataRow linha = dtAtividades.NewRow();
                linha[1] = "--TODAS--";
                dtAtividades.Rows.InsertAt(linha, 0);
            }

            return dtAtividades;
        }



        public AtividadeENT GetBy(long id)
        {
            return new Api.Atividade().GetBy(id);
        }



    }



}
