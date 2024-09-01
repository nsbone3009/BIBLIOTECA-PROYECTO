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
        private string cadenaConexion = @"Password=123;Persist Security Info=True;User ID=Jeremy01;Initial Catalog=Biblioteca;Data Source=DESKTOP-2UJUKM2\JEREMY";
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
        //AGREGADO POR KHRIZ INSERTA UN REGISTRO EN UNA TABLA
        public void Insert(string consulta)
        {
            conexion.Open();                                          // Abre la conexión con SQL Server.
            SqlCommand comando = new SqlCommand(consulta, conexion);  // Crea un comando SQL con la consulta proporcionada.
            comando.ExecuteNonQuery();                                // Ejecuta la consulta sin retornar resultados.
            conexion.Close();                                             // Retorna el SqlDataAdapter con los resultados.
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
      
        //AGREGADO POR KHRIZ, SIRVE PARA EXTRAER UN CAMPOS EN ESPECIFICO DE UN REGISTRO
        public string Extraer(string consulta, string columna)
        {
            string resultado = "";
            conexion.Open();
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataReader leer = comando.ExecuteReader();
            if(leer.Read()) { resultado = leer[columna].ToString(); }
            conexion.Close();
            return resultado;
        }
    }
}
