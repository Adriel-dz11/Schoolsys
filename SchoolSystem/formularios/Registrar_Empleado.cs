using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolSystem.formularios
{
    public partial class Registrar_Empleado : Form
    {
        public Registrar_Empleado()
        {
            InitializeComponent();
        }

        private void alumnoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.alumnoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.schoolDataSet);

        }

        private void Registrar_Empleado_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'schoolDataSet.alumno' table. You can move, or remove it, as needed.
            this.alumnoTableAdapter.Fill(this.schoolDataSet.alumno);

        }
    }
}
