using System;

namespace Fluxus.Domain.Entities
{

    public class Profile
    {
        public int Id { get; set; }
        public string Cnpj { get; set; }
        public string TradingName { get; set; }
        public string CompanyName { get; set; }
        public string StateId { get; set; }
        public string CityId { get; set; }
        public string Address { get; set; }
        public string Complement { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public string State { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Email { get; set; }
        public string BankAccountName { get; set; }
        public string BankAccountType { get; set; }
        public string BankAccountBranch { get; set; }
        public string BankAccountDigit { get; set; }
        public string BankAccountNumber { get; set; }
        public DateTime EstablishmentDate { get; set; }
        public string ContractorName { get; set; }
        public string ContractNotice { get; set; }
        public string ContractNumber { get; set; }
        public DateTime ContractEstablished { get; set; }
        public DateTime ContractStart { get; set; }
        public DateTime ContractEnd { get; set; }
        public byte[] Logo { get; set; }



        public Profile(int id, string cnpj, string tradingName, string companyName, string stateId, string cityId, string address, string complement, string district, string city, string zip, string state, string phone1, string phone2, string email, string bankAccountName, string bankAccountType, string bankAccountBranch, string bankAccountDigit, string bankAccountNumber, DateTime establishmentDate, string contractorName, string contractNotice, string contractNumber, DateTime contractEstablished, DateTime contractStart, DateTime contractEnd, byte[] logo)
        {
            Id = id;
            Cnpj = cnpj;
            TradingName = tradingName;
            CompanyName = companyName;
            StateId = stateId;
            CityId = cityId;
            Address = address;
            Complement = complement;
            District = district;
            City = city;
            Zip = zip;
            State = state;
            Phone1 = phone1;
            Phone2 = phone2;
            Email = email;
            BankAccountName = bankAccountName;
            BankAccountType = bankAccountType;
            BankAccountBranch = bankAccountBranch;
            BankAccountDigit = bankAccountDigit;
            BankAccountNumber = bankAccountNumber;
            EstablishmentDate = establishmentDate;
            ContractorName = contractorName;
            ContractNotice = contractNotice;
            ContractNumber = contractNumber;
            ContractEstablished = contractEstablished;
            ContractStart = contractStart;
            ContractEnd = contractEnd;
            Logo = logo;
        }
    }
}
