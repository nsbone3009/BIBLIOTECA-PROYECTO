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
    public partial class frmListaLectores : Form
    {
        public bool validacion = false;
        public frmListaLectores()
        {
            InitializeComponent();
        }
        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {
            frmAgregarODetallesLectores frm = new frmAgregarODetallesLectores();
            this.AddOwnedForm(frm);
            frm.btnEditarCampos.Visible = false;
            frm.ShowDialog();
        }
        private void frmListaLectores_Load(object sender, EventArgs e)
        {
            MostrarLectores();
        }
        public void MostrarLectores()
        {
            string consulta = "Select nombres_ltr, apellidos_ltr, fecha_nacimiento_ltr, correo_ltr, direccion_domicilio_ltr, sancion_ltr from Lectores";
            dgvLectores = new csAjustarDataGridView().Ajustar(dgvLectores, consulta);
        }
        private void dgvLectores_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                validacion = true;
                frmAgregarODetallesLectores frm = new frmAgregarODetallesLectores();
                this.AddOwnedForm(frm);
                frm.txtNombres.Text = dgvLectores.Rows[e.RowIndex].Cells[0].Value.ToString();
                frm.txtApellidos.Text = dgvLectores.Rows[e.RowIndex].Cells[1].Value.ToString();
                frm.txtFechaN.Text = dgvLectores.Rows[e.RowIndex].Cells[2].Value.ToString();
                frm.txtCorreoElectronico.Text = dgvLectores.Rows[e.RowIndex].Cells[3].Value.ToString();
                frm.txtDomicilio.Text = dgvLectores.Rows[e.RowIndex].Cells[4].Value.ToString();
                frm.txtSancion.Text = dgvLectores.Rows[e.RowIndex].Cells[5].Value.ToString();
                frm.txtNombres.Enabled = false;
                frm.txtApellidos.Enabled = false;
                frm.txtFechaN.Enabled = false;
                frm.txtCorreoElectronico.Enabled = false;
                frm.txtSancion.Enabled = false;
                frm.txtDomicilio.Enabled = false;
                frm.lbTituloVentana.Text = "Detalles del Lector";
                frm.txtCedula.Visible = false;
                frm.lbcedula.Visible = false;
                frm.btnGuardarCampos.Enabled = false;
                frm.cedula = new csConexionSQL().Extraer("Select cedula_ltr from Lectores where nombres_ltr = '"+ dgvLectores.Rows[e.RowIndex].Cells[0].Value.ToString() + "' and " +
                    "apellidos_ltr = '"+ dgvLectores.Rows[e.RowIndex].Cells[1].Value.ToString() + "'","cedula_ltr");
                frm.ShowDialog();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Length > 3)
            {
                string consulta = "Select nombres_ltr, apellidos_ltr, fecha_nacimiento_ltr, correo_ltr, direccion_domicilio_ltr, sancion_ltr " +
                    "from Lectores where nombres_ltr like '%"+txtBuscar.Text+ "%' or apellidos_ltr like '%" + txtBuscar.Text + "%' or correo_ltr like '%" + txtBuscar.Text + "%' ";
                dgvLectores.Rows.Clear();
                dgvLectores = new csAjustarDataGridView().Ajustar(dgvLectores, consulta);
            }
            if (txtBuscar.Text.Length == 0)
            {
                dgvLectores.Rows.Clear();
                MostrarLectores();
            }
        }
    }
}
