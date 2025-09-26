using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer_3_semn_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de filas:");
            int filas = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de columnas:");
            int columnas= int.Parse(Console.ReadLine());

            Console.WriteLine();
            int i = 1;

            while (i <= filas)
            {
                int j = 1;
                while (j <= columnas)
                {
                    Console.Write("* ");
                    j++;
                }
                Console.WriteLine();
                i++;
            }
            Console.ReadKey();
        
        }
        

    }
}
