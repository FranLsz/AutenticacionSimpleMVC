using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using AutenticacionSimple.Models;

namespace AutenticacionSimple.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]

        public ActionResult Index(Usuario model)
        {
            if (model.Login.Equals(model.Password))
            {
                var iden = new GenericIdentity(model.Login);

                //asigna el usuario en el rol
                var prin = new GenericPrincipal(iden, new[] { "usuario" });

                //HttpContext.User = prin;
                Thread.CurrentPrincipal = prin;
                FormsAuthentication.SetAuthCookie(model.Login, false);
                return RedirectToAction("Index", "Home");
            }
            ModelState.AddModelError("err", "Autentitacion incorrecta");

            return View(model);

        }
    }
}