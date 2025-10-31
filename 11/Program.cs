using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eje4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tamanio;
            int[] n;
            double prom;
            int mayo = 0;
            int menos = 0;
            Console.WriteLine("Nro de elementos:");
            tamanio = int.Parse(Console.ReadLine());

            n = new int[tamanio];
            //llamado sin retorno 
            generaraleatorio(n);
            listadedatos(n);
            
           
            //llamado con metodo retorno
            prom = Calcularpromedio(n);
            mayo = calcularmayor(n);
            menos = calcularmenor(n);
            imprimeresultado(prom,mayo,menos);
            
        }
        static void imprimeresultado(double prom , int mayo,int menos)
        {
            Console.WriteLine("pROMEDIO ES : " + prom);
            Console.WriteLine("el numero mayor es : " + mayo);
            Console.WriteLine("el numero menor es : " + menos);
        }
        static void generaraleatorio(int[] n)
        {
            Random rnd = new Random();
            for (int i = 0; i < n.Length; i++)
            {
                n[i] = rnd.Next(0, 21);

            }

        }
         static void listadedatos(int[] n )
         {
            for (int i = 0; i < n.Length; i++)
            {
                Console.WriteLine("\n n[" + i + "]= " + n[i]);

            }
         }
         static double Calcularpromedio(int[] n)
         {
            int suma = 0;
            double promedio;
            for(int i = 0; i < n.Length; i++)
            {
                suma += n[i];

            }
            promedio = 1.0 * suma / n.Length;
            return promedio;
         }
        static int calcularmayor(int[] n)
        {
            int mayor =n[0];
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] > mayor)

                    mayor = n[i];

            }
            return mayor;
        }
        static int calcularmenor(int[] n)
        {
            int menor =n[0];
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] < menor)
                    menor = n[i];
            }
            return menor;
        }
        
    } 

}






          
  

