namespace BiblioTech.Views.Multas
{
    partial class frmMultasPendientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlBuscar = new System.Windows.Forms.Panel();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvMultasPendientes = new System.Windows.Forms.DataGridView();
            this.colMPId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMPFechaGen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMPDiasMora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMPMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMPEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlResumen = new System.Windows.Forms.Panel();
            this.lblTotalLabel = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblLps = new System.Windows.Forms.Label();
            this.lblContador = new System.Windows.Forms.Label();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pnlBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMultasPendientes)).BeginInit();
            this.pnlResumen.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Lucida Handwriting", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(233, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(576, 65);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "MULTAS PENDIENTES";
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
            this.pnlBuscar.Size = new System.Drawing.Size(1019, 71);
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
            this.txtBuscar.Size = new System.Drawing.Size(298, 26);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // dgvMultasPendientes
            // 
            this.dgvMultasPendientes.AllowUserToAddRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvMultasPendientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMultasPendientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMultasPendientes.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMultasPendientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMultasPendientes.ColumnHeadersHeight = 32;
            this.dgvMultasPendientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMPId,
            this.colMPFechaGen,
            this.colMPDiasMora,
            this.colMPMonto,
            this.colMPEstado});
            this.dgvMultasPendientes.EnableHeadersVisualStyles = false;
            this.dgvMultasPendientes.Location = new System.Drawing.Point(18, 178);
            this.dgvMultasPendientes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvMultasPendientes.MultiSelect = false;
            this.dgvMultasPendientes.Name = "dgvMultasPendientes";
            this.dgvMultasPendientes.ReadOnly = true;
            this.dgvMultasPendientes.RowHeadersWidth = 30;
            this.dgvMultasPendientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMultasPendientes.Size = new System.Drawing.Size(1019, 492);
            this.dgvMultasPendientes.TabIndex = 2;
            // 
            // colMPId
            // 
            this.colMPId.HeaderText = "ID";
            this.colMPId.MinimumWidth = 8;
            this.colMPId.Name = "colMPId";
            this.colMPId.ReadOnly = true;
            // 
            // colMPFechaGen
            // 
            this.colMPFechaGen.HeaderText = "Fecha Generacion";
            this.colMPFechaGen.MinimumWidth = 8;
            this.colMPFechaGen.Name = "colMPFechaGen";
            this.colMPFechaGen.ReadOnly = true;
            // 
            // colMPDiasMora
            // 
            this.colMPDiasMora.HeaderText = "Dias Mora";
            this.colMPDiasMora.MinimumWidth = 8;
            this.colMPDiasMora.Name = "colMPDiasMora";
            this.colMPDiasMora.ReadOnly = true;
            // 
            // colMPMonto
            // 
            this.colMPMonto.HeaderText = "Monto";
            this.colMPMonto.MinimumWidth = 8;
            this.colMPMonto.Name = "colMPMonto";
            this.colMPMonto.ReadOnly = true;
            // 
            // colMPEstado
            // 
            this.colMPEstado.HeaderText = "Estado";
            this.colMPEstado.MinimumWidth = 8;
            this.colMPEstado.Name = "colMPEstado";
            this.colMPEstado.ReadOnly = true;
            // 
            // pnlResumen
            // 
            this.pnlResumen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(180)))));
            this.pnlResumen.Controls.Add(this.lblTotalLabel);
            this.pnlResumen.Controls.Add(this.txtTotal);
            this.pnlResumen.Controls.Add(this.lblLps);
            this.pnlResumen.Location = new System.Drawing.Point(18, 685);
            this.pnlResumen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlResumen.Name = "pnlResumen";
            this.pnlResumen.Size = new System.Drawing.Size(555, 58);
            this.pnlResumen.TabIndex = 3;
            // 
            // lblTotalLabel
            // 
            this.lblTotalLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTotalLabel.Location = new System.Drawing.Point(15, 15);
            this.lblTotalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalLabel.Name = "lblTotalLabel";
            this.lblTotalLabel.Size = new System.Drawing.Size(156, 34);
            this.lblTotalLabel.TabIndex = 0;
            this.lblTotalLabel.Text = "Total a Cobrar:";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(180)))));
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.txtTotal.ForeColor = System.Drawing.Color.DarkRed;
            this.txtTotal.Location = new System.Drawing.Point(222, 19);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(174, 30);
            this.txtTotal.TabIndex = 1;
            this.txtTotal.Text = "0.00";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblLps
            // 
            this.lblLps.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblLps.ForeColor = System.Drawing.Color.DarkRed;
            this.lblLps.Location = new System.Drawing.Point(404, 16);
            this.lblLps.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLps.Name = "lblLps";
            this.lblLps.Size = new System.Drawing.Size(60, 34);
            this.lblLps.TabIndex = 2;
            this.lblLps.Text = "Lps";
            // 
            // lblContador
            // 
            this.lblContador.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Italic);
            this.lblContador.ForeColor = System.Drawing.Color.DarkGray;
            this.lblContador.Location = new System.Drawing.Point(18, 757);
            this.lblContador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(600, 34);
            this.lblContador.TabIndex = 4;
            this.lblContador.Text = "Total: 0 multa(s) pendiente(s)";
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(76)))));
            this.btnPagar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPagar.ForeColor = System.Drawing.Color.White;
            this.btnPagar.Image = global::BiblioTech.Properties.Resources.metodo_de_pago;
            this.btnPagar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagar.Location = new System.Drawing.Point(600, 685);
            this.btnPagar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(135, 54);
            this.btnPagar.TabIndex = 5;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnRefrescar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefrescar.ForeColor = System.Drawing.Color.White;
            this.btnRefrescar.Image = global::BiblioTech.Properties.Resources.actualizar;
            this.btnRefrescar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefrescar.Location = new System.Drawing.Point(743, 685);
            this.btnRefrescar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(135, 54);
            this.btnRefrescar.TabIndex = 6;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = false;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Image = global::BiblioTech.Properties.Resources.eliminar;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(893, 685);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(144, 54);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmMultasPendientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1101, 812);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnlBuscar);
            this.Controls.Add(this.dgvMultasPendientes);
            this.Controls.Add(this.pnlResumen);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmMultasPendientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multas Pendientes";
            this.Load += new System.EventHandler(this.frmMultasPendientes_Load);
            this.pnlBuscar.ResumeLayout(false);
            this.pnlBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMultasPendientes)).EndInit();
            this.pnlResumen.ResumeLayout(false);
            this.pnlResumen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dgvMultasPendientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMPId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMPFechaGen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMPDiasMora;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMPMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMPEstado;
        private System.Windows.Forms.Panel pnlResumen;
        private System.Windows.Forms.Label lblTotalLabel;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblLps;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Button btnCerrar;
    }
}
