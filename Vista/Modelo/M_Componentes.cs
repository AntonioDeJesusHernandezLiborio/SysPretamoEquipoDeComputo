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

        public bool insertaCategoria(E_Categoria categoria)
        {
            SqlCommand cmd = new SqlCommand("SP_insertarCategoria", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre", categoria.Nombre);
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