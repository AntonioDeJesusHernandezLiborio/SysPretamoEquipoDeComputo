using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad.Carrera
{
    public class E_Carrera
    {
        int codigo;
        string nombre;
        int activo;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Activo { get => activo; set => activo = value; }
    }
}
