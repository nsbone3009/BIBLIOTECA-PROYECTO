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
            string consulta = "Select * from Devoluciones";
            csConexionSQL database = new csConexionSQL();
            dgvDevoluciones.DataSource = database.MostrarRegistros(consulta);
            new csAjustarDataGridView().Ajustar(dgvDevoluciones);
        }
    }
}
