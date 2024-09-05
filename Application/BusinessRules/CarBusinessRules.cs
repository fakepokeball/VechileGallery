using Core.CrossCuttingConcerns.Exceptions;
using Core.Entities.Concrete;

namespace Application.BusinessRules
{
    public class CarBusinessRules
    {
        public void CheckIfCarExists(Car? car)
        {
            if (car is null)
                throw new NotFoundException("Car not found.");
        }
    }
}
