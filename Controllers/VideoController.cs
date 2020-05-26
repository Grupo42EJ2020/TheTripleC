using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCLaboratorio.Models;

namespace MVCLaboratorio.Controllers
{
    public class VideoController : Controller
    {
        RepositorioVideo repoVideo = new RepositorioVideo();

        public ActionResult Index()
        {
            return View(repoVideo.obtenerVideos());
        }
       
        
        public ActionResult BorrarVideo(int id)
        {
            return View(repoVideo.obtenerVideo(id));
        }
        [HttpPost]
        public ActionResult BorrarVideo(int id, FormCollection datos)
        {
            repoVideo.eliminarVideo(id);

            return RedirectToAction("Index");
        }

       
        public ActionResult DetallesVideo(int id)
        {
            return View(repoVideo.obtenerVideo(id));
        }
        
        public ActionResult EditarVideo(int id)
        {
            return View(repoVideo.obtenerVideo(id));
        }
        [HttpPost]
        public ActionResult EditarVideo(int id, Video datosVideo)
        {
            datosVideo.IdVideo = id;
            repoVideo.actualizarVideo(datosVideo);

            return RedirectToAction("Index");
        }
    
        public ActionResult AgregarVideo()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AgregarVideo(Video datos)
        {
            repoVideo.insertarVideo(datos);
            return RedirectToAction("Index");
        }
    }
}
