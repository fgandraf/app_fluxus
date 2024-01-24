using Fluxus.Domain.Models;
using Fluxus.Domain.ViewModels;
using System.Collections.Generic;

namespace Fluxus.Domain.Contracts.Databases;

public interface IProfessionalRepository
{
    public int Insert(Professional body);

    public bool Update(Professional body);

    public bool Delete(int id);

    public Professional GetById(int id);

    public List<ProfessionalsIndexViewModel> GetIndex();

    public List<ProfessionalNameId> GetTagNameid();
}
