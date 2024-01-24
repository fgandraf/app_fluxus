using Fluxus.Domain.Models;
using Fluxus.Domain.ViewModels;
using System.Collections.Generic;

namespace Fluxus.Domain.Contracts.Databases;

public interface IServiceRepository
{
    public int Insert(Service body);

    public bool Update(Service body);

    public bool Delete(int id);

    public Service GetById(int id);

    public List<ServicesIndexViewModel> GetAll();
}
