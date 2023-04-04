using Fluxus.Domain.Entities;
using Fluxus.Domain.Struct;
using Fluxus.Infra.Repositories;
using Fluxus.Infra.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;


namespace Fluxus.App
{
    public class ServiceOrderApp
    {
        public string Message { get; private set; }

        public bool InsertOrUpdate(ServiceOrder serviceOrder, string method)
        {
            if (string.IsNullOrEmpty(serviceOrder.ReferenceCode) || serviceOrder.ReferenceCode == "../...")
            {
                Message = "Campo Referência é obrigatório";
                return false;
            }

            if (string.IsNullOrEmpty(serviceOrder.ServiceId))
            {
                Message = "Campo Atividade é obrigatório";
                return false;
            }

            if (string.IsNullOrEmpty(serviceOrder.ProfessionalId))
            {
                Message = "Campo Profissional é obrigatório";
                return false;
            }


            serviceOrder.ServiceAmount = serviceOrder.ServiceAmount.Replace(',', '.');
            serviceOrder.MileageAllowance = serviceOrder.MileageAllowance.Replace(',', '.');

            string tag = serviceOrder.Title;
            char[] dividers = { '.', '/' };
            string[] elements = serviceOrder.ReferenceCode.Split(dividers, StringSplitOptions.RemoveEmptyEntries);
            var referenceNumber = Convert.ToInt32(elements[2]);
            serviceOrder.Title = $"{tag}-{referenceNumber}" + "\n\n" +
                                 $"{serviceOrder.CustomerName.Replace(" ", " ")}" + "\n" +
                                 $"- Cidade: {serviceOrder.City}" + "\n" +
                                 $"- Prazo: {serviceOrder.Deadline.ToShortDateString()}";

            bool result;
            if (method == "Alterar")
                result = new ServiceOrderRepository().Update(serviceOrder);
            else
                result = new ServiceOrderRepository().Insert(serviceOrder);

            if (result)
                return true;
            else
            {
                Message = "Não foi possível inserir/alterar a ordem de serviço";
                return false;
            }
        }


        public void UpdateFaturaCod(int id, int invoiceId)
            => new ServiceOrderRepository().UpdateInvoiceId(id, invoiceId);


        public async void UpdateStatus(int id, string status)
            => await Task.Run(() => new ServiceOrderRepository().UpdateStatus(id, status));


        public bool Delete(int id)
        {
            var order = new App.ServiceOrderApp().GetBy(id);
            if (order.Invoiced)
            {
                Message = "Não é possível excluir uma Ordem de Serviço já faturada!";
                return false;
            }

            new ServiceOrderRepository().Delete(id);
            return true;
        }

        public List<ServiceOrderFlow> GetOrdensDoFluxo()
            => new ServiceOrderRepository().GetIndexOpen();


        public DataTable GetOrdensConcluidasNaoFaturadas()
            => new ServiceOrderRepository().GetOpenDone();


        public DataTable GetOrdensFaturadasDoCodigo(int invoiceId)
            => new ServiceOrderRepository().GetClosedByInvoiceId(invoiceId);


        public List<ServiceOrderFiltered> GetOrdensComFiltro(string filter)
            => new ServiceOrderRepository().GetFiltered(filter);


        public DataTable GetProfessionalByInvoiceId(int invoiceId)
            => new ServiceOrderRepository().GetProfessionalByInvoiceId(invoiceId);


        public List<string> GetCitiesFromOrders(bool addHeader)
        {
            var cities = new ServiceOrderRepository().GetCitiesFromOrders();

            if (addHeader)
                cities.Insert(0, "--TODAS--");

            return cities;
        }


        public ServiceOrder GetBy(int id)
            => new ServiceOrderRepository().GetById(id);


        public void ExportToSheet(List<ServiceOrderFiltered> serviceOrders)
            => new ExcelService().ExportToExcel(serviceOrders);

    }

}
