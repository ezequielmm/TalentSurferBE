using System.Linq;
using System.Security.Claims;
using EY.TalentSurfer.Support;
using Microsoft.AspNetCore.Http;

namespace EY.TalentSurfer.Support.Api
{
    public class HttpContextUserProvider : IUserProvider
    {
        public string UserName => string.Empty;
        public string ObjectId => string.Empty;
        public string Email => string.Empty;
        public string AppId => string.Empty;
    }
}
