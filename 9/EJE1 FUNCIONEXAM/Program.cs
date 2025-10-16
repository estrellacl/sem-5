using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EJE1_FUNCIONEXAM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double precio, impocompra, pordescuento, impopago, impodesc;
            string marca;
            int cantidad, obsequio1;
            Console.WriteLine("Marca:");
            marca = Console.ReadLine();


            Console.Write("Cantidad:");
            cantidad = int.Parse(Console.ReadLine());

            //llMANDO A LAS FUNCIONES 
            precio = Calcularprecio(marca);
            impocompra = CalcularimpoorteCompra(cantidad, precio);
            pordescuento = calcularPorcentajedes(cantidad);
            impodesc = Calcularimportededescuento(pordescuento, impocompra);
            impopago = calcularimportedepago(impodesc, impocompra);
            obsequio1 = obsequio(marca, cantidad);


            //imprimir 
            Console.WriteLine("Importe de compra:" + impocompra);
            Console.WriteLine("importde descuento :" + impodesc);
            Console.WriteLine("Importe de pago: " + impopago);
            Console.WriteLine("Mouse pas- obsequi:" + obsequio1);

        }
        //dETERMINA EL PRECIO EN fUNCION
        //SE DECLARA COMO 'PARARMETRO LAS VARIABLES QUE HAN SIDO LEIDOS 
        // O QUE HAN SIDO CALCULADOS EN OTRAS FUNCIONES
        static double Calcularprecio(string marca)
        {
            double precio;
            if (marca == "Dell")
                precio = 11000.00;
            else if (marca == "HP")
                precio = 9000.00;
            else if (marca == "Apple")
                precio = 13000.00;
            else
                precio = 12500.00;

            return precio;
        }

        //fUNCION PARA CALCULAR IMPORTE DE LA COMPRA
        static double CalcularimpoorteCompra(int cantidad, double precio)
        {

            double impocompra;
            impocompra = cantidad * precio;
            return impocompra;
        }

        //fUNCION PARA CALCULAR EL PORCENTAJE DE DESCU7ENTO

        static double calcularPorcentajedes(int cantidad)
        {
            double pordescuento;

            if (cantidad <= 3)
                pordescuento = 0.035;
            else if (cantidad >= 4 && cantidad < 6)
                pordescuento = 0.05;
            else if (cantidad >= 6 && cantidad < 9)
                pordescuento = 0.065;
            else
                pordescuento = 0.08;

            return pordescuento;


        }
        //FUNCION PARA Calcular el importe de descuento funciones
        static double Calcularimportededescuento(double pordescuento , double impocompra )
        {
            double impodesc;
            impodesc = pordescuento * impocompra;
            return impodesc;
        }

        // FUNCION PARA Calculamos el importe de pago
        static double calcularimportedepago( double impodesc,double impocompra)
        {
            double impopago;
            impopago = impocompra - impodesc;
            return impopago;

        }

        static int obsequio( string marca ,int cantidad )
        {

            int obsequio;
            if (marca == "HP")
                obsequio = 3 * (cantidad / 3);
            else
                obsequio = 0;
            return obsequio;

        }





    }











}
