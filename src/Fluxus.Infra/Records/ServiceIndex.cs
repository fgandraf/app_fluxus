
namespace Fluxus.Infra.Records
{

    public record ServiceIndex
    {
        public int Id { get; set; }
        public string? Tag { get; set; }
        public string? Description { get; set; }
        public string? ServiceAmount { get; set; }
        public string? MileageAllowance { get; set; }
        
    }


}
