
namespace Fluxus.Core.Models;

public class User
{
    public string? UserPasswordConfirmation { get; private set; }


    public long Id { get; private set; }
    public long ProfessionalId { get; set; }
    public bool TechnicianResponsible { get; private set; }
    public bool LegalResponsible { get; private set; }
    public bool UserActive { get; private set; }
    public string UserName { get; private set; }
    public string UserPassword { get; private set; }

    public User(long id, long professionalId, bool technicianResponsible, bool legalResponsible, bool userActive, string userName, string userPassword, string? userPasswordConfirmation)
    {
        Id = id;
        ProfessionalId = professionalId;
        TechnicianResponsible = technicianResponsible;
        LegalResponsible = legalResponsible;
        UserActive = userActive;
        UserName = userName;
        UserPassword = userPassword;
        UserPasswordConfirmation = userPasswordConfirmation;
    }

}
