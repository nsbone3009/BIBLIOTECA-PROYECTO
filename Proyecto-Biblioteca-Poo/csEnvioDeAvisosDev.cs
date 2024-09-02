using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_Biblioteca_Poo
{
    class csEnvioDeAvisosDev
    {
        static DateTime fechaAviso;
        static int estado = 0;
        static string correo = "";
        static int aviso = 0;
        public void Comparar()
        {
            DateTime fechaActual = DateTime.Now.Date;
            using (SqlConnection conexion = new SqlConnection(new csConexionSQL().cadenaConexion))
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("select P.fecha_devolucio_programada,P.estado_, P.aviso_, L.correo_ltr, L.cedula_ltr, L.nombres_ltr, P.isbn_lb from Prestamos as P inner join Lectores as L on P.cedula_ltr = L.cedula_ltr where P.aviso_ = 0 and P.estado_=1", conexion);
                SqlDataReader leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    string fhaviso = leer.GetString(0).Trim();
                    fechaAviso = DateTime.Parse(fhaviso);
                    estado = leer.GetInt32(1);
                    aviso = leer.GetInt32(2);
                    correo = leer.GetString(3);
                    int ced = int.Parse((leer.GetInt32(4).ToString()).Trim());
                    string nombre = leer.GetString(5);
                    string isbn = leer.GetString(6);
                    if ((fechaAviso.AddDays(-1) == fechaActual))
                    {
                        csConexionSQL obj = new csConexionSQL();
                        obj.Update("Update Prestamos set aviso_ = 1 where cedula_ltr = '" + ced.ToString().Trim() + "' and fecha_devolucio_programada = '" + fhaviso.Trim() + "'");
                        EnviarCorreo(correo.Trim(), nombre.Trim(), isbn.Trim());
                    }
                }
            }
        }
        public void EnviarCorreo(string correo, string nombre, string isbn)
        {
            frmPantallaPrincipal obj = new frmPantallaPrincipal();
            csEmail email = new csEmail();
            email.Asunto = "Recordatorio de Entrega de Libro - Queda 1 dia";
            email.Cuerpo = "Estimado/a " + nombre + ": \nEsperamos que se encuentre bien. \nLe recordamos que el libro de código [" + isbn + "] que tiene en préstamo se encuentra próximo a su fecha de vencimiento. \nLe resta 1 día para devolver el ejemplar a nuestra biblioteca. \nPara evitar recargos y permitir que otros usuarios disfruten del mismo, le solicitamos que realice la devolución dentro del plazo establecido. \nSi necesita extender el préstamo o tiene alguna consulta, por favor, no dude en contactarnos. Estamos aquí para ayudarle. \nAgradecemos su atención y comprensión.Atentamente la Biblioteca " + obj.lbNombreEmpresa.Text;
            email.Receptor = correo.Trim();
            email.Con_Copia = "sanchezvera243@gmail.com";
            email.Enviar();
            if (email.Enviar())
                MessageBox.Show($"Se acaba de enviar un recordatorio al estudiante {nombre} para la devolucin del libro con ISBN {isbn}\nEl recordatorio fue enviado al correo : {correo}");

        }
    }
}
