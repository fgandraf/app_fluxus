using System;

namespace Fluxus.Core.Models;


public class Invoice
{
    public long Id { get; private set; }
    public string? Description { get; private set; }
    public DateTime IssueDate { get; private set; }
    public double SubtotalService { get; private set; }
    public double SubtotalMileageAllowance { get; private set; }
    public double Total { get; private set; }


    public Invoice(long id, string? description, DateTime issueDate, double subtotalService, double subtotalMileageAllowance, double total)
    {
        Id = id;
        Description = description;
        IssueDate = issueDate;
        SubtotalService = subtotalService;
        SubtotalMileageAllowance = subtotalMileageAllowance;
        Total = total;
    }

}
