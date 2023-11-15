using Fluxus.Domain.Enums;
using System;

namespace Fluxus.Domain.Records
{
    public record ServiceOrderIndex
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string? ReferenceCode { get; set; }
        public string? Professional { get; set; }
        public int ProfessionalId { get; set; } //aqui
        public string? Service { get; set; }
        public string? City { get; set; }
        public string? CustomerName { get; set; }
        public DateTime SurveyDate { get; set; }
        public DateTime DoneDate { get; set; }
        public double ServiceAmount { get; set; }
        public double MileageAllowance { get; set; }
        public bool Invoiced { get; set; }
        public int InvoiceId { get; set; } //aqui
        public EnumStatus Status { get; set; } //aqui
    }
}
