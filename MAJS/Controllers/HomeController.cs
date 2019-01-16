using MAJS.Data;
using MAJS.Models;
using MAJS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MAJS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (Session["usuarioLogadoID"] != null)
            {
                List<FeedVM> listafeed = new List<FeedVM>();
                FeedVM feed = new FeedVM();
                PostagemBO postagemBO = new PostagemBO();
                List<Postagem> listaPostagens = postagemBO.GetPostagens();

                for (int i = 0; i < listaPostagens.Count(); i++)
                {
                    int usr = listaPostagens[i].IDUsuario;
                    UsuarioBO usuarioBO = new UsuarioBO();
                    Usuario usuario = usuarioBO.GetUsuario(usr);
                    feed.Postagem = listaPostagens[i];
                    feed.Usuario = usuario;
                    listafeed.Add(feed);
                }

                return View(listafeed);
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}