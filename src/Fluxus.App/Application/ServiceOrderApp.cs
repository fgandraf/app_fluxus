using Fluxus.Domain.Entities;
using Fluxus.Domain.Enums;
using Fluxus.Domain.Records;
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








        public bool InsertOrUpdate(ServiceOrder serviceOrder, EnumMethod method)
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
            serviceOrder.Title = $"{tag}-{serviceOrder.City}-{referenceNumber}" + "\n\n" +
                                 $"{serviceOrder.CustomerName.Replace(" ", " ")}" + "\n" +
                                 $"- Prazo: {serviceOrder.Deadline.ToShortDateString()}";

            int result;
            if (method == EnumMethod.Update)
                result = new ServiceOrderRepository().Update(serviceOrder) == true ? 1 : 0;
            else
                result = new ServiceOrderRepository().Insert(serviceOrder);

            if (result > 0)
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

        public List<ServiceOrderOpen> GetOrdensDoFluxo()
            => new ServiceOrderRepository().GetIndexOpen();

        public List<ServiceOrderIndex> GetOrdensConcluidasNaoFaturadas()
            => new ServiceOrderRepository().GetOpenDone();

        public List<ServiceOrderIndex> GetOrdensFaturadasDoCodigo(int invoiceId)
            => new ServiceOrderRepository().GetClosedByInvoiceId(invoiceId);

        public List<ServiceOrderIndex> GetOrdensComFiltro(string filter)
            => new ServiceOrderRepository().GetFiltered(filter);

        public DataTable GetProfessionalByInvoiceId(int invoiceId)
        {
            var professionalsList = new ServiceOrderRepository().GetProfessionalByInvoiceId(invoiceId);
            DataTable table = new DataTable();

            table.Columns.Add("ProfessionalId", typeof(int));
            table.Columns.Add("Nameid", typeof(string));

            foreach (var professional in professionalsList)
            {
                DataRow row = table.NewRow();
                row["ProfessionalId"] = professional.ProfessionalId;
                row["Nameid"] = professional.Nameid;
                table.Rows.Add(row);
            }

            return table;
        }
            
        public List<string> GetCitiesFromOrders(bool addHeader)
        {
            var cities = new ServiceOrderRepository().GetCitiesFromOrders();

            if (addHeader)
                cities.Insert(0, "--TODAS--");

            return cities;
        }

        public ServiceOrder GetBy(int id)
            => new ServiceOrderRepository().GetById(id);

        public void ExportToSheet(List<dynamic> serviceOrders)
            => new ExcelService().ExportToExcel(serviceOrders);

    }

}
