using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    internal class periodo
    {
        public int id_periodo { get; set; }
        public int oAno_escolar { get; set; }
        public string nombre { get; set; }
        public string fecha_inicio { get; set; }
        public string fecha_final { get; set; }
        public bool termino { get; set; }


    }
}
