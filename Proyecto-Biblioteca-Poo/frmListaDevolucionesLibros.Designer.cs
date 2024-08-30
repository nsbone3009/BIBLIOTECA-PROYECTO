namespace Proyecto_Biblioteca_Poo
{
    partial class frmListaDevolucionesLibros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaDevolucionesLibros));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbDevoluciones = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAgregarLibro = new System.Windows.Forms.Button();
            this.dgvDevoluciones = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevoluciones)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDevoluciones
            // 
            this.lbDevoluciones.AutoSize = true;
            this.lbDevoluciones.BackColor = System.Drawing.Color.Transparent;
            this.lbDevoluciones.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDevoluciones.ForeColor = System.Drawing.Color.White;
            this.lbDevoluciones.Location = new System.Drawing.Point(100, 76);
            this.lbDevoluciones.Name = "lbDevoluciones";
            this.lbDevoluciones.Size = new System.Drawing.Size(173, 24);
            this.lbDevoluciones.TabIndex = 1;
            this.lbDevoluciones.Text = "DEVOLUCIONES\r\n";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(24, 131);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(91, 35);
            this.btnBuscar.TabIndex = 18;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnAgregarLibro
            // 
            this.btnAgregarLibro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarLibro.BackgroundImage")));
            this.btnAgregarLibro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarLibro.FlatAppearance.BorderSize = 0;
            this.btnAgregarLibro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAgregarLibro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAgregarLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarLibro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarLibro.ForeColor = System.Drawing.Color.White;
            this.btnAgregarLibro.Location = new System.Drawing.Point(24, 536);
            this.btnAgregarLibro.Name = "btnAgregarLibro";
            this.btnAgregarLibro.Size = new System.Drawing.Size(180, 50);
            this.btnAgregarLibro.TabIndex = 17;
            this.btnAgregarLibro.Text = "AGREGAR";
            this.btnAgregarLibro.UseVisualStyleBackColor = true;
            this.btnAgregarLibro.Click += new System.EventHandler(this.btnAgregarLibro_Click);
            // 
            // dgvDevoluciones
            // 
            this.dgvDevoluciones.AllowUserToAddRows = false;
            this.dgvDevoluciones.AllowUserToDeleteRows = false;
            this.dgvDevoluciones.BackgroundColor = System.Drawing.Color.White;
            this.dgvDevoluciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDevoluciones.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDevoluciones.Location = new System.Drawing.Point(24, 186);
            this.dgvDevoluciones.Name = "dgvDevoluciones";
            this.dgvDevoluciones.ReadOnly = true;
            this.dgvDevoluciones.RowHeadersVisible = false;
            this.dgvDevoluciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDevoluciones.Size = new System.Drawing.Size(737, 335);
            this.dgvDevoluciones.TabIndex = 16;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(118, 131);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(643, 35);
            this.txtBuscar.TabIndex = 15;
            // 
            // frmListaDevolucionesLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(785, 640);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAgregarLibro);
            this.Controls.Add(this.dgvDevoluciones);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lbDevoluciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListaDevolucionesLibros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListaDevolucionesLibros";
            this.Load += new System.EventHandler(this.frmListaDevolucionesLibros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevoluciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDevoluciones;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAgregarLibro;
        public System.Windows.Forms.DataGridView dgvDevoluciones;
        private System.Windows.Forms.TextBox txtBuscar;
    }
}