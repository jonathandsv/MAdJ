using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MAJS.Models
{
    public class Ensaio
    {
        public int IDEnsaios { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public TimeSpan Hora { get; set; }
        public DateTime Data { get; set; }
        public string Local { get; set; }
    }
}