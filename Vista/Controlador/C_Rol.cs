using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Entidad.Rol;
using System.Data;

namespace Controlador
{
    public class C_Rol
    {

        M_Roles modeloRol = new M_Roles();

        public DataTable ConsultarRoles()
        {
            return modeloRol.ConsultarRoles();
        }

        public bool InsertarRol(E_Rol rol)
        {
            return modeloRol.InsertarRol(rol);
        }

        public bool ActualizarRol(E_Rol rol)
        {
            return modeloRol.ActualizarRol(rol);
        }
        public bool EliminarRol(E_Rol rol)
        {
            return modeloRol.EliminarRol(rol);
        }
    }
}
