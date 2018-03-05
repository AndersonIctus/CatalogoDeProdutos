using Catalogo.Aplicacao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Catalogo.Aplicacao.Controllers
{
    public class CategoriaController : Controller
    {
        // GET: Categoria
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                //Faz a inclusao no banco de dados !!
            }

            return View();
        }
    }
}