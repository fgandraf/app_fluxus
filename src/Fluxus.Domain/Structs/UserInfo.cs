
namespace Fluxus.Domain.Structs
{
    public struct UserInfo
    {
        public int Id { get; set; }
        public string Tag { get; set; }
        public bool TechnicianResponsible { get; set; }
        public bool LegalResponsible { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public bool UserActive { get; set; }
    }
}
