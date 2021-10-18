using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadatakIspit3_EM
{
    class Vozilo
    {
       public bool JeLiLeti;
        public bool JeLiPlovi;

        public void KudaVozi()
        {
            Console.WriteLine(" {1}, {0}", JeLiLeti, JeLiPlovi);
        }
    }
}
