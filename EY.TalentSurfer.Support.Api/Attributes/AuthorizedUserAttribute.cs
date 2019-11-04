using EY.TalentSurfer.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Linq;

namespace EY.TalentSurfer.Support.Api.Attributes
{
    public class AuthorizedUserAttribute : AuthorizeAttribute, IAuthorizationFilter
    {
        private readonly UserStatus[] _authorizedRoles;

        public AuthorizedUserAttribute(params UserStatus[] roles)
        {
            _authorizedRoles = roles;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (!_authorizedRoles.Any(r => context.HttpContext.User.IsInRole(r.ToString())))
            {
                context.Result = new UnauthorizedResult();
            }
        }
    }
}
