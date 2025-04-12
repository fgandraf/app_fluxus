using Fluxus.Core.Dtos.Branches;
using Fluxus.Core.Models;
using System.Collections.Generic;

namespace Fluxus.Core.Contracts.Databases;

public interface IBranchRepository
{
    public long Insert(BranchCreateRequest body);

    public bool Update(BranchUpdateRequest body);

    public bool Delete(string id);

    public Branch GetById(string id);

    public List<BranchIndexResponse> GetIndex();

    public BranchIndexResponse GetContacts(string agencyCode);
}
