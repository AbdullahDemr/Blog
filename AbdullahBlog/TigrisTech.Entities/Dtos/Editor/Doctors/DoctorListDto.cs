using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TigrisTech.Entities.Concrete.Editor;
using TigrisTech.Entities.Concrete.Team;
using TigrisTech.Shared.Entities.Abstract;

namespace TigrisTech.Entities.Dtos.Editor.References
{
    public class TeamListDto:DtoBase
    {
        public IList<Team> Teams { get; set; }

    }
}
