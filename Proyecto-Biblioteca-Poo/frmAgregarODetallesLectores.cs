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
            csConexionSQL conexion = new csConexionSQL();
            string consulta = "Update Lectores set cedula_ltr =  '" + txtCedula.Text +"'," +
                "nombres_ltr = '" + txtNombres.Text+ "',apellidos_ltr = '" + txtApellidos.Text + "', " +
                "fecha_nacimiento_ltr =  '" + txtFechaN.Text + "', direccion_domicilio_ltr = '" + txtDomicilio.Text + "'," +
                "correo_ltr ='" + txtCorreoElectronico.Text + "', sancion_ltr ='" + txtSan.Text + "' ," +
                "tiempo_scn_ltr = '" + txtTiempoS.Text + "'";
            conexion.Update(consulta);
        }

        private void txtFechaN_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
