namespace PasswordStorage.Data.Database.Infrastructure.Repository.UnitOfWork
{
    public interface IUnitOfWork
    {
        Task SaveAllAsync();

    }
}
