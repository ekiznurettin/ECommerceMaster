using ECommerceMaster.Core.Utilities.Results.Abstract;
using ECommerceMaster.Entities.Concrete;
using ECommerceMaster.Entities.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ECommerceMaster.Business.Abstract
{
    public interface IProductService
    {
        Task<IList<ProductListDto>> GetAllAsync();

        Task<IDataResult<ProductListDto>> GetAllByNonDeletedAsync();
       
        
        //Product GetById(int Id);
        //List<Product> GetAll();
        //List<Product> GetPopularProduct();
        //void Create(Product product);
        //void Update(Product product);
        //void Delete(Product product);
    }
}
