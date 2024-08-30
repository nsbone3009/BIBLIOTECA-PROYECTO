using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Biblioteca_Poo
{
    public class csPrestamos
    {
        private csConexionSQL conexionSQL;

        public csPrestamos()
        {
            conexionSQL = new csConexionSQL();
        }
        public DataTable ObtenerDatosPrestamo(int idPrestamo)
        {
            // Consulta SQL para obtener los datos del préstamo
            string query = $@"SELECT P.id_ptm, Le.cedula_ltr, Le.nombres_ltr, L.isbn_lb, L.titulo_lb, 
                              P.fecha_prestamo, P.fecha_devolucio_programada 
                              FROM Prestamos AS P 
                              JOIN Libros AS L ON P.isbn_lb = L.isbn_lb 
                              JOIN Lectores AS Le ON P.cedula_ltr = Le.cedula_ltr
                              WHERE P.id_ptm = {idPrestamo}";

            // Utiliza el método MostrarRegistros de csConexionSQL para ejecutar la consulta y llenar el DataTable
            DataTable dataTable = conexionSQL.MostrarRegistros(query);

            return dataTable;  // Retorna el DataTable con los resultados
        }
        public bool RegistrarPrestamo(int id_ptm, int cedula_ltr, string isbn_lb, string fecha_prestamo, string fecha_devolucio_programada)
        {
            try
            {
                string consulta = "INSERT INTO Prestamos (id_ptm, cedula_ltr, isbn_lb, fecha_prestamo, fecha_devolucio_programada, estado_ , aviso_) VALUES (@id_ptm, @cedula_ltr, @isbn_lb, @fecha_prestamo, @fecha_devolucio_programada, '"+1+"','"+0+"')";
                conexionSQL.AbrirConexion();
                SqlCommand comando = new SqlCommand(consulta, conexionSQL.Conexion);
                comando.Parameters.AddWithValue("@id_ptm", id_ptm);
                comando.Parameters.AddWithValue("@cedula_ltr", cedula_ltr);
                comando.Parameters.AddWithValue("@isbn_lb", isbn_lb);
                comando.Parameters.AddWithValue("@fecha_prestamo", fecha_prestamo);
                comando.Parameters.AddWithValue("@fecha_devolucio_programada", fecha_devolucio_programada);

                comando.ExecuteNonQuery();
                conexionSQL.CerrarConexion();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el préstamo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool EditarPrestamo(int id_ptm, int cedula_ltr, string isbn_lb, string fecha_prestamo, string fecha_devolucio_programada)
        {
            try
            {
                // Consulta SQL para actualizar el registro de un préstamo
                string consulta = @"UPDATE Prestamos 
                            SET cedula_ltr = @cedula_ltr, 
                                isbn_lb = @isbn_lb, 
                                fecha_prestamo = @fecha_prestamo, 
                                fecha_devolucio_programada = @fecha_devolucio_programada 
                            WHERE id_ptm = @id_ptm";
                // Abrir la conexión a la base de datos
                conexionSQL.AbrirConexion();

                // Crear un comando SQL con la consulta y la conexión
                SqlCommand comando = new SqlCommand(consulta, conexionSQL.Conexion);

                // Asignar los valores a los parámetros de la consulta
                comando.Parameters.AddWithValue("@id_ptm", id_ptm);
                comando.Parameters.AddWithValue("@cedula_ltr", cedula_ltr);
                comando.Parameters.AddWithValue("@isbn_lb", isbn_lb);
                comando.Parameters.AddWithValue("@fecha_prestamo", fecha_prestamo);
                comando.Parameters.AddWithValue("@fecha_devolucio_programada", fecha_devolucio_programada);

                // Ejecutar la consulta
                comando.ExecuteNonQuery();

                // Cerrar la conexión a la base de datos
                conexionSQL.CerrarConexion();

                // Retornar true indicando que la operación fue exitosa
                return true;
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error si ocurre alguna excepción
                MessageBox.Show("Error al editar el préstamo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    }
}
    
