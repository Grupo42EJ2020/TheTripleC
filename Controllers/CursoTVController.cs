using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using MVCLaboratorio.Utilerias;
using MVCLaboratorio.Models;

namespace MVCLaboratorio.Controllers
{
    public class CursoTVController : Controller
    {
        //
        // GET: /CursoTV/

        public ActionResult Index()
        {
            return View();
        }
        //---------------------------
        public ActionResult WatchCursosTV()
        {

            return View();
        }

        //___________________________

    }
}
