using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eje1xame
{
    internal class Program
    {
        static void Main(string[] args)


        {
            double precio, impocompra, pordescuento, impopago, impodesc;
            string marca;
            int cantidad , obsequio ;
            Console.WriteLine("Marca:");
            marca = Console.ReadLine();


            Console.Write("Cantidad:");
            cantidad = int.Parse(Console.ReadLine());

            // Determinar el precio


            if (marca == "Dell")
                precio = 11000.00;
            else if (marca == "HP")
                precio = 9000.00;
            else if (marca == "Apple")
                precio = 13000.00;
            else
                precio = 12500.00;

            //Calcular importe de compra sin descuento

            impocompra = cantidad * precio;


            //CALCULANDO EL IMPORTE DE LA COMPRA
            Console.WriteLine("Importe de compra:" + impocompra);


            //CALCULANDO EL IMPORTE DE DESCUENTO
            if (cantidad <= 3)
                pordescuento = 0.035;
            else if (cantidad >= 4 && cantidad < 6)
                pordescuento = 0.05;
            else if (cantidad >= 6 && cantidad < 9)
                pordescuento = 0.065;
            else
                pordescuento = 0.08;

            //Calcular el importe de descuento

            impodesc = pordescuento * impocompra;


            //Calculamos el importe de pago

            impopago = impocompra - impodesc;

            //calcular el obsequio
            if (marca == "HP")
                obsequio = 3 * (cantidad / 3);
            else
                obsequio = 0;




            Console.WriteLine("Importe de compra:" + impocompra);
            Console.WriteLine("importde descuento :" + impodesc);
            Console.WriteLine("Importe de pago: " + impopago);
            Console.WriteLine("Mouse pas- obsequi:" + obsequio);




        }
    }
}
