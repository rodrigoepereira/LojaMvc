using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Quiron.LojaVirtual.Dominio.Repositorio;

namespace Quiron.LojaVirtual.Web.Controllers
{
    public class VitrineController : Controller
    {
        //
        // GET: /Vitrine/

        private ProdutosRepositorio p;

        private int ProdutoPorPagina = 3;

        public ActionResult ListaProdutos( int pagina = 1)
        {
            p = new ProdutosRepositorio();
            
            var produto = p.todosProduto().OrderBy(x => x.Nome).Skip((pagina - 1) * ProdutoPorPagina).Take(ProdutoPorPagina);

            return View(produto);
        }
	}
}