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
    public class N_CONTRATO
    {
        D_CONTRATO DaoContrato = new D_CONTRATO();

        public List<E_CONTRATO> ListaContrato()
        {
            return DaoContrato.ListarContrato();
        }
    }
}
