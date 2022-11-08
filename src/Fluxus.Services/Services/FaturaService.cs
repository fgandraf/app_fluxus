using Fluxus.Domain.Entities;
using Fluxus.Infra.Repositories;
using System.Data;


namespace Fluxus.Services
{
    public class FaturaService
    {



        public long Insert(Fatura dado)
        {
            return new InvoiceRepository().Insert(dado);
        }



        public void Update(long id, Fatura dado)
        {
            new InvoiceRepository().Update(id, dado);
        }



        public void Delete(long id)
        {
            new InvoiceRepository().Delete(id);
        }



        public string DescricaoFatura(long id)
        {
            return new InvoiceRepository().GetDescription(id);
        }



        public DataTable ListarFatura()
        {
            return new InvoiceRepository().GetAll();
        }



    }



}