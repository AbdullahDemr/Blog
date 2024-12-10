using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TigrisTech.Data.Abstract;
using TigrisTech.Data.Concrete.EntityFramework.Contexts;
using TigrisTech.Entities.Concrete.Blog;
using TigrisTech.Shared.Data.Concrete;


namespace TigrisTech.Data.Concrete.Repositories
{
    public class CategoryRepository : EfEntityRepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(DbContext context) : base(context)
        {
        }
        protected TigrisContext BlogContext
        {
            get
            {
                return _context as TigrisContext;  
            }
        }
        public async Task<Category> GetByIdAsync(int categoryId)
        {
            return await BlogContext.Categories.SingleOrDefaultAsync(c => c.Id == categoryId);
        }
    }
}
