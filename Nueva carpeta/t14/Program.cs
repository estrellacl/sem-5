using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nom1, nom2;

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\nIngrese nombre 1 :");
                nom1 = Console.ReadLine().Trim();
                if (!string.IsNullOrWhiteSpace(nom1))
                    break;
                else Console.WriteLine("NO SE PERMITEN VACIOS.\n");
            }
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\nIngrese nombre 2 :");
                nom2 = Console.ReadLine().Trim();
                if (!string.IsNullOrWhiteSpace(nom2))
                    break;
                else Console.WriteLine("NO SE PERMITEN VACIOS.\n");
            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Cantidad de caracteres nombre 1 :" + nom1.Length);
            Console.WriteLine("Cantidad de carcateres nombre 2 :" + nom2.Length);
            Console.WriteLine("Nombre 1 en mayusuculas:" + nom1.ToUpper());
            Console.WriteLine("Nombre 2 en minuscula:" + nom2.ToLower());

            if (nom1.CompareTo(nom2) == 0)
                Console.WriteLine("Nombres son iguales");
            else
                Console.WriteLine("Nombres son diferentes");




            if (nom1.Contains("an"))
                Console.WriteLine("Si existe 'an'");
            else
                Console.WriteLine("No existe 'an");



            if (nom1.IndexOf("a") != -1)
                Console.WriteLine("1°pos:" + nom1.IndexOf("a"));
            else
                Console.WriteLine("No existe 'a'");

            if (nom2.LastIndexOf("a") != -1)
                Console.WriteLine("1°pos:" + nom2.LastIndexOf("a"));
            else
                Console.WriteLine("No existe 'a'");

            Console.WriteLine("Insertando UPN:" + nom1.Insert(0, "UPN"));
            Console.ResetColor();
            Console.WriteLine("Insertando SISTEMAS:" + nom2.Insert(nom2.Length, "SISTEMAS"));

            if (nom1.Length > 5)
                Console.WriteLine("Eliminado desde 5° pos" + nom1.Remove(5));
            else
                Console.WriteLine("Al menos debe tener 5 caracteres");
            Console.BackgroundColor = ConsoleColor.Red;

            if (nom1.Contains("a"))
                Console.WriteLine("Remplazando a po @:" + nom1.Replace("a", "@"));
            else
                Console.WriteLine("No existe 'a' ");
            Console.ResetColor();

            if (nom1.Contains("a"))
            {
                Console.Write("Division de partes:");
                string[] partes = nom1.Split('a');
                for (int i = 0; i < partes.Length; i++)
                    Console.Write(partes[i] + "  ->");


            }
            else
                Console.WriteLine("No existe 'a' ");

            if (nom1.Length > 4)
                Console.WriteLine(" \n Sub cadena:" + nom1.Substring(4));
            else
                Console.WriteLine("Al menos debe de tener 4 caracteres");

            char[] nom = nom1.ToCharArray();
            for (int i = 0; i < nom.Length; i++)
                Console.WriteLine(nom[i]);

            Console.WriteLine("Reversa:");
            for (int i = nom.Length - 1; i >= 0; i--)
                Console.Write(nom[1]);

            Console.WriteLine( "\nordenando:");
            Array.Sort(nom);
            for (int i = 0;i< nom.Length ; i++)
                Console.Write(nom[1]);











        }
    }
}
