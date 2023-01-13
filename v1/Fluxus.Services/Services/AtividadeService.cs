using Fluxus.Domain.Entities;
using Fluxus.Infra.Repositories;
using System.Data;


namespace Fluxus.Services
{
    public class AtividadeService
    {


        public void Insert(Atividade body)
        {
            new ActivityRepository().Insert(body);
        }



        public void Update(Atividade body)
        {
            new ActivityRepository().Update(body);
        }



        public void Delete(long id)
        {
            new ActivityRepository().Delete(id);
        }



        public DataTable ListarAtividades(bool addHeader)
        {
            DataTable table = new ActivityRepository().GetAll();

            DataView view = new DataView(table);

            DataTable atividades = view.ToTable("Selected", false, "id", "codigo", "descricao", "valorAtividade", "valorDeslocamento");

            if (addHeader)
            {
                DataRow linha = atividades.NewRow();
                linha[1] = "--TODAS--";
                atividades.Rows.InsertAt(linha, 0);
            }

            return atividades;
        }



        public Atividade GetBy(long id)
        {
            return new ActivityRepository().GetById(id);
        }



    }



}
