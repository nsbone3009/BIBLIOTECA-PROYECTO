using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Biblioteca_Poo
{
    internal class csLogin : csConexionSQL
    {
        public bool VerificarLogin(string usuario, string contraseña)
        {
            Conexion.Open();
            string consulta = @"
                SELECT usuario_crd, contraseña_crd, cedula_usr
                FROM Credenciales
                WHERE usuario_crd = @usuario AND contraseña_crd = @contraseña;";
            SqlCommand comando = new SqlCommand(consulta, Conexion);
            comando.Parameters.AddWithValue("@usuario", usuario);
            comando.Parameters.AddWithValue("@contraseña", contraseña);
            SqlDataReader leer = comando.ExecuteReader();
            if (leer.Read())
            {
                Cedula = leer["cedula_usr"].ToString().Trim();
                Conexion.Close();
                return true;

            }
            else
            {
                Conexion.Close();
                return false;
            }
        }
        public string ObtenerRolUsuario(string cedula)
        {
            Conexion.Open();
            string rol = "";
            string consulta = @"
                    SELECT correo_usr, rol_usr
                    FROM Credenciales AS C
                    INNER JOIN [Usuarios] AS U ON C.cedula_usr = U.cedula_usr
                    WHERE C.cedula_usr = @cedula";
            SqlCommand comando = new SqlCommand(consulta, Conexion);
            comando.Parameters.AddWithValue("@cedula", cedula.Trim());
            SqlDataReader leer = comando.ExecuteReader();
            if (leer.Read())
                rol = leer["rol_usr"].ToString().Trim();
            Conexion.Close();
            return rol.Trim();
        }

        public void ActualizarContraseña(string correo, string NuevaClave)
        {
            string consulta = " select cedula_usr from Usuarios where correo_usr='" + correo + "'";
            Conexion.Open();
            SqlCommand comandos = new SqlCommand(consulta, Conexion);
            SqlDataReader lector = comandos.ExecuteReader();
            if (lector.Read())
                Cedula = lector["cedula_usr"].ToString().Trim();
            lector.Close();
            string consulta01 = "update Credenciales set contraseña_crd='" + NuevaClave + "'where cedula_usr='" + Cedula + "'";
            SqlCommand comandos01 = new SqlCommand(consulta01, Conexion);
            comandos01.ExecuteReader();
            MessageBox.Show("Datos Actualizados");
            Conexion.Close();
        }

        public bool VerificarCorreoSQL(string correo)
        {
            string consulta = "select COUNT(*) from Usuarios where correo_usr='" + correo + "'";
            bool ExisteCorreo = false;
            Conexion.Open();
            SqlCommand comands = new SqlCommand(consulta, Conexion);
            int contador = (int)comands.ExecuteScalar();
            ExisteCorreo = contador > 0;
            Conexion.Close();
            return ExisteCorreo;
        }
    }
}