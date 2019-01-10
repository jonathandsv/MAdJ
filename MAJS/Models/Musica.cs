using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MAJS.Models
{
    public class Musica
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Letra { get; set; }
        public string AtivoNaoAtivo { get; set; }
        public string DLetra { get; set; }
        public string DNotas { get; set; }
        public string CVideo { get; set; }
    }
}