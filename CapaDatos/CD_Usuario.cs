using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;
using CapaEntidad;

namespace CapaDatos
{
    internal class CD_Usuario
    {
        public List<usuario> Listar()
        {
            List<usuario> usuarioList = new List<usuario>();
            using (SqlConnection conn = new SqlConnection())
            {
                try
                {
                    string query = "select id_usuario, usuario, contrasena from usuario";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.CommandText = CommandType.Text;

                }
                catch (Exception ex)
                {

                }
            }
        }
    }
}
