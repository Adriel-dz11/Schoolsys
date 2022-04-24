using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolSystem.formularios;

namespace SchoolSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MenuEstudiante_Click(object sender, EventArgs e)
        {
            Registrar_estudiante FEstudiante = new Registrar_estudiante();
            FEstudiante.Show();

        }

        private void MenuEmpleado_Click(object sender, EventArgs e)
        {
            Registrar_Empleado FEmpleado = new Registrar_Empleado();
            FEmpleado.Show();
        }

        private void registrarClasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mant_Clases MClases = new Mant_Clases();
            MClases.Show();
        }

        private void registrarGradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mant_Grado MGrado = new Mant_Grado();
            MGrado.Show();
        }

        private void registrarAñoEscolarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mant_anoescolar Maescolar = new Mant_anoescolar();
            Maescolar.Show();
        }

        private void MenuCalificaciones_Click(object sender, EventArgs e)
        {
            Mant_Calificacion Mcalif = new Mant_Calificacion();
            Mcalif.Show();
        }

        private void MenuUsuarios_Click(object sender, EventArgs e)
        {
            Mant_Usuario MUsuario = new Mant_Usuario();
            MUsuario.Show();
        }
    }
}
