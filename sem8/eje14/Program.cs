using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eje14
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            for (int i = 3; i <= 45; i += 3)
            {
                Console.WriteLine(i);

            }
            */

            /*
            int i = 3;
            while (i <= 45)
            {
                Console.WriteLine(i);
                i += 3;
            }
            */

            int i = 3;
            do
            {
                Console.WriteLine(i);
                i += 3;

            } while (i <= 45);                                         
        }


    }
}
