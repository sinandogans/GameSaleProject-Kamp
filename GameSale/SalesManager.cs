using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSale
{
    class SalesManager : ISalesService
    {

        public void Sale(Gamer gamer, Campaign campaign)
        {
            Console.WriteLine("Satış " +gamer.FirstName+ " adlı oyuncuya " + campaign.Name+ " kampanyası kullanılarak yapıldı.");
        }
    }
}
