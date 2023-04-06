using Fluxus.Domain.Entities;
using System;

namespace Fluxus.Domain.Struct
{
    public struct ServiceOrderFiltered
    {
        public int Id { get; set; }
        public EnumStatus Status { get; set; }
        public string Professional { get; set; }
        public DateTime OrderDate { get; set; }
        public string ReferenceCode { get; set; }
        public string Service { get; set; }
        public string City { get; set; }
        public string CustomerName { get; set; }
        public DateTime? SurveyDate { get; set; }
        public DateTime? DoneDate { get; set; }
        public bool Invoiced { get; set; }
    }
}
