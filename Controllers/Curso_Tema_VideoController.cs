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


        public ActionResult obtenerTodosCurso_Tema_Video()
        {
            return View(repoCurso_Tema_Video.obtenerTodosCurso_Tema_Video());
        }
    }
}
