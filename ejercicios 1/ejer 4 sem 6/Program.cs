using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer_4_sem_6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("GENERE UNA CONTRASEÑA:");
            string contra = Console.ReadLine();

            int intentos = 3;

            Console.WriteLine("-----------------------------");
            Console.WriteLine("**** Válida tu contraseña ***");
            Console.WriteLine("---------------------------\n");


            while (intentos > 0)
            {
                Console.Write("ingresa tu contraseña:");
                string pass = Console.ReadLine();

                if (contra == pass)
                {
                    Console.WriteLine("\n Acceso concedido");
                    return;
                }
                else
                {
                    Console.WriteLine($"\n CONTRASEÑA INCORRECTA!!! lE RESTAN {intentos -1 } intentos");
                    intentos--;

                }


            }

            Console.WriteLine("\n acceso denegdo ya fuiste :("  ));
                Console.ReadKey();
        }
    }
}
