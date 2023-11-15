using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_horarios_laborales_transporte
{
    public partial class RegistrarNovedades : Form
    {
        public RegistrarNovedades()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnatrasnovedad_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsalirnovedad_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
