using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] n = new int[3, 4];


           double aprobados= 0, desaprobados=0;
            Random rnd  = new Random();
            

;            //llenamos el arreglo con aleatorio de o a 20 

            for (int fila = 0; fila < n.GetLength(0); fila++)
            {

                for (int columna = 0; columna < n.GetLength(1); columna++)
                {
                    n[fila, columna] = rnd.Next(0, 21);
                  
                }
                
            }

            for (int fila = 0; fila < n.GetLength(0); fila++)
            {

                for (int columna = 0; columna < n.GetLength(1); columna++)
                {
                    
                    Console.Write(n[fila,columna]+"\t");
                    

                }
                Console.WriteLine();

            }

           
            for (int fila = 0; fila < n.GetLength(0); fila++)
            {
            
                for (int columna = 0; columna < n.GetLength(1); columna++)
                {
                    if (n[fila, columna] >= 12)
                        aprobados++;
                    else
                        desaprobados++;
                }
                Console.WriteLine("aprobados:"+ aprobados);
                Console.WriteLine("desaprobados:" + desaprobados);
                aprobados = 0;
                desaprobados =0;
            }
            






        }
    }
}
