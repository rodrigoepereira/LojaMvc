using Quiron.LojaVirtual.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Quiron.LojaVirtual.Dominio.Repositorio;
using System.Web.Security;

namespace Quiron.LojaVirtual.Web.Controllers
{
    public class AutenticacaoController : Controller
    {



        //
        // GET: /Autenticacao/
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View(new Administrador());
        }





        [HttpPost]
        public ActionResult Login(Administrador a, string returnUrl)
        {
            AdministradoresRepositorio adm = new AdministradoresRepositorio();

            if (ModelState.IsValid)
            {
                Administrador x = adm.ObtemAdministrador(a);

                if (x != null)
                {
                    if (!Equals(x.Senha.Trim(), a.Senha))
                    {
                        ModelState.AddModelError("", "Senha inválida!!!");
                    }
                    else
                    {
                        FormsAuthentication.SetAuthCookie(x.Login, false);

                        if (Url.IsLocalUrl(returnUrl)
                             && returnUrl.Length > 1
                             && returnUrl.StartsWith("/")
                             && !returnUrl.StartsWith("//")
                             && !returnUrl.StartsWith("/\\"))

                            return Redirect(returnUrl);
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Usuário inexistente na base de dados!!!");
                }

            }

            return View(new Administrador());
        } // fim metodo


      




    }

}
