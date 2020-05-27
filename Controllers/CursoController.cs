using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


using System.Data;
using System.Data.SqlClient;
using MVCLaboratorio.Utilerias;

using MVCLaboratorio.Models;


namespace MVCLaboratorio.Controllers
{
    public class CursoController : Controller
    {
        //
        // GET: /Curso/

        public ActionResult Index()
        {
            return View();
        }
//----------------------------------------------------------------------------------
        //mostrar lista de cursos
        public ActionResult watchCursos()
        {
            RepositorioCursos repo = new RepositorioCursos();

            return View(repo.obtenerCursos()); 
        }
//----------------------------------------------------------------------------------
        //EDITAR CURSOS
        public ActionResult actualizarCurso(int id)
        {
            RepositorioCursos repo = new RepositorioCursos();
            return View(repo.obtenerCurso(id));
        }
        [HttpPost]
        public ActionResult actualizarCurso(int id, Curso datosCurso)
        {
            //realizar el update
            RepositorioCursos repo = new RepositorioCursos();
            datosCurso.IdCurso = id;
            repo.actualizarCurso(datosCurso);
            return RedirectToAction("watchCursos");
        }
        
//----------------------------------------------------------------------------------
        //Borrar Curso
        public ActionResult BorrarCurso(int id)
        { 
            RepositorioCursos repo = new RepositorioCursos();
            
            return View(repo.obtenerCurso(id));
           
        }
        [HttpPost]
        public ActionResult BorrarCurso(int id, FormCollection datos)
        {
            RepositorioCursos repo = new RepositorioCursos();

            repo.eliminarCurso(id);
            return RedirectToAction("watchCursos");

        }
        //YAP
//----------------------------------------------------------------------------------
        //DetallesCurso
        public ActionResult DetallesCurso(int id)
        {
            RepositorioCursos repo = new RepositorioCursos();
            return View(repo.obtenerCurso(id));
        }
        //yap
        //----------------------------------------------------------------------------------
        public ActionResult InsertarCurso()
        {
            //mostrar interfaz
            return View();

        }
        [HttpPost]
        public ActionResult InsertarCurso(Curso datosCurso)
        {
            RepositorioCursos repo = new RepositorioCursos();
            repo.insertarCurso(datosCurso);
            return RedirectToAction("watchCursos");

        }

    }
}
