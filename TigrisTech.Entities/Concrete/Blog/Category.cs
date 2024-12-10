using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TigrisTech.Shared.Entities.Abstract;

namespace TigrisTech.Entities.Concrete.Blog
{
    public class Category : EntityBase, IEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        //Bir tane kategori birden fazla makaleye sahip olabilir.
        public ICollection<Article> Articles { get; set; }
    }
}
