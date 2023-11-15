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
    public partial class GenerarHorarios : Form
    {
        public GenerarHorarios()
        {
            InitializeComponent();
        }

        private void btnmanual_Click(object sender, EventArgs e)
        {

        }

        private void btnatrashorarios_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsalirhorarios_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnautomatico_Click(object sender, EventArgs e)
        {
            HorarioAutomatico form3 = new HorarioAutomatico();
            form3.ShowDialog();
        }
    }
}
