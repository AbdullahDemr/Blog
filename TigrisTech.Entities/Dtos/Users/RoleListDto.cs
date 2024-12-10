using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TigrisTech.Entities.Concrete.UserTable;


namespace TigrisTech.Entities.Dtos.Users
{
    public class RoleListDto
    {
        public IList<Role> Roles { get; set; }
    }
}
