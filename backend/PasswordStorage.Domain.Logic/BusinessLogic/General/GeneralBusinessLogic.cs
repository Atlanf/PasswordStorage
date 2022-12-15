using PasswordStorage.Data.Entities;
using PasswordStorage.Domain.DTO;
using AutoMapper;
using PasswordStorage.Domain.Logic.Repository.General.GenericRepository;
using PasswordStorage.Domain.Logic.Repository.General.UnitOfWork;

namespace PasswordStorage.Domain.Logic.BusinessLogic.General;

public class GeneralBusinessLogic<TEntity, TDto, TRepository> : IGeneralBusinessLogic<TEntity, TDto, TRepository>
    where TEntity : BaseEntity
    where TDto : BaseDto
    where TRepository : IGenericRepository<TEntity>
{
    protected readonly IMapper _mapper;
    protected readonly UnitOfWork _unitOfWork;
    protected readonly TRepository _repository;
    
    public GeneralBusinessLogic(IMapper mapper,
        UnitOfWork unitOfWork,
        TRepository repository)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
        _repository = repository;
    }
    
    public virtual async Task<TDto> GetByIdAsync(Guid id)
    {
        return _mapper.Map<TDto>(await _repository.GetByIdAsync(id));
    }

    public virtual IQueryable<TEntity> GetAll()
    {
        return _repository.GetAll();
    }

    public virtual async Task<Guid> InsertEntityAsync(TDto entitySaveDto)
    {
        var entitySave = _mapper.Map<TEntity>(entitySaveDto);
        return await _repository.InsertAsync(entitySave);
    }

    public virtual async Task<Guid> UpdateEntityAsync(TDto entityUpdateDto)
    {
        var entityUpdate = _mapper.Map<TEntity>(entityUpdateDto);
        return await _repository.UpdateAsync(entityUpdate);
    }

    public virtual async Task DeleteEntityAsync(Guid entityId, bool softDelete)
    {
        await _repository.DeleteAsync(entityId, softDelete);
    }
}