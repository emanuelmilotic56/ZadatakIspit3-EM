using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadatakIspit3_EM
{
    class Program
    {
         static void Main(string[] args)
         {
            Brod brod = new Brod();
            brod.KudaVozi();

            Zrakoplov zrakoplov = new Zrakoplov();
            zrakoplov.KudaVozi();

        }
    }
}
