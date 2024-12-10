using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TigrisTech.Shared.Utilities.Results.Abstract
{
    //out istersek tek bir nesnede istesekte bir liste döndürebiliriz.
    public interface IDataResult<out T> : IResult 
    {
        public T Data { get; } // new DataResult<Category>(ResultStatus.Success, category)

    }
}
