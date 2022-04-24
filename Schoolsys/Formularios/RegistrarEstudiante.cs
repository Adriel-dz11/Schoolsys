using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Schoolsys.Formularios
{
    public partial class RegistrarEstudiante : Form
    {
        public RegistrarEstudiante()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegistrarEstudiante_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'schoolDataSet.alumno' table. You can move, or remove it, as needed.
            this.alumnoTableAdapter.Fill(this.schoolDataSet.alumno);

        }


        private void alumnoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.alumnoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.schoolDataSet);

        }

        private void nombresTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BotonGuardar_Click(object sender, EventArgs e)
        {
          
               
                
                this.alumnoTableAdapter.InsertQuery(int.Parse(id_alumnoTextBox.Text),nombresTextBox.Text, apellidosTextBox.Text, fecha_nacimientoDateTimePicker.Value, fecha_ingresoDateTimePicker.Value, int.Parse(id_gradoTextBox.Text), matriculaTextBox.Text);
                MessageBox.Show("Estudiante agregado con éxito");
                

                
           
            //deshabilitar todos los controles
            id_alumnoTextBox.Enabled = false;
            nombresTextBox.Enabled = false;
            apellidosTextBox.Enabled = false;
            fecha_nacimientoDateTimePicker.Enabled = false;
            fecha_ingresoDateTimePicker.Enabled = false;
            id_gradoTextBox.Enabled = false;
            matriculaTextBox.Enabled = false;

            

        }

        private void BtnAnadir_Click(object sender, EventArgs e)
        {

            //habilitar todos los controles
            id_alumnoTextBox.Focus();

            id_alumnoTextBox.Enabled = true;
            nombresTextBox.Enabled = true;
            apellidosTextBox.Enabled = true;
            fecha_nacimientoDateTimePicker.Enabled = true;
            fecha_ingresoDateTimePicker.Enabled = true;
            id_gradoTextBox.Enabled = true;
            matriculaTextBox.Enabled = true;
            //limpiar
            limpiar();
            //dehabilitar botones 
            BtnDelete.Enabled = false;
            BtnEdit.Enabled = false;

            //posicionar en la 'ultima posicion
            

        }


        private void BtnDelete_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show("Se ha eliminado un registro satisfactoriamente");
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }
        void limpiar()
        {
            //limpiar todos los controles
            id_alumnoTextBox.Clear();
            nombresTextBox.Clear();
            apellidosTextBox.Clear();
            fecha_nacimientoDateTimePicker.ResetText();
            fecha_ingresoDateTimePicker.ResetText();
            id_gradoTextBox.Clear();
            matriculaTextBox.Clear();
        }
    }
}
