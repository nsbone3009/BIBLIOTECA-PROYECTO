using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; 
using System.Windows.Forms; 
using System.Data;           

namespace Proyecto_Biblioteca_Poo
{
    internal class csConexionSQL
    {
        // Cadena de conexión que especifica el servidor, base de datos, y las credenciales de SQL Server.
        private string cadenaConexion = @"Password = 1111; Persist Security Info = False; User ID = Administrador; Initial Catalog = Biblioteca; Data Source = DESKTOP-T767FTN\KHRIZ";
        private SqlConnection conexion;  // Objeto SqlConnection para manejar la conexión con SQL Server.

        // Propiedad que permite acceder al objeto SqlConnection desde fuera de la clase.

        public SqlConnection Conexion { get { return conexion; } }
        public string Cedula;

        // Constructor de la clase que inicializa el objeto SqlConnection con la cadena de conexión.
        public csConexionSQL()
        {
            conexion = new SqlConnection(cadenaConexion);
        }

        // Método para ejecutar una consulta SELECT y devolver los resultados en un DataTable.
        public DataTable MostrarRegistros(string consulta)
        {
            SqlCommand comando = new SqlCommand(consulta, conexion); // Crea un comando SQL con la consulta proporcionada.
            SqlDataAdapter datos = new SqlDataAdapter(comando);       // Usa SqlDataAdapter para llenar el DataTable con los resultados de la consulta.
            DataTable tabla = new DataTable();                        // Crea un nuevo DataTable para almacenar los resultados.
            datos.Fill(tabla);                                        // Llena el DataTable con los datos obtenidos.
            return tabla;                                             // Retorna el DataTable lleno.
        }

        // Método para ejecutar una consulta SQL que no retorna resultados, como UPDATE, INSERT o DELETE.
        public void Update(string consulta)
        {
            conexion.Open();                                          // Abre la conexión con SQL Server.
            SqlCommand comando = new SqlCommand(consulta, conexion);  // Crea un comando SQL con la consulta proporcionada.
            comando.ExecuteNonQuery();                                // Ejecuta la consulta sin retornar resultados.
            conexion.Close();                                         // Cierra la conexión.
        }

        // Método para ejecutar una consulta SELECT y devolver los resultados como un SqlDataAdapter.
        public SqlDataAdapter Select(string consulta)
        {
            SqlCommand comando = new SqlCommand(consulta, conexion);  // Crea un comando SQL con la consulta proporcionada.
            SqlDataAdapter datos = new SqlDataAdapter(comando);       // Usa SqlDataAdapter para manejar los resultados de la consulta.
            return datos;                                             // Retorna el SqlDataAdapter con los resultados.
        }

        // Método para ejecutar una consulta SELECT y devolver los resultados como un SqlDataReader.
        public SqlDataReader SelectLeer(string consulta)
        {
            conexion.Open();                                          // Abre la conexión con SQL Server.
            SqlCommand comando = new SqlCommand(consulta, conexion);  // Crea un comando SQL con la consulta proporcionada.
            SqlDataReader leer = comando.ExecuteReader();             // Ejecuta la consulta y obtiene un SqlDataReader con los resultados.
            return leer;                                              // Retorna el SqlDataReader con los resultados.
        }
        // Método para cerrar la conexión con SQL Server.
        public void CerrarConexion()
        {
            conexion.Close();                                         // Cierra la conexión.
        }

        // Método para abrir la conexión con SQL Server.
        public void AbrirConexion()
        {
            conexion.Open();                                          // Abre la conexión.
        }
        public bool VerificarLogin(string usuario, string contraseña)
        {
            using (SqlConnection conexio = GetConnection())
            {
                string consulta = @"
                    SELECT usuario_crd, contraseña_crd, cedula_usr 
                    FROM Credenciales 
                    WHERE usuario_crd = @usuario AND contraseña_crd = @contraseña;";

                using (SqlCommand comando = new SqlCommand(consulta, conexio))
                {
                    comando.Parameters.AddWithValue("@usuario", usuario);
                    comando.Parameters.AddWithValue("@contraseña", contraseña);

                    using (SqlDataReader leer = comando.ExecuteReader())
                    {
                        if (leer.Read())
                        {
                            Cedula = leer["cedula_usr"].ToString();
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
        }

        public string ObtenerRolUsuario(string cedula)
        {
            string rol = string.Empty;
            using (SqlConnection conexio = GetConnection())
            {
                string consulta = @"
                    SELECT correo_usr, rol_usr 
                    FROM Credenciales AS C 
                    INNER JOIN [Usuarios] AS U ON C.cedula_usr = U.cedula_usr 
                    WHERE C.cedula_usr = @cedula";

                using (SqlCommand comando = new SqlCommand(consulta, conexio))
                {
                    comando.Parameters.AddWithValue("@cedula", cedula.Trim());
                    using (SqlDataReader leer = comando.ExecuteReader())
                    {
                        if (leer.Read())
                        {
                            rol = leer["rol_usr"].ToString();
                        }
                    }
                }
            }
            return rol.Trim();
        }
        public void ActualizarContraseña(string correo, string NuevaClave)
        {
            string consulta = " select cedula_usr from Usuarios where correo_usr='" + correo + "'";
            conexion.Open();
            SqlCommand comandos = new SqlCommand(consulta, conexion);

            SqlDataReader lector = comandos.ExecuteReader();

            if (lector.Read())
            {
                Cedula = lector["cedula_usr"].ToString();
            }
            lector.Close();
            string consulta01 = "update Credenciales set contraseña_crd='" + NuevaClave + "'where cedula_usr='" + Cedula + "'";
            SqlCommand comandos01 = new SqlCommand(consulta01, conexion);
            comandos01.ExecuteReader();
            MessageBox.Show("Datos Actualizados");
            conexion.Close();
        }
        public bool VerificarCorreoSQL(string correo)
        {
            string consulta = "select COUNT(*) from Usuarios where correo_usr='" + correo + "'";
            bool ExisteCorreo = false;
            conexion.Open();
            SqlCommand comands = new SqlCommand(consulta, conexion);
            int contador = (int)comands.ExecuteScalar();
            ExisteCorreo = contador > 0;
            conexion.Close();
            return ExisteCorreo;
        }
    }
}
