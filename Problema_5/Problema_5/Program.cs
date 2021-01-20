using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_5
{
    class Program
    {
        // Se da un vector cu n elemente, o valoare e si o pozitie din vector k. 
        // Se cere sa se insereze valoarea e in vector pe pozitia k. 
        // Primul element al vectorului se considera pe pozitia zero. 
        
            static Random rnd = new Random();
            static void Main(string[] args)
            {
               
                int n, e, k;
                Console.WriteLine("Introduceti numarul de elemente: ");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine("Introduceti valoarea: ");
                e = int.Parse(Console.ReadLine());
                Console.WriteLine("Introduceti pozitia: ");
                k = int.Parse(Console.ReadLine());
                int[] v = new int[n];
                int[] v_final = new int[n + 1];

                for (int i = 0; i < n; i++)
                {
                    int x = rnd.Next(10);
                    v[i] = x;
                    Console.Write($"{v[i]} ");
                }
                for (int i = 0; i < n + 1; i++)
                {
                    if (i < k)
                        v_final[i] = v[i];
                    else
                    {
                        if (i == k)
                            v_final[i] = e;
                        else
                            v_final[i] = v[i - 1]; 
                    }
                }
                Console.WriteLine();
                for (int i = 0; i < n + 1; i++)
                    Console.Write($"{v_final[i]} ");
            }
        }
    }

