using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double angulo;
            string clasificacion;
            Console.WriteLine("Angulo:");
            angulo = double.Parse(Console.ReadLine());

            if (angulo >= 0 && angulo <= 360)
            {
                if (angulo == 0)
                    clasificacion = "Nulo";
                else if (angulo <= 90)
                    clasificacion = "Agudo";
                else if (angulo == 90)
                    clasificacion = "Recto";
                else if (angulo < 180)
                    clasificacion = "Obtuso";
                else if (angulo == 180)
                    clasificacion = "llano";
                else if (angulo < 360)
                    clasificacion = "concavo";
                else
                    clasificacion = "Completo";

                Console.WriteLine("Clasificacion :" + clasificacion);

            }
            else
                Console.WriteLine("Angulo incorrecto!!");
        }
    }
}
