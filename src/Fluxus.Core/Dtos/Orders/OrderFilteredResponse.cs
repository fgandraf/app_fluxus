using Fluxus.Core.Enums;
using System;

namespace Fluxus.Core.Dtos.Orders;

public record OrderFilteredResponse
{
    public long Id { get; set; }
    public EStatus Status { get; set; }
    public string Professional { get; set; } = string.Empty;
    public DateTime OrderDate { get; set; }
    public string ReferenceCode { get; set; } = string.Empty;
    public string Service { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string CustomerName { get; set; } = string.Empty;
    public DateTime? SurveyDate { get; set; }
    public DateTime? DoneDate { get; set; }
    public bool Invoiced { get; set; }
}