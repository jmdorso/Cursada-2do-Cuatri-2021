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
    public partial class Form2 : Form
    {
        public Form2(string titulo, string soy)
        {
            InitializeComponent();
            lblSoy.Text = soy;
            lblTitulo.Text = titulo;
        }

    }
}
