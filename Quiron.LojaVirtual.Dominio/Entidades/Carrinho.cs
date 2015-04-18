using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiron.LojaVirtual.Dominio.Entidades
{
    public class Carrinho
    {
        private List<ItensCarrinho> itensCarrinho = new List<ItensCarrinho>();

        public void AdicionarItem(Produto p , int quantidade) {
            
            ItensCarrinho i =  itensCarrinho.FirstOrDefault(x=> x.produto.ProdutoId == p.ProdutoId);
            
            if (i == null) {
                ItensCarrinho c = new ItensCarrinho();
                c.produto = p;
                c.Quantidade = quantidade;

                itensCarrinho.Add(c);

            } else
            {
                i.Quantidade = i.Quantidade + quantidade;
            }

        } // fim adiciona

        public void RemoveItem(Produto p)
        {
            itensCarrinho.RemoveAll(x => x.produto.ProdutoId == p.ProdutoId);
        }// fim remove item

        public decimal ObtemValor()
        {
            return itensCarrinho.Sum(x => x.produto.Preco * x.Quantidade);
        }// fim obtem valor


        public void LimpaCarrinho()
        {
            itensCarrinho.Clear();
        }// fim limpa carrinho


        public IEnumerable<ItensCarrinho> retornaCarrinho {
          get {return itensCarrinho;}

         }







    }

    

    public class ItensCarrinho{

        public Produto produto { get; set; }

        public int Quantidade { get; set; }

    }


}
