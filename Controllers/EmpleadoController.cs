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
    public class EmpleadoController : Controller
    {
        //********************************************************
        RepositorioEmpleado repoEmpleado = new RepositorioEmpleado();
        //********************************************************
        public ActionResult Index()
        {
            return View();
        }
        //********************************************************
        public ActionResult VerEmpleados()
        {
            return View(repoEmpleado.obtenerEmpleados());
        }
        //********************************************************
        
        public ActionResult BorrarEmpleado(int id)
        {
            return View(repoEmpleado.obtenerEmpleado(id));
        }
        [HttpPost]
        public ActionResult BorrarEmpleado(int id, FormCollection datos)
        {
            //realizar el delete del registro
            repoEmpleado.eliminarEmpleado(id);

            return RedirectToAction("VerEmpleados");
        }
      
        //********************************************************
        public ActionResult DetallesEmpleado(int id)
        {
            return View(repoEmpleado.obtenerEmpleado(id));
        }
        //********************************************************
        public ActionResult EditarEmpleado(int id)
        {
            return View(repoEmpleado.obtenerEmpleado(id));
        }
        [HttpPost]
        public ActionResult EditarEmpleado(int id, Empleado datosEmpleado)
        {
            datosEmpleado.IdEmpleado = id;
            repoEmpleado.actualizarEmpleado(datosEmpleado);

            return RedirectToAction("VerEmpleados");
        }
        //********************************************************
        public ActionResult AgregarEmpleado()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AgregarEmpleado(Empleado datos)
        {
            repoEmpleado.insertarEmpleado(datos);
            return RedirectToAction("VerEmpleados");
        }
        //********************************************************
      
    }
}
