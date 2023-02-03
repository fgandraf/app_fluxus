using System;

namespace Fluxus.Domain.Entities
{

    public class Invoice
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime IssueDate { get; set; }
        public double SubtotalService { get; set; }
        public double SubtotalMileageAllowance { get; set; }
        public double Total { get; set; }
    }


}
