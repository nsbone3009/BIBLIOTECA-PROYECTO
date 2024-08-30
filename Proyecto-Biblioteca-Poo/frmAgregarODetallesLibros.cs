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
            txtStock.Enabled = true;
            txtResume.Enabled = true;
            cbEstadoLibro.Enabled = true;
            btnGuardarCampos.Enabled = true;
            
        }

        private void DetallesOAgregarLibros_Load(object sender, EventArgs e)
        {
            btnGuardarCampos.Enabled = false;
            btnGuardarCampos.ForeColor = Color.White;
        }

        private void btnGuardarCampos_Click(object sender, EventArgs e)
        {

        }
    }
}
