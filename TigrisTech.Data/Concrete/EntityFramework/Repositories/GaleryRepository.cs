using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TigrisTech.Data.Abstract;
using TigrisTech.Entities.Concrete.Editor;
using TigrisTech.Shared.Data.Concrete;

namespace TigrisTech.Data.Concrete.EntityFramework.Repositories
{
    public class GaleryRepository : EfEntityRepositoryBase<Galery>, IGaleryRepository
    {
        public GaleryRepository(DbContext context) : base(context)
        {
        }
    }
}
