using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cat;
            double pro, descuento, pension, nuevapension; 



            Console.WriteLine("Categoria:");
            cat = Console.ReadLine();

            Console.WriteLine("Promedio");
            pro= double.Parse(Console.ReadLine());

            //Calculamos la pension
            if (cat == "A")
                pension = 550;
            else if (cat == "B")
                pension = 500;
            else if (cat == "C")
                pension = 460;
            else 
                 pension = 400;


            //Calculamos la rebaj o el descuento
            if (pro >= 0 && pro <= 13.99)
                descuento = 0;
            else if (pro <= 15.99)
                descuento = 0.10 * pension;

            else if (pro <= 17.99)
                descuento = 0.12 * pension;
            else 
                descuento =0.15 * pension;

            //Calculamos la nueva pension 
            nuevapension = pension - descuento;

            // imprimimos resultados 

            Console.WriteLine("pension : " + pension);
            Console.WriteLine("Descuento " + descuento);
            Console.WriteLine("nueva pension :"  + nuevapension);











        }
    }
}
