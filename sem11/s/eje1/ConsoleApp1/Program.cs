using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"Ingrese numero{i + 1}:");
                num[i] = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("\n Listas de pares:");
            for (int i = 0; i < num.Length; i++)

            {
                if(num[i] % 2 == 0)
                Console.WriteLine(num[i] + " ");
            }
            Console.ReadKey();


        }
    }
}
