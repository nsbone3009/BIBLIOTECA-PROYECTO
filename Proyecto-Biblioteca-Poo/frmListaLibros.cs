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
        public bool validacion = false;
        public frmListaLibros()
        {
            InitializeComponent();
        }

        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {
            frmAgregarODetallesLibros frm = new frmAgregarODetallesLibros();
            this.AddOwnedForm(frm);
            frm.lbTituloVentana.Text = "Agregar Nuevo Libro";
            frm.btnEditarCampos.Visible = false;
            frm.btnGuardarCampos.Enabled = true;
            frm.ShowDialog();
        }
        private void frmListaLibros_Load(object sender, EventArgs e)
        {
            MostrarLibros();
        }
        private void dgvLibros_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                validacion = true;
                frmAgregarODetallesLibros frm = new frmAgregarODetallesLibros();
                this.AddOwnedForm(frm);
                frm.lbTituloVentana.Text = "Detalles del Libro";
                frm.ISBN = new csConexionSQL().Extraer("Select isbn_lb from Libros where titulo_lb = '" + dgvLibros.Rows[e.RowIndex].Cells[0].Value.ToString().Trim() + "'", "isbn_lb");
                frm.txtTitulo.Text = dgvLibros.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                frm.txtAutor.Text = dgvLibros.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
                frm.txtEditorial.Text = dgvLibros.Rows[e.RowIndex].Cells[2].Value.ToString().Trim();
                frm.txtCategoria.Text = dgvLibros.Rows[e.RowIndex].Cells[3].Value.ToString().Trim();
                frm.txtPublicacion.Text = dgvLibros.Rows[e.RowIndex].Cells[4].Value.ToString().Trim();
                frm.txtCantidad.Text = dgvLibros.Rows[e.RowIndex].Cells[5].Value.ToString().Trim();
                frm.txtResume.Text = dgvLibros.Rows[e.RowIndex].Cells[6].Value.ToString().Trim();
                frm.txtTitulo.Enabled = false;
                frm.txtAutor.Enabled = false;
                frm.txtEditorial.Enabled = false;
                frm.txtCategoria.Enabled = false;
                frm.txtPublicacion.Enabled = false;
                frm.txtCantidad.Enabled = false;
                frm.txtResume.Enabled = false;
                frm.btnGuardarCampos.Enabled = false;
                frm.txtIsbn.Visible = false;
                frm.lbIsbn.Visible = false;
                frm.ShowDialog();
            }
        }
        public void MostrarLibros()
        {
            string consulta = "Select titulo_lb, autor_es_lb, editorial_lb, genero_lb, año_publicacion_lb, cantidad_lb, sinopsis_lb from Libros";
            dgvLibros = new csAjustarDataGridView().Ajustar(dgvLibros, consulta);
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if(txtBuscar.Text.Length > 3)
            {
                string consulta = "Select titulo_lb, autor_es_lb, editorial_lb, genero_lb, año_publicacion_lb, cantidad_lb, sinopsis_lb " +
                    "from Libros where titulo_lb like '%"+txtBuscar.Text+ "%' or autor_es_lb like '%"+txtBuscar.Text+ "%' or editorial_lb like '%"+txtBuscar.Text+"%' " +
                    "or genero_lb like '%"+txtBuscar.Text+"%'";
                dgvLibros.Rows.Clear();
                dgvLibros = new csAjustarDataGridView().Ajustar(dgvLibros, consulta);
            }
            if (txtBuscar.Text.Length == 0)
            {
                dgvLibros.Rows.Clear();
                MostrarLibros();
            }
        }
    }
}
