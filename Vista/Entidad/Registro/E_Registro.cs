using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class E_Registro
    {
        int clave;
        int idComponente;
        int matricula;
        int idencargado;
        string fecha_solicitud;
        string fecha_entrega;
        string activo;
        int id_modificacion;
        int id_eliminacion;
        string fechaModificacion;
        string fechaEliminacion;

        public int Clave { get => clave; set => clave = value; }
        public int IdComponente { get => idComponente; set => idComponente = value; }
        public int Matricula { get => matricula; set => matricula = value; }
        public int Idencargado { get => idencargado; set => idencargado = value; }
        public string Fecha_solicitud { get => fecha_solicitud; set => fecha_solicitud = value; }
        public string Fecha_entrega { get => fecha_entrega; set => fecha_entrega = value; }
        public string Activo { get => activo; set => activo = value; }
        public int Id_modificacion { get => id_modificacion; set => id_modificacion = value; }
        public int Id_eliminacion { get => id_eliminacion; set => id_eliminacion = value; }
        public string FechaModificacion { get => fechaModificacion; set => fechaModificacion = value; }
        public string FechaEliminacion { get => fechaEliminacion; set => fechaEliminacion = value; }
    }
}
