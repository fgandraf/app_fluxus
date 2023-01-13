using Fluxus.Domain.Entities;
using Fluxus.Infra.Repositories;
using System.Data;


namespace Fluxus.Services
{
    public class FaturaService
    {



        public long Insert(Fatura body)
        {
            return new InvoiceRepository().Insert(body);
        }



        public void Update(Fatura body)
        {
            new InvoiceRepository().Update(body);
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