using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Quiron.LojaVirtual.Dominio.Repositorio;

namespace Quiron.LojaVirtual.Web.Controllers
{
    public class CategoriaController : Controller
    {
        //
        // GET: /Categoria/

        private ProdutosRepositorio p;

        public PartialViewResult Menu(string categoria = null)
        {
            ViewBag.CategoriaSelecionada = categoria;

            p = new ProdutosRepositorio();

            IEnumerable<string> categorias = p.todosProduto.Select(c => c.Categoria).Distinct().OrderBy(c => c);

            return PartialView(categorias);
        }
	}
}