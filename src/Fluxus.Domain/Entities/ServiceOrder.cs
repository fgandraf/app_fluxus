using System;
using Fluxus.Domain.Enums;

namespace Fluxus.Domain.Entities
{

    public class ServiceOrder
    {
        
        public bool IsValid { get; private set; }
        public string? Message { get; private set; }


        public int Id { get; private set; }


        private string? _title;
        public string? Title 
        { 
            get => _title;
            set
            {
                if (value != null && ReferenceCode != null && CustomerName != null)
                {
                    string tag = value;
                    char[] dividers = { '.', '/' };
                    string[] elements = ReferenceCode.Split(dividers, StringSplitOptions.RemoveEmptyEntries);
                    var referenceNumber = Convert.ToInt32(elements[2]);
                    _title = $"{tag}-{City}-{referenceNumber}" + "\n\n" +
                                         $"{CustomerName.Replace(" ", " ")}" + "\n" +
                                         $"- Prazo: {Deadline.ToShortDateString()}";
                }
               
            }
        }


        public string? ReferenceCode { get; private set; }
        public string? Branch { get; private set; }
        public string? ProfessionalId { get; private set; }
        public string? ServiceId { get; private set; }



        private string? _serviceAmount;
        public string? ServiceAmount
        {
            get => _serviceAmount;
            set => _serviceAmount = value != null ? value.Replace(',', '.') : null;
        }



        private string? _mileageAllowance;
        public string? MileageAllowance
        {
            get => _mileageAllowance;
            set => _mileageAllowance = value != null ? value.Replace(',', '.') : null;
        }



        public string? CustomerName { get; private set; }
        public string? City { get; private set; }
        public string? ContactName { get; private set; }
        public string? ContactPhone { get; private set; }
        public string? Coordinates { get; private set; }
        public EnumStatus Status { get; private set; }
        public bool Invoiced { get; private set; }
        public int InvoiceId { get; private set; }
        public DateTime OrderDate { get; private set; }
        public DateTime Deadline { get; private set; }
        public DateTime? PendingDate { get; private set; }
        public DateTime? SurveyDate { get; private set; }
        public DateTime? DoneDate { get; private set; }
        public bool Siopi { get; private set; }



        public ServiceOrder(int id, string? title, string? referenceCode, string? branch, string? professionalId, string? serviceId, string? serviceAmount, string? mileageAllowance, string? customerName, string? city, string? contactName, string? contactPhone, string? coordinates, EnumStatus status, bool invoiced, int invoiceId, DateTime orderDate, DateTime deadline, DateTime? pendingDate, DateTime? surveyDate, DateTime? doneDate, bool siopi)
        {
            Id = id;
            Title = title;
            ReferenceCode = referenceCode;
            Branch = branch;
            ProfessionalId = professionalId;
            ServiceId = serviceId;
            ServiceAmount = serviceAmount;
            MileageAllowance = mileageAllowance;
            CustomerName = customerName;
            City = city;
            ContactName = contactName;
            ContactPhone = contactPhone;
            Coordinates = coordinates;
            Status = status;
            Invoiced =  invoiced;
            InvoiceId = invoiceId;
            OrderDate = orderDate;
            Deadline = deadline;
            PendingDate = pendingDate;
            SurveyDate = surveyDate;
            DoneDate = doneDate;
            Siopi = siopi;

            Validate();
        }

        public ServiceOrder(int id, string? title, string? referenceCode, string? branch, string? professionalId, string? serviceId, string? serviceAmount, string? mileageAllowance, string? customerName, string? city, string? contactName, string? contactPhone, string? coordinates, EnumStatus status, DateTime orderDate, DateTime deadline, DateTime? pendingDate, DateTime? surveyDate, DateTime? doneDate, bool siopi)
        {
            Id = id;
            Title = title;
            ReferenceCode = referenceCode;
            Branch = branch;
            ProfessionalId = professionalId;
            ServiceId = serviceId;
            ServiceAmount = serviceAmount;
            MileageAllowance = mileageAllowance;
            CustomerName = customerName;
            City = city;
            ContactName = contactName;
            ContactPhone = contactPhone;
            Coordinates = coordinates;
            Status = status;
            OrderDate = orderDate;
            Deadline = deadline;
            PendingDate = pendingDate;
            SurveyDate = surveyDate;
            DoneDate = doneDate;
            Siopi = siopi;
            
            Validate();
        }

        public ServiceOrder() { }


        private void Validate()
        {
            if (string.IsNullOrEmpty(ReferenceCode) || ReferenceCode == "../...")
            {
                Message = "Campo Referência é obrigatório";
                IsValid = false;
            }

            if (string.IsNullOrEmpty(ServiceId))
            {
                Message = "Campo Atividade é obrigatório";
                IsValid = false;
            }

            if (string.IsNullOrEmpty(ProfessionalId))
            {
                Message = "Campo Profissional é obrigatório";
                IsValid = false;
            }

            IsValid = true;
        }
    }
}
