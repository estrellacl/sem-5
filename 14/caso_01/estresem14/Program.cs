



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estresem14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tamanio;
          
            // STRING ES UNA CLASE  QUE PERMITE GESTIONAR CADENAS
            String cadena;
            int pos_1,pos,pos_2,pos_3;
            char letra_1, ultimo_pos;
            string palabra_1,primer_nombre,appellido_materno;
            cadena = "\nEstrella Alexandra Cabrera Lopez";
            Console.WriteLine(cadena);

            // Length es una propiedad de caracteres 
            tamanio = cadena.Length;
            Console.WriteLine("\nTamanio:" + tamanio);

            //IndexOf() ES una funcion que retorna la psoicion del carater indicado con parametro,si no existe seria -1
            cadena =cadena.ToLower();
            pos_1 = cadena.IndexOf("e");
            Console.WriteLine("\nla posicion 1 : " + pos_1);

            // retorna la posicion del caracter indicado como pararmetro a partir la posicion 8
            pos_2 = cadena.IndexOf("e", 8);
            Console.WriteLine("\nPosicion 2 : " + pos_2);


            //Retorna la posiicon del ultimo craxcter inducado como pararmetro
            pos_3 = cadena.LastIndexOf("r");
            Console.WriteLine("\nPosicion 3 :" + pos_3);


            //Extraer un caracter de la cadena especificando la posicion
            letra_1 = cadena[10];
            Console.WriteLine("\nLetra 1: " + letra_1 );

            //
            ultimo_pos = cadena[tamanio -1];
            Console.WriteLine("\nLetra 1: " + ultimo_pos);

            //substring()etxraer un parte de la cadena
            palabra_1 = cadena.Substring(4, 5);
            Console.WriteLine("\nPalabra 1:" + palabra_1);


            // extraer el primer nombre de la cadena
            primer_nombre = cadena.Substring(0,cadena.IndexOf(' '));
            Console.WriteLine("\nPrimer nombre :" + primer_nombre);



            appellido_materno = cadena.Substring(cadena.LastIndexOf(' ') + 1);
            Console.WriteLine("\nApellido materno:" + appellido_materno);


            Console.WriteLine("\nMayuscula:" + cadena.ToUpper());
            Console.WriteLine("\nMinuscula:" + cadena.ToLower());





        }
    }
}
