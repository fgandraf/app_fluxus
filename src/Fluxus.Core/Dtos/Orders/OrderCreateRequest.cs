using Fluxus.Core.Models;
using System;

namespace Fluxus.Core.Dtos.Orders;

public record OrderCreateRequest
{
    public string ReferenceCode { get; set; } = string.Empty;
    public string BranchId { get; set; } = string.Empty;
    public DateTime OrderDate { get; set; }
    public DateTime Deadline { get; set; }
    public long ProfessionalId { get; set; }
    public long ServiceId { get; set; }
    public double ServiceAmount { get; set; }
    public double MileageAllowance { get; set; }
    public bool Siopi { get; set; }
    public string CustomerName { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string ContactName { get; set; } = string.Empty;
    public string ContactPhone { get; set; } = string.Empty;
    public string Coordinates { get; set; } = string.Empty;
    public int Status { get; set; }
    public DateTime? PendingDate { get; set; }
    public DateTime? SurveyDate { get; set; }
    public DateTime? DoneDate { get; set; }
    public bool Invoiced { get; set; }
    public long InvoiceId { get; set; }


    public OrderCreateRequest(Order order)
    {
        ReferenceCode = order.ReferenceCode;
        BranchId = order.Branch;
        OrderDate = order.OrderDate;
        Deadline = order.Deadline;
        ProfessionalId = order.ProfessionalId;
        ServiceId = order.ServiceId;
        ServiceAmount = order.ServiceAmount;
        MileageAllowance = order.MileageAllowance;
        Siopi = order.Siopi;
        CustomerName = order.CustomerName;
        City = order.City;
        ContactName = order.ContactName;
        ContactPhone = order.ContactPhone;
        Coordinates = order.Coordinates;
        Status = (int)order.Status;
        PendingDate = order.PendingDate;
        SurveyDate = order.SurveyDate;
        DoneDate = order.DoneDate;
        Invoiced = order.Invoiced;
        InvoiceId = order.InvoiceId;
    }
}