using GameSimulation.Abstract;

namespace GameSimulation.Entities
{
    public class Sales : IEntity
    {
        public int SalesPrice { get; set; }
        public int SalesAmount { get; set; }
    }
}
