namespace Proyecto_Biblioteca_Poo
{
    partial class frmActualizarContraseña
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActualizarContraseña));
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lbCorreo = new System.Windows.Forms.Label();
            this.txtNuevaClave = new System.Windows.Forms.TextBox();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.txtConfirmarCLave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnOcultarContraseña = new System.Windows.Forms.Button();
            this.btnMostrarContraseña = new System.Windows.Forms.Button();
            this.bntocultaNueva = new System.Windows.Forms.Button();
            this.bntnuevacontra = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCorreo
            // 
            this.txtCorreo.Enabled = false;
            this.txtCorreo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(137, 208);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(506, 35);
            this.txtCorreo.TabIndex = 10;
            this.txtCorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCorreo_KeyPress);
            // 
            // lbCorreo
            // 
            this.lbCorreo.AutoSize = true;
            this.lbCorreo.BackColor = System.Drawing.Color.Transparent;
            this.lbCorreo.Enabled = false;
            this.lbCorreo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCorreo.Location = new System.Drawing.Point(133, 183);
            this.lbCorreo.Name = "lbCorreo";
            this.lbCorreo.Size = new System.Drawing.Size(69, 22);
            this.lbCorreo.TabIndex = 9;
            this.lbCorreo.Text = "Correo";
            // 
            // txtNuevaClave
            // 
            this.txtNuevaClave.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevaClave.Location = new System.Drawing.Point(137, 299);
            this.txtNuevaClave.Name = "txtNuevaClave";
            this.txtNuevaClave.Size = new System.Drawing.Size(253, 35);
            this.txtNuevaClave.TabIndex = 13;
            this.txtNuevaClave.UseSystemPasswordChar = true;
            this.txtNuevaClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNuevaClave_KeyPress);
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.BackColor = System.Drawing.Color.Transparent;
            this.lbCodigo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigo.Location = new System.Drawing.Point(133, 274);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(165, 22);
            this.lbCodigo.TabIndex = 12;
            this.lbCodigo.Text = "Nueva Contraseña";
            // 
            // txtConfirmarCLave
            // 
            this.txtConfirmarCLave.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmarCLave.Location = new System.Drawing.Point(137, 396);
            this.txtConfirmarCLave.Name = "txtConfirmarCLave";
            this.txtConfirmarCLave.Size = new System.Drawing.Size(253, 35);
            this.txtConfirmarCLave.TabIndex = 15;
            this.txtConfirmarCLave.UseSystemPasswordChar = true;
            this.txtConfirmarCLave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConfirmarCLave_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "Confirmar Contraseña";
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEnviar.BackgroundImage")));
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.FlatAppearance.BorderSize = 0;
            this.btnEnviar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEnviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.Location = new System.Drawing.Point(486, 328);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(157, 75);
            this.btnEnviar.TabIndex = 16;
            this.btnEnviar.Text = "ACTUALIZAR";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnOcultarContraseña
            // 
            this.btnOcultarContraseña.BackColor = System.Drawing.Color.Transparent;
            this.btnOcultarContraseña.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOcultarContraseña.BackgroundImage")));
            this.btnOcultarContraseña.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOcultarContraseña.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOcultarContraseña.FlatAppearance.BorderSize = 0;
            this.btnOcultarContraseña.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnOcultarContraseña.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnOcultarContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOcultarContraseña.Location = new System.Drawing.Point(445, 396);
            this.btnOcultarContraseña.Name = "btnOcultarContraseña";
            this.btnOcultarContraseña.Size = new System.Drawing.Size(35, 35);
            this.btnOcultarContraseña.TabIndex = 18;
            this.btnOcultarContraseña.UseVisualStyleBackColor = false;
            this.btnOcultarContraseña.Click += new System.EventHandler(this.btnOcultarContraseña_Click);
            // 
            // btnMostrarContraseña
            // 
            this.btnMostrarContraseña.BackColor = System.Drawing.Color.Transparent;
            this.btnMostrarContraseña.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMostrarContraseña.BackgroundImage")));
            this.btnMostrarContraseña.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMostrarContraseña.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarContraseña.FlatAppearance.BorderSize = 0;
            this.btnMostrarContraseña.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMostrarContraseña.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMostrarContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarContraseña.Location = new System.Drawing.Point(406, 396);
            this.btnMostrarContraseña.Name = "btnMostrarContraseña";
            this.btnMostrarContraseña.Size = new System.Drawing.Size(35, 35);
            this.btnMostrarContraseña.TabIndex = 17;
            this.btnMostrarContraseña.UseVisualStyleBackColor = false;
            this.btnMostrarContraseña.Click += new System.EventHandler(this.btnMostrarContraseña_Click);
            // 
            // bntocultaNueva
            // 
            this.bntocultaNueva.BackColor = System.Drawing.Color.Transparent;
            this.bntocultaNueva.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bntocultaNueva.BackgroundImage")));
            this.bntocultaNueva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bntocultaNueva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntocultaNueva.FlatAppearance.BorderSize = 0;
            this.bntocultaNueva.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bntocultaNueva.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bntocultaNueva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntocultaNueva.Location = new System.Drawing.Point(445, 299);
            this.bntocultaNueva.Name = "bntocultaNueva";
            this.bntocultaNueva.Size = new System.Drawing.Size(35, 35);
            this.bntocultaNueva.TabIndex = 20;
            this.bntocultaNueva.UseVisualStyleBackColor = false;
            this.bntocultaNueva.Click += new System.EventHandler(this.bntocultaNueva_Click);
            // 
            // bntnuevacontra
            // 
            this.bntnuevacontra.BackColor = System.Drawing.Color.Transparent;
            this.bntnuevacontra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bntnuevacontra.BackgroundImage")));
            this.bntnuevacontra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bntnuevacontra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntnuevacontra.FlatAppearance.BorderSize = 0;
            this.bntnuevacontra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bntnuevacontra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bntnuevacontra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntnuevacontra.Location = new System.Drawing.Point(406, 299);
            this.bntnuevacontra.Name = "bntnuevacontra";
            this.bntnuevacontra.Size = new System.Drawing.Size(35, 35);
            this.bntnuevacontra.TabIndex = 19;
            this.bntnuevacontra.UseVisualStyleBackColor = false;
            this.bntnuevacontra.Click += new System.EventHandler(this.bntnuevacontra_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.Black;
            this.btnCerrar.Location = new System.Drawing.Point(736, 12);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(35, 35);
            this.btnCerrar.TabIndex = 21;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmActualizarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(780, 560);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.bntocultaNueva);
            this.Controls.Add(this.bntnuevacontra);
            this.Controls.Add(this.btnOcultarContraseña);
            this.Controls.Add(this.btnMostrarContraseña);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtConfirmarCLave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNuevaClave);
            this.Controls.Add(this.lbCodigo);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lbCorreo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmActualizarContraseña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmActualizarContraseña_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCorreo;
        private System.Windows.Forms.TextBox txtNuevaClave;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.TextBox txtConfirmarCLave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnOcultarContraseña;
        private System.Windows.Forms.Button btnMostrarContraseña;
        private System.Windows.Forms.Button bntocultaNueva;
        private System.Windows.Forms.Button bntnuevacontra;
        private System.Windows.Forms.Button btnCerrar;
        public System.Windows.Forms.TextBox txtCorreo;
    }
}