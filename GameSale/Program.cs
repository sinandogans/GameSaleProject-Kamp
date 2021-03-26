using System;

namespace GameSale
{
    class Program
    {
       
        //Sinan Doğan, Engin Demiroğ Project
        
        
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer() { FirstName = "Sinan", LastName = "Dogan", Id = 1 };
            
            GamerManager gamerManager = new GamerManager(new VeritificationManager());

            gamerManager.Add(gamer1);

            CampaignManager campaignManager = new CampaignManager();
            
            Campaign campaign1 = new Campaign() { CampaignId = 1, Name = "Bindirim" };

            campaignManager.Add(campaign1);
            
            SalesManager salesManager = new SalesManager();

            salesManager.Sale(gamer1, campaign1);










        }
    }
}
