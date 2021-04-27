using POOII_CASO1_ADOLFO_PLANCHART.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace POOII_CASO1_ADOLFO_PLANCHART.Controllers
{
    public class Papeletas_DAO
    {
        string cn_string = ConfigurationManager.ConnectionStrings["SQLServer"].ConnectionString;
        public List<pa_listar_papeletas> PapeletasPorAnio(int anio)
        {
            List<pa_listar_papeletas> lista = new List<pa_listar_papeletas>();

            SqlConnection cn = new SqlConnection(cn_string);

            cn.Open();

            SqlCommand cmd = new SqlCommand("pa_listar_papeletasxanio",cn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@anio", SqlDbType.Int).Value = anio;

            SqlDataReader dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                lista.Add(new pa_listar_papeletas()
                {
                    NROPAP = dr.GetInt32(0),
                    PAPFECHA = dr.GetDateTime(1).ToString(),
                    NOMPRO = dr.GetString(2),
                    NROPLA = dr.GetString(3),
                    CODINF = dr.GetString(4)
                });
            }

            return lista;
        }
    }
}