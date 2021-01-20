using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_9
{
    class Program
    {
        // Rotire k. Se da un vector cu n elemente. Rotiti elementele vectorului cu k pozitii spre stanga. 

        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int n, k;
            Console.Write("Introduceti numarul de elemente: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Introduceti numarul de rotiri: ");
            k = int.Parse(Console.ReadLine());

            int[] v = new int[n];


            for (int i = 0; i < n; i++)
            {
                int x = rnd.Next(10);
                v[i] = x;
                Console.Write($"{v[i]} ");
            }

            for (int j = 0; j < k; j++) 
            {
                int y = v[0];
                for (int i = 1; i < n; i++)
                {
                    v[i - 1] = v[i]; 
                }
                v[n - 1] = y; 
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
                Console.Write($"{v[i]} ");
        }
    }
}
