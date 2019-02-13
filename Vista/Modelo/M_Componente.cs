using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using Entidad;

namespace Modelo
{
    class M_Componente
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);

        /*
            ALTER procedure [dbo].[SP_Componente]
                @intTipo int,
                @intClave int,
                @vchNombre varchar(100),
                @vchMarca nvarchar(100),
                @intStock int,
                @intCategoriaCodigo int,
                @intIdUsuario int
            as
         */

        public bool ComponenteInsertar(E_Categoria categoria, String idUser)
        {
            SqlCommand cmd = new SqlCommand("SP_Categoria", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@intTipo", 1);
            cmd.Parameters.AddWithValue("@intCodigo", ' ');
            cmd.Parameters.AddWithValue("@vchNombre", categoria.Nombre);
            cmd.Parameters.AddWithValue("@intIdUsuarioCreacion", idUser);
            cmd.Parameters.AddWithValue("@intIdUsuarioModificacion", ' ');
            cmd.Parameters.AddWithValue("@intIdUsuarioEliminacion", ' ');

            if (cn.State == ConnectionState.Open) cn.Close();
            cn.Open();
            if (cmd.ExecuteNonQuery() > 0)
            {
                cn.Close();
                return true;
            }
            else
            {
                cn.Close();
                return false;
            }

        }
    }
}
