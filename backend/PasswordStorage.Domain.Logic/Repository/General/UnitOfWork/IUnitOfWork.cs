using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordStorage.Domain.Logic.Repository.General.UnitOfWork
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        Task SaveAllAsync();
    }
}
