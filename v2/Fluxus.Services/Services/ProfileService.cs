using Fluxus.Domain.Entities;
using Fluxus.Infra.Repositories;
using System;
using System.Data;


namespace Fluxus.Services
{
    public class ProfileService
    {



        public void Insert(Profile body)
        {
            new ProfileRepository().Insert(body);
        }



        public void Update(Profile body)
        {
            new ProfileRepository().Update(body);
        }



        public Profile ListarCadastrais()
        {
            DataTable dt = new ProfileRepository().GetAll();
            Profile retorno = new Profile
            {
                Cnpj = dt.Rows[0]["cnpj"].ToString(),
                TradingName = dt.Rows[0]["tradingName"].ToString(),
                CompanyName = dt.Rows[0]["companyName"].ToString(),
                StateId = dt.Rows[0]["stateId"].ToString(),
                CityId = dt.Rows[0]["cityId"].ToString(),
                Address = dt.Rows[0]["address"].ToString(),
                Complement = dt.Rows[0]["complement"].ToString(),
                District = dt.Rows[0]["district"].ToString(),
                City = dt.Rows[0]["city"].ToString(),
                Zip = dt.Rows[0]["zip"].ToString(),
                State = dt.Rows[0]["state"].ToString(),
                EstablishmentDate = Convert.ToDateTime(dt.Rows[0]["establishmentDate"]),
                Phone1 = dt.Rows[0]["phone1"].ToString(),
                Phone2 = dt.Rows[0]["phone2"].ToString(),
                Email = dt.Rows[0]["email"].ToString(),
                BankAccountName = dt.Rows[0]["bankAccountName"].ToString(),
                BankAccountType = dt.Rows[0]["bankAccountType"].ToString(),
                BankAccountBranch = dt.Rows[0]["bankAccountBranch"].ToString(),
                BankAccountDigit = dt.Rows[0]["bankAccountDigit"].ToString(),
                BankAccountNumber = dt.Rows[0]["bankAccountNumber"].ToString(),
                ContractorName = dt.Rows[0]["contractorName"].ToString(),
                ContractNotice = dt.Rows[0]["contractNotice"].ToString(),
                ContractNumber = dt.Rows[0]["contractNumber"].ToString(),
                ContractEstablished = Convert.ToDateTime(dt.Rows[0]["contractEstablished"]),
                ContractStart = Convert.ToDateTime(dt.Rows[0]["contractStart"]),
                ContractEnd = Convert.ToDateTime(dt.Rows[0]["contractEnd"]),
                Logo = dt.Rows[0]["logo"].ToString()
            };

            return retorno;
        }



        public DataTable DadosParaImpressao()
        {
            return new ProfileRepository().GetToPrint();
        }



        public string GetFantasia()
        {
            return new ProfileRepository().GetName();
        }



    }



}
