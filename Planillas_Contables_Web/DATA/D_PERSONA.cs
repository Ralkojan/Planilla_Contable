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

        public class D_PERSONA
        {
            SqlConnection conx = new SqlConnection("Data Source=.;Initial Catalog=PLANILLA_CONTABLE;Integrated Security=True");

            public List<E_PERSONA> ListarPersona()
            {
                List<E_PERSONA> listaPersona = new List<E_PERSONA>();

                using (SqlCommand cmd = conx.CreateCommand())
                {
                    cmd.CommandText = "PLANILLA.LISTAR_PERSONA";
                    cmd.CommandType = CommandType.StoredProcedure;
                    conx.Open();
                    E_PERSONA persona = new E_PERSONA(); ;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            persona.id_persona = reader.GetString(reader.GetOrdinal("id_persona"));
                            persona.nombre = reader.GetString(reader.GetOrdinal("nombre"));
                            persona.ape_paterno = reader.GetString(reader.GetOrdinal("ape_paterno"));
                            persona.ape_materno = reader.GetString(reader.GetOrdinal("ape_materno"));
                            persona.dni = reader.GetString(reader.GetOrdinal("dni"));
                            persona.Fecha_Registro = reader.GetDateTime(reader.GetOrdinal("fecha_registro"));
                            persona.id_rol = reader.GetString(reader.GetOrdinal("id_rol"));
                            listaPersona.Add(persona);
                        }
                    }
                    conx.Close();
                }
                return listaPersona;


            }
        }
    }
