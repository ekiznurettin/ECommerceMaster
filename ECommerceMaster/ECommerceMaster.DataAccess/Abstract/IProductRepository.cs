using ECommerceMaster.Core.DataAccess.Abstract;
using ECommerceMaster.Entities.Concrete;
using System.Collections.Generic;

namespace ECommerceMaster.DataAccess.Abstract
{
    public interface IProductRepository: IEntityRepository<Product>
    {
        List<Product> GetPopularProducts();
    }
}
