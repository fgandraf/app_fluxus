using Fluxus.Core.Dtos.Professionals;
using Fluxus.Core.Models;
using System.Collections.Generic;

namespace Fluxus.Core.Contracts.Databases;

public interface IProfessionalRepository
{
    public long Insert(ProfessionalCreateRequest body);

    public bool Update(ProfessionalUpdateRequest body);

    public bool Delete(long id);

    public Professional GetById(long id);

    public List<ProfessionalIndexResponse> GetIndex();

    public List<ProfessionalTagNameIdResponse> GetTagNameid();
}
