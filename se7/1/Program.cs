using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int secreto = rnd.Next (1,21);
            int inentos = 3;
            Console.WriteLine("************************************************");
            Console.WriteLine("*     BIENVENIDO AL JUEGO ADIVINADOR      ******");
            Console.WriteLine("*                                         ******");
            Console.WriteLine("* 1. UD.DEBERA ADIVINAR EL NUMERO ENTRE 1 Y 20 *");
            Console.WriteLine("* 2. UD. TIENE 3 INTENTOS                      *");
            Console.WriteLine("*3.POR CADA FALTA SE OTORGAERA UNA PISTA       *");
            Console.WriteLine("************************************************");

            do
            {
                Console.WriteLine($"Ingrese numero(intentos{inentos}):");
                int num = int.Parse(Console.ReadLine());

                if (num == secreto)
                {
                    Console.WriteLine("Felicidades ,  Adivinaste!!!");
                    return;
                }
                else
                {
                    inentos--;
                    if (num < secreto)
                        Console.WriteLine("el numero es mayor");
                    else
                        Console.WriteLine("El numero es menor");




                }



            } while (inentos > 0);
            Console.WriteLine("\nNo loograste adivinar el numero" + secreto);

        }
    }
}
