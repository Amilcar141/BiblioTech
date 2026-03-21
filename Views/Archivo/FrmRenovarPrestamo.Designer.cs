namespace BiblioTech.Views.Archivo
{
    partial class FrmRenovarPrestamo
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlBuscar = new System.Windows.Forms.Panel();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvPrestamos = new System.Windows.Forms.DataGridView();
            this.colRId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRLector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRLimite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colREstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpNuevaFecha = new System.Windows.Forms.GroupBox();
            this.lblNuevaFecha = new System.Windows.Forms.Label();
            this.dtpNuevaFecha = new System.Windows.Forms.DateTimePicker();
            this.lblContador = new System.Windows.Forms.Label();
            this.btnRenovar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pnlBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).BeginInit();
            this.grpNuevaFecha.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Lucida Handwriting", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(218, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(520, 65);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "RENOVAR PRESTAMO";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBuscar
            // 
            this.pnlBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(133)))), ((int)(((byte)(82)))));
            this.pnlBuscar.Controls.Add(this.lblBuscar);
            this.pnlBuscar.Controls.Add(this.txtBuscar);
            this.pnlBuscar.Location = new System.Drawing.Point(18, 92);
            this.pnlBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlBuscar.Name = "pnlBuscar";
            this.pnlBuscar.Size = new System.Drawing.Size(951, 71);
            this.pnlBuscar.TabIndex = 1;
            // 
            // lblBuscar
            // 
            this.lblBuscar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBuscar.ForeColor = System.Drawing.Color.White;
            this.lblBuscar.Location = new System.Drawing.Point(15, 18);
            this.lblBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(90, 34);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(111, 17);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(448, 26);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // dgvPrestamos
            // 
            this.dgvPrestamos.AllowUserToAddRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvPrestamos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPrestamos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrestamos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(133)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrestamos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPrestamos.ColumnHeadersHeight = 30;
            this.dgvPrestamos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRId,
            this.colRLector,
            this.colRLibro,
            this.colRLimite,
            this.colREstado});
            this.dgvPrestamos.EnableHeadersVisualStyles = false;
            this.dgvPrestamos.Location = new System.Drawing.Point(18, 178);
            this.dgvPrestamos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvPrestamos.MultiSelect = false;
            this.dgvPrestamos.Name = "dgvPrestamos";
            this.dgvPrestamos.ReadOnly = true;
            this.dgvPrestamos.RowHeadersWidth = 30;
            this.dgvPrestamos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrestamos.Size = new System.Drawing.Size(951, 446);
            this.dgvPrestamos.TabIndex = 2;
            this.dgvPrestamos.SelectionChanged += new System.EventHandler(this.dgvPrestamos_SelectionChanged);
            // 
            // colRId
            // 
            this.colRId.HeaderText = "ID";
            this.colRId.MinimumWidth = 8;
            this.colRId.Name = "colRId";
            this.colRId.ReadOnly = true;
            this.colRId.Visible = false;
            // 
            // colRLector
            // 
            this.colRLector.HeaderText = "Usuario";
            this.colRLector.MinimumWidth = 8;
            this.colRLector.Name = "colRLector";
            this.colRLector.ReadOnly = true;
            // 
            // colRLibro
            // 
            this.colRLibro.HeaderText = "Libro";
            this.colRLibro.MinimumWidth = 8;
            this.colRLibro.Name = "colRLibro";
            this.colRLibro.ReadOnly = true;
            // 
            // colRLimite
            // 
            this.colRLimite.HeaderText = "Fecha Limite Actual";
            this.colRLimite.MinimumWidth = 8;
            this.colRLimite.Name = "colRLimite";
            this.colRLimite.ReadOnly = true;
            // 
            // colREstado
            // 
            this.colREstado.HeaderText = "Estado";
            this.colREstado.MinimumWidth = 8;
            this.colREstado.Name = "colREstado";
            this.colREstado.ReadOnly = true;
            // 
            // grpNuevaFecha
            // 
            this.grpNuevaFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(180)))));
            this.grpNuevaFecha.Controls.Add(this.lblNuevaFecha);
            this.grpNuevaFecha.Controls.Add(this.dtpNuevaFecha);
            this.grpNuevaFecha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpNuevaFecha.Location = new System.Drawing.Point(18, 638);
            this.grpNuevaFecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpNuevaFecha.Name = "grpNuevaFecha";
            this.grpNuevaFecha.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpNuevaFecha.Size = new System.Drawing.Size(750, 85);
            this.grpNuevaFecha.TabIndex = 3;
            this.grpNuevaFecha.TabStop = false;
            this.grpNuevaFecha.Text = "Nueva Fecha Limite";
            // 
            // lblNuevaFecha
            // 
            this.lblNuevaFecha.Location = new System.Drawing.Point(15, 40);
            this.lblNuevaFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNuevaFecha.Name = "lblNuevaFecha";
            this.lblNuevaFecha.Size = new System.Drawing.Size(165, 34);
            this.lblNuevaFecha.TabIndex = 0;
            this.lblNuevaFecha.Text = "Nueva Fecha:";
            // 
            // dtpNuevaFecha
            // 
            this.dtpNuevaFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNuevaFecha.Location = new System.Drawing.Point(188, 37);
            this.dtpNuevaFecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpNuevaFecha.Name = "dtpNuevaFecha";
            this.dtpNuevaFecha.Size = new System.Drawing.Size(298, 31);
            this.dtpNuevaFecha.TabIndex = 1;
            // 
            // lblContador
            // 
            this.lblContador.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Italic);
            this.lblContador.ForeColor = System.Drawing.Color.DarkGray;
            this.lblContador.Location = new System.Drawing.Point(18, 738);
            this.lblContador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(375, 34);
            this.lblContador.TabIndex = 4;
            this.lblContador.Text = "Activos: 0";
            // 
            // btnRenovar
            // 
            this.btnRenovar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(76)))));
            this.btnRenovar.ForeColor = System.Drawing.Color.White;
            this.btnRenovar.Image = global::BiblioTech.Properties.Resources.guardar_el_archivo;
            this.btnRenovar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRenovar.Location = new System.Drawing.Point(446, 733);
            this.btnRenovar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRenovar.Name = "btnRenovar";
            this.btnRenovar.Size = new System.Drawing.Size(180, 54);
            this.btnRenovar.TabIndex = 5;
            this.btnRenovar.Text = "Renovar";
            this.btnRenovar.UseVisualStyleBackColor = false;
            this.btnRenovar.Click += new System.EventHandler(this.btnRenovar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Image = global::BiblioTech.Properties.Resources.escoba;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(634, 733);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(120, 54);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Image = global::BiblioTech.Properties.Resources.eliminar;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(762, 732);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(141, 54);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FrmRenovarPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1006, 800);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnlBuscar);
            this.Controls.Add(this.dgvPrestamos);
            this.Controls.Add(this.grpNuevaFecha);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.btnRenovar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmRenovarPrestamo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Renovar Prestamo";
            this.Load += new System.EventHandler(this.FrmRenovarPrestamo_Load);
            this.pnlBuscar.ResumeLayout(false);
            this.pnlBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).EndInit();
            this.grpNuevaFecha.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dgvPrestamos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRLector;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRLimite;
        private System.Windows.Forms.DataGridViewTextBoxColumn colREstado;
        private System.Windows.Forms.GroupBox grpNuevaFecha;
        private System.Windows.Forms.Label lblNuevaFecha;
        private System.Windows.Forms.DateTimePicker dtpNuevaFecha;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Button btnRenovar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCerrar;
    }
}
