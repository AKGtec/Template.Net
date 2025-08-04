using ProjectTemplate.Shared.RequestFeatures;

namespace ProjectTemplate.Service.Contracts;

public interface IBaseService<TDto, TEntity>
{
    Task<IEnumerable<TDto>> GetAllAsync(RequestParameters parameters, bool trackChanges);
    Task<TDto?> GetByIdAsync(int id, bool trackChanges);
    Task<TDto> CreateAsync(TDto dto);
    Task UpdateAsync(int id, TDto dto, bool trackChanges);
    Task DeleteAsync(int id, bool trackChanges);
}
