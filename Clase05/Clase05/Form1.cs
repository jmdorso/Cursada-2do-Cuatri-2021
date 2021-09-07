using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Clase05
{
    public partial class frmHolaWindowsForms : Form
    {
        public  frmHolaWindowsForms()
        {
            InitializeComponent();
            //Persona p = new Persona(textBox1.Text, textBox2.Text);
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2("¡Hola, Windows Forms!", "Soy " + txtNombre.Text + " " + txtApellido.Text);
            f.ShowDialog(this);
        }


    }
}