using Core.CrossCuttingConcerns.Exceptions;
using Core.Entities.Concrete;

namespace Application.BusinessRules
{
    public class BusBusinessRules
    {
        public void CheckIfBusExists(Bus? bus)
        {
            if (bus is null)
                throw new NotFoundException("Bus not found.");
        }
    }
}