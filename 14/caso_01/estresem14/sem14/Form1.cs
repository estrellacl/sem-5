using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sem14
{
    public partial class txts : Form
    {
        public txts()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            String cadena;
            int tamanio;
            cadena = textcadena.Text;

            
            tamanio = cadena.Length;
            textS.Text = "Longitud:" + tamanio;


            //txts.text=cadena;

        }
    }
}
