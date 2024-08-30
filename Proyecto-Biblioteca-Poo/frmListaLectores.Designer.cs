namespace Proyecto_Biblioteca_Poo
{
    partial class frmListaLectores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaLectores));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAgregarLector = new System.Windows.Forms.Button();
            this.dgvLectores = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lbLibros = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLectores)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(24, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 35);
            this.button1.TabIndex = 14;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnAgregarLector
            // 
            this.btnAgregarLector.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarLector.BackgroundImage")));
            this.btnAgregarLector.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarLector.FlatAppearance.BorderSize = 0;
            this.btnAgregarLector.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAgregarLector.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAgregarLector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarLector.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarLector.ForeColor = System.Drawing.Color.White;
            this.btnAgregarLector.Location = new System.Drawing.Point(24, 535);
            this.btnAgregarLector.Name = "btnAgregarLector";
            this.btnAgregarLector.Size = new System.Drawing.Size(221, 42);
            this.btnAgregarLector.TabIndex = 13;
            this.btnAgregarLector.Text = "AGREGAR";
            this.btnAgregarLector.UseVisualStyleBackColor = true;
            this.btnAgregarLector.Click += new System.EventHandler(this.btnAgregarLibro_Click);
            // 
            // dgvLectores
            // 
            this.dgvLectores.AllowUserToAddRows = false;
            this.dgvLectores.AllowUserToDeleteRows = false;
            this.dgvLectores.AllowUserToResizeColumns = false;
            this.dgvLectores.AllowUserToResizeRows = false;
            this.dgvLectores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLectores.BackgroundColor = System.Drawing.Color.White;
            this.dgvLectores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLectores.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLectores.Location = new System.Drawing.Point(24, 185);
            this.dgvLectores.Name = "dgvLectores";
            this.dgvLectores.ReadOnly = true;
            this.dgvLectores.RowHeadersVisible = false;
            this.dgvLectores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLectores.Size = new System.Drawing.Size(738, 336);
            this.dgvLectores.TabIndex = 12;
            this.dgvLectores.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLectores_CellContentDoubleClick);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(118, 130);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(643, 35);
            this.txtBuscar.TabIndex = 11;
            // 
            // lbLibros
            // 
            this.lbLibros.AutoSize = true;
            this.lbLibros.BackColor = System.Drawing.Color.Transparent;
            this.lbLibros.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLibros.ForeColor = System.Drawing.Color.White;
            this.lbLibros.Location = new System.Drawing.Point(124, 77);
            this.lbLibros.Name = "lbLibros";
            this.lbLibros.Size = new System.Drawing.Size(124, 24);
            this.lbLibros.TabIndex = 10;
            this.lbLibros.Text = "LECTORES";
            // 
            // frmListaLectores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(785, 640);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAgregarLector);
            this.Controls.Add(this.dgvLectores);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lbLibros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListaLectores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListaLectores";
            this.Load += new System.EventHandler(this.frmListaLectores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLectores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAgregarLector;
        public System.Windows.Forms.DataGridView dgvLectores;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lbLibros;
    }
}