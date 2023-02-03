using Fluxus.Domain.Entities;
using Fluxus.Infra.Repositories;
using System.Data;
using System.Threading.Tasks;


namespace Fluxus.Services
{
    public class ServiceOrderService
    {



        public void Insert(ServiceOrder body)
        {
            new ServiceOrderRepository().Insert(body);
        }



        public void Update(ServiceOrder body)
        {
            new ServiceOrderRepository().Update(body);
        }



        public void UpdateFaturaCod(int id, int invoiceId)
        {
            new ServiceOrderRepository().UpdateInvoiceId(id, invoiceId);
        }



        public async void UpdateStatus(int id, string status)
        {
            await Task.Run(() => new ServiceOrderRepository().UpdateStatus(id, status));
        }



        public void Delete(int id)
        {
            new ServiceOrderRepository().Delete(id);
        }



        public DataTable GetOrdensDoFluxo()
        {
            return new ServiceOrderRepository().GetIndexOpen();
        }



        public DataTable GetOrdensConcluidasNaoFaturadas()
        {
            return new ServiceOrderRepository().GetOpenDone();
        }



        public DataTable GetOrdensFaturadasDoCodigo(int invoiceId)
        {
            return new ServiceOrderRepository().GetClosedByInvoiceId(invoiceId);
        }



        public DataTable GetOrdensComFiltro(string filter)
        {
            return new ServiceOrderRepository().GetFiltered(filter);
        }



        public DataTable GetProfissionaisDaFatura(int invoiceId)
        {
            return new ServiceOrderRepository().GetProfessionalByInvoiceId(invoiceId);
        }



        public DataTable GetCidadesDasOrdens(bool addHeader)
        {
            DataTable distinctCidades = new ServiceOrderRepository().GetCitiesFromOrders();

            if (addHeader)
            {
                DataRow linha = distinctCidades.NewRow();
                linha[0] = "--TODAS--";
                distinctCidades.Rows.InsertAt(linha, 0);
            }

            return distinctCidades;
        }



        public Domain.Entities.ServiceOrder GetBy(int id)
        {
            return new ServiceOrderRepository().GetById(id);
        }



    }



}
