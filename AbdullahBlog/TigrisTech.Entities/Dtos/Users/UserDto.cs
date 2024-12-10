using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TigrisTech.Entities.Concrete.UserTable;
using TigrisTech.Shared.Entities.Abstract;


namespace TigrisTech.Entities.Dtos.Users
{
    public class UserDto:DtoGetBase
    {
        public User User { get; set; }
    }
}
