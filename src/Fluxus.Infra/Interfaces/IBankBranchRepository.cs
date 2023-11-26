
using Fluxus.Domain.Entities;
using Fluxus.Infra.Records;
using System.Collections.Generic;

namespace Fluxus.Infra.Interfaces
{
    public interface IBankBranchRepository
    {
        public int Insert(BankBranch body);

        public bool Update(BankBranch body);

        public bool Delete(int id);

        public BankBranch GetById(int id);

        public List<BankBranchIndex> GetIndex();

        public BankBranch GetByCode(string agencyCode);
    }
}
