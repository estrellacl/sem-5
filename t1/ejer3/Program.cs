using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tipo;
            int can,obsequio;
            double precio, impoCom,desc,imPago;

            Console.WriteLine("tipo ; ");
            tipo = Console.ReadLine();

            Console.WriteLine("Cantidad :");
            can = int.Parse(Console.ReadLine());

            if (tipo == "Primor")
                precio = 8.5;
            else if (tipo == "dulzura")
                precio = 10.0;
            else if (tipo == "tentacion ")
                precio = 7.0;
            else
                precio = 12.50;

            //calcular el importe 
            impoCom = can * precio;
            
            if 

            // calculando el descuento 
            impoCom = impoCom - desc;

         












        }
    }
}
