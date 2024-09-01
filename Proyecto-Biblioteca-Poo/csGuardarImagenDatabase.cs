using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Data.SqlClient;

namespace Proyecto_Biblioteca_Poo
{
    class csGuardarImagenDatabase
    {
        public void GuardarImagen(PictureBox Imagen)
        {
            MemoryStream espacio = new MemoryStream(); //Dar espacio de memoria
            Imagen.Image.Save(espacio, ImageFormat.Png); // Guardar la imagen del Pb en el espacio de memoria en formato JPEG
            byte[] Convertir = espacio.ToArray(); // Convertir la imagen guardada en memoria a un arreglo de bytes
            csConexionSQL conexion = new csConexionSQL();
            conexion.AbrirConexion();
            string consulta = "update logo set imagen_lg = @imagen where id_imagen = 1";
            SqlCommand Comando = new SqlCommand(consulta, conexion.Conexion);
            Comando.Parameters.AddWithValue("imagen", Convertir); // Agregar el parámetro @Imagen con el arreglo de bytes convertido de la imagen
            Comando.ExecuteNonQuery(); //Ejecutar el comando
            conexion.CerrarConexion();
        }
    }
}
