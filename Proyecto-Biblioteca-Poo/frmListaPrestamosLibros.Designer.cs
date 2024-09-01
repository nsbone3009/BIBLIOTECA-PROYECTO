namespace Proyecto_Biblioteca_Poo
{
    partial class frmListaPrestamosLibros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaPrestamosLibros));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvPrestamos = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnAgregarPrestamo = new System.Windows.Forms.Button();
            this.blPrestamos = new System.Windows.Forms.Label();
            this.btnModificarPrestamo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(23, 141);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(91, 35);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // dgvPrestamos
            // 
            this.dgvPrestamos.AllowUserToAddRows = false;
            this.dgvPrestamos.AllowUserToDeleteRows = false;
            this.dgvPrestamos.AllowUserToResizeColumns = false;
            this.dgvPrestamos.AllowUserToResizeRows = false;
            this.dgvPrestamos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrestamos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrestamos.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPrestamos.Location = new System.Drawing.Point(23, 196);
            this.dgvPrestamos.Name = "dgvPrestamos";
            this.dgvPrestamos.ReadOnly = true;
            this.dgvPrestamos.RowHeadersVisible = false;
            this.dgvPrestamos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrestamos.Size = new System.Drawing.Size(737, 335);
            this.dgvPrestamos.TabIndex = 11;
            this.dgvPrestamos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrestamos_CellDoubleClick);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(117, 141);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(643, 35);
            this.txtBuscar.TabIndex = 10;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // btnAgregarPrestamo
            // 
            this.btnAgregarPrestamo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarPrestamo.BackgroundImage")));
            this.btnAgregarPrestamo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarPrestamo.FlatAppearance.BorderSize = 0;
            this.btnAgregarPrestamo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAgregarPrestamo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAgregarPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPrestamo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPrestamo.ForeColor = System.Drawing.Color.White;
            this.btnAgregarPrestamo.Location = new System.Drawing.Point(23, 546);
            this.btnAgregarPrestamo.Name = "btnAgregarPrestamo";
            this.btnAgregarPrestamo.Size = new System.Drawing.Size(180, 50);
            this.btnAgregarPrestamo.TabIndex = 13;
            this.btnAgregarPrestamo.Text = "AGREGAR";
            this.btnAgregarPrestamo.UseVisualStyleBackColor = true;
            this.btnAgregarPrestamo.Click += new System.EventHandler(this.btnAgregarPrestamo_Click);
            // 
            // blPrestamos
            // 
            this.blPrestamos.AutoSize = true;
            this.blPrestamos.BackColor = System.Drawing.Color.Transparent;
            this.blPrestamos.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blPrestamos.ForeColor = System.Drawing.Color.White;
            this.blPrestamos.Location = new System.Drawing.Point(128, 74);
            this.blPrestamos.Name = "blPrestamos";
            this.blPrestamos.Size = new System.Drawing.Size(140, 24);
            this.blPrestamos.TabIndex = 14;
            this.blPrestamos.Text = "PRESTAMOS";
            // 
            // btnModificarPrestamo
            // 
            this.btnModificarPrestamo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModificarPrestamo.BackgroundImage")));
            this.btnModificarPrestamo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarPrestamo.FlatAppearance.BorderSize = 0;
            this.btnModificarPrestamo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnModificarPrestamo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnModificarPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarPrestamo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarPrestamo.ForeColor = System.Drawing.Color.White;
            this.btnModificarPrestamo.Location = new System.Drawing.Point(230, 546);
            this.btnModificarPrestamo.Name = "btnModificarPrestamo";
            this.btnModificarPrestamo.Size = new System.Drawing.Size(180, 50);
            this.btnModificarPrestamo.TabIndex = 15;
            this.btnModificarPrestamo.Text = "MODIFICAR";
            this.btnModificarPrestamo.UseVisualStyleBackColor = true;
            this.btnModificarPrestamo.Click += new System.EventHandler(this.btnModificarPrestamo_Click);
            // 
            // frmListaPrestamosLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(785, 640);
            this.Controls.Add(this.btnModificarPrestamo);
            this.Controls.Add(this.blPrestamos);
            this.Controls.Add(this.btnAgregarPrestamo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvPrestamos);
            this.Controls.Add(this.txtBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListaPrestamosLibros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loans";
            this.Load += new System.EventHandler(this.frmListaPrestamosLibros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        public System.Windows.Forms.DataGridView dgvPrestamos;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnAgregarPrestamo;
        private System.Windows.Forms.Label blPrestamos;
        private System.Windows.Forms.Button btnModificarPrestamo;
    }
}