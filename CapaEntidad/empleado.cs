using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    internal class empleado
    {
        public int id_empleado { get; set; }
        public string nombre{ get; set; }
        public string apellido { get; set; }
        
        public string direccion { get; set; }
        public string fecha_nacimiento { get; set; }
        public string fecha_ingreso { get; set; }

        public decimal salario { get; set; }

        public string cedula { get; set; }

        public int oCargo { get; set; }






    }
}
