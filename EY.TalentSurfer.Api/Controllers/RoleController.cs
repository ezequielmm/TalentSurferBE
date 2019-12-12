using EY.TalentSurfer.Domain;
using EY.TalentSurfer.Dto.Roles;
using EY.TalentSurfer.Services.Contracts;
using EY.TalentSurfer.Support;
using EY.TalentSurfer.Support.Api.Attributes;
using EY.TalentSurfer.Support.Exceptions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Threading.Tasks;
using EY.TalentSurfer.Api.Base;
using System.Collections.Generic;

namespace EY.TalentSurfer.Api.Controllers
{
    public class RoleController : TalentSurferBaseController
    {
        private readonly IRoleService _roleService;

        public RoleController(IRoleService roleService)
        {
            _roleService = roleService;
        }

        // GET: api/Status
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RoleReadDTO>>> GetRoles()
        {
            var roles = await _roleService.GetAllAsync();
            return Ok(roles);
        }
    }
}