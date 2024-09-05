using Core.Enums;

namespace Core.Entities.Abstract
{
    public abstract class Vehicle : Entity<Guid>
    {
        public Color Color { get; set; }
    }
}
