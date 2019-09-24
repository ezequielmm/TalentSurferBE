using EY.TalentSurfer.Dto.Contracts;
using EY.TalentSurfer.Support.Persistence;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EY.TalentSurfer.Services.Contracts
{
    public interface IBaseService<TEntity> where TEntity : Entity
    {
        Task<TReadDto> GetAsync<TReadDto>(int id) where TReadDto : IReadDto;
        Task<IEnumerable<TReadDto>> GetAllAsync<TReadDto>() where TReadDto : IReadDto;
        Task UpdateAsync(int id, object updateDto);
        Task<TReadDto> CreateAsync<TReadDto>(object createDto) where TReadDto : IReadDto;
        Task DeleteAsync(int id);
        Task<bool> ExistsAsync(int id);
    }
}
