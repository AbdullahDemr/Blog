using System.Collections.Generic;
using TigrisTech.Entities.Concrete.UserTable;

namespace TigrisTech.MvcUI.Areas.Admin.Models
{
    public class UserWithRolesViewModel
    {
        public User User { get; set; }
        public IList<string> Roles { get; set; }

    }
}
