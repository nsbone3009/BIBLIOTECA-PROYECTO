using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Proyecto_Biblioteca_Poo
{
    public partial class frmValidacionEntrada : Form
    {
        public frmValidacionEntrada()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            btnOcultarContraseña.Visible = false;
            csConexionSQL conexion = new csConexionSQL();
            string consulta = "Select * from Logo where id_imagen = 1";
            SqlDataReader leer =  conexion.SelectLeer(consulta);
            if (leer.Read())
            {
                try
                {

                    MemoryStream ImgMemoria = new MemoryStream((byte[])leer["imagen_lg"]);
                    Bitmap bitmap = new Bitmap(ImgMemoria);
                    ptboxLogo.BackgroundImage = bitmap;
                    lbNombreEmpresa.Text = leer["nombre_lg"].ToString();
                } catch {}
            }
            conexion.CerrarConexion();
        }

        private void btnMostrarContraseña_Click(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = false;
            btnMostrarContraseña.Visible = false;
            btnOcultarContraseña.Visible = true;
        }

        private void btnOcultarContraseña_Click(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = true;
            btnMostrarContraseña.Visible = true;
            btnOcultarContraseña.Visible = false;
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            Ingreso(txtUsuario.Text, txtContraseña.Text);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lbOlvidoContraseña_Click(object sender, EventArgs e)
        {
            new frmRecuperarContraseña().ShowDialog();
        }
        private void Ingreso(string usu, string contra)
        {
            csConexionSQL conexion = new csConexionSQL();
            if (conexion.VerificarLogin(usu, contra))
            {
                string cedulaUsuario = conexion.Cedula;
                string rol = conexion.ObtenerRolUsuario(cedulaUsuario);

                frmPantallaPrincipal frm = new frmPantallaPrincipal();

                if (rol == "Bibliotecario")
                {
                    frm.btnAdministracion.Visible = false;
                    frm.btnAdministracion.Enabled = false;
                }

                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas");
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) txtContraseña.Focus();
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) Ingreso(txtUsuario.Text, txtContraseña.Text);
        }
    }
}
