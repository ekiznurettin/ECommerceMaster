using ECommerceMaster.Core.Utilities.Results.Abstract;
using ECommerceMaster.Entities.Dtos;
using System.Threading.Tasks;

namespace ECommerceMaster.Business.Abstract
{
    public interface ICategoryService
    {
        Task<IDataResult<CategoryListDto>> GetAllByNonDeletedAsync();
    }
}
