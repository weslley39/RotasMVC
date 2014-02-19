using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RotasMVC.Models;

namespace RotasMVC.Controllers
{
    public class HomeController : Controller
    {

        private readonly IEnumerable<Noticia> todasasnoticias;

        public HomeController()
        {
            todasasnoticias  = new Noticia().TodasAsNoticias().OrderByDescending(x => x.Data);
        }

        public ActionResult Index()
        {
            var ultimanoticia = todasasnoticias.Take(2);
            var todasascategorias = todasasnoticias.Select(x => x.Categoria).Distinct().ToList();

            ViewBag.Categorias = todasascategorias;

            return View(ultimanoticia);
        }

        public ActionResult TodasAsNoticias()
        {
            return View(todasasnoticias);

        }

        public ActionResult MostraNoticia(int noticiaid, string titulo, string categoria)
        {
            return View(todasasnoticias.FirstOrDefault(x => x.NoticiaID == noticiaid));
        }

        public ActionResult mostraCategoria(string categoria)
        {
            var categoriaespecifica = todasasnoticias.Where(x => x.Categoria.ToLower() == categoria.ToLower()).ToList();
            ViewBag.Categoria = categoria;
            return View(categoriaespecifica);
        }
    }
}
