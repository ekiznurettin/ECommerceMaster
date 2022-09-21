using ECommerceMaster.DataAccess.Abstract;
using ECommerceMaster.DataAccess.Concrete.EntityFramework;
using System.Threading.Tasks;

namespace ECommerceMaster.DataAccess.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ShopContext _context;
        private EfProductRepository _productRepository= null;
        private EfCategoryRepository _categoryRepository= null;
        private EfUserRepository _userRepository= null;
        private EfOperationClaimRepository _operationClaimRepository= null;
        private EfUserOperationClaimRepository _userOperationClaimRepository = null;

        public UnitOfWork(ShopContext context)
        {
            _context = context;
        }

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }


        public IProductRepository Products => _productRepository ?? new EfProductRepository(_context);

        public ICategoryRepository Categories => _categoryRepository ?? new EfCategoryRepository(_context);

        public IUserRepository Users => _userRepository?? new EfUserRepository(_context);

        public IUserOperationClaimRepository UserOperationClaims => _userOperationClaimRepository ?? new EfUserOperationClaimRepository(_context);

        public IOperationClaimRepository OperationClaims => _operationClaimRepository ?? new EfOperationClaimRepository(_context);

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
