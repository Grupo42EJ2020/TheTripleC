using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data;
using MVCLaboratorio.Utilerias;
using MVCLaboratorio.Models;

namespace MVCLaboratorio.Controllers
{
    public class TemaController : Controller
    {
        RepositorioTema repoTema = new RepositorioTema();

        public ActionResult Index()
        {
           return View(repoTema.obtenerTemas());
        }

        public ActionResult DeleteTema(int IdTema)
        {
            return View(repoTema.obtenerTema(IdTema));
        }

        [HttpPost]
        public ActionResult DeleteTema(int IdTema, FormCollection datos) 
        {
            repoTema.eliminarTema(IdTema);
            return RedirectToAction("Index");
        }

        public ActionResult DetailsTema(int IdTema)
        {
            return View(repoTema.obtenerTema(IdTema));
        }

        public ActionResult EditTema(int IdTema)
        {
            return View(repoTema.obtenerTema(IdTema));
        }

        [HttpPost]
        public ActionResult EditTema(int IdTema, Tema datosTema)
        {
            datosTema.IdTema = IdTema; 
            repoTema.actualizarTema(datosTema);
            return RedirectToAction("Index");
        }

        public ActionResult CreateTema()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateTema(Tema datosTema)
        {
            repoTema.insertarTema(datosTema);
            return RedirectToAction("Index");
        }


    }
}
