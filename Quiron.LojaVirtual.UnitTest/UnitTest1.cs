using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quiron.LojaVirtual.Dominio.Entidades;
using System.Collections.Generic;
using System.Linq;


namespace Quiron.LojaVirtual.UnitTest
{
    [TestClass]
    public class unitTestQuiron
    {
        [TestMethod]
        public void TestMethod1()
        {
            Carrinho c = new Carrinho();

            ItensCarrinho i = new ItensCarrinho();

            Produto p = new Produto();

            p.ProdutoId = 1;
            p.Nome = "creme de bunda";
            p.Preco = 10;

            Produto p2 = new Produto();
            p2.ProdutoId = 1;
            p2.Nome = "creme 3";
            p2.Preco = 100;

            Produto p3 = new Produto();
            p3.ProdutoId = 3;
            p3.Nome = "creme 3";
            p3.Preco = 100;

            c.AdicionarItem(p, 2);

            c.AdicionarItem(p2, 2);

            c.AdicionarItem(p3, 2);

            ItensCarrinho[] x = c.retornaCarrinho.ToArray();

           decimal z =  c.ObtemValor();

           c.RemoveItem(p3);

           Assert.AreEqual(c.retornaCarrinho.Where(c1 => c1.produto.ProdutoId == p3.ProdutoId).Count(), 0);

           Assert.AreEqual(c.retornaCarrinho.Count(), 1);

           //Assert.AreEqual(x.Length, 1);

           //Assert.AreEqual(x[0].Quantidade, 5);


         //  decimal x = z;

           c.LimpaCarrinho();

           Assert.AreEqual(c.retornaCarrinho.Count(), 0);

            

            

            


        }
    }
}
