using System;

namespace Fluxus.Domain.Entities
{

    public class Invoice
    {
        public Invoice(int id, string? description, DateTime? issueDate, double subtotalService, double subtotalMileageAllowance, double total)
        {
            Id = id;
            Description = description;
            IssueDate = issueDate;
            SubtotalService = subtotalService;
            SubtotalMileageAllowance = subtotalMileageAllowance;
            Total = total;
        }

        public bool IsValid { get; private set; }
        public string? Message { get; private set; }



        public int Id { get; private set; }
        public string? Description { get; private set; }
        public DateTime? IssueDate { get; private set; }
        public double SubtotalService { get; private set; }
        public double SubtotalMileageAllowance { get; private set; }
        public double Total { get; private set; }
    }


}
