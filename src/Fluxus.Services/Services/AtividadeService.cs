using Fluxus.Domain.Entities;
using Fluxus.Infra.Repositories;
using System.Data;


namespace Fluxus.Services
{
    public class AtividadeService
    {


        public void Insert(Atividade dado)
        {
            new ActivityRepository().Insert(dado);
        }



        public void Update(long id, Atividade dado)
        {
            new ActivityRepository().Update(id, dado);
        }



        public void Delete(long id)
        {
            new ActivityRepository().Delete(id);
        }



        public DataTable ListarAtividades(bool adicionaTitulo)
        {
            DataTable table = new ActivityRepository().GetAll();

            DataView view = new DataView(table);

            DataTable atividades = view.ToTable("Selected", false, "id", "codigo", "descricao", "valor_atividade", "valor_deslocamento");

            if (adicionaTitulo)
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
