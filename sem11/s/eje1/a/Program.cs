using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { -2, 5, -1, 0, 8, -6, 3 };
            Console.Write("Lista original:");
            foreach (int i in num)
                Console.Write(i);

            Console.WriteLine("\n Listas de numeros: " );
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] < 0)
                {
                    num[i] = 0;
                }

                Console.Write(num[i] + " ");
            }
            Console.ReadKey();



        }
    }
}
