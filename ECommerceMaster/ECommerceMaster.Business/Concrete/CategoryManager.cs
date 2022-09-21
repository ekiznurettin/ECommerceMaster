using AutoMapper;
using ECommerceMaster.Business.Abstract;
using ECommerceMaster.Businnes.Concrete;
using ECommerceMaster.Businnes.Utilities;
using ECommerceMaster.Core.Utilities.Results.Abstract;
using ECommerceMaster.Core.Utilities.Results.ComplexTypes;
using ECommerceMaster.Core.Utilities.Results.Concrete;
using ECommerceMaster.DataAccess.Abstract;
using ECommerceMaster.Entities.Dtos;
using System.Threading.Tasks;

namespace ECommerceMaster.Business.Concrete
{
    public class CategoryManager : BaseManager, ICategoryService
    {
        public CategoryManager(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {

        }
        public async Task<IDataResult<CategoryListDto>> GetAllByNonDeletedAsync()
        {
            var categories = await UnitOfWork.Categories.GetAllAsync(c => !c.IsDeleted);
            if (categories.Count > -1)
            {
                return new DataResult<CategoryListDto>(ResultStatus.Success, new CategoryListDto
                {
                    Categories = categories,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<CategoryListDto>(ResultStatus.Error, Messages.Category.NotFound(false), new CategoryListDto
            {
                Categories = null,
                ResultStatus = ResultStatus.Error,
                Message = Messages.Category.NotFound(true)
            });
        }
    }
}
