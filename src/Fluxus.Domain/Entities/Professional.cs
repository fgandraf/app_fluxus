using System;

namespace Fluxus.Domain.Entities
{

    public class Professional
    {

        public int Id { get; private set; }
        public string Tag { get; private set; }
        public string Name { get; private set; }
        public string Cpf { get; private set; }
        public DateTime Birthday { get; private set; }
        public string Profession { get; private set; }
        public string PermitNumber { get; private set; }
        public string Association { get; private set; }
        public string Phone1 { get; private set; }
        public string Phone2 { get; private set; }
        public string Email { get; private set; }


        public Professional(int id, string tag, string name, string cpf, DateTime birthday, string profession, string permitNumber, string association, string phone1, string phone2, string email)
        {
            Id = id;
            Tag = tag;
            Name = name;
            Cpf = cpf;
            Birthday = birthday;
            Profession = profession;
            PermitNumber = permitNumber;
            Association = association;
            Phone1 = phone1;
            Phone2 = phone2;
            Email = email;
        }
    }
}
