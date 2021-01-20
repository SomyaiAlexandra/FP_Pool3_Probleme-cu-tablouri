using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1
{
    class Program
    {
        // Calculati suma elementelor unui vector de n numere citite de la tastatura. 
        // Rezultatul se va afisa pe ecran.
        static void Main(string[] args)
        {
            int n;
            Console.Write("n: ");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int S = 0;
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
                S = S + v[i];
            }
            Console.WriteLine($"Suma este: {S}");
        }
    }
}
