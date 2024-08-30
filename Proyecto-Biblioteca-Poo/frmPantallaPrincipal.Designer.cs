namespace Proyecto_Biblioteca_Poo
{
    partial class frmPantallaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPantallaPrincipal));
            this.plBarraLateral = new System.Windows.Forms.Panel();
            this.lbUsuarios = new System.Windows.Forms.Label();
            this.btnLectores = new System.Windows.Forms.Button();
            this.btnLibros = new System.Windows.Forms.Button();
            this.btnAdministracion = new System.Windows.Forms.Button();
            this.lbNombreEmpresa = new System.Windows.Forms.Label();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.ptboxLogo = new System.Windows.Forms.PictureBox();
            this.lbListaLectores = new System.Windows.Forms.Label();
            this.lbConfiguracion = new System.Windows.Forms.Label();
            this.lbListaLibros = new System.Windows.Forms.Label();
            this.lbDevolucionesLibros = new System.Windows.Forms.Label();
            this.lbPrestamosLibros = new System.Windows.Forms.Label();
            this.plPantalla = new System.Windows.Forms.Panel();
            this.plBarraLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptboxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // plBarraLateral
            // 
            this.plBarraLateral.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("plBarraLateral.BackgroundImage")));
            this.plBarraLateral.Controls.Add(this.lbUsuarios);
            this.plBarraLateral.Controls.Add(this.btnLectores);
            this.plBarraLateral.Controls.Add(this.btnLibros);
            this.plBarraLateral.Controls.Add(this.btnAdministracion);
            this.plBarraLateral.Controls.Add(this.lbNombreEmpresa);
            this.plBarraLateral.Controls.Add(this.btnCerrarSesion);
            this.plBarraLateral.Controls.Add(this.ptboxLogo);
            this.plBarraLateral.Controls.Add(this.lbListaLectores);
            this.plBarraLateral.Controls.Add(this.lbConfiguracion);
            this.plBarraLateral.Controls.Add(this.lbListaLibros);
            this.plBarraLateral.Controls.Add(this.lbDevolucionesLibros);
            this.plBarraLateral.Controls.Add(this.lbPrestamosLibros);
            this.plBarraLateral.Location = new System.Drawing.Point(0, 0);
            this.plBarraLateral.Name = "plBarraLateral";
            this.plBarraLateral.Size = new System.Drawing.Size(239, 640);
            this.plBarraLateral.TabIndex = 0;
            // 
            // lbUsuarios
            // 
            this.lbUsuarios.AutoSize = true;
            this.lbUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.lbUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbUsuarios.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuarios.ForeColor = System.Drawing.Color.White;
            this.lbUsuarios.Location = new System.Drawing.Point(12, 468);
            this.lbUsuarios.Name = "lbUsuarios";
            this.lbUsuarios.Size = new System.Drawing.Size(95, 22);
            this.lbUsuarios.TabIndex = 14;
            this.lbUsuarios.Text = "- Usuarios";
            // 
            // btnLectores
            // 
            this.btnLectores.BackColor = System.Drawing.Color.Transparent;
            this.btnLectores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLectores.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLectores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLectores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLectores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLectores.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLectores.ForeColor = System.Drawing.Color.White;
            this.btnLectores.Location = new System.Drawing.Point(0, 243);
            this.btnLectores.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnLectores.Name = "btnLectores";
            this.btnLectores.Size = new System.Drawing.Size(239, 40);
            this.btnLectores.TabIndex = 2;
            this.btnLectores.Text = "Lectores";
            this.btnLectores.UseVisualStyleBackColor = false;
            this.btnLectores.Click += new System.EventHandler(this.btnLectores_Click);
            // 
            // btnLibros
            // 
            this.btnLibros.BackColor = System.Drawing.Color.Transparent;
            this.btnLibros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLibros.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLibros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLibros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLibros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibros.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibros.ForeColor = System.Drawing.Color.White;
            this.btnLibros.Location = new System.Drawing.Point(0, 197);
            this.btnLibros.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnLibros.Name = "btnLibros";
            this.btnLibros.Size = new System.Drawing.Size(239, 40);
            this.btnLibros.TabIndex = 1;
            this.btnLibros.Text = "Libros";
            this.btnLibros.UseVisualStyleBackColor = false;
            this.btnLibros.Click += new System.EventHandler(this.btnLibros_Click);
            // 
            // btnAdministracion
            // 
            this.btnAdministracion.BackColor = System.Drawing.Color.Transparent;
            this.btnAdministracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdministracion.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdministracion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAdministracion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAdministracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdministracion.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministracion.ForeColor = System.Drawing.Color.White;
            this.btnAdministracion.Location = new System.Drawing.Point(0, 289);
            this.btnAdministracion.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnAdministracion.Name = "btnAdministracion";
            this.btnAdministracion.Size = new System.Drawing.Size(239, 40);
            this.btnAdministracion.TabIndex = 5;
            this.btnAdministracion.Text = "Administracion";
            this.btnAdministracion.UseVisualStyleBackColor = false;
            this.btnAdministracion.Click += new System.EventHandler(this.btnAdministracion_Click);
            // 
            // lbNombreEmpresa
            // 
            this.lbNombreEmpresa.AutoSize = true;
            this.lbNombreEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.lbNombreEmpresa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbNombreEmpresa.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreEmpresa.ForeColor = System.Drawing.Color.White;
            this.lbNombreEmpresa.Location = new System.Drawing.Point(40, 138);
            this.lbNombreEmpresa.Name = "lbNombreEmpresa";
            this.lbNombreEmpresa.Size = new System.Drawing.Size(127, 22);
            this.lbNombreEmpresa.TabIndex = 13;
            this.lbNombreEmpresa.Text = "XXXXXXXXX";
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCerrarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Location = new System.Drawing.Point(72, 555);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(80, 50);
            this.btnCerrarSesion.TabIndex = 12;
            this.btnCerrarSesion.Text = "Exit";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // ptboxLogo
            // 
            this.ptboxLogo.BackColor = System.Drawing.Color.Transparent;
            this.ptboxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptboxLogo.Location = new System.Drawing.Point(67, 23);
            this.ptboxLogo.Name = "ptboxLogo";
            this.ptboxLogo.Size = new System.Drawing.Size(100, 100);
            this.ptboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptboxLogo.TabIndex = 11;
            this.ptboxLogo.TabStop = false;
            // 
            // lbListaLectores
            // 
            this.lbListaLectores.AutoSize = true;
            this.lbListaLectores.BackColor = System.Drawing.Color.Transparent;
            this.lbListaLectores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbListaLectores.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListaLectores.ForeColor = System.Drawing.Color.White;
            this.lbListaLectores.Location = new System.Drawing.Point(12, 424);
            this.lbListaLectores.Name = "lbListaLectores";
            this.lbListaLectores.Size = new System.Drawing.Size(61, 22);
            this.lbListaLectores.TabIndex = 7;
            this.lbListaLectores.Text = "- Lista";
            this.lbListaLectores.Click += new System.EventHandler(this.lbListaLectores_Click);
            // 
            // lbConfiguracion
            // 
            this.lbConfiguracion.AutoSize = true;
            this.lbConfiguracion.BackColor = System.Drawing.Color.Transparent;
            this.lbConfiguracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbConfiguracion.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConfiguracion.ForeColor = System.Drawing.Color.White;
            this.lbConfiguracion.Location = new System.Drawing.Point(12, 446);
            this.lbConfiguracion.Name = "lbConfiguracion";
            this.lbConfiguracion.Size = new System.Drawing.Size(138, 22);
            this.lbConfiguracion.TabIndex = 6;
            this.lbConfiguracion.Text = "- Configuracion\r\n";
            this.lbConfiguracion.Click += new System.EventHandler(this.lbConfiguracion_Click);
            // 
            // lbListaLibros
            // 
            this.lbListaLibros.AutoSize = true;
            this.lbListaLibros.BackColor = System.Drawing.Color.Transparent;
            this.lbListaLibros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbListaLibros.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListaLibros.ForeColor = System.Drawing.Color.White;
            this.lbListaLibros.Location = new System.Drawing.Point(12, 358);
            this.lbListaLibros.Name = "lbListaLibros";
            this.lbListaLibros.Size = new System.Drawing.Size(61, 22);
            this.lbListaLibros.TabIndex = 4;
            this.lbListaLibros.Text = "- Lista";
            this.lbListaLibros.Click += new System.EventHandler(this.lbListaLibros_Click);
            // 
            // lbDevolucionesLibros
            // 
            this.lbDevolucionesLibros.AutoSize = true;
            this.lbDevolucionesLibros.BackColor = System.Drawing.Color.Transparent;
            this.lbDevolucionesLibros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbDevolucionesLibros.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDevolucionesLibros.ForeColor = System.Drawing.Color.White;
            this.lbDevolucionesLibros.Location = new System.Drawing.Point(12, 402);
            this.lbDevolucionesLibros.Name = "lbDevolucionesLibros";
            this.lbDevolucionesLibros.Size = new System.Drawing.Size(136, 22);
            this.lbDevolucionesLibros.TabIndex = 3;
            this.lbDevolucionesLibros.Text = "- Devoluciones";
            this.lbDevolucionesLibros.Click += new System.EventHandler(this.lbDevolucionesLibros_Click);
            // 
            // lbPrestamosLibros
            // 
            this.lbPrestamosLibros.AutoSize = true;
            this.lbPrestamosLibros.BackColor = System.Drawing.Color.Transparent;
            this.lbPrestamosLibros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbPrestamosLibros.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrestamosLibros.ForeColor = System.Drawing.Color.White;
            this.lbPrestamosLibros.Location = new System.Drawing.Point(12, 380);
            this.lbPrestamosLibros.Name = "lbPrestamosLibros";
            this.lbPrestamosLibros.Size = new System.Drawing.Size(113, 22);
            this.lbPrestamosLibros.TabIndex = 1;
            this.lbPrestamosLibros.Text = "- Prestamos";
            this.lbPrestamosLibros.Click += new System.EventHandler(this.lbPrestamosLibros_Click);
            // 
            // plPantalla
            // 
            this.plPantalla.Location = new System.Drawing.Point(239, 0);
            this.plPantalla.Name = "plPantalla";
            this.plPantalla.Size = new System.Drawing.Size(785, 640);
            this.plPantalla.TabIndex = 1;
            // 
            // frmPantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 640);
            this.Controls.Add(this.plBarraLateral);
            this.Controls.Add(this.plPantalla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPantallaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.plBarraLateral.ResumeLayout(false);
            this.plBarraLateral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptboxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plBarraLateral;
        private System.Windows.Forms.Button btnLibros;
        private System.Windows.Forms.Button btnLectores;
        private System.Windows.Forms.Label lbPrestamosLibros;
        private System.Windows.Forms.Label lbListaLibros;
        private System.Windows.Forms.Label lbDevolucionesLibros;
        private System.Windows.Forms.Button btnAdministracion;
        private System.Windows.Forms.Panel plPantalla;
        private System.Windows.Forms.Label lbConfiguracion;
        private System.Windows.Forms.Label lbListaLectores;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Label lbUsuarios;
        public System.Windows.Forms.PictureBox ptboxLogo;
        public System.Windows.Forms.Label lbNombreEmpresa;
    }
}