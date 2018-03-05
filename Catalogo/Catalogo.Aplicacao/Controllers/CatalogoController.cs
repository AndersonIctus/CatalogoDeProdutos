using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Catalogo.Aplicacao.Models;

namespace Catalogo.Aplicacao.Controllers
{
    public class CatalogoController : Controller
    {
        private IEnumerable<Produto> lsProdutos;
        private IEnumerable<Categoria> lsCategorias;

        public CatalogoController()
        {
            //pega a listagem de produtos
            lsProdutos = new Produto().TodosProdutos();
            lsCategorias = new Categoria().TodasCategorias();
        }

        // GET: Catalogo
        public ActionResult Index()
        {
            ViewBag.Categorias = lsCategorias;
            return View(lsProdutos);
        }
    }
}