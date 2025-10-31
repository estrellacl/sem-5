using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eje1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5];
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"Ingrese numero{i + 1}:");
                num[i] = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("\n Listas de numeros:");
            foreach (int i in num)
            {
                Console.WriteLine(i);
            }
             
        }    
    }
}
