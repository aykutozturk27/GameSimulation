using GameSimulation.Abstract;

namespace GameSimulation.Entities
{
    public class Campaign : IEntity
    {
        public string CampaignName { get; set; }
        public string CampaignStart { get; set; }
        public string CampaignFinish { get; set; }
    }
}
