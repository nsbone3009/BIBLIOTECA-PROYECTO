using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Biblioteca_Poo
{
    public partial class frmAgregarODetallesLectores : Form
    {
        public string cedula = "";
        public frmAgregarODetallesLectores()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarCampos_Click(object sender, EventArgs e)
        {
            frmListaLectores frm = Owner as frmListaLectores;
            if (frm.validacion)
            {
                string consulta = "Update Lectores set nombres_ltr = '" + txtNombres.Text + "',apellidos_ltr = '" + txtApellidos.Text + "', " +
                "fecha_nacimiento_ltr =  '" + txtFechaN.Text + "', direccion_domicilio_ltr = '" + txtDomicilio.Text + "'," +
                "correo_ltr ='" + txtCorreoElectronico.Text + "', sancion_ltr ='" + txtSancion.Text + "' where cedula_ltr = '" + cedula + "'";
                new csConexionSQL().Update(consulta);
                frm.validacion = false;
            }
            else
            {
                string consulta = "Insert into Lectores(cedula_ltr, nombres_ltr, apellidos_ltr, fecha_nacimiento_ltr, direccion_domicilio_ltr, correo_ltr, sancion_ltr)" +
                    "values('"+txtCedula.Text+"', '" + txtNombres.Text + "', '" + txtApellidos.Text + "', '" + txtFechaN.Text + "', '" + txtDomicilio.Text + "', '" + txtCorreoElectronico.Text + "', '" + txtSancion.Text + "')";
                new csConexionSQL().Insert(consulta);
            }
            frm.dgvLectores.Rows.Clear();
            frm.MostrarLectores();
            this.Close();
        }
        private void btnEditarCampos_Click(object sender, EventArgs e)
        {
            txtNombres.Enabled = true;
            txtApellidos.Enabled = true;
            txtFechaN.Enabled = true;
            txtCorreoElectronico.Enabled = true;
            txtSancion.Enabled = true;
            txtDomicilio.Enabled = true;
            btnGuardarCampos.Enabled = true;
        }
    }
}
