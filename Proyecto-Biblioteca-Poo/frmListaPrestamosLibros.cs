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
        csPrestamos prestamo = new csPrestamos();
        csConexionSQL database = new csConexionSQL();
        public bool bandera = false;
        public frmListaPrestamosLibros()
        {
            InitializeComponent();
            CargarDatos();
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
            string sentencia = prestamo.CargarDatos();
            dgvPrestamos.DataSource = database.MostrarRegistros(sentencia);
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
            if (bandera == true)
            {
                try
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
                catch (Exception ex)
                {
                    MessageBox.Show("Error en el dgvprestamo:" + ex);
                }
            }
        }
        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtBuscar.Text.Length > 3)
            {
                dgvPrestamos.DataSource = database.MostrarRegistros("SELECT id_ptm as [ID PRESTAMO], cedula_ltr as [CEDULA LECTOR], isbn_lb as [ISBN LIBRO], fecha_prestamo as [FECHA PRESTAMO], fecha_devolucio_programada as [FECHA DEVOLUCION] FROM Prestamos where estado_=1 and CONVERT(varchar,cedula_ltr) like '%" + txtBuscar.Text + "%'  or isbn_lb like '%" + txtBuscar.Text + "%'");
            }
            if (txtBuscar.Text.Length == 0)
                CargarDatos();
        }
    }
}
