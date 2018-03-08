using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES
{
    public class E_CONTRATO
    {
        public string ID_Contrato { get; set; }
        public string ID_Empleado { get; set; }
        public string ID_Banco { get; set; }
        public string ID_Situacion { get; set; }
        public string TipoContrato { get; set; }
        public DateTime Fecha_Inicio { get; set; }
        public DateTime Fecha_Fin { get; set; }
        public string Numero_cuenta { get; set; }
        public decimal Remuneracion { get; set; }
        public decimal Hora_diurna1 { get; set; }
        public decimal Hora_diurna2 { get; set; }
        public decimal Hora_Nocturna1 { get; set; }
        public decimal Hora_Nocturna2 { get; set; }
        public decimal Dominical { get; set; }
        public decimal BonificacionNocturna { get; set; }
    }
}
