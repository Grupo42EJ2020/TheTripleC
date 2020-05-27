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
    public class Curso_Tema_VideoController : Controller
    {
        //
       
        RepositorioCurso_Tema_Video repoCurso_Tema_Video = new RepositorioCurso_Tema_Video();
        // GET: /Curso_Tema_Video/

        public ActionResult Index()
        {
            return View();
        }

        //-----------------------------------------------------
        //ver todo
        public ActionResult obtenerTodosCurso_Tema_Video()
        {
            return View(repoCurso_Tema_Video.obtenerTodosCurso_Tema_Video());
        }
        //_____________________________________________________

        //-----------------------------------------------------
        //detalles
        public ActionResult obtenerUnCurso_Tema_Video(int id)
        {
            return View(repoCurso_Tema_Video.obtenerUnCurso_Tema_Video(id));
        }
        //_______________________________________________________

        //-------------------------------------------------------
        public ActionResult insertarCurso_Tema_Video()
        {
            return View();

        }
        [HttpPost]
        public ActionResult insertarCurso_Tema_Video(Curso_Tema_Video datosCurso_Tema_VideodatosCurso_Tema_Video)
        {
            repoCurso_Tema_Video.insertarCurso_Tema_Video(datosCurso_Tema_VideodatosCurso_Tema_Video);
            return RedirectToAction("obtenerTodosCurso_Tema_Video");
        }
        //________________________________________________________

        //--------------------------------------------------------
        public ActionResult eliminarCurso_Tema_Video(int id)
        {
            
            return View(repoCurso_Tema_Video.obtenerUnCurso_Tema_Video(id));
        }
        [HttpPost]
        public ActionResult eliminarCurso_Tema_Video(int id, FormCollection datos)
        {
            repoCurso_Tema_Video.eliminarCurso_Tema_Video(id);

            return RedirectToAction("obtenerTodosCurso_Tema_Video");

        }
        //YAP____________________________________________________
        public ActionResult actualizarCurso_Tema_Video(int id)
        { 
        //realizar el update
            return View(repoCurso_Tema_Video.obtenerUnCurso_Tema_Video(id));
}
            [HttpPost]
             public ActionResult actualizarCurso_Tema_Video(int id, Curso_Tema_Video datosCurso_Tema_Video)
             {
            datosCurso_Tema_Video.IdCTV = id;
            repoCurso_Tema_Video.actualizarCurso_Tema_Video(datosCurso_Tema_Video);
            return RedirectToAction("obtenerTodosCurso_Tema_Video");
             }
        

    }
}
