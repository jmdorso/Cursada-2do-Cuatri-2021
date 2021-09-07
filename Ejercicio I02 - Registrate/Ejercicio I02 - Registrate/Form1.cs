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

namespace Ejercicio_I02___Registrate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            string[] valoresCheckBox = new string[0];
            string genero = null;

            foreach(Control item in groupBoxCursos.Controls)
            {
                if (item is CheckBox && ((CheckBox)item).Checked)
                {
                    Array.Resize<string>(ref valoresCheckBox, valoresCheckBox.Length + 1);
                    valoresCheckBox[valoresCheckBox.Length - 1] = ((CheckBox)item).Text;
                }                
            }

            foreach (Control item in groupBoxGenero.Controls)
            {
                if (item is RadioButton && ((RadioButton)item).Checked)
                {
                    genero = item.Text;
                }

            }


            Ingresante ingresante = new Ingresante(textBoxNombre.Text,
                                                   textBoxDireccion.Text,
                                                   genero,
                                                   (string)listBoxPais.SelectedItem,
                                                   valoresCheckBox,
                                                   (int)numericUpDownEdad.Value);

            MessageBox.Show(ingresante.Mostrar());
        }
    }
}
