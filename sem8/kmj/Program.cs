using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kmj
{
    internal class Program
    {
        static int sumanumeros()
        {
            int a = 5, b = 10, suma;
            suma = a + b;
            return suma;
        }

        static int restanumero ()
        {
            int a = 5, b = 10, resta;
            resta  = a + b;
            return resta ;
        }
        static int multiplicacionnumero()
        {
            int a = 5, b = 10, mult;
            mult = a + b;
            return mult;

        }
        static int dividionnumero()
        {
            int a = 5, b = 10, divi;
            divi = a + b;
            return divi;
        }


        static void Main(string[] args)
        {
              int sumanum;
               sumanum = sumanumeros();
              Console.WriteLine("suma:" + sumanum);
               sumanum = sumanumeros();
        }
    }  


}
