using GameSimulation.Abstract;
using GameSimulation.Entities;
using System;

namespace GameSimulation.Concrete
{
    public class SalesManager : ISalesService
    {
        public void Sell(Sales sales, Campaign campaign)
        {
            Console.WriteLine("Satış yapıldı: " + sales.SalesPrice + "TL Satış Miktarı: " + sales.SalesAmount + "Adet");
            if (sales.SalesAmount == 0)
            {
                Console.WriteLine("Kampanya uygulandı");
            }
            else
            {
                Console.WriteLine("Üzgünüz: " + campaign.CampaignName + " kampanya uygulanamadı");
            }
        }
    }
}
