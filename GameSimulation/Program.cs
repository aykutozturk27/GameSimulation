using GameSimulation.Concrete;
using GameSimulation.Entities;

namespace GameSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { Id = 1, BirthYear = 1992, FirstName = "Aykut", LastName = "Öztürk", IdentityNumber = 12345 });

            CampaignManager campaignManager = new CampaignManager();
            Campaign campaign = new Campaign { CampaignName = "4 al 3 öde", CampaignStart = "10.04.2021", CampaignFinish = "10.05.2021" };

            SalesManager salesManager = new SalesManager();
            Sales sales = new Sales { SalesPrice = 300, SalesAmount = 10 };

            salesManager.Sell(sales, campaign);
        }
    }
}
