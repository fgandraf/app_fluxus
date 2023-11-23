
namespace Fluxus.Domain.Entities
{

    public class BankBranch
    {
        public bool IsValid { get; private set; }
        public string? Message { get; private set; }



        public int Id { get; private set; }
        public string BranchNumber { get; private set; }
        public string Name { get; private set; }
        public string Address { get; private set; }
        public string Complement { get; private set; }
        public string District { get; private set; }
        public string City { get; private set; }
        public string Zip { get; private set; }
        public string State { get; private set; }
        public string ContactName { get; private set; }
        public string Phone1 { get; private set; }
        public string Phone2 { get; private set; }
        public string Email { get; private set; }



        public BankBranch(int id, string branchNumber, string name, string address, string complement, string district, string city, string zip, string state, string contactName, string phone1, string phone2, string email)
        {
            Id = id;
            BranchNumber = branchNumber;
            Name = name;
            Address = address;
            Complement = complement;
            District = district;
            City = city;
            Zip = zip;
            State = state;
            ContactName = contactName;
            Phone1 = phone1;
            Phone2 = phone2;
            Email = email;

            Validate();
        }

        private void Validate()
        {
            if (string.IsNullOrEmpty(BranchNumber))
            {
                Message = "Campos com * são obrigatório";
                IsValid = false;
            }
            IsValid = true;

        }

        
    }


}
