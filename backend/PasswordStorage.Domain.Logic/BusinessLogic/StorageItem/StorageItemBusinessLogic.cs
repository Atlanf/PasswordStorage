using AutoMapper;
using PasswordStorage.Domain.DTO.StorageItem;
using PasswordStorage.Domain.Logic.BusinessLogic.General;
using PasswordStorage.Domain.Logic.Repository.General.UnitOfWork;
using PasswordStorage.Domain.Logic.Repository.Repositories.StorageItemRepository;

namespace PasswordStorage.Domain.Logic.BusinessLogic.StorageItem;

public class StorageItemBusinessLogic :
    GeneralBusinessLogic<Data.Entities.StorageItem, StorageItemDto, StorageItemRepository>, IStorageItemBusinessLogic
{
    public StorageItemBusinessLogic(IMapper mapper,
        UnitOfWork unitOfWork,
        StorageItemRepository repository) : base(mapper, unitOfWork, repository)
    {
    }
}