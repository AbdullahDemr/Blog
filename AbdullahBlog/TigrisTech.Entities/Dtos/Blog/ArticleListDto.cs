using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TigrisTech.Entities.Concrete.Blog;
using TigrisTech.Shared.Entities.Abstract;


namespace TigrisTech.Entities.Dtos.Blog
{
    public class ArticleListDto : DtoGetBase
    {
        public IList<Article> Articles { get; set; }
        public int? CategoryId { get; set; }

    }
}
