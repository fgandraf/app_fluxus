using Fluxus.Core.Models;
using Fluxus.Core.ViewModels;
using System.Collections.Generic;

namespace Fluxus.Core.Contracts.Databases;

public interface IProfessionalRepository
{
    public int Insert(Professional body);

    public bool Update(Professional body);

    public bool Delete(int id);

    public Professional GetById(int id);

    public List<ProfessionalsIndexViewModel> GetIndex();

    public List<ProfessionalNameId> GetTagNameid();
}
