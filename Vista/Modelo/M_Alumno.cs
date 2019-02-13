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
    class M_Alumno
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);

        /*
            ALTER procedure [dbo].[SP_Alumno] 
                @intTipo int,
                @intCodigo int,
                @vchMatricula nvarchar(8),
                @vchNombre varchar(100),
                @vchAP varchar(100),
                @vchAM varchar(100),
                @intCuatrimestre int,
                @intGrupo char,
                @intCarrera int,
                @intIdUsuario int
            as
         */
        public bool AlumnoInsertar(E_Alumno alumno)
        {
            SqlCommand cmd = new SqlCommand("SP_insertarCategoria", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@intTipo", 1);
            cmd.Parameters.AddWithValue("@intCodigo", ' ');
            cmd.Parameters.AddWithValue("@vchMatricula", alumno.Matricula);
            cmd.Parameters.AddWithValue("@vchAP", alumno.AP1);
            cmd.Parameters.AddWithValue("@vchAM", alumno.AM1);
            cmd.Parameters.AddWithValue("@intCuatrimestre", alumno.Cuatrimestre);
            cmd.Parameters.AddWithValue("@intGrupo", alumno.Grupo);
            cmd.Parameters.AddWithValue("@intCarrera", alumno.Carrera);
            cmd.Parameters.AddWithValue("@intIdUsuario", ' ');

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
        public bool AlumnoModificar(E_Alumno alumno)
        {
            SqlCommand cmd = new SqlCommand("SP_insertarCategoria", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@intTipo", 2);
            cmd.Parameters.AddWithValue("@intCodigo", ' ');
            cmd.Parameters.AddWithValue("@vchMatricula", alumno.Matricula);
            cmd.Parameters.AddWithValue("@vchAP", alumno.AP1);
            cmd.Parameters.AddWithValue("@vchAM", alumno.AM1);
            cmd.Parameters.AddWithValue("@intCuatrimestre", alumno.Cuatrimestre);
            cmd.Parameters.AddWithValue("@intGrupo", alumno.Grupo);
            cmd.Parameters.AddWithValue("@intCarrera", alumno.Carrera);
            cmd.Parameters.AddWithValue("@intIdUsuario", ' ');

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

        public bool AlumnoEliminar(E_Alumno alumno)
        {
            SqlCommand cmd = new SqlCommand("SP_insertarCategoria", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@intTipo", 3);
            cmd.Parameters.AddWithValue("@intCodigo", ' ');
            cmd.Parameters.AddWithValue("@vchMatricula", alumno.Matricula);
            cmd.Parameters.AddWithValue("@vchAP", alumno.AP1);
            cmd.Parameters.AddWithValue("@vchAM", alumno.AM1);
            cmd.Parameters.AddWithValue("@intCuatrimestre", alumno.Cuatrimestre);
            cmd.Parameters.AddWithValue("@intGrupo", alumno.Grupo);
            cmd.Parameters.AddWithValue("@intCarrera", alumno.Carrera);
            cmd.Parameters.AddWithValue("@intIdUsuario", ' ');

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
    }// --> Termina clase
}
