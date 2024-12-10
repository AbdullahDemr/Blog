using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TigrisTech.Shared.Entities.Abstract;

namespace TigrisTech.Entities.Concrete.Editor
{
    public class Takimarka : EntityBase, IEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Test { get; set; }
    }
}
