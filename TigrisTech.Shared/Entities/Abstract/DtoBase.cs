using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TigrisTech.Shared.Utilities.Results.ComplexTypes;

namespace TigrisTech.Shared.Entities.Abstract
{
    public abstract class DtoBase
    {
        public virtual ResultStatus ResultStatus { get; set; }
        public virtual string Message { get; set; }
        public Team team { get; set; }
    }
}
