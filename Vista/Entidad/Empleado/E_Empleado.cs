using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class E_Empleado
    {
        int codigo;
        string nombre;
        string AP;
        string AM;
        string turno;
        string clave;
        string usuario;
        

        public string Nombre { get => nombre; set => nombre = value; }
        public string AP1 { get => AP; set => AP = value; }
        public string AM1 { get => AM; set => AM = value; }
        public string Turno { get => turno; set => turno = value; }
        public string Clave { get => clave; set => clave = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public string Usuario { get => usuario; set => usuario = value; }
    }
}
