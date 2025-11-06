using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace caso_1_global
{
    internal class Program

    {    //antes del main crea una variable global (debe ser reconocida en cualquier parte del programa)
        static int[]deposito = { 3700, 3200, 2300, 2200, 3500, 2100, 3900, 8000, 2500, 3100 };

        static int longitud, depositoAlmacenado,mas,menos,cant,can,pos,p;
        static double prom;
        
        static void Main(string[] args)
        {
            //LLamado con retorno
            longitud = tamanio();
            depositoAlmacenado = obtenerdeposito(2);
            prom = promedioDeposito();
            mas = depositarmayor();
            menos = depositarmenor();
            cant = cantidadmayor3000();
            can = cantidadmenores2500();
            pos = Posprimerdepo();
            p = posUltimoDeposito();
          
            //llamado static
            imprimeresul();
            generaraleatorio();
            
        }

        //funcion void que imprime eresultados 
        static void imprimeresul()
        {
            Console.WriteLine("LONGITUD:" + longitud);
            Console.WriteLine("Deposito Almacenado :" + depositoAlmacenado);
            Console.WriteLine("Deposito delo promedio:" + prom);
            Console.WriteLine("Deposito mayor:" + mas);
            Console.WriteLine("Deposito menor: " + menos);
            Console.WriteLine("Cantidad mayores:" + cant);
            Console.WriteLine("Cantidad menores:" + can);
            Console.WriteLine("pos primer depo:" + pos);
            Console.WriteLine("POS ultimo depo :" + p);
             
        }
        //funcio0n tamanio que retorna la cantidad de elemento de arreglo 
        static int tamanio()
        {
            return deposito.Length;
        }
        //funcion 

        static int obtenerdeposito(int pos)
        {
            return deposito[pos];
        }
        // funcion Un método promedioDepositos que retorne el promedio de todos los depósitos
        static double promedioDeposito()

        {
            int suma = 0;
            for (int i = 0; i < deposito.Length; i++)
            {
                suma += deposito[i];
            }
            return 1.0 * suma / deposito.Length;


        }
        static int depositarmayor()
        {
            int mayor = deposito[0];
            for (int i = 0; i < deposito.Length; i++)
            {
                if (deposito[i] > mayor)
                    mayor = deposito[i];
            }
            return mayor;

        }

        static int depositarmenor()
        {
            int menor  = deposito[0];
            for (int i = 0; i < deposito.Length; i++)
            {
                if (deposito[i] < menor )
                    menor  = deposito[i];
            }
            return menor ;

        }

        static int cantidadmayor3000()
        {

            int can1 = 0;
            for (int i = 0; i < deposito.Length; i++)
            {
                if (deposito[i] > 3000)
                    can1++;

            }
            return can1;
           
        }

        static int cantidadmenores2500()
        {

            int can2 = 0;
            for (int i = 0; i < deposito.Length; i++)
            {
                if (deposito[i] < 2500)
                    can2++;

            }
            return can2;

        }
        static int Posprimerdepo()
        {


            for (int i = 0; i < deposito.Length; i++)
            {
                if (deposito[i] >= 2000 && deposito[i] <= 2500)
                    return i;

            }
            return -1;

        }
        static int posUltimoDeposito()
        {
            int posic = -1;
            for (int i = 0; i < deposito.Length ; i++)
            {

                if (deposito[i] >= 3500 && deposito[i] <= 4000)

                    return i;

            }

            return posic;

        }
        
        static void generaraleatorio()
        {
            Random rnd = new Random();
     
            for (int i = 0; i < deposito.Length; i++)
            {
                deposito [i] = rnd.Next(1001,2000);

            }

            for (int i = 0; i < deposito.Length; i++)
            {
                Console.WriteLine(deposito[i]);
            }


        }

        static void generardeposito ()
        {
            Random rnd = new Random();

            for (int i = 0; i < deposito.Length; i++)
            {
                deposito[i] = rnd.Next(1001, 2000);

            }

            for (int i = 0; i < deposito.Length; i++)
            {
                Console.WriteLine(deposito[i]);
            }


        }




    }
}


