using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Quiron.LojaVirtual.Dominio.Entidades;

namespace Quiron.LojaVirtual.Web.Models
{
    public class CarrinhoViewModel
    {
       
        public Carrinho Carrinho { get; set; }

        public string ReturnUrl { get; set; }

    }
}