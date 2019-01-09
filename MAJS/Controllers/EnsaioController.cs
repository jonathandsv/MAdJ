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
    }
}