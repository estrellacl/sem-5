using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int aleatorio, cant1 = 0, cant2 = 0, cant3 = 0;

            do
            {
                aleatorio = rnd.Next(5, 501);
                Console.WriteLine(aleatorio);
                if (aleatorio <= 9)
                    cant1 += 1;
                else if (aleatorio <= 99)
                    cant2 += 1;
                else 
                    cant3+= 1;
                

            } while(!(aleatorio %3 == 0 && (aleatorio >= 10 && aleatorio <= 99)));
            Console.WriteLine("cantidad 1 digito:" + cant1);
            Console.WriteLine("Cantidad 2 digito:" + cant2);
            Console.WriteLine("cantidad 3 digitos:" + cant3);
        }
    }
}
