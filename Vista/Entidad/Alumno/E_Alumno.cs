using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class E_Alumno
    {
        int codigo;
        string matricula;
        string nombre;
        string AP;
        string AM;
        int cuatrimestre;
        int grupo;
        int carrera;
        int activo;
        int id_usuario;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string AP1 { get => AP; set => AP = value; }
        public string AM1 { get => AM; set => AM = value; }
        public int Cuatrimestre { get => cuatrimestre; set => cuatrimestre = value; }
        public int Grupo { get => grupo; set => grupo = value; }
        public int Carrera { get => carrera; set => carrera = value; }
        public int Activo { get => activo; set => activo = value; }
        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
    }
}
