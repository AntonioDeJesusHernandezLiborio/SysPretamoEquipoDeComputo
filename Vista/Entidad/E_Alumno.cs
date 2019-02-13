using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    class E_Alumno
    {
        string matricula;
        string nombre;
        string AP;
        string AM;
        string cuatrimestre;
        string grupo;
        string carrera;

        public string Matricula { get => matricula; set => matricula = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string AP1 { get => AP; set => AP = value; }
        public string AM1 { get => AM; set => AM = value; }
        public string Cuatrimestre { get => cuatrimestre; set => cuatrimestre = value; }
        public string Grupo { get => grupo; set => grupo = value; }
        public string Carrera { get => carrera; set => carrera = value; }
    }
}
