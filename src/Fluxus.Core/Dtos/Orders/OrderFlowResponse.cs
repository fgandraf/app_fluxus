namespace Fluxus.Core.Dtos.Orders;

public record OrderFlowResponse
{
    public long Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public int Status { get; set; }
    public long ProfessionalId { get; set; }
}