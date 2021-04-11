using GameSimulation.Entities;

namespace GameSimulation.Abstract
{
    public interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
