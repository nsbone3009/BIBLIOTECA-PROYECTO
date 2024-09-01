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
        static frmAgregarODetallesLibros frmmmmm = new frmAgregarODetallesLibros();
        public frmListaLibros()
        {
            InitializeComponent();
        }
        public bool BtnAgregarLibroVisible
        {
            get { return btnAgregarLibro.Visible; }
            set { btnAgregarLibro.Visible = value; }
        }
        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {
            new frmAgregarODetallesLibros().ShowDialog();
        }

        private void frmListaLibros_Load(object sender, EventArgs e)
        {
            string consulta = "Select titulo_lb, autor_es_lb, editorial_lb, genero_lb, año_publicacion_lb, cantidad_lb, sinopsis_lb from Libros";
            dgvLibros = new csLLenarDataGridView().Mostrar(dgvLibros, consulta);
        }
        private void dgvLibros_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.AddOwnedForm(frmmmmm);
            //frmmmmm.btnCerrar.Visible = false;
            frmmmmm.lbTituloVentana.Text = "DETALLES DEL LIBRO";
            //frmmmmm.txtISBN.Text = dgvLibros.Rows[e.RowIndex].Cells[0].Value.ToString(); ;
            frmmmmm.txtTitulo.Text = dgvLibros.Rows[e.RowIndex].Cells[1].Value.ToString();
            frmmmmm.txtAutor.Text = dgvLibros.Rows[e.RowIndex].Cells[2].Value.ToString();
            //frmmmmm.txtEditorial.Text = dgvLibros.Rows[e.RowIndex].Cells[3].Value.ToString();
            //frmmmmm.txtGenero.Text = dgvLibros.Rows[e.RowIndex].Cells[4].Value.ToString();
            //frmmmmm.txtAñoPublicacion.Text = dgvLibros.Rows[e.RowIndex].Cells[5].Value.ToString();
            //frmmmmm.txtStock.Text = dgvLibros.Rows[e.RowIndex].Cells[6].Value.ToString();
            //frmmmmm.txtResume.Text = dgvLibros.Rows[e.RowIndex].Cells[7].Value.ToString();
            frmmmmm.ShowDialog();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if(txtBuscar.Text.Length > 3)
            {
                string consulta = "Select titulo_lb, autor_es_lb, editorial_lb, genero_lb, año_publicacion_lb, cantidad_lb, sinopsis_lb from " +
                "Libros where titulo_lb like '%" + txtBuscar.Text + "%' or autor_es_lb like '%"+txtBuscar.Text+"%' or editorial_lb like '%"+txtBuscar.Text+"%' or genero_lb like '%"+txtBuscar.Text+"%' ";
                dgvLibros.Rows.Clear();
                dgvLibros = new csLLenarDataGridView().Mostrar(dgvLibros, consulta);
            }   
            if(txtBuscar.Text.Length == 0)
            {
                dgvLibros.Rows.Clear();
                string consulta = "Select titulo_lb, autor_es_lb, editorial_lb, genero_lb, año_publicacion_lb, cantidad_lb, sinopsis_lb from Libros";
                dgvLibros = new csLLenarDataGridView().Mostrar(dgvLibros, consulta);
            }
        }
    }
}
