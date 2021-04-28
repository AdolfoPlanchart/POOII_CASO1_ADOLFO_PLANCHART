using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace POOII_CASO1_ADOLFO_PLANCHART.Controllers
{
    public class PREGUNTA2Controller : Controller
    {
        // GET: PREGUNTA2
        Papeletas_DAO pap_dao = new Papeletas_DAO();
        public ActionResult PapeletasPorAnio(int anio=0)
        {
            var listado = pap_dao.Papeletas(anio);
            ViewBag.ANIO = anio;
            return View(listado);
        }
    }
}