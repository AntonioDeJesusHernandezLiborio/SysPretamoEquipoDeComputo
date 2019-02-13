using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Entidad;
using System.Data;

namespace Controlador
{
    public class C_Login
    {
        M_Login modeloLogin = new M_Login();

        public DataTable IniciarSesion(E_Empleado empleado)
        {
            return modeloLogin.IniciarSesion(empleado);
        }

    }
}
