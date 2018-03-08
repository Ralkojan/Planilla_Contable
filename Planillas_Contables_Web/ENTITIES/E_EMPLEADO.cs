using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES
{
    class E_EMPLEADO
    {
        public string id_empleado { get; set; }
        public string nombre_empleado { get; set; }
        public string cargo_empleado { get; set; }
        public string CUSSP_empleado { get; set; }
        public decimal asig_familiar { get; set; }
        public string id_empresa { get; set; }
        public string id_afp { get; set; }
        public string id_documento { get; set; }
    }
}
