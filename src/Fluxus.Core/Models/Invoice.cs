﻿using System;

namespace Fluxus.Core.Models;


public class Invoice
{
    public long Id { get; private set; }
    public string? Description { get; private set; }
    public DateTime IssueDate { get; private set; }
    public decimal SubtotalService { get; private set; }
    public decimal SubtotalMileageAllowance { get; private set; }
    public decimal Total { get; private set; }


    public Invoice(long id, string? description, DateTime issueDate, decimal subtotalService, decimal subtotalMileageAllowance, decimal total)
    {
        Id = id;
        Description = description;
        IssueDate = issueDate;
        SubtotalService = subtotalService;
        SubtotalMileageAllowance = subtotalMileageAllowance;
        Total = total;
    }

}
