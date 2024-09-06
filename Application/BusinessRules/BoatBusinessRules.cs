using Core.CrossCuttingConcerns.Exceptions;
using Core.Entities.Concrete;

namespace Application.BusinessRules
{
    public class BoatBusinessRules
    {
        public void CheckIfBoatExists(Boat? boat)
        {
            if (boat is null)
                throw new NotFoundException("Boat not found.");
        }
    }
}