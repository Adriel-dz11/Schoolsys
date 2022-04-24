using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Schoolsys
{
    public class Conexion
    {
        private SqlConnection sqlcon()
        {
            SqlConnection cnx;
            cnx = new SqlConnection("Data Source = LAPTOP-JGSAQF21\\SQLEXPRESS;Initial Catalog=School;");
            cnx.Open();

            return cnx;
        }
    }
}
