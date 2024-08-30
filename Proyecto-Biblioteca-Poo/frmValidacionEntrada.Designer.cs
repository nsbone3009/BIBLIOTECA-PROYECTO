namespace Proyecto_Biblioteca_Poo
{
    partial class frmValidacionEntrada
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmValidacionEntrada));
            this.lbIniciarSesion = new System.Windows.Forms.Label();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbContraseña = new System.Windows.Forms.Label();
            this.lbOlvidoContraseña = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.btnMostrarContraseña = new System.Windows.Forms.Button();
            this.btnOcultarContraseña = new System.Windows.Forms.Button();
            this.ptboxLogo = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.lbNombreEmpresa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptboxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbIniciarSesion
            // 
            this.lbIniciarSesion.AutoSize = true;
            this.lbIniciarSesion.BackColor = System.Drawing.Color.Transparent;
            this.lbIniciarSesion.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIniciarSesion.Location = new System.Drawing.Point(579, 156);
            this.lbIniciarSesion.Name = "lbIniciarSesion";
            this.lbIniciarSesion.Size = new System.Drawing.Size(167, 24);
            this.lbIniciarSesion.TabIndex = 0;
            this.lbIniciarSesion.Text = "INICIAR SESION";
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lbUsuario.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.Location = new System.Drawing.Point(579, 218);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(74, 22);
            this.lbUsuario.TabIndex = 1;
            this.lbUsuario.Text = "Usuario";
            // 
            // lbContraseña
            // 
            this.lbContraseña.AutoSize = true;
            this.lbContraseña.BackColor = System.Drawing.Color.Transparent;
            this.lbContraseña.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContraseña.Location = new System.Drawing.Point(579, 303);
            this.lbContraseña.Name = "lbContraseña";
            this.lbContraseña.Size = new System.Drawing.Size(107, 22);
            this.lbContraseña.TabIndex = 2;
            this.lbContraseña.Text = "Contraseña";
            // 
            // lbOlvidoContraseña
            // 
            this.lbOlvidoContraseña.AutoSize = true;
            this.lbOlvidoContraseña.BackColor = System.Drawing.Color.Transparent;
            this.lbOlvidoContraseña.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOlvidoContraseña.Location = new System.Drawing.Point(580, 385);
            this.lbOlvidoContraseña.Name = "lbOlvidoContraseña";
            this.lbOlvidoContraseña.Size = new System.Drawing.Size(179, 17);
            this.lbOlvidoContraseña.TabIndex = 3;
            this.lbOlvidoContraseña.Text = "¿Olvidaste tu contraseña?";
            this.lbOlvidoContraseña.Click += new System.EventHandler(this.lbOlvidoContraseña_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(583, 253);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(354, 35);
            this.txtUsuario.TabIndex = 4;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(583, 338);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(354, 35);
            this.txtContraseña.TabIndex = 5;
            this.txtContraseña.UseSystemPasswordChar = true;
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIniciarSesion.BackgroundImage")));
            this.btnIniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciarSesion.FlatAppearance.BorderSize = 0;
            this.btnIniciarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnIniciarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSesion.Location = new System.Drawing.Point(583, 438);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(354, 42);
            this.btnIniciarSesion.TabIndex = 6;
            this.btnIniciarSesion.Text = "INICIAR SESION";
            this.btnIniciarSesion.UseVisualStyleBackColor = true;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
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
            this.btnMostrarContraseña.Location = new System.Drawing.Point(943, 338);
            this.btnMostrarContraseña.Name = "btnMostrarContraseña";
            this.btnMostrarContraseña.Size = new System.Drawing.Size(35, 35);
            this.btnMostrarContraseña.TabIndex = 8;
            this.btnMostrarContraseña.UseVisualStyleBackColor = false;
            this.btnMostrarContraseña.Click += new System.EventHandler(this.btnMostrarContraseña_Click);
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
            this.btnOcultarContraseña.Location = new System.Drawing.Point(943, 338);
            this.btnOcultarContraseña.Name = "btnOcultarContraseña";
            this.btnOcultarContraseña.Size = new System.Drawing.Size(35, 35);
            this.btnOcultarContraseña.TabIndex = 9;
            this.btnOcultarContraseña.UseVisualStyleBackColor = false;
            this.btnOcultarContraseña.Click += new System.EventHandler(this.btnOcultarContraseña_Click);
            // 
            // ptboxLogo
            // 
            this.ptboxLogo.BackColor = System.Drawing.Color.Transparent;
            this.ptboxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptboxLogo.Location = new System.Drawing.Point(71, 106);
            this.ptboxLogo.Name = "ptboxLogo";
            this.ptboxLogo.Size = new System.Drawing.Size(391, 374);
            this.ptboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptboxLogo.TabIndex = 10;
            this.ptboxLogo.TabStop = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(965, 12);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(50, 50);
            this.btnCerrar.TabIndex = 13;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.Location = new System.Drawing.Point(902, 12);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(50, 50);
            this.btnMinimizar.TabIndex = 14;
            this.btnMinimizar.Text = "-";
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // lbNombreEmpresa
            // 
            this.lbNombreEmpresa.AutoSize = true;
            this.lbNombreEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.lbNombreEmpresa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbNombreEmpresa.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreEmpresa.ForeColor = System.Drawing.Color.White;
            this.lbNombreEmpresa.Location = new System.Drawing.Point(120, 497);
            this.lbNombreEmpresa.Name = "lbNombreEmpresa";
            this.lbNombreEmpresa.Size = new System.Drawing.Size(168, 32);
            this.lbNombreEmpresa.TabIndex = 15;
            this.lbNombreEmpresa.Text = "XXXXXXXXX";
            // 
            // frmValidacionEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1024, 640);
            this.Controls.Add(this.lbNombreEmpresa);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.ptboxLogo);
            this.Controls.Add(this.btnOcultarContraseña);
            this.Controls.Add(this.btnMostrarContraseña);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lbOlvidoContraseña);
            this.Controls.Add(this.lbContraseña);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.lbIniciarSesion);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmValidacionEntrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptboxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbIniciarSesion;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lbContraseña;
        private System.Windows.Forms.Label lbOlvidoContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.Button btnMostrarContraseña;
        private System.Windows.Forms.Button btnOcultarContraseña;
        private System.Windows.Forms.PictureBox ptboxLogo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Label lbNombreEmpresa;
    }
}

