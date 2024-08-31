using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Drawing.Imaging;

namespace Proyecto_Biblioteca_Poo
{
    public partial class frmConfiguracionSistema : Form
    {
        static SqlConnection Conexion = new SqlConnection(@"Server = NIURLETH; Database = Biblioteca; Integrated Security = True");
        
        public frmConfiguracionSistema()
        {
            InitializeComponent();
        }

        private void frmConfiguracionSistema_Load(object sender, EventArgs e)
        {
            csConexionSQL conexion = new csConexionSQL();
            string consulta1 = "Select * from Logo where id_imagen = 1";
            SqlDataReader leer = conexion.SelectLeer(consulta1);
            if (leer.Read())
            {
                try
                {
                    MemoryStream ImgMemoria = new MemoryStream((byte[])leer["imagen_lg"]);
                    Bitmap bitmap = new Bitmap(ImgMemoria);
                    frmPantallaPrincipal frm = Owner as frmPantallaPrincipal;
                    ptbxImagen.BackgroundImage = bitmap;
                }
                catch { }
            }
            conexion.CerrarConexion();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog Imagen = new OpenFileDialog();
            Imagen.Filter = "archivos de imagen (*png;)|*png;";

            if (Imagen.ShowDialog() == DialogResult.OK)
            {
                ptbxImagen.Image = Image.FromFile(Imagen.FileName);
            }

            MemoryStream espacio = new MemoryStream(); //Dar espacio de memoria
            ptbxImagen.Image.Save(espacio, ImageFormat.Png); // Guardar la imagen del Pb en el espacio de memoria en formato JPEG
            byte[] Convertir = espacio.ToArray(); // Convertir la imagen guardada en memoria a un arreglo de bytes

            Conexion.Open();
            string consulta = "update logo set imagen_lg = @imagen where id_imagen = 1";
            SqlCommand Comando = new SqlCommand(consulta, Conexion);
            Comando.Parameters.AddWithValue("Imagen", Convertir); // Agregar el parámetro @Imagen con el arreglo de bytes convertido de la imagen
            Comando.ExecuteNonQuery(); //Ejecutar el comando
            Conexion.Close();

            csConexionSQL conexion = new csConexionSQL();
            string consulta1 = "Select * from Logo where id_imagen = 1";
            SqlDataReader leer = conexion.SelectLeer(consulta1);
            if (leer.Read())
            {
                MemoryStream ImgMemoria = new MemoryStream((byte[])leer["imagen_lg"]);
                Bitmap bitmap = new Bitmap(ImgMemoria);
                frmPantallaPrincipal frm = Owner as frmPantallaPrincipal;
                frm.ptboxLogo.BackgroundImage = bitmap;
            }

        }

        private void btnGuardarCampos_Click(object sender, EventArgs e)
        {
            string consulta = "update logo set nombre_lg = '"+ txtNombreEmpresa.Text +"' where id_imagen = 1";
            Conexion.Open();
            SqlCommand Comando = new SqlCommand(consulta, Conexion);
            Comando.ExecuteNonQuery(); //Ejecutar el comando
            Conexion.Close();

            csConexionSQL conexion = new csConexionSQL();
            string consulta1 = "Select * from Logo where id_imagen = 1";
            SqlDataReader leer = conexion.SelectLeer(consulta1);
            if (leer.Read())
            {
                frmPantallaPrincipal frm = Owner as frmPantallaPrincipal;
                frm.lbNombreEmpresa.Text = leer["nombre_lg"].ToString();
            }
        }
    }
}
