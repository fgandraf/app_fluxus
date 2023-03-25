using Fluxus.Domain.Entities;
using Fluxus.Infra.Repositories;
using System.Data;


namespace Fluxus.Services
{
    public class FaturaService
    {

        public int Insert(Invoice body)
            => new InvoiceRepository().Insert(body);


        public void Update(Invoice body)
            => new InvoiceRepository().Update(body);


        public void Delete(int id)
            => new InvoiceRepository().Delete(id);


        public string DescricaoFatura(int id)
            => new InvoiceRepository().GetDescription(id);


        public DataTable ListarFatura()
            => new InvoiceRepository().GetAll();

    }

}