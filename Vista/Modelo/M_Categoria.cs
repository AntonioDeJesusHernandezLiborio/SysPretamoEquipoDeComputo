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
    public class M_Categoria
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);

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

        public bool CategoriaInsertar(E_Categoria categoria)
        {
            SqlCommand cmd = new SqlCommand("SP_Categoria", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@intTipo", 1);
            cmd.Parameters.AddWithValue("@intCodigo", ' ');
            cmd.Parameters.AddWithValue("@vchNombre", categoria.Nombre);
            cmd.Parameters.AddWithValue("@intIdUsuarioCreacion", categoria.Id_creacion);
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

        public bool CategoriaModificar(E_Categoria categoria)
        {
            SqlCommand cmd = new SqlCommand("SP_Categoria", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@intTipo", 2);
            cmd.Parameters.AddWithValue("@intCodigo", categoria.Codigo);
            cmd.Parameters.AddWithValue("@vchNombre", categoria.Nombre);
            cmd.Parameters.AddWithValue("@intIdUsuarioCreacion", ' ');
            cmd.Parameters.AddWithValue("@intIdUsuarioModificacion", categoria.Id_modificacion);
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

        public bool CategoriaEliminar(E_Categoria categoria)
        {
            SqlCommand cmd = new SqlCommand("SP_Categoria", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@intTipo", 3);
            cmd.Parameters.AddWithValue("@intCodigo", categoria.Codigo);
            cmd.Parameters.AddWithValue("@vchNombre", ' ');
            cmd.Parameters.AddWithValue("@intIdUsuarioCreacion", ' ');
            cmd.Parameters.AddWithValue("@intIdUsuarioModificacion",' ');
            cmd.Parameters.AddWithValue("@intIdUsuarioEliminacion", categoria.Id_eliminacion);

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

        public DataTable ConsultarCategoria()
        {
            DataTable dt = new DataTable();
            try
            {
                if (cn.State == ConnectionState.Open) cn.Close();
                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SP_Categoria '4','','','','','';", cn);
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


        //Visualizar una tabla



        //public int ultimoRegistroPedido()
        //{
        //    int r = 0;
        //    SqlCommand cmd = new SqlCommand("SP_Pedidos 2,0,0,'','','','','','','','','','','';", cn);
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    if (dt.Rows.Count > 0)
        //    {
        //        DataRow row = dt.Rows[0];
        //        r = int.Parse(row[0].ToString());
        //    }
        //    return r;
        //}
    }
}