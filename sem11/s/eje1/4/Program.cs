using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de numeros:");
            int cant = int.Parse(Console.ReadLine());

            int[] num = new int[cant];
            int suma = 0;

            
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"Ingrese numero{i + 1}:");
                num[i] = int.Parse(Console.ReadLine());
                suma += num[i];

            }

            Console.WriteLine("\n suma:" + suma);
       



        }
    }
}
