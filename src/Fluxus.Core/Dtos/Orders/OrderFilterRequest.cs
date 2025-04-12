namespace Fluxus.Core.Dtos.Orders;

public record OrderFilterRequest
{
    public string? professionalTag { get; set; }
    public string? serviceTag { get; set; }
    public string? city { get; set; }
    public int? status { get; set; }
    public bool? invoiced { get; set; }
}
