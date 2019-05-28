using MAJS.Data;
using MAJS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MAJS.Controllers
{
    public class EnsaioController : Controller
    {
        // GET: Ensaio
        public ActionResult Index()
        {
            EnsaioBO ensaioBO = new EnsaioBO();
            List<Ensaio> ensaios = ensaioBO.GetEnsaios();

            return View(ensaios);
        }
        public ActionResult CadastrarEnsaio()
        {
            return View();
        }

        public ActionResult AlterarEnsaio(int id)
        {
            EnsaioBO eventoBO = new EnsaioBO();
            Ensaio evento = eventoBO.GetEnsaio(id);

            return View(evento);
        }
        // Fim da Chamada de Páginas

        [HttpPost]
        public ActionResult NovoEnsaio(Ensaio ensaio)
        {
            if (ModelState.IsValid)
            {
                EnsaioBO ensaioBO = new EnsaioBO();

                var resultado = ensaioBO.CadastrarEnsaio(ensaio);

                if (resultado != 0)
                {
                    return RedirectToAction("Index");
                }
            }
            return RedirectToAction("Index");
        }
    }
}