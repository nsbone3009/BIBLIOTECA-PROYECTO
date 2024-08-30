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
                MessageBox.Show("No se encontraron registros para el ID de préstamo especificado.");
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
            frmLectores.Owner = this;
            frmLectores.ShowDialog();
        }
        private void btnSeleccionarLibro_Click(object sender, EventArgs e)
        {
            frmListaLibros frmLibros = new frmListaLibros();
            frmLibros.Owner = this;
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
                    // Crear una instancia del servicio de préstamos
                    ManejoPrestamo = new csPrestamos();
                    // Registrar el préstamo
                    bool exito = ManejoPrestamo.RegistrarPrestamo(id_ptm, cedula_ltr, isbn_lb, FechaP, FechaD);
                    string cuerpoC = $"Hola Querido Lector: {txtNombreLector.Text.Trim()}, haz prestado el libro {txtTituloLibro.Text.Trim()}, no olvides delvolver el {txtFechaDevolucion.Text.Trim()}";
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
                else 
                {
                    ManejoPrestamo = new csPrestamos();
                    int cedula_ltr = int.Parse(txtCedula.Text);
                    string isbn_lb = txtISBN.Text;
                    string FechaP = txtFechaPrestamo.Text;
                    string FechaD = txtFechaDevolucion.Text;
                    if (ManejoPrestamo.EditarPrestamo(IDPrestamo, cedula_ltr, isbn_lb, FechaP, FechaD))
                        MessageBox.Show("Editado correctamente.");
                   
                    else MessageBox.Show("Ha ocurrido un error al editar.");
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el préstamo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
