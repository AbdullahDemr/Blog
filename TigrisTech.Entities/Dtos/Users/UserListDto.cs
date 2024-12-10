using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TigrisTech.Entities.Concrete.UserTable;
using TigrisTech.Shared.Entities.Abstract;

namespace TigrisTech.Entities.Dtos.Users
{
    public class UserListDto : DtoGetBase
    {
        public IList<User> Users { get; set; }
        public int? CategoryId { get; set; }
    }
}
