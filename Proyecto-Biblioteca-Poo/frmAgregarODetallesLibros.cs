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
    public partial class frmAgregarODetallesLibros : Form
    {
        public string ISBN = "";

        public frmAgregarODetallesLibros()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditarCampos_Click(object sender, EventArgs e)
        {
            txtTitulo.Enabled = true;
            txtAutor.Enabled = true;
            txtEditorial.Enabled = true;
            txtCategoria.Enabled = true;
            txtPublicacion.Enabled = true;
            txtCantidad.Enabled = true;
            txtResume.Enabled = true;
            btnGuardarCampos.Enabled = true;
        }

        private void btnGuardarCampos_Click(object sender, EventArgs e)
        {

            frmListaLibros frm = Owner as frmListaLibros;
            if (frm.validacion)
            {
                string consulta = "Update Libros set titulo_lb = '" + txtTitulo.Text + "', autor_es_lb = '" + txtAutor.Text + "'," +
                " editorial_lb = '" + txtEditorial.Text + "',genero_lb = '" + txtCategoria.Text + "', año_publicacion_lb = '" + txtPublicacion.Text + "'," +
                " cantidad_lb = '" + txtCantidad.Text + "', sinopsis_lb = '" + txtResume.Text + "' where isbn_lb = '" + ISBN + "'";
                new csConexionSQL().Update(consulta);
                frm.validacion = false;
            }
            else
            {
                string consulta = "Insert into Libros(isbn_lb, titulo_lb, autor_es_lb, editorial_lb, genero_lb, año_publicacion_lb, cantidad_lb, sinopsis_lb)" +
                    "Values('"+txtIsbn.Text+"','"+txtTitulo.Text+"', '"+txtAutor.Text+"', '"+txtEditorial.Text+"', '"+txtCategoria.Text+"', '"+txtPublicacion.Text+"', '"+txtCantidad.Text+"', '"+txtResume.Text+"')";
                new csConexionSQL().Insert(consulta);
            }
            frm.dgvLibros.Rows.Clear();
            frm.MostrarLibros();
            frm.validacion = false;
            this.Close();
        }
    }
}
