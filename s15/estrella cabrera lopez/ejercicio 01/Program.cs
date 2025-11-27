using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int valor_1, nro_columna, nro_fila, suma = 0, mayor = 0;
           

             //ARREGLO BIDIMESNSIONAL CON VALORES FIJOS // FLOAT DECIMAL ,NOMBRE-> STRING
            int[,] n = new int[3, 4] 
            {
                {12,10,18,12 },
                { 13,14,18,8 }, 
                {14,15,18,10 }
            };

            int menor = n[0, 0];


            //      fila|columna  valor de la fila 
            valor_1 = n[0, 1];
            Console.WriteLine(valor_1);

            //getlenght(0) retorna el numero de filas
            nro_fila = n.GetLength(0);

            //getlenght(1) retorna el numero de columnas
            nro_columna = n.GetLength(1);

            Console.WriteLine("\nNro filas:" + nro_fila);
            Console.WriteLine("\nNro columnas:" + nro_columna);

            //recorremos el arreglo
            // dimensional (un for) bidimensional (dos for)

            for (int fila = 0; fila < n.GetLength(0); fila++) 
            {
                for (int columna = 0; columna < n.GetLength(1); columna++)
                {
                    Console.Write(n[fila, columna] + "\t");

                }
                Console.WriteLine();
                //termino el recorrido de una fila
            }

            //Calculamos la suma , promedio,mayor men
            for (int fila = 0; fila < n.GetLength(0); fila++)
            {
                for (int columna = 0; columna < n.GetLength(1); columna++)
                {   
                    //calcula la suma
                    suma += n[fila, columna];

                    //calcula el mayor
                    if (n[fila, columna] > mayor)
                        mayor = n[fila, columna];

                    // calcula el menor 
                  
                    if (n[fila, columna] < menor)
                        menor = n[fila, columna];

                }
            }
            Console.WriteLine("\nSuma:" + suma);
            Console.WriteLine("\nMayor:" + mayor);
            Console.WriteLine("\nMenor:" + menor);

            // numero de elemento de promedio
            Console.WriteLine("\nPromedio:" + +1.0*suma/n.Length);








        }
    }
}
