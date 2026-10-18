using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InicioSesion_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string correo, string contraseña)
        {
            UsuariosDAO consulta = new UsuariosDAO();
            var cuenta = consulta.Index(correo, contraseña);
            string mensaje = "Correo o contraseña incorrectos";
            if (cuenta != null)
            {
                mensaje = string.Format("Hola de nuevo, {1} {0}",
                    cuenta.apellido, cuenta.nombre);
            }
            ViewBag.Mensaje = mensaje;
            return View();

        }


    }
}