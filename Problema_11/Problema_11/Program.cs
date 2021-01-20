using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_11
{
    class Program
    {
        // Se da un numar natural n. 
        // Se cere sa se afiseze toate numerele prime mai mici sau egale cu n (ciurul lui Eratostene). 
        static void Main(string[] args)
        {
            List<int> Sir = new List<int>();

            int n;
            Console.Write("n: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 2; i <= n; i++)
                Sir.Add(i);

            int[] v = new int[n]; int k = 0;

            foreach (int numar in Sir.ToList()) 
            {
                if (numar * 2 < 10)
                {
                    for (int multiplu = 2; numar * multiplu <= n; multiplu++)
                        Sir.Remove(numar * multiplu);
                    
                    k = 0;
                    foreach (int nr_ramas in Sir)
                        v[k++] = nr_ramas;

                }
                else
                    break;

            }
            Console.WriteLine();
            Console.WriteLine($"Sunt {k} numere prime din intervalul [2,{n}] iar ele sunt: ");
            for (int i = 0; i < k; i++)
                Console.Write(v[i] + " ");

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
