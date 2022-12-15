using PasswordStorage.Data.Entities;
using PasswordStorage.Domain.DTO;
using PasswordStorage.Domain.Logic.Repository.General.GenericRepository;

namespace PasswordStorage.Domain.Logic.BusinessLogic.General;

public interface IGeneralBusinessLogic<TEntity, TDto, TRepository>
    where TEntity : BaseEntity
    where TDto : BaseDto
    where TRepository : IGenericRepository<TEntity>
{
    Task<TDto> GetByIdAsync(Guid id);
    IQueryable<TEntity> GetAll();
    Task<Guid> InsertEntityAsync(TDto entitySaveDto);
    Task<Guid> UpdateEntityAsync(TDto entityUpdateDto);
    Task DeleteEntityAsync(Guid entityId, bool softDelete);
}