using GameSimulation.Abstract;
using GameSimulation.Entities;

namespace GameSimulation.Concrete
{
    public class NewEStateUserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            return true;
        }
    }
}
