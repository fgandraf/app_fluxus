using System;

namespace Fluxus.Domain.Entities
{

    public class ServiceOrder
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? ReferenceCode { get; set; }
        public string? Branch { get; set; }
        public string? ProfessionalId { get; set; }
        public string? ServiceId { get; set; }
        public string? ServiceAmount { get; set; }
        public string? MileageAllowance { get; set; }
        public string? CustomerName { get; set; }
        public string? City { get; set; }
        public string? ContactName { get; set; }
        public string? ContactPhone { get; set; }
        public string? Coordinates { get; set; }
        public EnumStatus? Status { get; set; }
        public string? Comments { get; set; }
        public bool Invoiced { get; set; }
        public int InvoiceId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime Deadline { get; set; }
        public DateTime? PendingDate { get; set; }
        public DateTime? SurveyDate { get; set; }
        public DateTime? DoneDate { get; set; }
        public bool Siopi { get; set; }
    }


}
