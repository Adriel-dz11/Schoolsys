using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Schoolsys.Formularios;


namespace Schoolsys
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void verClasesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void verCalificacioensToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void registroDeEstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RegistrarEstudiante().ShowDialog();
        }

        private void registrarAñoEscolarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new anoEscolar().ShowDialog();
        }

        private void registrarGradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RegistrarGrado().ShowDialog();
        }
    }
}
