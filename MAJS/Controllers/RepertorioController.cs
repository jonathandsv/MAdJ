using MAJS.Data;
using MAJS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MAJS.Controllers
{
    public class RepertorioController : Controller
    {
        // GET: Repertorio
        public ActionResult Index()
        {
            MusicaBO musicaBO = new MusicaBO();
            List<Musica> musicas = musicaBO.GetMusicas();

            return View(musicas);
        }
        public ActionResult CadastrarRepertorio()
        {
            return View();
        }
        // Fim da Chamada de Páginas

        [HttpPost]
        public ActionResult NovaMusica(Musica musica)
        {
            if (ModelState.IsValid)
            {
                MusicaBO musicaBO = new MusicaBO();

                var resultado = musicaBO.CadastrarMusica(musica);

                if (resultado != 0)
                {
                    return RedirectToAction("Index");
                }
            }
            return RedirectToAction("Index");
        }
    }
}