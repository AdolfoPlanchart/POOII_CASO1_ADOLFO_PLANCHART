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
    public class Policias_DAO
    {
        string cn_string = ConfigurationManager.ConnectionStrings["SQLServer"].ConnectionString;
        public List<pa_listar_policias> Policias()
        {
            List<pa_listar_policias> lista = new List<pa_listar_policias>();

            SqlConnection cn = new SqlConnection(cn_string);

            cn.Open();

            SqlCommand cmd = new SqlCommand("pa_listar_policias", cn);

            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                lista.Add(new pa_listar_policias()
                {
                    CODPOL = dr.GetString(0),
                    NOMPOL = dr.GetString(1)
                });
            }

            return lista;
        }
    }
}