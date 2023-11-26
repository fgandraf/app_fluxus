
namespace Fluxus.Infra.Records
{
    public record ProfessionalIndex
    {
        public int Id { get; set; }
        public string? Tag { get; set; }
        public string? Name { get; set; }
        public string? Profession { get; set; }
        public string? Phone1 { get; set; }
        public bool UserActive { get; set; }

    }
}
