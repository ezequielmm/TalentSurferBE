using AutoMapper;
using EY.TalentSurfer.Dto.Contracts;
using EY.TalentSurfer.Services.Contracts;
using EY.TalentSurfer.Support.Persistence;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EY.TalentSurfer.Services
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : Entity
    {
        protected readonly IRepository<TEntity> _repository;
        protected readonly IMapper _mapper;

        public BaseService(IRepository<TEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<TReadDto> GetAsync<TReadDto>(int id) where TReadDto : IReadDto
        {
            var entity = await _repository.FindAsync(id);
            return _mapper.Map<TReadDto>(entity);
        }

        public async Task<IEnumerable<TReadDto>> GetAllAsync<TReadDto>() where TReadDto : IReadDto
        {
            var entities = await _repository.ToListAsync();
            return _mapper.Map<IEnumerable<TReadDto>>(entities);
        }

        public async Task UpdateAsync(int id, object updateDto)
        {
            var entity = await _repository.FindAsync(id);
            _mapper.Map(updateDto, entity);
            await _repository.UpdateAsync(entity);
        }

        public async Task<TReadDto> CreateAsync<TReadDto>(object createDto) where TReadDto : IReadDto
        {
            var entity = _mapper.Map<TEntity>(createDto);
            await _repository.InsertAsync(entity);
            return _mapper.Map<TReadDto>(entity);
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _repository.FindAsync(id);
            await _repository.DeleteAsync(entity);
        }

        public async Task<bool> ExistsAsync(int id)
        {
            return await _repository.ExistsAsync(id);
        }
    }
}
