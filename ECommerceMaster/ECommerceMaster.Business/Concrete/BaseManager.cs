using AutoMapper;
using ECommerceMaster.DataAccess.Abstract;

namespace ECommerceMaster.Businnes.Concrete
{
    public  class BaseManager
    {
        protected IUnitOfWork UnitOfWork { get; }
        protected IMapper Mapper { get; }

        public BaseManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            UnitOfWork = unitOfWork;
            Mapper = mapper;
        }
    }
}
