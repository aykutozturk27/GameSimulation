using GameSimulation.Entities;

namespace GameSimulation.Abstract
{
    public interface ISalesService
    {
        void Sell(Sales sales, Campaign campaign);
    }
}
