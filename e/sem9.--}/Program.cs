using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net;
using System.Text;
using biblioteca;

namespace sem9.___
{
    internal class Program
    {
        static void Main(string[] args)
        {
            triangulo t = new triangulo(); // instancia 
            cuadrado c = new cuadrado();

            string conti;
            int opc2;


            do
            {
                menu1();
                do
                {
                    Console.Write("iNGRESE UNA OPCION:");
                    opc2 = int.Parse(Console.ReadLine());
                    if (opc2 < 0 | opc2 > 4)
                        Console.WriteLine("Error . ingrese una opcion valida \n ");
                    else break;

                } while (true);


                switch(opc2)
                {
                    case 0: return;
                    case 1:
                        int opc3 = menu2();
                        
                        switch (opc3)
                        {
                            case 1: t.area();break;
                            case 2: t.perimetro();break;

                        }
                        break;
              

                        
                   
                    case 2:
                        opc3 = menu2();

                        Console.Write("\nIngrese lado:");
                        int lado = int.Parse(Console.ReadLine());


                        switch (opc3)
                        {
                            case 1: c.area(lado); break;
                            case 2: c.perimetro(lado ); break;

                        }
                        break;
                       
                    case 3: break;
                    case 4: break;

                }



                do
                {
                    Console.Write("¿Desea continuar?  (s/n)");
                    conti = Console.ReadLine();
                   if (conti != "n" & conti != "S")
                        Console.WriteLine("Error . ingrese solo 's' 0 'n' . \n");
                   else break;

                } while (true);



            } while (conti == "s");


        }

        static void menu1()

        {
            Console.WriteLine("BIENVENIDO A CALCULOS DE AREA Y PERIMETROS \n");
            Console.WriteLine("*************Menu de opciones************* \n");
            Console.WriteLine("*             1.Triangulo                 *\n");
            Console.WriteLine("*             2.Cuadrado                  *\n");
            Console.WriteLine("*             3.Rectangulo                *\n");
            Console.WriteLine("*             3.Trapecio                  *\n");
            Console.WriteLine("*             0.salir                     *\n");
            Console.WriteLine("****************************************** \n");

        }
      
        static int menu2 ()
        {
            Console.WriteLine("\n***********Seleccione calculo**************");
            Console.WriteLine("*             1.Area                        *");
            Console.WriteLine("*             2.Perimetro                   *");
            Console.WriteLine("*********************************************");

            Console.Write("\nIngrese una opcion:");
            int opc = int.Parse(Console.ReadLine());


            return opc;






        }
        
        
       
    }
}
