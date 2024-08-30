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
        static frmListaLibros frmListaLibros = new frmListaLibros();
        static frmListaLectores frmListaLectores = new frmListaLectores();
        static frmListaPrestamosLibros frmListaPrestamosLibros = new frmListaPrestamosLibros();
        static frmListaDevolucionesLibros frmListaDevolucionesLibros = new frmListaDevolucionesLibros();
        static frmConfiguracionSistema frmConfiguracion = new frmConfiguracionSistema();
        static bool clickLibros = false, clickLectores = false, clickAdministracion = false;
        private Timer timer;
        static DateTime fechaAviso;
        static int estado = 0;
        static string correo = "";
        static int aviso = 0;
        public frmPantallaPrincipal()
        {
            InitializeComponent();
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
            Comparar();
        }
        private void Comparar()
        {
            DateTime fechaActual = DateTime.Now.Date;
            using (SqlConnection conexion = new SqlConnection(@"Server = NIURLETH; Database = Biblioteca; Integrated Security = True"))
            {

                conexion.Open();
                SqlCommand comando = new SqlCommand("select P.fecha_devolucio_programada,P.estado_, P.aviso_, L.correo_ltr, L.cedula_ltr, L.nombres_ltr, P.isbn_lb from Prestamos as P inner join Lectores as L on P.cedula_ltr = L.cedula_ltr where P.aviso_ = 0 and P.estado_=1", conexion);
                SqlDataReader leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    string a = leer.GetString(0).Trim();
                    fechaAviso = DateTime.Parse(a);
                    estado = leer.GetInt32(1);
                    aviso = leer.GetInt32(2);
                    correo = leer.GetString(3);
                    int ced = int.Parse((leer.GetInt32(4).ToString()).Trim());
                    string nombre = leer.GetString(5);
                    string isbn = leer.GetString(6);
                    if ((fechaAviso.AddDays(-1) == fechaActual))
                    {
                        csConexionSQL obj = new csConexionSQL();
                        obj.Update("Update Prestamos set aviso_ = 1 where cedula_ltr = '" + ced.ToString().Trim() + "' and fecha_devolucio_programada = '" + a.Trim() + "'");
                        MessageBox.Show(ced.ToString().Trim() + "-" + a.Trim());
                        EnviarCorreo(correo.Trim(), nombre.Trim(), isbn.Trim());
                    }
                }
            }
        }
        private void EnviarCorreo(string correo, string nombre, string isbn)
        {
            frmPantallaPrincipal obj = new frmPantallaPrincipal();
            csEmail email = new csEmail();
            email.Asunto = "Recordatorio de Entrega de Libro - Queda 1 dia";
            email.Cuerpo = "Estimado/a " + nombre + ": Esperamos que se encuentre bien. \nLe recordamos que el libro de código [" + isbn + "] que tiene en préstamo se encuentra próximo a su fecha de vencimiento. \nLe resta 1 día para devolver el ejemplar* a nuestra biblioteca. \nPara evitar recargos y permitir que otros usuarios disfruten del mismo, le solicitamos que realice la devolución dentro del plazo establecido. \nSi necesita extender el préstamo o tiene alguna consulta, por favor, no dude en contactarnos. Estamos aquí para ayudarle. \nAgradecemos su atención y comprensión.Atentamente la Biblioteca " + obj.lbNombreEmpresa.Text;
            email.Receptor = correo.Trim();
            email.Con_Copia = "sanchezvera243@gmail.com";
            email.Enviar();
        }
        private void Menu_Load(object sender, EventArgs e)
        {
            csConexionSQL conexion = new csConexionSQL();
            string consulta = "Select * from Logo where id_imagen = 1";
            SqlDataReader leer = conexion.SelectLeer(consulta);
            if (leer.Read())
            {
                try
                {
                    MemoryStream ImgMemoria = new MemoryStream((byte[])leer["imagen_lg"]);
                    Bitmap bitmap = new Bitmap(ImgMemoria);
                    ptboxLogo.BackgroundImage = bitmap;
                    lbNombreEmpresa.Text = leer["nombre_lg"].ToString();
                }
                catch { }
            }
            conexion.CerrarConexion();
            lbListaLibros.Visible = false;
            lbPrestamosLibros.Visible = false;
            lbDevolucionesLibros.Visible = false;
            lbListaLectores.Visible = false;
            lbConfiguracion.Visible = false;
            lbUsuarios.Visible = false;
            LlamarFormulario(frmListaLibros);
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
            LlamarFormulario(frmListaLibros);
        }

        private void lbPrestamosLibros_Click(object sender, EventArgs e)
        {
            LlamarFormulario(frmListaPrestamosLibros);
        }

        private void lbDevolucionesLibros_Click(object sender, EventArgs e)
        {
            LlamarFormulario(frmListaDevolucionesLibros);
        }

        private void lbListaLectores_Click(object sender, EventArgs e)
        {
            LlamarFormulario(frmListaLectores);
        }

        private void LlamarFormulario(Form formulario)
        {
            plPantalla.Controls.Clear();
            formulario.TopLevel = false;
            plPantalla.Controls.Add(formulario);
            formulario.Show();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            new frmValidacionEntrada().Show();
            this.Hide();
        }

        private void lbConfiguracion_Click(object sender, EventArgs e)
        {
            plPantalla.Controls.Clear();
            this.AddOwnedForm(frmConfiguracion);
            frmConfiguracion.TopLevel = false;
            plPantalla.Controls.Add(frmConfiguracion);
            frmConfiguracion.Show();
        } 
    }
}
