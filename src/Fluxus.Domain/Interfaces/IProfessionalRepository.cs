
using Fluxus.Domain.Entities;
using Fluxus.Domain.Structs;

namespace Fluxus.Domain.Interfaces
{
    public interface IProfessionalRepository
    {
        public bool Insert(Professional body);
        public bool Update(Professional body);
        public bool Delete(int id);
        public UserInfo GetUser(string username);
        public string GetById(int id);
        public string GetIndex();
        public string GetTagNameid();
    }
}
