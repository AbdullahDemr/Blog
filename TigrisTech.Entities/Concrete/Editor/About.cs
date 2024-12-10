
using TigrisTech.Shared.Entities.Abstract;


namespace TigrisTech.Entities.Concrete.Editor
{
    public class About : EntityBase, IEntity
    {
        public string Description { get; set; }
    }
}
