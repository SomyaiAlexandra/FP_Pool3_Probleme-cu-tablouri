using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_10
{
    class Program
    {
        // Cautare binara. Se da un vector cu n elemente sortat in ordine crescatoare. 
        // Se cere sa se determine pozitia unui element dat k.
        // Daca elementul nu se gaseste in vector rezultatul va fi -1.

        static int n, x, m;
        static int[] v;
        static void Main(string[] args)
        {
            n = 0;
            x = 0;
            m = 0;

            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());

            v = new int[n];

            Console.Write("x= ");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti elemente in ordine crescatoare: ");

            for (int i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());

            Console.WriteLine($"Elementul a fost gasit pe pozitia {cautare(0, n - 1)}!");
            Console.ReadKey();
        }

        static int cautare(int s, int d)
        {
            if (s > d)
                return -1;

            m = (s + d) / 2;
            if (x == v[m])
                return m;
            if (x < v[m])
                return cautare(s, m - 1);
            else
                return cautare(m + 1, d);
        }
    }
}


