using NCP.Model.Interfaces;
using System;

namespace NCP.Model.Concrete
{
    public abstract class BaseModel : IEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
