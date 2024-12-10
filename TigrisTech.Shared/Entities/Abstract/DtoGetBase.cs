using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TigrisTech.Shared.Utilities.Results.ComplexTypes;

namespace TigrisTech.Shared.Entities.Abstract
{
    public abstract class DtoGetBase
    {
        public virtual ResultStatus ResultStatus { get; set; }
        public virtual string Message { get; set; }
        //Şu anki sayfa
        public virtual int CurrentPage { get; set; } = 1;
        //her sayfada gösterilen kaç değer var(default = 5)
        public virtual int PageSize { get; set; } = 5;
        //Toplamda kaç makale olduğunu tutacak
        public virtual int TotalCount { get; set; }
        //Toplamda kaç sayfa olacağını belirler
        public virtual int TotalPages => (int)Math.Ceiling(decimal.Divide(TotalCount, PageSize));
        public virtual bool ShowPrevious => CurrentPage > 1;
        public virtual bool ShowNext => CurrentPage < TotalPages;
        public virtual bool IsAscending { get; set; } = false;
    }
}
