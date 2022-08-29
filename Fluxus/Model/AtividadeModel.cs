using Fluxus.Model.ENT;
using System.Data;

using MySQL = Fluxus.Data.MySQL;
using Api = Fluxus.Data.Api;


namespace Fluxus.Model
{
    class AtividadeModel
    {



        public void Insert(AtividadeENT dado)
        {
            if (Util.DataSource == "MySQL")
                new MySQL.Atividade().Insert(dado);
            else
                new Api.Atividade().Insert(dado);
        }



        public void Update(long id, AtividadeENT dado)
        {
            if (Util.DataSource == "MySQL")
                new MySQL.Atividade().Update(id, dado);
            else
                new Api.Atividade().Update(id, dado);
        }



        public void Delete(long id)
        {
            if (Util.DataSource == "MySQL")
                new MySQL.Atividade().Delete(id);
            else
                new Api.Atividade().Delete(id);
        }



        public DataTable ListarAtividades(bool adicionaTitulo)
        {
            DataView dvAtividades = new DataView();
            if (Util.DataSource == "MySQL")
                dvAtividades = new DataView(new MySQL.Atividade().GetAll());
            else
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
            if (Util.DataSource == "MySQL")
                return new MySQL.Atividade().GetBy(id);
            else
                return new Api.Atividade().GetBy(id);
        }



    }



}
