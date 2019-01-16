using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MAJS.Models
{
    public class Postagem
    {
        public int IDPostagem { get; set; }
        public int IDUsuario { get; set; }
        public int IDEnsaio { get; set; }
        public int IDEvento { get; set; }
        public string Titulo { get; set; }
        public string Descricao{ get; set; }
        public TimeSpan Hora { get; set; }
        public DateTime Data { get; set; }
    }
}