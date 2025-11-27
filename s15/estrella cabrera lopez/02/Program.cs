using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[,] n = new int[3, 4]
            {
                {12,10,18,12 },
                { 13,14,18,8 },
                {14,15,18,10 }
            };


            int suma = 0;
            for (int fila = 0; fila < n.GetLength(0); fila++)
            {
                suma = 0;
                for (int columna = 0; columna < n.GetLength(1); columna++)
                {
                    suma += n[fila, columna];
                }
                Console.WriteLine("suma:" + fila +" : " + suma);
            }























        }
    }
}
