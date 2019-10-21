using EY.TalentSurfer.Support.Services.Contracts;
using EY.TalentSurfer.Support.Persistence;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EY.TalentSurfer.Services.Contracts
{
    public interface IBaseService<TEntity, TCreate, TRead, TUpdate>
        where TEntity : Entity
        where TCreate : ICreateDto
        where TRead : IReadDto
        where TUpdate : IUpdateDto
    {
        Task<TRead> GetAsync(int id);
        Task<IEnumerable<TRead>> GetAllAsync();
        Task<TRead> UpdateAsync(int id, TUpdate updateDto);
        Task<TRead> CreateAsync(TCreate createDto);
        Task DeleteAsync(int id);
        Task<bool> ExistsAsync(int id);
    }
}
