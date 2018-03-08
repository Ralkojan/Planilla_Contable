using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITIES;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
namespace DATA
{
    public class D_CONTRATO
    {
        SqlConnection conx = new SqlConnection("Data Source=.;Initial Catalog=PLANILLA_CONTABLE;Integrated Security=True");

        public List<E_CONTRATO> ListarContrato()
        {
            List<E_CONTRATO> listaContrato = new List<E_CONTRATO>();

            using (SqlCommand cmd = conx.CreateCommand())
            {
                cmd.CommandText = "PLANILLA.LISTAR_CONTRATO";
                cmd.CommandType = CommandType.StoredProcedure;
                conx.Open();
                E_CONTRATO contrato = new E_CONTRATO();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        contrato.ID_Contrato = reader.GetString(reader.GetOrdinal("id_contrato"));
                        contrato.ID_Empleado = reader.GetString(reader.GetOrdinal("id_empleado"));
                        contrato.ID_Banco = reader.GetString(reader.GetOrdinal("id_banco"));
                        contrato.ID_Situacion = reader.GetString(reader.GetOrdinal("id_situacion"));
                        contrato.TipoContrato = reader.GetString(reader.GetOrdinal("tipo_contrato"));
                        contrato.Fecha_Inicio = reader.GetDateTime(reader.GetOrdinal("fecha_inicio"));
                        contrato.Fecha_Fin = reader.GetDateTime(reader.GetOrdinal("fecha_fin"));
                        contrato.Numero_cuenta = reader.GetString(reader.GetOrdinal("numero_cuenta"));
                        contrato.Remuneracion = Decimal.Parse(reader.GetOrdinal("remuneracion_basica").ToString());
                        contrato.Hora_diurna1 = Decimal.Parse(reader.GetOrdinal("hora_diurna_1").ToString());
                        contrato.Hora_diurna2 = Decimal.Parse(reader.GetOrdinal("hora_diurna_2").ToString());
                        contrato.Hora_Nocturna1 = Decimal.Parse(reader.GetOrdinal("hora_nocturna_1").ToString());
                        contrato.Hora_Nocturna2 = Decimal.Parse(reader.GetOrdinal("hora_nocturna_2").ToString());
                        contrato.Dominical = Decimal.Parse(reader.GetOrdinal("hora_dominical").ToString());
                        contrato.BonificacionNocturna = Decimal.Parse(reader.GetOrdinal("bonificacion_nocturna").ToString());
                        listaContrato.Add(contrato);
                    }
                }
                conx.Close();
            }
            return listaContrato;


        }
    }
}
