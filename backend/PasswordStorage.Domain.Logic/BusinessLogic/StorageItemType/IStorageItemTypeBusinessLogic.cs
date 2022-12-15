using PasswordStorage.Domain.DTO.StorageItemType;
using PasswordStorage.Domain.Logic.BusinessLogic.General;
using PasswordStorage.Domain.Logic.Repository.Repositories.StorageItemTypeRepository;

namespace PasswordStorage.Domain.Logic.BusinessLogic.StorageItemType;

public interface IStorageItemTypeBusinessLogic :
    IGeneralBusinessLogic<Data.Entities.StorageItemType, StorageItemTypeDto, StorageItemTypeRepository>
{
    
}