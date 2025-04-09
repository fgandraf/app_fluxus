using Fluxus.Core.Dtos.Branches;
using Fluxus.Core.Models;
using System.Collections.Generic;

namespace Fluxus.Core.Contracts.Databases;

public interface IBranchRepository
{
    public long Insert(Branch body);

    public bool Update(Branch body);

    public bool Delete(string id);

    public Branch GetById(string id);

    public List<BranchIndexResponse> GetIndex();

    public Branch GetContacts(string agencyCode);
}
