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

        public ActionResult BorrarTema(int id)
        {
            return View(repoTema.obtenerTema(id));
        }
        [HttpPost]
        public ActionResult BorrarTema(int id, FormCollection datos)
        {
            repoTema.eliminarTema(id);

            return RedirectToAction("Index");
        }

        public ActionResult DetallesTema(int id)
        {
            return View(repoTema.obtenerTema(id));
        }
        
        public ActionResult EditarTema(int id)
        {
            return View(repoTema.obtenerTema(id));
        }
        [HttpPost]
        public ActionResult EditarTema(int id, Tema datosTema)
        {
            datosTema.IdTema = id;
            repoTema.actualizarTema(datosTema);

            return RedirectToAction("Index");
        }
       
        public ActionResult AgregarTema()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AgregarTema(Tema datos)
        {
            repoTema.insertarTema(datos);
            return RedirectToAction("Index");
        }
        
    }
}
