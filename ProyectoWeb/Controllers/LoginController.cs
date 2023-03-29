using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoWeb.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string usuario, string contrasenia) {

            int idUsuario = CD_Usuario.LoginUsuario(usuario, contrasenia);

            if (idUsuario == 0) {
                ViewBag.Error = "Usuario o contraseña no correcta";
                return View();
            }

            Session["IdUsuario"] = idUsuario;

            return RedirectToAction("Index", "Home");
        }

        [Route("Login/Sesion")]
        public ActionResult sesion()
        {
            ViewBag.Message = "llegue";
            return View();
        }

        [Route("Login/Nosotros")]
        public ActionResult nosotros()
        {
            return View();
        }
        [Route("Login/Programas")]
        public ActionResult programas()
        {
            return View();
        }
        [Route("Login/Convenios")]
        public ActionResult convenios()
        {
            return View();
        }
        [Route("Login/Contactanos")]
        public ActionResult contactanos()
        {
            return View();
        }
        [Route("Login/Seguridad")]
        public ActionResult seguridad()
        {
            return View();
        }
        [Route("Login/Habilidades")]
        public ActionResult habilidades()
        {
            return View();
        }
        [Route("Login/Gestion")]
        public ActionResult gestion()
        {
            return View();
        }


    }
}