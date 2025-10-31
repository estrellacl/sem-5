using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nom = new string[5];

            for (int i = 0; i < nom.Length; i++)
            {
                Console.Write("Ingrese el producto");
                string pro = Console.ReadLine();
                bool buscar = false;

                for (int j = 0; i < nom.Length; i++)
                {
                    if (nom[j] == pro)
                    {
                        Console.WriteLine(" Producto existente.\n");
                        buscar = true;
                        break;
                    }
                }
                if (buscar == false )
                {
                    nom[reg] = pro;
                   indicve 
                }



            }



        }
    }
}
