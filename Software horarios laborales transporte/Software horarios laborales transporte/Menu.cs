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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btncerrarsecion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnregistrarusuario_Click(object sender, EventArgs e)
        {
            RegistroEmpleado form = new RegistroEmpleado();
            form.ShowDialog();
        }

        private void btnhorarios_Click(object sender, EventArgs e)
        {
            GenerarHorarios form2 = new GenerarHorarios();
            form2.ShowDialog();
        }

        private void btnincapacidades_Click(object sender, EventArgs e)
        {
            RegistrarIncapacidad form4 = new RegistrarIncapacidad();
            form4.ShowDialog();
        }

        private void btnconsultahorarios_Click(object sender, EventArgs e)
        {
            ConsultarHorarios form5 = new ConsultarHorarios();
            form5.ShowDialog();
        }

        private void btnvacaciones_Click(object sender, EventArgs e)
        {
           RegistrarVacaciones form6 = new RegistrarVacaciones();
            form6.ShowDialog();
        }

        private void btnrutas_Click(object sender, EventArgs e)
        {
            RegistrarRutas form7 = new RegistrarRutas();
            form7.ShowDialog();
        }

        private void btnnovedades_Click(object sender, EventArgs e)
        {
            RegistrarNovedades form8 = new RegistrarNovedades();
            form8.ShowDialog();
        }

        private void btnconsultarutas_Click(object sender, EventArgs e)
        {
            ConsultarRutas form9 = new ConsultarRutas();
            form9.ShowDialog();

        }
    }
}
