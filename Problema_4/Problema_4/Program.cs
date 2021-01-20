using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_4
{
    class Program
    {
        // Deteminati printr-o singura parcurgere, cea mai mica si cea mai mare valoare 
        // dintr-un vector si de cate ori apar acestea. 
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int n;
            Console.Write("n: ");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int x = rnd.Next(11);
            v[0] = x;
            Console.Write($"{v[0]} ");
            int nr_aparitii1 = 1;
            int nr_aparitii2 = 1;
            int min = x;
            int max = x;

            for (int i = 1; i < n; i++)
            {
                int y = rnd.Next(11);
                Console.Write($"{y} ");
                v[i] = y;
                if (v[i] <= min)
                {
                    if (v[i] == min)
                    {
                        nr_aparitii1++;
                        //Console.WriteLine("daaa");
                    }
                    else
                    {
                        nr_aparitii1 = 1;
                        min = v[i];
                    }

                }
                if (v[i] >= max)
                {

                    if (v[i] == max)
                    {
                        nr_aparitii2++;
                        //Console.WriteLine("daa");
                    }

                    else
                    {
                        nr_aparitii2 = 1;
                        max = v[i];
                    }

                }
            }
            Console.WriteLine();
            Console.WriteLine($"Minimul {min} apare de {nr_aparitii1} ori \n Maximul {max} apare de {nr_aparitii2} ori.");
        }
    }
}
