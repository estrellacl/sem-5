using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnaceptar_click(object sender, EventArgs e )
        {
            String cadena;
            char letra_1, ultimo_pos;
            int tamanio, pos_1;
            cadena = textcadena.Text;


            tamanio = cadena.Length;
            letra_1 = cadena[0];
            ultimo_pos = cadena[tamanio - 1];
            pos_1 = cadena.IndexOf(" ");

            textS.Text="Longitud :" +tamanio + "\r\n ";
            textS.AppendText("Primera letra :" + letra_1 + "\r\n ");
            textS.AppendText("ultima letra :" + ultimo_pos + "\r\n ");
            textS.AppendText("pos primer espacio :" + pos_1 + "\r\n ");


            //Calcular el nro de vocales de la cadena
            string letra;
            int can_vocales = 0;

            for (int i = 0;i < tamanio;i++)
            {
                letra = "" + cadena[i];
                if (letra == "a" || letra == " e " || letra == "i")
                    can_vocales++;
            }
            textS.AppendText("Cantidad vocales:" + can_vocales + "\r\n ");




        }
   
    }
}   
