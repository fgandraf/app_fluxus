using Fluxus.Core.Models;

namespace Fluxus.Core.Dtos.Users;

public record UserCreateRequest
{
    public string Email { get; set; } = string.Empty;
    public string Password {  get; set; } = string.Empty;
    public long ProfessionalId { get; set; }
    public bool TechnicianResponsible { get; private set; }
    public bool LegalResponsible { get; private set; }


    public UserCreateRequest(User user)
    {
        Email = user.Email;
        Password = user.Password;
        ProfessionalId = user.ProfessionalId;
        TechnicianResponsible = user.TechnicianResponsible;
        LegalResponsible = user.LegalResponsible;
    }
}