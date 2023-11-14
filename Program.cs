using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int par = 0;
            int nepar = 0;
            int [] mjau = new int [10];
            int [] woof = new int [10];
            while ((x != 0) || (par < 8) || (nepar < 8)) 
            {
                Console.WriteLine("upisite neki broj");
                x = Convert.ToInt32(Console.ReadLine());
                if(x % 2 == 0)
                {
                    mjau[par] = x;
                    par++;
                }
                if (x % 2 == 1)
                {
                    woof[nepar] = x;
                    nepar++;
                }
            } 
        }
    }
}
