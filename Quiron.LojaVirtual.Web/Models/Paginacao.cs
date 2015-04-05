using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Quiron.LojaVirtual.Web.Models
{
    public class Paginacao
    {
        public int TotalDeItens { get; set; }

        public int ItensPorPagina { get; set; }

        public int PaginaAtual { get; set; }
       
        public int TotalDePagina()
        { 
           int t = 0 ;

           t = Convert.ToInt16(TotalDeItens / ItensPorPagina);

           return t;
         }

    }
}