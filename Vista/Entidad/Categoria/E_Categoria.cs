using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class E_Categoria
    {
        /*
        ALTER procedure [dbo].[SP_Categoria]
            @intTipo int,
            @intCodigo int,
            @vchNombre varchar(100),
            @intIdUsuarioCreacion int,
            @intIdUsuarioModificacion int,
            @intIdUsuarioEliminacion int
        as
        */

        int codigo;
        string nombre;
        int id_creacion;
        int id_modificacion;
        int id_eliminacion;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Id_creacion { get => id_creacion; set => id_creacion = value; }
        public int Id_modificacion { get => id_modificacion; set => id_modificacion = value; }
        public int Id_eliminacion { get => id_eliminacion; set => id_eliminacion = value; }
    }
}
