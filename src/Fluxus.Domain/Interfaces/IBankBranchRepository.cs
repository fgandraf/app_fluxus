
using Fluxus.Domain.Entities;
using Fluxus.Domain.Structs;
using System.Collections.Generic;

namespace Fluxus.Domain.Interfaces
{
    public interface IBankBranchRepository
    {
        public bool Insert(BankBranch body);

        public bool Update(BankBranch body);

        public bool Delete(int id);

        public List<BankBranchIndex> GetIndex();

        public BankBranch GetByCode(string agencyCode);

        public BankBranch GetById(int id);
    }
}
