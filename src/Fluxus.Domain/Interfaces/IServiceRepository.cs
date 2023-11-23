
using Fluxus.Domain.Entities;
using Fluxus.Domain.Records;
using System.Collections.Generic;

namespace Fluxus.Domain.Interfaces
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
