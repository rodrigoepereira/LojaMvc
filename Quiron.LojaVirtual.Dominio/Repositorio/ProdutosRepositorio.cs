using Quiron.LojaVirtual.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiron.LojaVirtual.Dominio.Repositorio
{
    public class ProdutosRepositorio
    {
        private readonly EfDbContext contexto = new EfDbContext();

        public IEnumerable<Produto> todosProduto
        {

            get { return contexto.Produtos; }

        }

        public void Salvar(Produto produtoId)
        {

            if (produtoId.ProdutoId == 0)
            {
                contexto.Produtos.Add(produtoId);
                contexto.SaveChanges();
            }
            else
            {
                Produto p = contexto.Produtos.FirstOrDefault(x => x.ProdutoId == produtoId.ProdutoId);
                if (p != null)
                {
                    p.Categoria = produtoId.Categoria;
                    p.Descricao = produtoId.Descricao;
                    p.Nome = produtoId.Nome;
                    p.Preco = produtoId.Preco;
                    contexto.SaveChanges();
                }

            }

        }


        public Produto Excluir(int produtoId)
        {
            Produto prod = contexto.Produtos.Find(produtoId);

            if (prod != null)
            {
                contexto.Produtos.Remove(prod);
                contexto.SaveChanges();
            }

            return prod;
        }





    }
}
