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
    public partial class Contraseña : Form
    {
        string Usuario = "usuario";
        string pasword = "123";

        public Contraseña()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text !=  Usuario || txtcontraseña.Text != pasword)
            {
                if (txtusuario.Text != Usuario)
                {
                    MessageBox.Show("Usuario incorecto");
                    txtusuario.Clear();
                    txtusuario.Focus();
                    return;
                }
                if (txtcontraseña.Text != pasword)
                {
                    MessageBox.Show("contraseña incorecta");
                    txtcontraseña.Clear();
                    txtcontraseña.Focus();
                    return;
                }


            }
            else
            {
                txtusuario.Clear();
                txtcontraseña.Clear();
                Menu form = new Menu();
                form.ShowDialog();


            }
        }
    }
}
