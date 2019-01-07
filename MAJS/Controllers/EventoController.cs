﻿using MAJS.Models;
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
            //PreencheViewDataListaPerfilEvento();
            return View(eventos);
        }

        public ActionResult CadastrarEvento()
        {
            PreencheViewBagListaPerfilEvento();
            return View();
        }
        // Fim da Chamada de Páginas

        public Evento NovoEvento(Evento evento)
        {
            if (ModelState.IsValid)
            {
                EventoBO eventoBO = new EventoBO();

                var resultado = eventoBO.CadastrarEvento(evento);

                if (resultado != 0 )
                {
                    RedirectToAction("Index");
                }
                
            }

            return (null);
        }

        private void PreencheViewBagListaPerfilEvento()
        {
            EventoBO eventoBO = new EventoBO();
            List<EventoPerfil> eventoPerfis = eventoBO.BuscarEventosPerfis();
            ViewBag.ListaEventoPerfil = eventoPerfis;
            //ViewData["EventoPerfis"] = eventoPerfis;
        }
    }
}