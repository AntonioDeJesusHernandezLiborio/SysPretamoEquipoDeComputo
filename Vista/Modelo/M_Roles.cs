using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using Entidad.Rol;

namespace Modelo
{
    public class M_Roles
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);

        public DataTable ConsultarRoles()
        {
            DataTable dt = new DataTable();
            try
            {
                if (cn.State == ConnectionState.Open) cn.Close();
                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SP_Rol '4','','';", cn);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    return dt;
                }
                else
                {
                    return dt;
                }
            }
            catch
            {
                return dt;
            }

        }
        public bool InsertarRol(E_Rol roles)
        {
            SqlCommand cmd = new SqlCommand("SP_Rol", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@intTipo", 1);
            cmd.Parameters.AddWithValue("@intCodigo", "");
            cmd.Parameters.AddWithValue("@vchDescripcion", roles.Descripcion);
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
        public bool ActualizarRol(E_Rol roles)
        {
            SqlCommand cmd = new SqlCommand("SP_Rol", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@intTipo", 2);
            cmd.Parameters.AddWithValue("@intCodigo", roles.Codigo);
            cmd.Parameters.AddWithValue("@vchDescripcion", roles.Descripcion);
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

        public bool EliminarRol(E_Rol roles)
        {
            SqlCommand cmd = new SqlCommand("SP_Rol", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@intTipo", 3);
            cmd.Parameters.AddWithValue("@intCodigo", roles.Codigo);
            cmd.Parameters.AddWithValue("@vchDescripcion","");
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
