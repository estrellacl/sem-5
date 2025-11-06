using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caso_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarar 
            int longitud, depositoAlmacenado;
            double prom;
            // v ariable local y parametro 
            int[] deposito = { 3700, 3200, 2300, 2200, 3500, 2100, 3900, 8000, 2500, 3100 };

            //LLamado con retorno
            longitud = tamanio(deposito);
            depositoAlmacenado = obtenerdeposito(deposito,2 );
            prom = promedioDeposito(deposito);
         
            Console.WriteLine("LONGITUD:" + longitud);
            Console.WriteLine("Deposito Almacenado :" + depositoAlmacenado);
            Console.WriteLine("Deposito delo promedio:" + prom);
        }


        //funcio0n tamanio que retorna la cantidad de elemento de arreglo 
        static int tamanio(int[] deposito)
        {
            return deposito.Length;
        }
        //funcion 

        static int obtenerdeposito(int[] deposito,int pos)
        {
            return deposito[pos];
        }
        // funcion Un método promedioDepositos que retorne el promedio de todos los depósitos
        static double promedioDeposito( int[] deposito)
             
        {
            int suma = 0;
            for (int i = 0; i < deposito.Length; i++)
            {
                suma += deposito[i];
            }
            return 1.0 * suma / deposito.Length;
        }

        
    }
}
