

namespace Fluxus.Infra.Records
{
    public record BankBranchIndex
    {
        public int Id { get; set; }
        public string? BranchNumber { get; set; }
        public string? Name { get; set; }
        public string? City { get; set; }
        public string? Phone1 { get; set; }
        public string? Email { get; set; }
    }
}
