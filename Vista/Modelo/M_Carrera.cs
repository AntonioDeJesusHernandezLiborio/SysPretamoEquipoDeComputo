using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using Entidad.Carrera;

namespace Modelo
{
    public class M_Carrera
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);

        /*
        ALTER procedure [dbo].[SP_Carrera]
            @intTipo int,
            @intCodigo int,
            @vchNombre varchar(max)
        as
        */

        public bool CategoriaInsertar(E_Carrera Carrera, String idUser)
        {
            SqlCommand cmd = new SqlCommand("SP_Carrera", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@intTipo", 1);
            cmd.Parameters.AddWithValue("@intCodigo", ' ');
            cmd.Parameters.AddWithValue("@vchNombre", Carrera.Nombre);
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
