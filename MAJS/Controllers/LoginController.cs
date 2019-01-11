using MAJS.Data;
using MAJS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MAJS.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Usuario usuario)
        {
            UsuarioBO usuarioBO = new UsuarioBO();

            if (usuario != null)
            {
                var v = usuarioBO.GetUsuario(usuario.Nome);
                if (v.Nome == usuario.Nome.ToLower() && v.Senha == usuario.Senha)
                {
                    Session["usuarioLogadoID"] = v.Idade.ToString();
                    Session["nomeUsuarioLogado"] = v.Nome.ToString();
                    return RedirectToAction("Index", "Home");
                }
            }
            return View(usuario);
        }

        public ActionResult Logoff()
        {
            Session.Remove("usuarioLogadoID");
            Session.Remove("nomeUsuarioLogado");

            return RedirectToAction("Index");
        }
    }
}