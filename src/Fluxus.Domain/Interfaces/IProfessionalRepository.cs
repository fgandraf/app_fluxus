
using Fluxus.Domain.Entities;
using Fluxus.Domain.Structs;
using System.Collections.Generic;

namespace Fluxus.Domain.Interfaces
{
    public interface IProfessionalRepository
    {
        public int Insert(Professional body);

        public bool Update(Professional body);

        public bool Delete(int id);

        public Professional GetById(int id);

        public List<ProfessionalIndex> GetIndex();

        public UserInfo GetUser(string username);
        
        public List<ProfessionalNameId> GetTagNameid();
    }
}
