using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Biblioteca_Poo
{
    public partial class frmListaDevolucionesLibros : Form
    {
        static frmListaDevolucionesLibros instancia = null;
        public static frmListaDevolucionesLibros Validacion()
        {
            if (instancia == null)
                instancia = new frmListaDevolucionesLibros();
            return instancia;
        }
        public frmListaDevolucionesLibros()
        {
            InitializeComponent();
        }
        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {
            new frmAgregarODetallesDevolucionesLibros().ShowDialog();
        }
        private void frmListaDevolucionesLibros_Load(object sender, EventArgs e)
        {
            MostrarDevolucines();
        }
        public void MostrarDevolucines()
        {
            string consulta = @"SELECT id_dl AS [ID DEVOLUCION], cedula_ltr AS [CEDULA LECTOR], isbn_lb AS [ISBN LIBRO], fecha_prestamo AS [FECHA PRESTAMO], fecha_devolucion_programada AS [FECHA DEVOLUCION PROGRAMADA], fecha_devolucion AS [FECHA DEVOLUCION] FROM Devoluciones";
            csConexionSQL database = new csConexionSQL();
            dgvDevoluciones.DataSource = database.MostrarRegistros(consulta);
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            //if (txtBuscar.Text.Length > 3)
            //{
            //    string consulta = @"SELECT id_dl AS [ID DEVOLUCION], cedula_ltr AS [CEDULA LECTOR], isbn_lb AS [ISBN LIBRO], fecha_prestamo AS [FECHA PRESTAMO], fecha_devolucion_programada AS [FECHA DEVOLUCION PROGRAMADA], fecha_devolucion AS [FECHA DEVOLUCION] FROM Devoluciones";
            //    dgvDevoluciones.Rows.Clear();
            //    dgvDevoluciones = new csAjustarDataGridView().Ajustar(dgvDevoluciones, consulta);
            //}
            //if (txtBuscar.Text.Length == 0)
            //{
            //    dgvDevoluciones.Rows.Clear();
            //    MostrarDevolucines();
            //}
        }
    }
}
