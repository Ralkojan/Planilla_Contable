
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA;
using ENTITIES;
using System.Data;

namespace NEGOCIO
{
    public class N_PERSONA
    {

        D_PERSONA DaoPersona = new D_PERSONA();

        public List<E_PERSONA> ListaPersona()
        {
            return DaoPersona.ListarPersona();
        }
    }
}
