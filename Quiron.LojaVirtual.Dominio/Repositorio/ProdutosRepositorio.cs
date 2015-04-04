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

        public IEnumerable<Produto> todosProduto() {

            return contexto.Produtos;
        
        }






    }
}
