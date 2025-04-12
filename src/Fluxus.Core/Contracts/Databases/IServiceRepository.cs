using Fluxus.Core.Dtos.Services;
using Fluxus.Core.Models;
using System.Collections.Generic;

namespace Fluxus.Core.Contracts.Databases;

public interface IServiceRepository
{
    public long Insert(ServiceCreateRequest body);

    public bool Update(ServiceUpdateRequest body);

    public bool Delete(long id);

    public Service GetById(long id);

    public List<ServiceResponse> GetAll();
}
