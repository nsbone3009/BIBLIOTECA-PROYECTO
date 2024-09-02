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

        static frmListaPrestamosLibros instancia = null;
        public static frmListaPrestamosLibros Validacion()
        {
            if (instancia == null)
                instancia = new frmListaPrestamosLibros();
            return instancia;
        }
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
        private void dgvPrestamos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (bandera)
            {
                frmAgregarODetallesDevolucionesLibros datitos = Owner as frmAgregarODetallesDevolucionesLibros;
                string consulta = dgvPrestamos.Rows[e.RowIndex].Cells[2].Value.ToString();
                string NuevaConsulta = "select L.titulo_lb,L.isbn_lb,Le.nombres_ltr,Le.cedula_ltr,D.fecha_prestamo,D.fecha_devolucion_programada from Devoluciones as D inner join[Libros] as L on D.isbn_lb=[L].isbn_lb inner join Lectores as Le  on d.cedula_ltr=[Le].cedula_ltr where D.isbn_lb='" + consulta + "'";
                csConexionSQL conector = new csConexionSQL();
                SqlDataReader lector = conector.SelectLeer(NuevaConsulta);
                if (lector.Read())
                {
                    datitos.txtTitulo.Text = lector["titulo_lb"].ToString().Trim();
                    datitos.txtLector.Text = lector["nombres_ltr"].ToString();
                    datitos.txtCedula.Text = lector["cedula_ltr"].ToString().Trim();
                    datitos.txtISBN.Text = lector["isbn_lb"].ToString().Trim();
                    datitos.txtFechaPrestamo.Text = lector["fecha_prestamo"].ToString().Trim();
                    datitos.txtFechaDevolucion.Text = lector["fecha_devolucion_programada"].ToString().Trim();
                    datitos.txtFechaActual.Text = DateTime.Now.ToString("yyyy-MM-dd"); 
                }
            }
            this.Close();
        }
        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            //if (txtBuscar.Text.Length > 3)
            //{
            //    string consulta = "Select titulo_lb, autor_es_lb, editorial_lb, genero_lb, año_publicacion_lb, cantidad_lb, sinopsis_lb " +
            //        "from Libros where titulo_lb like '%" + txtBuscar.Text + "%' or autor_es_lb like '%" + txtBuscar.Text + "%' or editorial_lb like '%" + txtBuscar.Text + "%' " +
            //        "or genero_lb like '%" + txtBuscar.Text + "%'";
            //    dgvPrestamos.Rows.Clear();
            //    dgvPrestamos = new csAjustarDataGridView().Ajustar(dgvPrestamos, consulta);
            //}
            //if (txtBuscar.Text.Length == 0)
            //{
            //    dgvPrestamos.Rows.Clear();
            //    CargarDatos();
            //}
        }
    }
}
