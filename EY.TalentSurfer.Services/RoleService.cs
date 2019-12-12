using AutoMapper;
using EY.TalentSurfer.Domain;
using EY.TalentSurfer.Dto;
using EY.TalentSurfer.Dto.Roles;
using EY.TalentSurfer.Services.Contracts;
using EY.TalentSurfer.Support.Persistence;
using EY.TalentSurfer.Support.Persistence.Sql;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EY.TalentSurfer.Services
{
    public class RoleService : IRoleService
    {
        IRoleRepository _repository;
        IMapper _mapper;
        public RoleService(IRoleRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;

        }
        public async Task<IEnumerable<RoleReadDTO>> GetAllAsync()
        {
            var roles = await _repository.ToListAsync();

            return _mapper.Map<IEnumerable<RoleReadDTO>>(roles);
        }
    }
}
