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
    public partial class RegistroEmpleado : Form
    {
        public RegistroEmpleado()
        {
            InitializeComponent();
        }

        private void btnatrasregemple_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsalirregemple_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
