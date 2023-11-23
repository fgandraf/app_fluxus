
using System;

namespace Fluxus.Domain.Entities
{

    public class Professional
    {
        private string? _userPasswordConfirmation;
        public bool IsValid { get; private set; }
        public string? Message { get; private set; }

        public int Id { get; private set; }
        public string Tag { get; private set; }
        public string Name { get; private set; }


        private string? _nameId;
        public string? Nameid 
        {
            get => _nameId;
            set
            {
                if (value != null)
                {
                    string nameIdConstructor = string.Empty;
                    if (!string.IsNullOrEmpty(Profession))
                        nameIdConstructor = Profession.Substring(0, 3) + ". ";

                    string[] nomeCompleto = Name.Split(' ');
                    nameIdConstructor += nomeCompleto[0] + " " + nomeCompleto[nomeCompleto.Length - 1];

                    _nameId = nameIdConstructor;

                }
            }
        }


        public string Cpf { get; private set; }
        public DateTime Birthday { get; private set; }
        public string Profession { get; private set; }
        public string PermitNumber { get; private set; }
        public string Association { get; private set; }
        public string Phone1 { get; private set; }
        public string Phone2 { get; private set; }
        public string Email { get; private set; }
        public bool TechnicianResponsible { get; private set; }
        public bool LegalResponsible { get; private set; }
        public bool UserActive { get; private set; }
        public string UserName { get; private set; }
        public string UserPassword { get; private set; }


        public Professional(int id, string tag, string name, string nameid, string cpf, DateTime birthday, string profession, string permitNumber, string association, string phone1, string phone2, string email, bool technicianResponsible, bool legalResponsible, bool userActive, string userName, string userPassword, string ?userPasswordConfirmation)
        {
            Id = id;
            Tag = tag;
            Name = name;
            Nameid = nameid;
            Cpf = cpf;
            Birthday = birthday;
            Profession = profession;
            PermitNumber = permitNumber;
            Association = association;
            Phone1 = phone1;
            Phone2 = phone2;
            Email = email;
            TechnicianResponsible = technicianResponsible;
            LegalResponsible = legalResponsible;
            UserActive = userActive;
            UserName = userName;
            UserPassword = userPassword;
            _userPasswordConfirmation = userPasswordConfirmation;

            Validate();
        }


        private void Validate()
        {
            if (string.IsNullOrEmpty(Tag) || string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(UserName))
            {
                Message = "Campos com * são obrigatório";
                IsValid = false;
            }

            if (string.IsNullOrWhiteSpace(UserPassword) || UserPassword != _userPasswordConfirmation)
            {
                Message = "Senhas não conferem";
                IsValid = false;
            }


            IsValid = true;
        }

    }
}
