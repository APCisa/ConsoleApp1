using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Joris
{
    public class Joris : IJoris
    {
        public void DireBonjour()
        {
            Console.WriteLine("Bonjour, je suis Joris !");
        }

        public void DireAuRevoir()
        {
            Console.WriteLine("Je suis Joris, au revoir !");
        }
    }
}
