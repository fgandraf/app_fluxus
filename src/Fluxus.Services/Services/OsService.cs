using Fluxus.Domain.Entities;
using Fluxus.Infra.Repositories;
using System.Data;
using System.Threading.Tasks;


namespace Fluxus.Services
{
    public class OsService
    {



        public void Insert(Os dado)
        {
            new OrderRepository().Insert(dado);
        }



        public void Update(long id, Os dado)
        {
            new OrderRepository().Update(id, dado);
        }



        public void UpdateFaturaCod(long id, long fatura_cod)
        {
            new OrderRepository().UpdateFaturaCod(id, fatura_cod);
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



        public DataTable GetOrdensFaturadasDoCodigo(long fatura_cod)
        {
            return new OrderRepository().GetClosedByInvoiceId(fatura_cod);
        }



        public DataTable GetOrdensComFiltro(string filtro)
        {
            return new OrderRepository().GetFiltered(filtro);
        }



        public DataTable GetProfissionaisDaFatura(long fatura_cod)
        {
            return new OrderRepository().GetProfessionalByInvoiceId(fatura_cod);
        }



        public DataTable GetCidadesDasOrdens(bool adicionaTitulo)
        {
            DataTable distinctCidades = new OrderRepository().GetCitiesFromOrders();

            if (adicionaTitulo)
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
