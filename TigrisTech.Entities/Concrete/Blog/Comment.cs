using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TigrisTech.Shared.Entities.Abstract;

namespace TigrisTech.Entities.Concrete.Blog
{
    public class Comment : EntityBase, IEntity
    {
        //public override bool IsActive { get; set; } = false;
        public string Text { get; set; }
        public int ArticleId { get; set; }
        //Bir yorum sadece bir makaleye eklenebilir. 
        public Article Article { get; set; }

    }
}
