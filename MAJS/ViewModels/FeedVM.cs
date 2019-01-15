using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MAJS.Models;

namespace MAJS.ViewModels
{
    public class FeedVM
    {
        public Usuario Usuario { get; set; }
        public Postagem Postagem { get; set; }
    }
}