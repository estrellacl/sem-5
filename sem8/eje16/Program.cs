using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eje16
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            int aleatorio, suma = 0, cantpares = 0, sumapares = 0, canimp = 0, suimp = 0;
            do
            {

                aleatorio = rnd.Next(1000, 10000);
                Console.WriteLine(aleatorio);
                suma += aleatorio;

                if (aleatorio % 2 == 0)

                {
                    cantpares++;
                    sumapares += aleatorio;
                }
                
                else

                {
                    canimp++;
                    suimp += aleatorio;
                }




            } while (!(aleatorio % 2 == 1 && aleatorio < 1800));
            Console.WriteLine("Suma:" + suma);
            Console.WriteLine("Cantidad de parees:" + cantpares);
            Console.WriteLine("Suma de pares:" + sumapares);
            Console.WriteLine("Cantidad de impares:" + canimp);
            Console.WriteLine("Suma de impares:" + suimp);
        }
    }
}
