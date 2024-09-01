namespace Proyecto_Biblioteca_Poo
{
    partial class frmAgregarODetallesPrestamosLibros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarODetallesPrestamosLibros));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrarPrestamo = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbLibro = new System.Windows.Forms.Label();
            this.lbISBN = new System.Windows.Forms.Label();
            this.lbCedula = new System.Windows.Forms.Label();
            this.lbLector = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtTituloLibro = new System.Windows.Forms.TextBox();
            this.txtFechaPrestamo = new System.Windows.Forms.TextBox();
            this.txtFechaDevolucion = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtNombreLector = new System.Windows.Forms.TextBox();
            this.btnSeleccionarLibro = new System.Windows.Forms.Button();
            this.btnSeleccionarLector = new System.Windows.Forms.Button();
            this.btnCalendario = new System.Windows.Forms.Button();
            this.lbTituloVentana = new System.Windows.Forms.Label();
            this.lbNombreLector = new System.Windows.Forms.Label();
            this.lbDetallesLibro = new System.Windows.Forms.Label();
            this.calDevolucion = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(188, 451);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(125, 40);
            this.btnCancelar.TabIndex = 45;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnRegistrarPrestamo
            // 
            this.btnRegistrarPrestamo.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrarPrestamo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegistrarPrestamo.BackgroundImage")));
            this.btnRegistrarPrestamo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarPrestamo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRegistrarPrestamo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRegistrarPrestamo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRegistrarPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarPrestamo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarPrestamo.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarPrestamo.Location = new System.Drawing.Point(45, 451);
            this.btnRegistrarPrestamo.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnRegistrarPrestamo.Name = "btnRegistrarPrestamo";
            this.btnRegistrarPrestamo.Size = new System.Drawing.Size(125, 40);
            this.btnRegistrarPrestamo.TabIndex = 43;
            this.btnRegistrarPrestamo.Text = "Guardar";
            this.btnRegistrarPrestamo.UseVisualStyleBackColor = false;
            this.btnRegistrarPrestamo.Click += new System.EventHandler(this.btnRegistrarPrestamo_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(253, 362);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 18);
            this.label8.TabIndex = 41;
            this.label8.Text = "Fecha de Devolucion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(42, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 18);
            this.label7.TabIndex = 40;
            this.label7.Text = "Fecha de Prestamo";
            // 
            // lbLibro
            // 
            this.lbLibro.AutoSize = true;
            this.lbLibro.BackColor = System.Drawing.Color.Transparent;
            this.lbLibro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLibro.Location = new System.Drawing.Point(255, 245);
            this.lbLibro.Name = "lbLibro";
            this.lbLibro.Size = new System.Drawing.Size(44, 18);
            this.lbLibro.TabIndex = 38;
            this.lbLibro.Text = "Libro";
            // 
            // lbISBN
            // 
            this.lbISBN.AutoSize = true;
            this.lbISBN.BackColor = System.Drawing.Color.Transparent;
            this.lbISBN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbISBN.Location = new System.Drawing.Point(44, 245);
            this.lbISBN.Name = "lbISBN";
            this.lbISBN.Size = new System.Drawing.Size(44, 18);
            this.lbISBN.TabIndex = 37;
            this.lbISBN.Text = "ISBN";
            // 
            // lbCedula
            // 
            this.lbCedula.AutoSize = true;
            this.lbCedula.BackColor = System.Drawing.Color.Transparent;
            this.lbCedula.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCedula.Location = new System.Drawing.Point(44, 125);
            this.lbCedula.Name = "lbCedula";
            this.lbCedula.Size = new System.Drawing.Size(58, 18);
            this.lbCedula.TabIndex = 35;
            this.lbCedula.Text = "Cedula";
            // 
            // lbLector
            // 
            this.lbLector.AutoSize = true;
            this.lbLector.BackColor = System.Drawing.Color.Transparent;
            this.lbLector.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLector.Location = new System.Drawing.Point(43, 90);
            this.lbLector.Name = "lbLector";
            this.lbLector.Size = new System.Drawing.Size(182, 22);
            this.lbLector.TabIndex = 34;
            this.lbLector.Text = "Detalles del Lector";
            // 
            // txtISBN
            // 
            this.txtISBN.Enabled = false;
            this.txtISBN.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISBN.Location = new System.Drawing.Point(47, 266);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(205, 35);
            this.txtISBN.TabIndex = 32;
            // 
            // txtTituloLibro
            // 
            this.txtTituloLibro.Enabled = false;
            this.txtTituloLibro.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTituloLibro.Location = new System.Drawing.Point(258, 266);
            this.txtTituloLibro.Name = "txtTituloLibro";
            this.txtTituloLibro.Size = new System.Drawing.Size(396, 35);
            this.txtTituloLibro.TabIndex = 31;
            // 
            // txtFechaPrestamo
            // 
            this.txtFechaPrestamo.Enabled = false;
            this.txtFechaPrestamo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaPrestamo.Location = new System.Drawing.Point(40, 383);
            this.txtFechaPrestamo.Name = "txtFechaPrestamo";
            this.txtFechaPrestamo.Size = new System.Drawing.Size(197, 35);
            this.txtFechaPrestamo.TabIndex = 30;
            // 
            // txtFechaDevolucion
            // 
            this.txtFechaDevolucion.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaDevolucion.Location = new System.Drawing.Point(256, 383);
            this.txtFechaDevolucion.Name = "txtFechaDevolucion";
            this.txtFechaDevolucion.Size = new System.Drawing.Size(197, 35);
            this.txtFechaDevolucion.TabIndex = 29;
            // 
            // txtCedula
            // 
            this.txtCedula.Enabled = false;
            this.txtCedula.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.Location = new System.Drawing.Point(47, 146);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(205, 35);
            this.txtCedula.TabIndex = 27;
            // 
            // txtNombreLector
            // 
            this.txtNombreLector.Enabled = false;
            this.txtNombreLector.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreLector.Location = new System.Drawing.Point(258, 146);
            this.txtNombreLector.Name = "txtNombreLector";
            this.txtNombreLector.Size = new System.Drawing.Size(396, 35);
            this.txtNombreLector.TabIndex = 26;
            // 
            // btnSeleccionarLibro
            // 
            this.btnSeleccionarLibro.BackColor = System.Drawing.Color.Transparent;
            this.btnSeleccionarLibro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSeleccionarLibro.BackgroundImage")));
            this.btnSeleccionarLibro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeleccionarLibro.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSeleccionarLibro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSeleccionarLibro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSeleccionarLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarLibro.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarLibro.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionarLibro.Location = new System.Drawing.Point(657, 266);
            this.btnSeleccionarLibro.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnSeleccionarLibro.Name = "btnSeleccionarLibro";
            this.btnSeleccionarLibro.Size = new System.Drawing.Size(58, 35);
            this.btnSeleccionarLibro.TabIndex = 48;
            this.btnSeleccionarLibro.Text = "...";
            this.btnSeleccionarLibro.UseVisualStyleBackColor = false;
            this.btnSeleccionarLibro.Click += new System.EventHandler(this.btnSeleccionarLibro_Click);
            // 
            // btnSeleccionarLector
            // 
            this.btnSeleccionarLector.BackColor = System.Drawing.Color.Transparent;
            this.btnSeleccionarLector.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSeleccionarLector.BackgroundImage")));
            this.btnSeleccionarLector.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeleccionarLector.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSeleccionarLector.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSeleccionarLector.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSeleccionarLector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarLector.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarLector.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionarLector.Location = new System.Drawing.Point(657, 146);
            this.btnSeleccionarLector.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnSeleccionarLector.Name = "btnSeleccionarLector";
            this.btnSeleccionarLector.Size = new System.Drawing.Size(58, 35);
            this.btnSeleccionarLector.TabIndex = 49;
            this.btnSeleccionarLector.Text = "...";
            this.btnSeleccionarLector.UseVisualStyleBackColor = false;
            this.btnSeleccionarLector.Click += new System.EventHandler(this.btnSeleccionarLector_Click);
            // 
            // btnCalendario
            // 
            this.btnCalendario.BackColor = System.Drawing.Color.Transparent;
            this.btnCalendario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCalendario.BackgroundImage")));
            this.btnCalendario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalendario.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCalendario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCalendario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCalendario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendario.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendario.ForeColor = System.Drawing.Color.White;
            this.btnCalendario.Location = new System.Drawing.Point(456, 383);
            this.btnCalendario.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnCalendario.Name = "btnCalendario";
            this.btnCalendario.Size = new System.Drawing.Size(58, 35);
            this.btnCalendario.TabIndex = 50;
            this.btnCalendario.Text = "...";
            this.btnCalendario.UseVisualStyleBackColor = false;
            this.btnCalendario.Click += new System.EventHandler(this.btnCalendario_Click);
            // 
            // lbTituloVentana
            // 
            this.lbTituloVentana.AutoSize = true;
            this.lbTituloVentana.BackColor = System.Drawing.Color.Transparent;
            this.lbTituloVentana.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloVentana.ForeColor = System.Drawing.Color.White;
            this.lbTituloVentana.Location = new System.Drawing.Point(104, 29);
            this.lbTituloVentana.Name = "lbTituloVentana";
            this.lbTituloVentana.Size = new System.Drawing.Size(94, 24);
            this.lbTituloVentana.TabIndex = 51;
            this.lbTituloVentana.Text = "XXXXXX";
            // 
            // lbNombreLector
            // 
            this.lbNombreLector.AutoSize = true;
            this.lbNombreLector.BackColor = System.Drawing.Color.Transparent;
            this.lbNombreLector.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreLector.Location = new System.Drawing.Point(260, 125);
            this.lbNombreLector.Name = "lbNombreLector";
            this.lbNombreLector.Size = new System.Drawing.Size(134, 18);
            this.lbNombreLector.TabIndex = 52;
            this.lbNombreLector.Text = "Nombre de Lector";
            // 
            // lbDetallesLibro
            // 
            this.lbDetallesLibro.AutoSize = true;
            this.lbDetallesLibro.BackColor = System.Drawing.Color.Transparent;
            this.lbDetallesLibro.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetallesLibro.Location = new System.Drawing.Point(48, 202);
            this.lbDetallesLibro.Name = "lbDetallesLibro";
            this.lbDetallesLibro.Size = new System.Drawing.Size(171, 22);
            this.lbDetallesLibro.TabIndex = 53;
            this.lbDetallesLibro.Text = "Detalles del Libro";
            // 
            // calDevolucion
            // 
            this.calDevolucion.Location = new System.Drawing.Point(523, 313);
            this.calDevolucion.Name = "calDevolucion";
            this.calDevolucion.TabIndex = 54;
            this.calDevolucion.Visible = false;
            this.calDevolucion.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // frmAgregarODetallesPrestamosLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(780, 560);
            this.Controls.Add(this.calDevolucion);
            this.Controls.Add(this.lbDetallesLibro);
            this.Controls.Add(this.lbNombreLector);
            this.Controls.Add(this.lbTituloVentana);
            this.Controls.Add(this.btnCalendario);
            this.Controls.Add(this.btnSeleccionarLector);
            this.Controls.Add(this.btnSeleccionarLibro);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrarPrestamo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbLibro);
            this.Controls.Add(this.lbISBN);
            this.Controls.Add(this.lbCedula);
            this.Controls.Add(this.lbLector);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.txtTituloLibro);
            this.Controls.Add(this.txtFechaPrestamo);
            this.Controls.Add(this.txtFechaDevolucion);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.txtNombreLector);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAgregarODetallesPrestamosLibros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetallesOAgregarPrestamos";
            this.Load += new System.EventHandler(this.DetallesOAgregarPrestamos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Button btnRegistrarPrestamo;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label lbLibro;
        public System.Windows.Forms.Label lbISBN;
        public System.Windows.Forms.Label lbCedula;
        public System.Windows.Forms.Label lbLector;
        public System.Windows.Forms.TextBox txtISBN;
        public System.Windows.Forms.TextBox txtTituloLibro;
        public System.Windows.Forms.TextBox txtFechaPrestamo;
        public System.Windows.Forms.TextBox txtFechaDevolucion;
        public System.Windows.Forms.TextBox txtCedula;
        public System.Windows.Forms.TextBox txtNombreLector;
        public System.Windows.Forms.Button btnSeleccionarLibro;
        public System.Windows.Forms.Button btnSeleccionarLector;
        public System.Windows.Forms.Button btnCalendario;
        public System.Windows.Forms.Label lbTituloVentana;
        public System.Windows.Forms.Label lbNombreLector;
        public System.Windows.Forms.Label lbDetallesLibro;
        private System.Windows.Forms.MonthCalendar calDevolucion;
    }
}