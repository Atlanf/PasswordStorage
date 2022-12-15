using AutoMapper;
using PasswordStorage.Domain.DTO.StorageItemType;
using PasswordStorage.Domain.Logic.BusinessLogic.General;
using PasswordStorage.Domain.Logic.Repository.General.UnitOfWork;
using PasswordStorage.Domain.Logic.Repository.Repositories.StorageItemTypeRepository;

namespace PasswordStorage.Domain.Logic.BusinessLogic.StorageItemType;

public class StorageItemTypeBusinessLogic :
    GeneralBusinessLogic<Data.Entities.StorageItemType, StorageItemTypeDto, StorageItemTypeRepository>
{
    public StorageItemTypeBusinessLogic(IMapper mapper,
        UnitOfWork unitOfWork,
        StorageItemTypeRepository repository) : base(mapper, unitOfWork, repository)
    {
    }
}