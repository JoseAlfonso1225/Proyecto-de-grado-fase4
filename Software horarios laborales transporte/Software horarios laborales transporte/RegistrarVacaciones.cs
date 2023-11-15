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
    public partial class RegistrarVacaciones : Form
    {
        public RegistrarVacaciones()
        {
            InitializeComponent();
        }

        private void btnatrasvaca_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsalirvaca_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
