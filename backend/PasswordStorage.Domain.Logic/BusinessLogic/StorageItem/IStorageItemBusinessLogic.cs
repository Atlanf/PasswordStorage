using PasswordStorage.Domain.DTO.StorageItem;
using PasswordStorage.Domain.Logic.BusinessLogic.General;
using PasswordStorage.Domain.Logic.Repository.Repositories.StorageItemRepository;

namespace PasswordStorage.Domain.Logic.BusinessLogic.StorageItem;

public interface IStorageItemBusinessLogic :
    IGeneralBusinessLogic<Data.Entities.StorageItem, StorageItemDto, IStorageItemRepository>
{
    
}