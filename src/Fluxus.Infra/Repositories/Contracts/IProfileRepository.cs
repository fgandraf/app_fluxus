using Fluxus.Domain.Entities;

namespace Fluxus.Infra.Repositories.Contracts
{
    public interface IProfileRepository
    {
        public int Insert(Profile profile);

        public bool Update(Profile profile);

        public Profile GetById(int id);

        public Profile GetToPrint();

        public byte[] GetLogo();

        public string GetTradingName();
    }
}
