using Fluxus.Domain.Enums;

namespace Fluxus.Domain.Records
{
    public record ServiceOrderOpen
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public EnumStatus Status { get; set; }
        public string? ProfessionalId { get; set; }
    }
}
