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
        static int idPrestamo; static string cedulaLector; static string isbnLibro;
        static string fechaPrestamo; static string fechaDevolucion;

        public frmListaPrestamosLibros()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void btnAgregarPrestamo_Click(object sender, EventArgs e)
        {
            frmAgregarODetallesPrestamosLibros formulario = new frmAgregarODetallesPrestamosLibros();
            formulario.GuardarOModificar = true;
            formulario.ShowDialog();
            CargarDatos();
        }

        private void frmListaPrestamosLibros_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        public void CargarDatos()
        {
            string consulta = "Select * from Prestamos";
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
                MessageBox.Show("Por favor, seleccione una fila primero.");
            }
            CargarDatos();
        }
        private void btnEliminarPrestamo_Click(object sender, EventArgs e)
        {
        }
    }
}
