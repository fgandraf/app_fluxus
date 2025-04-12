using Fluxus.Core.Models;
using System;

namespace Fluxus.Core.Dtos.Professionals;

public record ProfessionalUpdateRequest
{
    public long Id { get; set; }
    public string Tag { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Cpf { get; set; } = string.Empty;
    public DateTime Birthday { get; set; }
    public string Profession { get; set; } = string.Empty;
    public string PermitNumber { get; set; } = string.Empty;
    public string Association { get; set; } = string.Empty;
    public string Phone1 { get; set; } = string.Empty;
    public string Phone2 { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;

    public ProfessionalUpdateRequest(Professional professional)
    {
        Id = professional.Id;
        Tag = professional.Tag;
        Name = professional.Name;
        Cpf = professional.Cpf;
        Birthday = professional.Birthday;
        Profession = professional.Profession;
        PermitNumber = professional.PermitNumber;
        Association = professional.Association;
        Phone1 = professional.Phone1;
        Phone2 = professional.Phone2;
        Email = professional.Email;
    }

    public ProfessionalUpdateRequest() { }
}