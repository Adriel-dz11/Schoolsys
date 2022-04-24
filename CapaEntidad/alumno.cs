using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    internal class alumno
    {
        public int id_alumno { get; set; }
        public string nombres { get; set; }
        public string apellidos {get; set; }
        public string fecha_nacimiento { get; set; }
        public string fecha_ingreso { get; set; }
        public int oGrado {get; set; }
        public string matricula {get; set; }

    }
}
