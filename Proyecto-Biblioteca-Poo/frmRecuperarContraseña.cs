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
    public partial class frmRecuperarContraseña : Form
    {
        static long codigo = 0;
        static string correo = "";

        public frmRecuperarContraseña()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnVerificar.Visible = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            codigo = new Random().Next(10000000, 99999999);
            csEmail mensaje = new csEmail();
            mensaje.Receptor = txtCorreo.Text;
            mensaje.Asunto = "RECUPERACION DE CONTRASEÑA";
            mensaje.Cuerpo = "El codigo de verificacion es: " + codigo + ".\nNo compartas este codigo con nadie, si no eres tu revisa tu cuenta rapidamente.";
            if (mensaje.Enviar())
            { MessageBox.Show("CODIGO ENVIADO CORRECTAMENTE, REVISA TU BANDEJA DE ENTRADA, SI NO APARECE REVISA EN LA PARTE SPAM."); btnEnviar.Visible = false; btnVerificar.Visible = true; txtCodigo.Enabled = true; correo = txtCorreo.Text; }
            else { MessageBox.Show("ERROR, REVISA QUE SEA UN CORREO VALIDO."); }
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (long.Parse(txtCodigo.Text) == codigo) 
            {

                frmActualizarContraseña frm = new frmActualizarContraseña();
                frm.txtCorreo.Text = correo;
                frm.ShowDialog();
                this.Close(); 
            }
            else { MessageBox.Show("ERROR, CODIGO INCORRECTO, VERIFIQUE."); }
        }
    }
}
