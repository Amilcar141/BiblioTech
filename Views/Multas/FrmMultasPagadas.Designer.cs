namespace BiblioTech.Views.Multas
{
    partial class FrmMultasPagadas
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlBuscar = new System.Windows.Forms.Panel();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvMultasPagadas = new System.Windows.Forms.DataGridView();
            this.colPGId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPGFechaGen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPGFechaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPGDias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPGMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPGEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlResumen = new System.Windows.Forms.Panel();
            this.lblCantidadLabel = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblTotalLabel = new System.Windows.Forms.Label();
            this.txtTotalRecaudado = new System.Windows.Forms.TextBox();
            this.lblLps = new System.Windows.Forms.Label();
            this.lblContador = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.pnlBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMultasPagadas)).BeginInit();
            this.pnlResumen.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Lucida Handwriting", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(209, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(585, 65);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "MULTAS PAGADAS";
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
            this.pnlBuscar.Size = new System.Drawing.Size(1055, 71);
            this.pnlBuscar.TabIndex = 1;
            // 
            // lblBuscar
            // 
            this.lblBuscar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBuscar.ForeColor = System.Drawing.Color.White;
            this.lblBuscar.Location = new System.Drawing.Point(15, 18);
            this.lblBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(150, 34);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "Buscar ID:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(171, 17);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(429, 26);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // dgvMultasPagadas
            // 
            this.dgvMultasPagadas.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvMultasPagadas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMultasPagadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMultasPagadas.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMultasPagadas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMultasPagadas.ColumnHeadersHeight = 32;
            this.dgvMultasPagadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPGId,
            this.colPGFechaGen,
            this.colPGFechaPago,
            this.colPGDias,
            this.colPGMonto,
            this.colPGEstado});
            this.dgvMultasPagadas.EnableHeadersVisualStyles = false;
            this.dgvMultasPagadas.Location = new System.Drawing.Point(18, 178);
            this.dgvMultasPagadas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvMultasPagadas.Name = "dgvMultasPagadas";
            this.dgvMultasPagadas.ReadOnly = true;
            this.dgvMultasPagadas.RowHeadersWidth = 30;
            this.dgvMultasPagadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMultasPagadas.Size = new System.Drawing.Size(1055, 477);
            this.dgvMultasPagadas.TabIndex = 2;
            // 
            // colPGId
            // 
            this.colPGId.HeaderText = "ID";
            this.colPGId.MinimumWidth = 8;
            this.colPGId.Name = "colPGId";
            this.colPGId.ReadOnly = true;
            // 
            // colPGFechaGen
            // 
            this.colPGFechaGen.HeaderText = "Fecha Generacion";
            this.colPGFechaGen.MinimumWidth = 8;
            this.colPGFechaGen.Name = "colPGFechaGen";
            this.colPGFechaGen.ReadOnly = true;
            // 
            // colPGFechaPago
            // 
            this.colPGFechaPago.HeaderText = "Fecha de Pago";
            this.colPGFechaPago.MinimumWidth = 8;
            this.colPGFechaPago.Name = "colPGFechaPago";
            this.colPGFechaPago.ReadOnly = true;
            // 
            // colPGDias
            // 
            this.colPGDias.HeaderText = "Dias Mora";
            this.colPGDias.MinimumWidth = 8;
            this.colPGDias.Name = "colPGDias";
            this.colPGDias.ReadOnly = true;
            // 
            // colPGMonto
            // 
            this.colPGMonto.HeaderText = "Monto";
            this.colPGMonto.MinimumWidth = 8;
            this.colPGMonto.Name = "colPGMonto";
            this.colPGMonto.ReadOnly = true;
            // 
            // colPGEstado
            // 
            this.colPGEstado.HeaderText = "Estado";
            this.colPGEstado.MinimumWidth = 8;
            this.colPGEstado.Name = "colPGEstado";
            this.colPGEstado.ReadOnly = true;
            // 
            // pnlResumen
            // 
            this.pnlResumen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(180)))));
            this.pnlResumen.Controls.Add(this.lblCantidadLabel);
            this.pnlResumen.Controls.Add(this.txtCantidad);
            this.pnlResumen.Controls.Add(this.lblTotalLabel);
            this.pnlResumen.Controls.Add(this.txtTotalRecaudado);
            this.pnlResumen.Controls.Add(this.lblLps);
            this.pnlResumen.Location = new System.Drawing.Point(18, 671);
            this.pnlResumen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlResumen.Name = "pnlResumen";
            this.pnlResumen.Size = new System.Drawing.Size(763, 58);
            this.pnlResumen.TabIndex = 3;
            // 
            // lblCantidadLabel
            // 
            this.lblCantidadLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCantidadLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblCantidadLabel.Location = new System.Drawing.Point(15, 15);
            this.lblCantidadLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidadLabel.Name = "lblCantidadLabel";
            this.lblCantidadLabel.Size = new System.Drawing.Size(135, 34);
            this.lblCantidadLabel.TabIndex = 0;
            this.lblCantidadLabel.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(180)))));
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantidad.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.txtCantidad.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtCantidad.Location = new System.Drawing.Point(156, 14);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.ReadOnly = true;
            this.txtCantidad.Size = new System.Drawing.Size(90, 30);
            this.txtCantidad.TabIndex = 1;
            this.txtCantidad.Text = "0";
            // 
            // lblTotalLabel
            // 
            this.lblTotalLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTotalLabel.Location = new System.Drawing.Point(259, 15);
            this.lblTotalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalLabel.Name = "lblTotalLabel";
            this.lblTotalLabel.Size = new System.Drawing.Size(210, 34);
            this.lblTotalLabel.TabIndex = 2;
            this.lblTotalLabel.Text = "Total Recaudado:";
            // 
            // txtTotalRecaudado
            // 
            this.txtTotalRecaudado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(180)))));
            this.txtTotalRecaudado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalRecaudado.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.txtTotalRecaudado.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtTotalRecaudado.Location = new System.Drawing.Point(477, 14);
            this.txtTotalRecaudado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotalRecaudado.Name = "txtTotalRecaudado";
            this.txtTotalRecaudado.ReadOnly = true;
            this.txtTotalRecaudado.Size = new System.Drawing.Size(210, 30);
            this.txtTotalRecaudado.TabIndex = 3;
            this.txtTotalRecaudado.Text = "0.00";
            this.txtTotalRecaudado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblLps
            // 
            this.lblLps.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblLps.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblLps.Location = new System.Drawing.Point(695, 14);
            this.lblLps.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLps.Name = "lblLps";
            this.lblLps.Size = new System.Drawing.Size(60, 34);
            this.lblLps.TabIndex = 4;
            this.lblLps.Text = "Lps";
            // 
            // lblContador
            // 
            this.lblContador.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Italic);
            this.lblContador.ForeColor = System.Drawing.Color.DarkGray;
            this.lblContador.Location = new System.Drawing.Point(18, 745);
            this.lblContador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(600, 34);
            this.lblContador.TabIndex = 4;
            this.lblContador.Text = "Total: 0 multa(s) pagada(s)";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Image = global::BiblioTech.Properties.Resources.eliminar;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(932, 671);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(141, 54);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnRefrescar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefrescar.ForeColor = System.Drawing.Color.White;
            this.btnRefrescar.Image = global::BiblioTech.Properties.Resources.actualizar;
            this.btnRefrescar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefrescar.Location = new System.Drawing.Point(789, 671);
            this.btnRefrescar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(135, 54);
            this.btnRefrescar.TabIndex = 5;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = false;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // FrmMultasPagadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1098, 797);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnlBuscar);
            this.Controls.Add(this.dgvMultasPagadas);
            this.Controls.Add(this.pnlResumen);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmMultasPagadas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multas Pagadas";
            this.Load += new System.EventHandler(this.FrmMultasPagadas_Load);
            this.pnlBuscar.ResumeLayout(false);
            this.pnlBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMultasPagadas)).EndInit();
            this.pnlResumen.ResumeLayout(false);
            this.pnlResumen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dgvMultasPagadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPGId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPGFechaGen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPGFechaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPGDias;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPGMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPGEstado;
        private System.Windows.Forms.Panel pnlResumen;
        private System.Windows.Forms.Label lblCantidadLabel;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblTotalLabel;
        private System.Windows.Forms.TextBox txtTotalRecaudado;
        private System.Windows.Forms.Label lblLps;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Button btnCerrar;
    }
}
