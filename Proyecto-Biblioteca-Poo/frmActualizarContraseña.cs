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
    public partial class frmActualizarContraseña : Form
    {
        public frmActualizarContraseña()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmActualizarContraseña_Load(object sender, EventArgs e)
        {
            btnOcultarContraseña.Visible = false;
            bntocultaNueva.Visible = false;
        }
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            csLogin ingreso = new csLogin();
            if (txtNuevaClave.Text == txtConfirmarCLave.Text)
            {
                ingreso.ActualizarContraseña(txtCorreo.Text, txtNuevaClave.Text);
                this.Hide();
            }
            else
            {
                MessageBox.Show("La Claves no son iguales");
            }
        }

        private void bntnuevacontra_Click(object sender, EventArgs e)
        {
            txtConfirmarCLave.UseSystemPasswordChar = true;
            btnMostrarContraseña.Visible = true;
            btnOcultarContraseña.Visible = false;
           
        }

        private void bntocultaNueva_Click(object sender, EventArgs e)
        {
            txtConfirmarCLave.UseSystemPasswordChar = false;
            btnMostrarContraseña.Visible = false;
            btnOcultarContraseña.Visible = true;
           
        }

        private void btnMostrarContraseña_Click(object sender, EventArgs e)
        {

            txtNuevaClave.UseSystemPasswordChar = true;
            btnMostrarContraseña.Visible = true;
            btnOcultarContraseña.Visible = false;
        }

        private void btnOcultarContraseña_Click(object sender, EventArgs e)
        {
            txtNuevaClave.UseSystemPasswordChar = false;
            btnMostrarContraseña.Visible = false;
            btnOcultarContraseña.Visible = true;
        }

        private void frmActualizarContraseña_Load_1(object sender, EventArgs e)
        {
            btnOcultarContraseña.Visible = false;
            bntocultaNueva.Visible = false;
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
                MessageBox.Show("No se permiten espacios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtNuevaClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
                MessageBox.Show("No se permiten espacios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtConfirmarCLave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
                MessageBox.Show("No se permiten espacios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
