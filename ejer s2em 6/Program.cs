using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer_s2em_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int si = 0, sp = 0;
            while (true)
            {
                Console.Write("INGRESE UN NUMERO POSITIVO: ");
                int num = int.Parse(Console.ReadLine());

                

                if (num == 0) break;
                if (num < 0)
                {
                    Console.WriteLine("Error, Ingrese solo positivos:");
                    Console.WriteLine();
                    continue;
                }

                if (num % 2 == 0) sp += num;
                else si += num;

             
            }

            Console.WriteLine("\n Sumade pares :  " + sp);
            Console.WriteLine("\n Sumade impares : " + sp);
            Console.ReadKey();
        }
    }
}
