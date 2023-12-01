using Fluxus.Domain.Entities;
using Fluxus.Infra.Records;
using System.Collections.Generic;

namespace Fluxus.Infra.Repositories.Contracts
{
    public interface IServiceRepository
    {
        public int Insert(Service body);

        public bool Update(Service body);

        public bool Delete(int id);

        public Service GetById(int id);

        public List<ServiceIndex> GetAll();
    }
}
