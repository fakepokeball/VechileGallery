using Core.Entities.Abstract;
using System.Drawing;

namespace Core.Entities.Concrete
{
    public class Vehicle : Entity<Guid>
    {
        public Color Color { get; set; }
    }
}
