using System;

namespace Fluxus.Domain.Models;


public class Invoice
{
    public int Id { get; private set; }
    public string? Description { get; private set; }
    public DateTime IssueDate { get; private set; }
    public decimal SubtotalService { get; private set; }
    public decimal SubtotalMileageAllowance { get; private set; }
    public decimal Total { get; private set; }


    public Invoice(int id, string? description, DateTime issueDate, decimal subtotalService, decimal subtotalMileageAllowance, decimal total)
    {
        Id = id;
        Description = description;
        IssueDate = issueDate;
        SubtotalService = subtotalService;
        SubtotalMileageAllowance = subtotalMileageAllowance;
        Total = total;
    }

}
