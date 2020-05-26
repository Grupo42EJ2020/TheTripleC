using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Data;
using MVCLaboratorio.Utilerias;
using System.Data.SqlClient;
using MVCLaboratorio.Models;

namespace MVCLaboratorio.Controllers
{
    public class Curso_TemaController : Controller
    {
        //********************************************************
        RepositorioCurso_Tema repoCurso_Tema = new RepositorioCurso_Tema();
        //********************************************************
        public ActionResult Index()
        {
            return View();
        }
        //********************************************************
        public ActionResult VerCurso_Tema()
        {
            return View(repoCurso_Tema.obtenerTodosCurso_Tema());
        }
        //********************************************************

        public ActionResult BorrarCurso_Tema(int id)
        {
            return View(repoCurso_Tema.obtenerUnCurso_Tema(id));
        }
        [HttpPost]
        public ActionResult BorrarCurso_Tema(int id, FormCollection datos)
        {
            //realizar el delete del registro
            repoCurso_Tema.eliminarCurso_Tema(id);

            return RedirectToAction("VerCurso_Tema");
        }

        //********************************************************
        public ActionResult DetallesCurso_Tema(int id)
        {
            return View(repoCurso_Tema.obtenerUnCurso_Tema(id));
        }
        //********************************************************
        public ActionResult EditarCurso_Tema(int id)
        {
            return View(repoCurso_Tema.obtenerUnCurso_Tema(id));
        }
        [HttpPost]
        public ActionResult EditarCurso_Tema(int id, Curso_Tema datosCurso_Tema)
        {
            datosCurso_Tema.IdCT = id;
            repoCurso_Tema.actualizarCurso_Tema(datosCurso_Tema);

            return RedirectToAction("VerCurso_Tema");
        }
        //********************************************************
        public ActionResult AgregarCurso_Tema()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AgregarCurso_Tema(Curso_Tema datos)
        {
            repoCurso_Tema.insertarCurso_Tema(datos);
            return RedirectToAction("VerCurso_Tema");
        }
        //********************************************************

    }
}
