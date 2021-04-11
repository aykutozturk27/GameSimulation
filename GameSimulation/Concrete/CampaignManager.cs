using GameSimulation.Abstract;
using GameSimulation.Entities;
using System;

namespace GameSimulation.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya eklendi.");
        }
        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya güncellendi.");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya silindi.");
        }

    }
}
