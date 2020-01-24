using EY.TalentSurfer.Support.Services.Contracts;

namespace EY.TalentSurfer.Dto
{
    public class UserCreateDto : ICreateDto
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
    }
}
