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


namespace Proyecto_Biblioteca_Poo
{
    public partial class frmConfiguracionSistema : Form
    {
        static csConexionSQL conexion = new csConexionSQL();
        public frmConfiguracionSistema()
        {
            InitializeComponent();
        }
        public void Mostrar()
        {
            string consulta1 = "Select * from Logo where id_imagen = 1";
            SqlDataReader leer = conexion.SelectLeer(consulta1);
            if (leer.Read())
            {
                try
                {
                    txtNombreEmpresa.Text = leer["nombre_lg"].ToString().Trim();
                    MemoryStream ImgMemoria = new MemoryStream((byte[])leer["imagen_lg"]);
                    Bitmap bitmap = new Bitmap(ImgMemoria);
                    frmPantallaPrincipal frm = Owner as frmPantallaPrincipal;
                    ptbxImagen.BackgroundImage = bitmap;
                }
                catch { }
            }
            conexion.CerrarConexion();
        }

        private void btnGuardarCampos_Click(object sender, EventArgs e)
        {
            string consulta = "Update logo set nombre_lg = '" + txtNombreEmpresa.Text + "' where id_imagen = 1";
            conexion.Update(consulta);
            frmPantallaPrincipal frm = Owner as frmPantallaPrincipal;
            frm.MostrarLogoNombre();
            btnGuardarCampos.Enabled = false;
            txtNombreEmpresa.Enabled = false;
        }

        private void btnEditarCampos_Click(object sender, EventArgs e)
        {
            btnGuardarCampos.Enabled = true;
            txtNombreEmpresa.Enabled = true;
        }

        private void frmConfiguracionSistema_Load(object sender, EventArgs e)
        {
            btnGuardarCampos.Enabled = false;
            txtNombreEmpresa.Enabled = false;
        }

        private void btnCambiarLogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog Imagen = new OpenFileDialog();
            Imagen.Filter = "archivos de imagen (*png;)|*png;";
            if (Imagen.ShowDialog() == DialogResult.OK) 
            {
                ptbxImagen.BackgroundImage = null;
                ptbxImagen.Image = Image.FromFile(Imagen.FileName);
                new csGuardarImagenDatabase().GuardarImagen(ptbxImagen);
            }
            frmPantallaPrincipal frm = Owner as frmPantallaPrincipal;
            frm.MostrarLogoNombre();
        }
    }
}
