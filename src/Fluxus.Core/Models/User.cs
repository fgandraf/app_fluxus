
namespace Fluxus.Core.Models;

public class User
{
    public string? PasswordConfirmation { get; private set; }


    public long Id { get; private set; }
    public long ProfessionalId { get; set; }
    public bool TechnicianResponsible { get; private set; }
    public bool LegalResponsible { get; private set; }
    public bool Active { get; private set; }
    public string Email { get; private set; }
    public string Password { get; private set; }

    public User(long id, long professionalId, bool technicianResponsible, bool legalResponsible, bool active, string email, string password, string? passwordConfirmation)
    {
        Id = id;
        ProfessionalId = professionalId;
        TechnicianResponsible = technicianResponsible;
        LegalResponsible = legalResponsible;
        Active = active;
        Email = email;
        Password = password;
        PasswordConfirmation = passwordConfirmation;
    }

}
