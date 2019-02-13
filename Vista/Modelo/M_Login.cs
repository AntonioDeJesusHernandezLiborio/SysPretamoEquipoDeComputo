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
    public class M_Login
    {

        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);

        public DataTable IniciarSesion(E_Empleado empleado)
        {
            DataTable dt = new DataTable();
            try
            {
                if (cn.State == ConnectionState.Open) cn.Close();
                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SP_Login '" + empleado.Nombre + "','" + empleado.Clave + "';",cn);
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
    }
}
