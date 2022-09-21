using ECommerceMaster.Core.Utilities.Results.ComplexTypes;
using System;

namespace ECommerceMaster.Core.Entities.Abtract
{
    public abstract class DtoGetBase
    {
        public virtual ResultStatus ResultStatus { get; set; }
        public virtual string Message { get; set; }

        //Makale sayfalama işlemi için eklendi
        public virtual int CurrentPage { get; set; } = 1;
        public virtual int PageSize { get; set; } = 5;
        public virtual int TotalCount { get; set; }
        public virtual int TotalPage => (int)Math.Ceiling(decimal.Divide(TotalCount, PageSize));
        public virtual bool ShowPrevious => CurrentPage > 1;
        public virtual bool ShowNext => CurrentPage < TotalPage;
        public virtual bool IsAscending { get; set; } = false;
        /////
    }
}
