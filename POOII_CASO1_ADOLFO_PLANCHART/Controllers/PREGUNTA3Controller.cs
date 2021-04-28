using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace POOII_CASO1_ADOLFO_PLANCHART.Controllers
{
    public class PREGUNTA3Controller : Controller
    {
        Papeletas_DAO pap_dao = new Papeletas_DAO();
        Policias_DAO pol_dao = new Policias_DAO();
        // GET: PREGUNTA3
        public ActionResult PapeletasPorAnioYPolicia(int anio=0,string codpol="")
        {
            var listado = pap_dao.Papeletas(anio, codpol);

            if(ViewBag.ANIO != 0)
            {
                ViewBag.ANIO = anio;
            }

            ViewBag.POLICIAS = new SelectList(
                pol_dao.Policias(),
                "codpol",
                "nompol"
                );

            return View(listado);
        }
    }
}