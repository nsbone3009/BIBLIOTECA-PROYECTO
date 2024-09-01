using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_Biblioteca_Poo
{
    public partial class frmAgregarODetallesPrestamosLibros : Form
    {
        private int IDPrestamo;
        private string cedulaLector;
        private string nombreLector;
        private string isbnLibro;
        private string tituloLibro;
        private string fechaPrestamo;
        private string fechaDevolucionProgramada;
        public string correo;
        public bool GuardarOModificar = false;
        static Random random = new Random(DateTime.Now.Millisecond);
        csPrestamos prestamos;
        static int numeroAleatorio = random.Next(10000000, 100000000);
        public string LabelText
        {
            get { return lbTituloVentana.Text; }
            set { lbTituloVentana.Text = value; }
        }
        public frmAgregarODetallesPrestamosLibros(string Cedula, string Nombre)
        {
            InitializeComponent();
            txtCedula.Text = Cedula;
            txtNombreLector.Text = Nombre;
        }
        public frmAgregarODetallesPrestamosLibros(int idPrestamo)
        {
            InitializeComponent();
            // En base a la id llamo un datatable de la bd mediante una consulta y la filtro
            //para extraer los datos necesarios.
            prestamos = new csPrestamos();
            // Llamar al método ObtenerDatosPrestamo
            DataTable dataTable = prestamos.ObtenerDatosPrestamo(idPrestamo);

            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];
                IDPrestamo = Convert.ToInt32(row["id_ptm"]);
                cedulaLector = row["cedula_ltr"].ToString();
                nombreLector = row["nombres_ltr"].ToString();
                isbnLibro = row["isbn_lb"].ToString();
                tituloLibro = row["titulo_lb"].ToString();
                fechaPrestamo = row["fecha_prestamo"].ToString();
                fechaDevolucionProgramada = row["fecha_devolucio_programada"].ToString();

                txtCedula.Text = cedulaLector;
                txtNombreLector.Text = nombreLector;
                txtISBN.Text = isbnLibro;
                txtTituloLibro.Text = tituloLibro;
                txtFechaPrestamo.Text = fechaPrestamo;
                txtFechaDevolucion.Text = fechaDevolucionProgramada;
            }
            else
            {
                MessageBox.Show("No se encontraron registros para el ID de préstamo especificado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        public frmAgregarODetallesPrestamosLibros(string cedula, string isbn, string fechaPrestamo, string fechaDevolucion, int idPrestamo)
        {
            InitializeComponent();
            txtCedula.Text = cedula;
            txtISBN.Text = isbn;
            txtFechaPrestamo.Text = fechaPrestamo;
            txtFechaDevolucion.Text = fechaDevolucion;
        }
        public frmAgregarODetallesPrestamosLibros()
        {
            InitializeComponent();
        }
        private void DetallesOAgregarPrestamos_Load(object sender, EventArgs e)
        {
            txtFechaPrestamo.Text = DateTime.Today.ToString("dd-MM-yyyy");
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSeleccionarLector_Click(object sender, EventArgs e)
        {
            frmListaLectores frmLectores = new frmListaLectores();
            frmLectores.btnAgregarLector.Visible = false;
            frmLectores.Owner = this;
            frmLectores.bandera = true;
            frmLectores.ShowDialog();
        }
        private void btnSeleccionarLibro_Click(object sender, EventArgs e)
        {
            frmListaLibros frmLibros = new frmListaLibros();
            frmLibros.btnAgregarLibro.Visible = false;
            frmLibros.Owner = this;
            frmLibros.bandera = true;
            frmLibros.ShowDialog();
        }
        private void btnCalendario_Click(object sender, EventArgs e)
        {
            calDevolucion.Visible = !calDevolucion.Visible;
        }
        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime fechaSeleccionada = calDevolucion.SelectionStart;
            txtFechaDevolucion.Text = fechaSeleccionada.ToString("dd-MM-yyyy");
            calDevolucion.Visible = false;
        }
        private void btnRegistrarPrestamo_Click(object sender, EventArgs e)
        {
            try
            {
                csPrestamos ManejoPrestamo;
                if (GuardarOModificar)
                {
                    int id_ptm = numeroAleatorio;
                    int cedula_ltr = int.Parse(txtCedula.Text);
                    string isbn_lb = txtISBN.Text;
                    string FechaP = txtFechaPrestamo.Text;
                    string FechaD = txtFechaDevolucion.Text;

                    if (DateTime.Parse(FechaP) < DateTime.Parse(FechaD))
                    {
                        try
                        {
                            // Crear una instancia del servicio de préstamos
                            ManejoPrestamo = new csPrestamos();
                            // Registrar el préstamo
                            bool exito = ManejoPrestamo.RegistrarPrestamo(id_ptm, cedula_ltr, isbn_lb, FechaP, FechaD);
                            string cuerpoC = $"Estimado(a) lector(a) {txtNombreLector.Text.Trim()}:\n\n" +
                 $"Esperamos que estés disfrutando de la lectura de {txtTituloLibro.Text.Trim()}. Te recordamos que este libro fue prestado de nuestra biblioteca y que la fecha de devolución es el {txtFechaDevolucion.Text.Trim()}. Por favor, asegúrate de devolverlo a tiempo para que otros usuarios también puedan acceder a él.\n\n" +
                 "Si necesitas más tiempo para finalizar tu lectura, no dudes en ponerte en contacto con nosotros para solicitar una extensión del préstamo.\n\n" +
                 "Gracias por utilizar nuestros servicios y ayudarnos a mantener los recursos disponibles para todos. ¡Que disfrutes el resto de tu lectura!";
                            ;
                            if (exito)
                            {
                                MessageBox.Show("Préstamo registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtCedula.Text = txtNombreLector.Text = txtISBN.Text = txtTituloLibro.Text = txtFechaDevolucion.Text = "";
                                csEmail Correo = new csEmail();
                                Correo.Receptor = correo;
                                Correo.Asunto = "HAZ REALIZADO UN PRESTAMO";
                                Correo.Cuerpo = cuerpoC;
                                MessageBox.Show(Correo.Enviar() ? "Correo enviado correctamente" : "Error al enviar el correo", "Envio de correo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al realizar prestamo: " + ex);
                        }
                    }
                    else
                    {
                        MessageBox.Show("La fecha de devolucion es menor a la de prestamo porfavor ingrese una nueva fecha de devolucion");
                        txtFechaDevolucion.Text = string.Empty;
                        txtFechaDevolucion.Focus();
                    }

                }
                else
                {
                    try
                    {
                        ManejoPrestamo = new csPrestamos();
                        int cedula_ltr = int.Parse(txtCedula.Text);
                        string isbn_lb = txtISBN.Text;
                        string FechaP = txtFechaPrestamo.Text;
                        string FechaD = txtFechaDevolucion.Text;
                        if (DateTime.Parse(FechaP) < DateTime.Parse(FechaD))
                        {
                            if (ManejoPrestamo.EditarPrestamo(IDPrestamo, cedula_ltr, isbn_lb, FechaP, FechaD))
                                MessageBox.Show("Prestamo editado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else MessageBox.Show("Ha ocurrido un error al editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("La fecha de devolucion es menor a la de prestamo porfavor ingrese una nueva fecha de devolucion");
                            txtFechaDevolucion.Text = string.Empty;
                            txtFechaDevolucion.Focus();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al editar un prestamo: " + ex);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el préstamo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
