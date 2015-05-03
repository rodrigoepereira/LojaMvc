using Quiron.LojaVirtual.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiron.LojaVirtual.Dominio.Repositorio
{
    public class AdministradoresRepositorio
    {
        private readonly EfDbContext contexto = new EfDbContext();

        public Administrador ObtemAdministrador(Administrador a)
        {
            return contexto.Administradores.FirstOrDefault(x => x.Login == a.Login);
        }

    }
}
