using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Biblioteca_Poo
{
    public partial class frmListaPrestamosLibros : Form
    {
        //static int idPrestamo; static string cedulaLector; static string isbnLibro;
        //static string fechaPrestamo; static string fechaDevolucion;
        public frmListaPrestamosLibros()
        {
            InitializeComponent();
            CargarDatos();
        }
        public bool BtnAgregarPrestamoVisible
        {
            get { return btnAgregarPrestamo.Visible; }
            set { btnAgregarPrestamo.Visible = value; }
        }
        public DataGridView DgvPrestamo
        {
            get { return dgvPrestamos; }
            set { dgvPrestamos = value; }
        }
        public bool BtnModificarPrestamoVisible
        {
            get { return btnModificarPrestamo.Visible; }
            set { btnModificarPrestamo.Visible = value; }
        }

        private void btnAgregarPrestamo_Click(object sender, EventArgs e)
        {
            frmAgregarODetallesPrestamosLibros formulario = new frmAgregarODetallesPrestamosLibros();
            formulario.LabelText = "AGREGAR PRESTAMO";
            formulario.GuardarOModificar = true;
            formulario.ShowDialog();
            CargarDatos();
        }

        private void frmListaPrestamosLibros_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        private void CargarDatos()
        {
            string consulta = @"
        SELECT 
            id_ptm AS [ID Prestamo], 
            cedula_ltr AS [Cédula Lector], 
            isbn_lb AS [ISBN Libro], 
            fecha_prestamo AS [Fecha Préstamo], 
            fecha_devolucio_programada AS [Fecha Devolución Programada] 
        FROM Prestamos 
        WHERE estado_ = 1";
            csConexionSQL database = new csConexionSQL();
            dgvPrestamos.DataSource = database.MostrarRegistros(consulta);
            //new csAjustarDataGridView().Ajustar(dgvPrestamos);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
        }
        private void btnModificarPrestamo_Click(object sender, EventArgs e)
        {
           
            if (dgvPrestamos.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvPrestamos.SelectedRows[0];
                int idPrestamo = int.Parse(selectedRow.Cells[0].Value.ToString());
                new frmAgregarODetallesPrestamosLibros(idPrestamo).ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila primero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            CargarDatos();
        }

        private void dgvPrestamos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string consulta = dgvPrestamos.CurrentRow.Cells[2].Value.ToString();
            string NuevaConsulta = "select L.titulo_lb,L.isbn_lb,Le.nombres_ltr,Le.cedula_ltr,D.fecha_prestamo,D.fecha_devolucion_programada from Devoluciones as D inner join[Libros] as L on D.isbn_lb=[L].isbn_lb inner join Lectores as Le  on d.cedula_ltr=[Le].cedula_ltr where D.isbn_lb='" + consulta + "'";
            csConexionSQL conector = new csConexionSQL();
            SqlDataReader lector = conector.SelectLeer(NuevaConsulta);
            if (lector.Read())
            {
                frmAgregarODetallesDevolucionesLibros datitos = new frmAgregarODetallesDevolucionesLibros();
                datitos.txtTitulo.Text = lector["titulo_lb"].ToString().Trim();
                datitos.txtLector.Text = lector["nombres_ltr"].ToString();
                datitos.txtCedula.Text = lector["cedula_ltr"].ToString().Trim();
                datitos.txtISBN.Text = lector["isbn_lb"].ToString().Trim();
                datitos.txtFechaPrestamo.Text = lector["fecha_prestamo"].ToString().Trim();
                datitos.txtFechaDevolucion.Text = lector["fecha_devolucion_programada"].ToString().Trim();
                datitos.txtFechaActual.Text = DateTime.Now.ToString("yyyy-MM-dd");
                datitos.ShowDialog();
                this.Close();
            }
        }
    }
}
