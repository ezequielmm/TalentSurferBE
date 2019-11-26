using EY.TalentSurfer.Support.Persistence;

namespace EY.TalentSurfer.Domain
{
    public class RefreshToken : AuditableEntity
    {
        public string Username { get; set; }
        public string Token { get; set; }
        public bool Revoked { get; set; }
    }
}