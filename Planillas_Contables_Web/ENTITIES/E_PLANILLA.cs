using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES
{
    public class E_PLANILLA
    {
        public string id_planilla { get; set; }
        public string id_empleado { get; set; }
        public string id_periodo { get; set; }
        public string nombre_mes { get; set; }
        public DateTime fecha_pago { get; set; }
        public string dias_mes { get; set; }
        public string horas_mes { get; set; }
    }
}
