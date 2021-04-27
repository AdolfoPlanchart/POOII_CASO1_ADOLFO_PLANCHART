using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace POOII_CASO1_ADOLFO_PLANCHART.Controllers
{
    public class PREGUNTA1Controller : Controller
    {
        // GET: PREGUNTA1
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string usr,string psw)
        {
            if(usr == "CIBER" && psw == "T4CM2021")
            {
                return RedirectToAction("PapeletasPorAnio");
            }
            ViewBag.MENSAJE = "Error: Usuario y/ o Clave son incorrectos";
            return View();
        }
    }
}