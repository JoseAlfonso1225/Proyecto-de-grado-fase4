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
    public partial class ConsultarRutas : Form
    {
        public ConsultarRutas()
        {
            InitializeComponent();
        }

        private void btnsalirconsuruta_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnatrasconsuruta_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
