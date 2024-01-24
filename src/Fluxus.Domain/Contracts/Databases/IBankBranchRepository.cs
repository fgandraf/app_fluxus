using Fluxus.Domain.Models;
using Fluxus.Domain.ViewModels;
using System.Collections.Generic;

namespace Fluxus.Domain.Contracts.Databases;

public interface IBankBranchRepository
{
    public int Insert(Branch body);

    public bool Update(Branch body);

    public bool Delete(string id);

    public Branch GetById(string id);

    public List<BranchesIndexViewModel> GetIndex();

    public Branch GetContacts(string agencyCode);
}
