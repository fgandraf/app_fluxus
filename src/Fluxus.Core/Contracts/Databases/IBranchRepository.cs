using Fluxus.Core.Models;
using Fluxus.Core.ViewModels;
using System.Collections.Generic;

namespace Fluxus.Core.Contracts.Databases;

public interface IBranchRepository
{
    public int Insert(Branch body);

    public bool Update(Branch body);

    public bool Delete(string id);

    public Branch GetById(string id);

    public List<BranchesIndexViewModel> GetIndex();

    public Branch GetContacts(string agencyCode);
}
