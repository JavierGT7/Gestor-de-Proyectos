using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sistema.Presentacion.Controllers
{
    public class PuestosController : Controller
    {
        // GET: Puestos
        public ActionResult Index()
        {
            return View();
        }
    }
}