
using Fluxus.Domain.Entities;
using Fluxus.Domain.Structs;
using System.Collections.Generic;

namespace Fluxus.Domain.Interfaces
{
    public interface IProfessionalRepository
    {
        public bool Insert(Professional body);
        public bool Update(Professional body);
        public bool Delete(int id);
        public UserInfo GetUser(string username);
        public Professional GetById(int id);
        public List<ProfessionalIndex> GetIndex();
        public List<ProfessionalNameId> GetTagNameid();
    }
}
