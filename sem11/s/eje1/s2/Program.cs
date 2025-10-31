using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { -2, 5, -1, 0, 8, -6, 3 };
            Console.Write("Lista original:");
            foreach (int i in num)
                Console.Write(i);

            int minimo = num[0];
            int maximo = num[0];
            for (int i = 0; i < num.Length; i++)
            { if (num[i] < minimo)
                    minimo = num[i];

                if (num[i] > maximo)

                    maximo = num[i];
            }

            Console.WriteLine("\n NRO mayor: " + maximo);
            Console.WriteLine("\n NRO menor :" + minimo);
            Console.ReadKey();

        }
    }
}
