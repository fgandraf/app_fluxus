using Fluxus.Domain.Entities;
using Fluxus.Infra.Repositories;
using System.Data;


namespace Fluxus.Services
{
    public class ServiceService
    {
        public string InsertOrUpdate (Service service, string method)
        {
            if (service.Tag == "")
                return "Campos com * são obrigatório";

            if (method == "&Adicionar")
                new ServiceRepository().Insert(service);
            else
                new ServiceRepository().Update(service);

            return "Dados cadastrados com sucesso!";
        }

        public void Delete(int id)
            => new ServiceRepository().Delete(id);


        public DataTable GetAll(bool addHeader)
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
