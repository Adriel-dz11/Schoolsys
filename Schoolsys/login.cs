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

namespace Schoolsys
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "Select usuario,contrasena from usuario where usuario = '" + txtUsuario.Text.ToString().Trim() + "'AND contrasena = '" + textBox2.Text.ToString().Trim() + "' ";
            SqlConnection cnx;
            cnx = new SqlConnection("Data Source = LAPTOP-JGSAQF21\\SQLEXPRESS;Initial Catalog=School;");
            cnx.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnx;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;

            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

         

            if (reader.HasRows == false)
            {
                MessageBox.Show("USUARIO O CONTRASEÑA INCORRECTA", "", MessageBoxButtons.OK);
            }
            else
            {
                this.Hide();
                new Form1().Show();
            }



          
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            this.Show();
            
        }
    }
}
