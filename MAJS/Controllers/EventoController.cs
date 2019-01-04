using MAJS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MAJS.Data;


namespace MAJS.Controllers
{
    public class EventoController : Controller
    {
        // GET: Evento
        public ActionResult Index()
        {
            EventoBO eventoBO = new EventoBO();
            List<Evento> eventos = eventoBO.GetEventos();

            return View(eventos);
        }
    }
}