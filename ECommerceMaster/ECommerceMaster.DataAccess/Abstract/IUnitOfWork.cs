using ECommerceMaster.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceMaster.DataAccess.Abstract
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        ICategoryRepository Categories { get; }
        IProductRepository Products { get; }
        IUserRepository Users { get; }
        IUserOperationClaimRepository UserOperationClaims { get; }
        IOperationClaimRepository OperationClaims { get; }


        Task<int> SaveAsync();
    }
}
