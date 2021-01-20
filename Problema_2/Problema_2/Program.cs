using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2
{
    class Program
    {
        // Se da un vector cu n elemente si o valoare k. 
        // Se cere sa se determine prima pozitie din vector pe care apare k. 
        // Daca k nu apare in vector rezultatul va fi -1. 
        static void Main(string[] args)
        {
            int n, k;
            Console.Write("n: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("k: ");
            k = int.Parse(Console.ReadLine());

            int[] v = new int[n];
            //initializare valori vector
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());

            }
            bool ok = false;
            for (int i = 0; i < n; i++)
            {
                if (v[i] == k)
                {
                    Console.WriteLine($"Valoarea {k} se afla pe pozitia {i}");
                    ok = true;
                    break;
                }
            }

            if (ok == false)
                Console.WriteLine(-1);
        }
    }
}
