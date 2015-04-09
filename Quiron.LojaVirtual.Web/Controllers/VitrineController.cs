using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Quiron.LojaVirtual.Dominio.Repositorio;
using Quiron.LojaVirtual.Web.Models;

namespace Quiron.LojaVirtual.Web.Controllers
{
    public class VitrineController : Controller
    {
        //
        // GET: /Vitrine/

        private ProdutosRepositorio p,p1;

        private int ProdutoPorPagina = 3;

        public ViewResult ListaProdutos(string categoria, int pagina = 1)
        {
            p = new ProdutosRepositorio();

            if (categoria == null) categoria = "";

          //  p1 = new ProdutosRepositorio();

            var produto = p.todosProduto.Where(x => x.Categoria.Contains(categoria) )
                .OrderBy(x => x.Nome).Skip((pagina - 1) * ProdutoPorPagina).Take(ProdutoPorPagina);

            
            Paginacao pg = new Paginacao();
            pg.PaginaAtual = pagina;
            pg.ItensPorPagina = ProdutoPorPagina;
            pg.TotalDeItens = p.todosProduto.Count();

            ProdutosViewModel model = new ProdutosViewModel();
            model.Produtos = produto;
            model.Paginacao = pg;
            model.CategoriaAtual = categoria;
            
            return View(model);
        }
	}
}