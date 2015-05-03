using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Quiron.LojaVirtual.Dominio.Repositorio;
using Quiron.LojaVirtual.Dominio.Entidades;

namespace Quiron.LojaVirtual.Web.Areas.Administrativo.Controllers
{
    [Authorize]
    public class ProdutoController : Controller
    {

        private ProdutosRepositorio repositorio;

        //
        // GET: /Administrativo/Produto/
        public ActionResult Index()
        {
            repositorio = new ProdutosRepositorio();

            var produto = repositorio.todosProduto;

            return View(produto);
        }


        public ViewResult Alterar(int produtoId)
        {
            repositorio = new ProdutosRepositorio();

            var produto = repositorio.todosProduto.FirstOrDefault(x => x.ProdutoId == produtoId);


            return View(produto);

        }

        [HttpPost]
        public ActionResult Alterar(Produto produto)
        {
            if (ModelState.IsValid)
            {
                repositorio = new ProdutosRepositorio();
                repositorio.Salvar(produto);
                TempData["mensagem"] = string.Format("{0} foi salvo com sucesso", produto.Nome);

                return RedirectToAction("index");
            }

            return View(produto);
        }

        public ViewResult NovoProduto()
        {
            return View("Alterar", new Produto());
        }

        //[HttpPost]
        //public ActionResult Excluir(int produtoId)
        //{
        //    repositorio = new ProdutosRepositorio();

        //    Produto produto = repositorio.Excluir(produtoId);

        //    if (produto != null)
        //    {
        //        TempData["mensagem"] = string.Format("{0} foi excluído com sucesso!!!", produto.Nome);

        //    }
        //    else
        //    {
        //        TempData["mensagem"] = string.Format("{0} falha na exclusão!!!", produto.Nome);

        //    }

        //    return RedirectToAction("index");


        //}



        [HttpPost]
        public JsonResult Excluir(int produtoId)
        {

            string mensagem = string.Empty;

            repositorio = new ProdutosRepositorio();

            Produto produto = repositorio.Excluir(produtoId);

            if (produto != null)
            {
                mensagem = string.Format("{0} foi excluído com sucesso!!!", produto.Nome);

            }
            else
            {
                mensagem = string.Format("{0} falha na exclusão!!!", produto.Nome);

            }

            return Json(mensagem,JsonRequestBehavior.AllowGet);


        }


    }
}