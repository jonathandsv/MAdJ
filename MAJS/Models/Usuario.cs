using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MAJS.Models
{
    public class Usuario
    {
        public int IDUsuario { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int IDPerfilUsuario { get; set; }
        public int IDPerfilMembro { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public string Sexo { get; set; }
        public int Idade { get; set; }
    }
}