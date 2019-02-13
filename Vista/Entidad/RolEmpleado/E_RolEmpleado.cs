using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad.RolEmpleado
{
    public class E_RolEmpleado
    {
        int codigo;
        int rol;
        int empleado;

        public int Codigo { get => codigo; set => codigo = value; }
        public int Rol { get => rol; set => rol = value; }
        public int Empleado { get => empleado; set => empleado = value; }
    }
}
