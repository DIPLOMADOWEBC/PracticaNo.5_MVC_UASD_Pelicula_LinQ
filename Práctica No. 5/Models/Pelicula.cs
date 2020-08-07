using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Práctica_No._5.Models
{
    public class Pelicula
    {
        public string Titulo { get; set; }
        public string Director { get; set; }
        public string AutorPrincipal { get; set; }
        public int numAutores { get; set; }
        public double Duracion { get; set; }
        public int Estreno { get; set; }
    }
}