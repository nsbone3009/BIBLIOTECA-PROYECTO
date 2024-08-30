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
    public partial class frmListaLibros : Form
    {
        public frmListaLibros()
        {
            InitializeComponent();
        }

        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {
            new frmAgregarODetallesLibros().ShowDialog();
        }

        private void frmListaLibros_Load(object sender, EventArgs e)
        {
            string consulta = "Select * from Libros";
            csConexionSQL database = new csConexionSQL();
            dgvLibros.DataSource = database.MostrarRegistros(consulta);
            new csAjustarDataGridView().Ajustar(dgvLibros);
        }
        private void dgvLibros_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string ISBN = dgvLibros.Rows[e.RowIndex].Cells["isbn_lb"].Value.ToString();
                string Titulo = dgvLibros.Rows[e.RowIndex].Cells["titulo_lb"].Value.ToString();
                frmAgregarODetallesPrestamosLibros frmPrincipal = Owner as frmAgregarODetallesPrestamosLibros;
                if (frmPrincipal != null)
                {
                    frmPrincipal.txtISBN.Text = ISBN;
                    frmPrincipal.txtTituloLibro.Text = Titulo;
                }
                this.Close();
            }
        }
    }
}
