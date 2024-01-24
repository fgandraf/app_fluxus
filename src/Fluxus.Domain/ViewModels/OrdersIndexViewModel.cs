using Fluxus.Domain.Enums;
using System;

namespace Fluxus.Domain.ViewModels;

public record OrdersIndexViewModel
{
    public int Id { get; set; }
    public DateTime OrderDate { get; set; }
    public string? ReferenceCode { get; set; }
    public string? Professional { get; set; }
    public int ProfessionalId { get; set; }
    public string? Service { get; set; }
    public string? City { get; set; }
    public string? CustomerName { get; set; }
    public DateTime SurveyDate { get; set; }
    public DateTime DoneDate { get; set; }
    public decimal ServiceAmount { get; set; }
    public decimal MileageAllowance { get; set; }
    public bool Invoiced { get; set; }
    public int InvoiceId { get; set; }
    public EStatus Status { get; set; }
}
