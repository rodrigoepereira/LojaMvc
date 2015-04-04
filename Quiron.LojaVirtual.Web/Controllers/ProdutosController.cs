using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Quiron.LojaVirtual.Dominio.Repositorio;

namespace Quiron.LojaVirtual.Web.Controllers
{
    public class ProdutosController : Controller
    {
        //
        // GET: /Produtos/

        private ProdutosRepositorio p;

        public ActionResult Index()
        {
            p = new ProdutosRepositorio();
            var produto = p.todosProduto().Take(10);

            return View(produto);
        }
	}
}