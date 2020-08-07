using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Práctica_No._5.Models;

namespace Práctica_No._5.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var peliculas = new List<Pelicula>
            {
                new Pelicula {Titulo ="The Godfather", Director ="Francis Ford Coppola", AutorPrincipal = "Al pacino", numAutores = 30, Duracion = 2, Estreno = 1994},
                new Pelicula {Titulo ="The Shawshank", Director ="Frank Darabont", AutorPrincipal = "Morgan Freeman", numAutores = 15, Duracion = 3, Estreno = 1972},
                new Pelicula {Titulo ="The Matrix", Director ="Lana Wachowski", AutorPrincipal = "Keanu Reeves", numAutores = 15, Duracion = 2.30, Estreno = 1999},
                new Pelicula {Titulo ="City of God", Director ="Fernando Meirelles", AutorPrincipal = "Alexandre Rodrigues", numAutores = 10, Duracion = 3, Estreno = 2002},
                new Pelicula {Titulo ="Star Wars: Episodio IV", Director ="George Lucas", AutorPrincipal = "Harrison Ford", numAutores = 20, Duracion = 2.40, Estreno = 2007},
                new Pelicula {Titulo ="Lo que el viento se llevo", Director ="Yo", AutorPrincipal = "Yo", numAutores = 1, Duracion = 7, Estreno = 2020}
            };

            var resulPeliculas = from Pelicula in peliculas
                                 where Pelicula.Titulo.Contains("The")
                                 select Pelicula;

            return View(resulPeliculas);
        }

        public ActionResult Productos()
        {
            var productos = new List<Producto>
            {
                new Producto {Id = 1, Descripcion = "Boligrafo", Precio = 8.35},
                new Producto {Id = 2, Descripcion = "Cuaderno grande", Precio = 21.5},
                new Producto {Id = 3, Descripcion = "Cuaderno pequeño", Precio = 10},
                new Producto {Id = 4, Descripcion = "Folios 500 uds.", Precio = 550.55},
                new Producto {Id = 5, Descripcion = "Grapadora", Precio = 85.25},
                new Producto {Id = 6, Descripcion = "Tijeras", Precio = 62},
                new Producto {Id = 7, Descripcion = "Cinta adhesiva", Precio = 45.10},
                new Producto {Id = 8, Descripcion = "Rotulador", Precio = 20.75},
                new Producto {Id = 9, Descripcion = "Mochila escolar", Precio = 800.90},
                new Producto {Id = 10, Descripcion = "Pegamento barra", Precio = 30.15},
                new Producto {Id = 11, Descripcion = "Lapicero", Precio = 15.55},
                new Producto {Id = 12, Descripcion = "Grapas", Precio = 40.90}
            };

            //Que contenga
            //var resulProductos = from Producto in productos
            //where Producto.Descripcion.Contains("i")
            //select Producto;

            //Que inicie con
            //var resulProductos = from Producto in productos
            //where Producto.Descripcion.ToLower().StartsWith("c")
            //select Producto;

            //Que finalice en
            //var resulProductos = from Producto in productos
            //where Producto.Descripcion.ToLower().EndsWith("o")
            //select Producto;

            //Precio sea mayor que “20”.
            //var resulProductos = from Producto in productos
                                 //where Producto.Precio > 20
                                 //select Producto;

            //Precio sea menor que “70”
            var resulProductos = from Producto in productos
                                 where Producto.Precio < 70
                                 select Producto;

            return View(resulProductos);
        }
    }
}