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
    public partial class HorarioAutomatico : Form
    {
        public HorarioAutomatico()
        {
            InitializeComponent();
        }

        private void btnatrasauto_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsalirautoma_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnguardarauto_Click(object sender, EventArgs e)
        {
            int turnos = 3;
            int empleados = 5;

            // Definir los días de la semana
            string[] dias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes","Sabado", "Domingo" };

            // Definir las horas de trabajo
            string[] horas = { "4:00", "5:00", "6:00", "7:00", "8:00", "8:00", "9:00", 
                "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00" };

            // Generar horarios aleatorios
            Random random = new Random();
            for (int i = 0; i < turnos; i++)
            {
                richTextBox1.AppendText("-------------------------------------------------\n");
                richTextBox1.AppendText("Turno " + (i + 1) + "\n");
                richTextBox1.AppendText("-------------------------------------------------\n");

                for (int j = 0; j < empleados; j++)
                {
                    richTextBox1.AppendText("Empleado ID # :  " + (j + 1) + "\n");
                    for (int k = 0; k < dias.Length; k++)
                    {
                        richTextBox1.AppendText(dias[k] + ": " + horas[random.Next(horas.Length)] + "\n");
                    }
                    richTextBox1.AppendText("\n");
                }
            }
        }
    }
        
    
}
