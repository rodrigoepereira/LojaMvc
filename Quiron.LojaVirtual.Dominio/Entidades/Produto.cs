using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// adicionar para funcionar os decores e annotations
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Quiron.LojaVirtual.Dominio.Entidades
{
    public class Produto
    {
        [HiddenInput(DisplayValue=false)]
        public int ProdutoId { get; set; }
     
        [Required(ErrorMessage="O campo nome é obrigatório")]
        public string Nome   { get; set; }

        [Required(ErrorMessage = "O campo descrição é obrigatório")]
        [DataType(DataType.MultilineText)]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O campo preço é obrigatório")]
        [Range(0.01,Double.MaxValue,ErrorMessage="Valor deve ser maior 0,01")]
        [RegularExpression(@"[0-9]+$", ErrorMessage="Deve ser informado números")]
        public decimal Preco { get; set; }

        [Required(ErrorMessage = "O campo categoria é obrigatório")]
        public string Categoria { get; set; }

        public byte[] Imagem { get; set; }

        public string ImagemMimeType { get; set; }
    }
}
