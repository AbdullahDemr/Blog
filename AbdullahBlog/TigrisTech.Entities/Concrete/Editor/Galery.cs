﻿

using TigrisTech.Shared.Entities.Abstract;

namespace TigrisTech.Entities.Concrete.Editor
{
    public class Galery : EntityBase, IEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
    }
}
