using GameSimulation.Abstract;
using GameSimulation.Entities;

namespace GameSimulation.Concrete
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1992 && gamer.FirstName == "Aykut" && gamer.LastName == "Öztürk" && gamer.IdentityNumber == 12345)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
