using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSale
{
    class GamerManager : IGamerService
    {

        IVeritificationService _veritificationManager;

        public GamerManager(IVeritificationService veritificationManager)
        {
            _veritificationManager = veritificationManager;
        }

        public void Add(Gamer gamer)
        {
            if(_veritificationManager.Verify(gamer) == true)
            {
                Console.WriteLine("Doğrulama başarılı, kayıt başarılı.");

            }
            else
            {
                Console.WriteLine("Doğrulama başarısız, kayıt başarısız.");
            }
        }

        public void Delete(Gamer gamer)
        {
            throw new NotImplementedException();
        }


        public void Update(Gamer gamer)
        {
            throw new NotImplementedException();
        }
    }
}
