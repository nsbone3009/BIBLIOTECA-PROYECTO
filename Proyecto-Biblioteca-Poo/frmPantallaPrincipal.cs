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
    public partial class frmPantallaPrincipal : Form
    {
        static frmPantallaPrincipal instancia = null;
        public static frmPantallaPrincipal Validacion()
        {
            if (instancia == null)
                instancia = new frmPantallaPrincipal();
            return instancia;
        }

        static csEnvioDeAvisosDev avisos = new csEnvioDeAvisosDev();
        static bool clickLibros = false, clickLectores = false, clickAdministracion = false;
        private Timer timer;

        public frmPantallaPrincipal()
        {
            InitializeComponent();
            Confi();
        }
        private void Confi()
        {
            timer = new Timer();
            timer.Interval = 60000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            avisos.Comparar();
        }
        private void Menu_Load(object sender, EventArgs e)
        {
            lbListaLibros.Visible = false;
            lbPrestamosLibros.Visible = false;
            lbDevolucionesLibros.Visible = false;
            lbListaLectores.Visible = false;
            lbConfiguracion.Visible = false;
            lbUsuarios.Visible = false;
            MostrarLogoNombre();
            frmListaLibros frm = frmListaLibros.Validacion();
            LlamarFormulario(frm);
        }
        public void MostrarLogoNombre()
        {
            csConexionSQL conexion = new csConexionSQL();
            string consulta = "Select * from Logo where id_imagen = 1";
            SqlDataReader leer = conexion.SelectLeer(consulta);
            if (leer.Read())
            {
                try
                {
                    lbNombreEmpresa.Text = leer["nombre_lg"].ToString();
                    MemoryStream ImgMemoria = new MemoryStream((byte[])leer["imagen_lg"]);
                    Bitmap bitmap = new Bitmap(ImgMemoria);
                    ptboxLogo.BackgroundImage = bitmap;
                }
                catch { }
            }
        }
        private void btnLibros_Click(object sender, EventArgs e)
        {
            if (clickLectores) { btnLectores.PerformClick(); }
            if (clickAdministracion) { btnAdministracion.PerformClick(); }
            if (!clickLibros)
            {
                btnLectores.Location = new Point(0, 330);
                btnAdministracion.Location = new Point(0, 380);

                lbListaLibros.Visible = true;
                lbListaLibros.Location = new Point(0, 245); //+2

                lbPrestamosLibros.Visible = true;
                lbPrestamosLibros.Location = new Point(0, 272); //+27

                lbDevolucionesLibros.Visible = true;
                lbDevolucionesLibros.Location = new Point(0, 299); //+27

                clickLibros = true;
            }
            else
            {
                btnLectores.Location = new Point(0, 243);
                btnAdministracion.Location = new Point(0, 289);
                lbPrestamosLibros.Visible = false;
                lbDevolucionesLibros.Visible = false;
                lbListaLibros.Visible = false;
                clickLibros = false;
            }
        }
        private void btnLectores_Click(object sender, EventArgs e)
        {
            if (clickLibros) { btnLibros.PerformClick(); }
            if (clickAdministracion) { btnAdministracion.PerformClick(); }
            if (!clickLectores)
            {
                btnAdministracion.Location = new Point(0, 322);
                lbListaLectores.Visible = true;
                lbListaLectores.Location = new Point(0, 290);
                clickLectores = true;
            }
            else
            {
                btnAdministracion.Location = new Point(0, 289);
                lbListaLectores.Visible = false;
                clickLectores = false;
            }
        }
        private void btnAdministracion_Click(object sender, EventArgs e)
        {
            if (clickLibros) { btnLibros.PerformClick(); }
            if(clickLectores){ btnLectores.PerformClick();}
            if(!clickAdministracion)
            {
                lbConfiguracion.Visible = true;
                lbConfiguracion.Location = new Point(0, 338);
                lbUsuarios.Visible = true;
                lbUsuarios.Location = new Point(0, 365);
                clickAdministracion = true;
            }
            else
            {
                lbConfiguracion.Visible = false;
                lbUsuarios.Visible = false;
                clickAdministracion = false;
            }
        }
        private void lbListaLibros_Click(object sender, EventArgs e)
        {
            frmListaLibros frm = frmListaLibros.Validacion();
            frm.MostrarLibros();
            LlamarFormulario(frm);
        }
        private void lbPrestamosLibros_Click(object sender, EventArgs e)
        {
            frmListaPrestamosLibros frm = frmListaPrestamosLibros.Validacion();
            LlamarFormulario(frm);
        }
        private void lbDevolucionesLibros_Click(object sender, EventArgs e)
        {
            frmListaDevolucionesLibros frm = frmListaDevolucionesLibros.Validacion();
            frm.MostrarDevolucines();
            LlamarFormulario(frm);
        }
        private void lbListaLectores_Click(object sender, EventArgs e)
        {
            frmListaLectores frm = frmListaLectores.Validacion();
            LlamarFormulario(frm);
        }
        private void LlamarFormulario(Form formulario)
        {
            plPantalla.Controls.Clear();
            formulario.TopLevel = false;
            plPantalla.Controls.Add(formulario);
            formulario.Show();
        } //Revise un formulario, limpia el panel, agrega y muestra
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            frmValidacionEntrada frm = frmValidacionEntrada.Validacion();
            frm.Show();
            this.Hide();
        }
        private void lbConfiguracion_Click(object sender, EventArgs e)
        {
            frmConfiguracionSistema frm = frmConfiguracionSistema.Validacion();
            frm.Mostrar();
            LlamarFormulario(frm);
        } 
    }
}
