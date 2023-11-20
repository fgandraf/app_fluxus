using Fluxus.Domain.Entities;
using Fluxus.Domain.Interfaces;
using Fluxus.Domain.Records;
using Fluxus.Infra.Repositories;
using Fluxus.Infra.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;


namespace Fluxus.App.Services
{
    public class ServiceOrderService
    {

        private IServiceOrderRepository _repository;
        public ServiceOrder ServiceOrder { get; set; }


        public string Message { get; private set; }



        public ServiceOrderService(IServiceOrderRepository repository)
            => _repository = repository;



        public int Insert()
        {
            if (ServiceOrder != null && IsValid())
            {
                FormatThis();
                return new ServiceOrderRepository().Insert(ServiceOrder);
            }

            Message = "Não foi possível incluir a ordem de serviço";
            return 0;
        }

        public int Update()
        {
            if (ServiceOrder != null && IsValid() && _repository.Update(ServiceOrder))
            {
                FormatThis();
                return 1;
            }

            Message = "Não foi possível alterar a ordem de serviço!";
            return 0;
        }

        private bool IsValid()
        {
            if (string.IsNullOrEmpty(ServiceOrder.ReferenceCode) || ServiceOrder.ReferenceCode == "../...")
            {
                Message = "Campo Referência é obrigatório";
                return false;
            }

            if (string.IsNullOrEmpty(ServiceOrder.ServiceId))
            {
                Message = "Campo Atividade é obrigatório";
                return false;
            }

            if (string.IsNullOrEmpty(ServiceOrder.ProfessionalId))
            {
                Message = "Campo Profissional é obrigatório";
                return false;
            }

            return true;
        }

        private void FormatThis()
        {
            ServiceOrder.ServiceAmount = ServiceOrder.ServiceAmount.Replace(',', '.');
            ServiceOrder.MileageAllowance = ServiceOrder.MileageAllowance.Replace(',', '.');

            string tag = ServiceOrder.Title;
            char[] dividers = { '.', '/' };
            string[] elements = ServiceOrder.ReferenceCode.Split(dividers, StringSplitOptions.RemoveEmptyEntries);
            var referenceNumber = Convert.ToInt32(elements[2]);
            ServiceOrder.Title = $"{tag}-{ServiceOrder.City}-{referenceNumber}" + "\n\n" +
                                 $"{ServiceOrder.CustomerName.Replace(" ", " ")}" + "\n" +
                                 $"- Prazo: {ServiceOrder.Deadline.ToShortDateString()}";
        }




        public void UpdateFaturaCod(int id, int invoiceId)
            => _repository.UpdateInvoiceId(id, invoiceId);

        public async void UpdateStatus(int id, string status)
            => await Task.Run(() => _repository.UpdateStatus(id, status));

        public bool Delete(int id)
        {
            var order = GetBy(id);
            if (order.Invoiced)
            {
                Message = "Não é possível excluir uma Ordem de Serviço já faturada!";
                return false;
            }

            _repository.Delete(id);
            return true;
        }

        public List<ServiceOrderOpen> GetOrdensDoFluxo()
            => _repository.GetIndexOpen();

        public List<ServiceOrderIndex> GetOrdensConcluidasNaoFaturadas()
            => _repository.GetOpenDone();

        public List<ServiceOrderIndex> GetOrdensFaturadasDoCodigo(int invoiceId)
            => _repository.GetClosedByInvoiceId(invoiceId);

        public List<ServiceOrderIndex> GetOrdensComFiltro(string filter)
            => _repository.GetFiltered(filter);

        public DataTable GetProfessionalByInvoiceId(int invoiceId)
        {
            var professionalsList = _repository.GetProfessionalByInvoiceId(invoiceId);
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
            var cities = _repository.GetCitiesFromOrders();

            if (addHeader)
                cities.Insert(0, "--TODAS--");

            return cities;
        }

        public ServiceOrder GetBy(int id)
            => _repository.GetById(id);

        public void ExportToSheet(List<dynamic> serviceOrders)
            => new ExcelService().ExportToExcel(serviceOrders);

    }

}
