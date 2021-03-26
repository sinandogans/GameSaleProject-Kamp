using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSale
{
    class VeritificationManager : IVeritificationService
    {
        public bool Verify(Gamer gamer)
        {
            if(gamer.Id == 1 && gamer.FirstName =="Sinan" && gamer.LastName=="Dogan")
            {
                return true;

            }

            else
            {
                return false;
            }

        }

    }
}
