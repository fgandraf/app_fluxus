using Fluxus.Domain.Entities;
using Fluxus.Domain.Struct;
using Fluxus.Infra.Repositories;
using Fluxus.Infra.Services;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;


namespace Fluxus.App
{
    public class ServiceOrderApp
    {

        public void Insert(ServiceOrder body)
            => new ServiceOrderRepository().Insert(body);


        public void Update(ServiceOrder body)
            => new ServiceOrderRepository().Update(body);


        public void UpdateFaturaCod(int id, int invoiceId)
            => new ServiceOrderRepository().UpdateInvoiceId(id, invoiceId);


        public async void UpdateStatus(int id, string status)
            => await Task.Run(() => new ServiceOrderRepository().UpdateStatus(id, status));


        public string Delete(ServiceOrder order)
        {
            if (order.Invoiced)
                return "Não é possível excluir uma Ordem de Serviço já faturada!";

            new ServiceOrderRepository().Delete(order.Id);
            return "Ordem de Serviço excluída!";
        }

        public List<ServiceOrder> GetOrdensDoFluxo()
            => new ServiceOrderRepository().GetIndexOpen();

        public DataTable GetOrdensDoFluxoEmTabela()
            => new ServiceOrderRepository().GetIndexOpenEmTabela();

        public DataTable GetOrdensConcluidasNaoFaturadas()
            => new ServiceOrderRepository().GetOpenDone();


        public DataTable GetOrdensFaturadasDoCodigo(int invoiceId)
            => new ServiceOrderRepository().GetClosedByInvoiceId(invoiceId);


        public List<ServiceOrderFiltered> GetOrdensComFiltro(string filter)
            => new ServiceOrderRepository().GetFiltered(filter);


        public DataTable GetProfessionalByInvoiceId(int invoiceId)
            => new ServiceOrderRepository().GetProfessionalByInvoiceId(invoiceId);
            

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


        public ServiceOrder GetBy(int id)
            => new ServiceOrderRepository().GetById(id);


        public void ExportToSheet(List<ServiceOrderFiltered> serviceOrders)
            => new ExcelService().ExportToExcel(serviceOrders);

    }

}
