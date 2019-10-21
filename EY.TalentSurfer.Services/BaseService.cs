using AutoMapper;
using EY.TalentSurfer.Support.Services.Contracts;
using EY.TalentSurfer.Services.Contracts;
using EY.TalentSurfer.Support.Persistence;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EY.TalentSurfer.Services
{
    public class BaseService<TEntity, TCreateDto, TReadDto, TUpdateDto> : IBaseService<TEntity, TCreateDto, TReadDto, TUpdateDto>
        where TEntity : Entity
        where TCreateDto : ICreateDto
        where TReadDto : IReadDto
        where TUpdateDto : IUpdateDto
    {
        protected readonly IRepository<TEntity> _repository;
        protected readonly IMapper _mapper;

        public BaseService(IRepository<TEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<TReadDto> GetAsync(int id)
        {
            var entity = await _repository.FindAsync(id);
            return _mapper.Map<TReadDto>(entity);
        }

        public async Task<IEnumerable<TReadDto>> GetAllAsync()
        {
            var entities = await _repository.ToListAsync();
            return _mapper.Map<IEnumerable<TReadDto>>(entities);
        }

        public async Task<TReadDto> UpdateAsync(int id, TUpdateDto updateDto)
        {
            var entity = await _repository.FindAsync(id);
            _mapper.Map(updateDto, entity);
            await _repository.UpdateAsync(entity);
            return _mapper.Map<TReadDto>(entity);
        }

        public async Task<TReadDto> CreateAsync(TCreateDto createDto)
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
