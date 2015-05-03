using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// importar dataannotations

using System.ComponentModel.DataAnnotations;

namespace Quiron.LojaVirtual.Dominio.Entidades
{
    public class Administrador
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage="Informe o login")]
        [Display(Name="Login: ")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Informe a senha")]
        [Display(Name ="Senha: ")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        public DateTime UltimoAcesso { get; set; }


    }
}
