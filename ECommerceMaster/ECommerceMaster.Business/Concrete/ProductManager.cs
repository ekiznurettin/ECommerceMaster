using AutoMapper;
using ECommerceMaster.Business.Abstract;
using ECommerceMaster.Businnes.Concrete;
using ECommerceMaster.Businnes.Utilities;
using ECommerceMaster.Core.Utilities.Results.Abstract;
using ECommerceMaster.Core.Utilities.Results.ComplexTypes;
using ECommerceMaster.Core.Utilities.Results.Concrete;
using ECommerceMaster.DataAccess.Abstract;
using ECommerceMaster.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ECommerceMaster.Business.Concrete
{
    public class ProductManager : BaseManager, IProductService
    {
        public ProductManager(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {

        }

        public Task<IList<ProductListDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<ProductListDto>> GetAllByNonDeletedAsync()
        {
            var products = await UnitOfWork.Products.GetAllAsync(c => !c.IsDeleted, c => c.Category);
            if (products.Count > -1)
            {
                return new DataResult<ProductListDto>(ResultStatus.Success, new ProductListDto
                {
                    Products = products,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ProductListDto>(ResultStatus.Error, Messages.Product.NotFound(false), new ProductListDto
            {
                Products = null,
                ResultStatus = ResultStatus.Error,
                Message = Messages.Category.NotFound(true)
            });
        }
    }
}
