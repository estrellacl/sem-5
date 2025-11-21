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
            string numero;

            while (true)
            {
                
                Console.WriteLine("\nIngrese un número decimal con exactamente 1 entero y 2 decimales :");
                numero = Console.ReadLine().Trim();

                //  NO esté vacío
                if (string.IsNullOrWhiteSpace(numero))
                {
                    Console.WriteLine("NO SE PERMITEN VACÍOS.\n");
                    continue;
                }

                // contenga un punto
                if (!numero.Contains("."))
                {
                    Console.WriteLine("Debe contener un punto decimal.\n");
                    continue;
                }

                // solo haya UN punto
                if (numero.IndexOf('.') != numero.LastIndexOf('.'))
                {
                    Console.WriteLine("El número solo puede tener un punto decimal.\n");
                    continue;
                }

                // Separar en partes antes y después del punto
                string[] partes = numero.Split('.');

                //  parte entera y parte decimal
                if (partes.Length != 2)
                {
                    Console.WriteLine("Formato incorrecto.\n");
                    continue;
                }

                string entero = partes[0];
                string decimales = partes[1];

                // la parte entera tenga  1 dígito
                if (entero.Length != 1 || !char.IsDigit(entero[0]))
                {
                    Console.WriteLine("El entero debe tener exactamente 1 dígito.\n");
                    continue;
                }

                //  la parte decimal tenga  2 dígitos
                if (decimales.Length != 2 || !char.IsDigit(decimales[0]) || !char.IsDigit(decimales[1]))
                {
                    Console.WriteLine("Los decimales deben tener exactamente 2 dígitos.\n");
                    continue;
                }

                // Si todo es válido, salimos del ciclo
                break;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nNúmero válido ingresado: {numero}");
            Console.ResetColor();




        }
    }
}
