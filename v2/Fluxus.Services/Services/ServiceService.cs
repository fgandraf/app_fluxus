using Fluxus.Domain.Entities;
using Fluxus.Infra.Repositories;
using System.Data;


namespace Fluxus.Services
{
    public class ServiceService
    {
        public void Insert(Service body)
            => new ServiceRepository().Insert(body);


        public void Update(Service body)
            => new ServiceRepository().Update(body);


        public void Delete(int id)
            => new ServiceRepository().Delete(id);


        public DataTable ListarAtividades(bool addHeader)
        {
            DataTable table = new ServiceRepository().GetAll();
            DataView view = new DataView(table);
            DataTable atividades = view.ToTable("Selected", false, "id", "tag", "description", "serviceAmount", "mileageAllowance");

            if (addHeader)
            {
                DataRow linha = atividades.NewRow();
                linha[1] = "--TODAS--";
                atividades.Rows.InsertAt(linha, 0);
            }

            return atividades;
        }


        public Service GetBy(int id)
            => new ServiceRepository().GetById(id);

    }

}
