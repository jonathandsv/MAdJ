﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MAJS.Models
{
    public class Evento
    {
        public int IDEvento { get; set; }
        public int IDEventoPerfil { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime Hora { get; set; }
        public DateTime Data { get; set; }
        public string Local { get; set; }
    }
}