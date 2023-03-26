using Fluxus.Domain.Entities;
using Fluxus.Infra.Repositories;
using System.Data;

namespace Fluxus.Services
{
    public class ProfileService
    {

        public void InsertOrUpdate(string method, Profile profile)
        {
            if (method == "Update")
                new ProfileRepository().Update(profile);
            else
                new ProfileRepository().Insert(profile);
        }


        public Profile GetAll() 
            => new ProfileRepository().GetAll();


        public Profile GetToPrint() 
            => new ProfileRepository().GetToPrint();


        public byte[] GetLogo()
            => new ProfileRepository().GetLogo();


        public string GetTradingName() 
            => new ProfileRepository().GetName();

    }
}
