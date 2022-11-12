using Fluxus.Domain.Entities;
using Fluxus.Infra.Repositories;
using System.Data;
using System.Threading.Tasks;


namespace Fluxus.Services
{
    public class OsService
    {



        public void Insert(Os body)
        {
            new OrderRepository().Insert(body);
        }



        public void Update(Os body)
        {
            new OrderRepository().Update(body);
        }



        public void UpdateFaturaCod(long id, long invoiceId)
        {
            new OrderRepository().UpdateInvoiceId(id, invoiceId);
        }



        public async void UpdateStatus(long id, string status)
        {
            await Task.Run(() => new OrderRepository().UpdateStatus(id, status));
        }



        public void Delete(long id)
        {
            new OrderRepository().Delete(id);
        }



        public DataTable GetOrdensDoFluxo()
        {
            return new OrderRepository().GetIndexOpen();
        }



        public DataTable GetOrdensConcluidasNaoFaturadas()
        {
            return new OrderRepository().GetOpenDone();
        }



        public DataTable GetOrdensFaturadasDoCodigo(long invoiceId)
        {
            return new OrderRepository().GetClosedByInvoiceId(invoiceId);
        }



        public DataTable GetOrdensComFiltro(string parameters)
        {
            return new OrderRepository().GetFiltered(parameters);
        }



        public DataTable GetProfissionaisDaFatura(long invoiceId)
        {
            return new OrderRepository().GetProfessionalByInvoiceId(invoiceId);
        }



        public DataTable GetCidadesDasOrdens(bool addHeader)
        {
            DataTable distinctCidades = new OrderRepository().GetCitiesFromOrders();

            if (addHeader)
            {
                DataRow linha = distinctCidades.NewRow();
                linha[0] = "--TODAS--";
                distinctCidades.Rows.InsertAt(linha, 0);
            }

            return distinctCidades;
        }



        public Os GetBy(long id)
        {
            return new OrderRepository().GetById(id);
        }



    }



}
