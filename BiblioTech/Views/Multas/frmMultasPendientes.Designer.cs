namespace BiblioTech.Views.Multas
{
    partial class frmMultasPendientes
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dgvHeaderStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvAltStyle     = new System.Windows.Forms.DataGridViewCellStyle();

            this.lblTitulo             = new System.Windows.Forms.Label();
            this.grpDatos              = new System.Windows.Forms.GroupBox();
            this.lblIdMulta            = new System.Windows.Forms.Label();
            this.txtIdMulta            = new System.Windows.Forms.TextBox();
            this.lblMonto              = new System.Windows.Forms.Label();
            this.txtMonto              = new System.Windows.Forms.TextBox();
            this.lblTotal              = new System.Windows.Forms.Label();
            this.lblTotalValor         = new System.Windows.Forms.Label();
            this.lblFechaRegistro      = new System.Windows.Forms.Label();
            this.lblFechaRegistroValor = new System.Windows.Forms.Label();
            this.dgvMultasPendientes   = new System.Windows.Forms.DataGridView();
            this.btnRegistrar          = new System.Windows.Forms.Button();
            this.btnPagar              = new System.Windows.Forms.Button();
            this.btnLimpiar            = new System.Windows.Forms.Button();
            this.btnCancelar           = new System.Windows.Forms.Button();

            this.grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMultasPendientes)).BeginInit();
            this.SuspendLayout();

            // lblTitulo
            this.lblTitulo.Font      = new System.Drawing.Font("Lucida Handwriting", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location  = new System.Drawing.Point(410, 9);
            this.lblTitulo.Name      = "lblTitulo";
            this.lblTitulo.Size      = new System.Drawing.Size(580, 64);
            this.lblTitulo.TabIndex  = 0;
            this.lblTitulo.Text      = "MULTAS PENDIENTES";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // grpDatos
            this.grpDatos.BackColor = System.Drawing.Color.FromArgb(192, 133, 82);
            this.grpDatos.Controls.Add(this.lblIdMulta);
            this.grpDatos.Controls.Add(this.txtIdMulta);
            this.grpDatos.Controls.Add(this.lblMonto);
            this.grpDatos.Controls.Add(this.txtMonto);
            this.grpDatos.Controls.Add(this.lblTotal);
            this.grpDatos.Controls.Add(this.lblTotalValor);
            this.grpDatos.Controls.Add(this.lblFechaRegistro);
            this.grpDatos.Controls.Add(this.lblFechaRegistroValor);
            this.grpDatos.Location  = new System.Drawing.Point(15, 90);
            this.grpDatos.Name      = "grpDatos";
            this.grpDatos.Padding   = new System.Windows.Forms.Padding(4);
            this.grpDatos.Size      = new System.Drawing.Size(424, 290);
            this.grpDatos.TabIndex  = 1;
            this.grpDatos.TabStop   = false;
            this.grpDatos.Text      = "Registrar Multa";

            // lblIdMulta
            this.lblIdMulta.Font     = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblIdMulta.Location = new System.Drawing.Point(10, 34);
            this.lblIdMulta.Name     = "lblIdMulta";
            this.lblIdMulta.Size     = new System.Drawing.Size(140, 26);
            this.lblIdMulta.TabIndex = 0;
            this.lblIdMulta.Text     = "ID Multa:";

            this.txtIdMulta.Location = new System.Drawing.Point(171, 34);
            this.txtIdMulta.Name     = "txtIdMulta";
            this.txtIdMulta.Size     = new System.Drawing.Size(240, 26);
            this.txtIdMulta.TabIndex = 1;

            // lblMonto
            this.lblMonto.Font     = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMonto.Location = new System.Drawing.Point(10, 80);
            this.lblMonto.Name     = "lblMonto";
            this.lblMonto.Size     = new System.Drawing.Size(140, 26);
            this.lblMonto.TabIndex = 2;
            this.lblMonto.Text     = "Monto ($):";

            this.txtMonto.Location = new System.Drawing.Point(171, 80);
            this.txtMonto.Name     = "txtMonto";
            this.txtMonto.Size     = new System.Drawing.Size(240, 26);
            this.txtMonto.TabIndex = 3;

            // lblTotal
            this.lblTotal.Font     = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(10, 126);
            this.lblTotal.Name     = "lblTotal";
            this.lblTotal.Size     = new System.Drawing.Size(140, 26);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text     = "Total Pendiente:";

            this.lblTotalValor.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalValor.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTotalValor.Location  = new System.Drawing.Point(171, 126);
            this.lblTotalValor.Name      = "lblTotalValor";
            this.lblTotalValor.Size      = new System.Drawing.Size(223, 26);
            this.lblTotalValor.TabIndex  = 5;
            this.lblTotalValor.Text      = "$ 0.00";

            // lblFechaRegistro
            this.lblFechaRegistro.Font     = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFechaRegistro.Location = new System.Drawing.Point(10, 172);
            this.lblFechaRegistro.Name     = "lblFechaRegistro";
            this.lblFechaRegistro.Size     = new System.Drawing.Size(151, 26);
            this.lblFechaRegistro.TabIndex = 6;
            this.lblFechaRegistro.Text     = "Fecha Registro:";

            this.lblFechaRegistroValor.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblFechaRegistroValor.Location  = new System.Drawing.Point(167, 172);
            this.lblFechaRegistroValor.Name      = "lblFechaRegistroValor";
            this.lblFechaRegistroValor.Size      = new System.Drawing.Size(223, 26);
            this.lblFechaRegistroValor.TabIndex  = 7;
            this.lblFechaRegistroValor.Text      = "-";

            // dgvMultasPendientes
            this.dgvMultasPendientes.AllowUserToAddRows       = false;
            this.dgvMultasPendientes.BackgroundColor           = System.Drawing.Color.White;
            this.dgvMultasPendientes.BorderStyle               = System.Windows.Forms.BorderStyle.None;
            this.dgvMultasPendientes.ReadOnly                  = true;
            this.dgvMultasPendientes.SelectionMode             = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMultasPendientes.EnableHeadersVisualStyles = false;
            this.dgvMultasPendientes.RowHeadersWidth           = 62;
            this.dgvMultasPendientes.Location                  = new System.Drawing.Point(447, 90);
            this.dgvMultasPendientes.Name                      = "dgvMultasPendientes";
            this.dgvMultasPendientes.Size                      = new System.Drawing.Size(1014, 479);
            this.dgvMultasPendientes.TabIndex                  = 2;

            dgvAltStyle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvMultasPendientes.AlternatingRowsDefaultCellStyle = dgvAltStyle;

            dgvHeaderStyle.Alignment          = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dgvHeaderStyle.BackColor          = System.Drawing.Color.FromArgb(255, 128, 0);
            dgvHeaderStyle.Font               = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dgvHeaderStyle.ForeColor          = System.Drawing.Color.White;
            dgvHeaderStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dgvHeaderStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvMultasPendientes.ColumnHeadersDefaultCellStyle = dgvHeaderStyle;
            this.dgvMultasPendientes.ColumnHeadersHeight            = 34;

            // btnRegistrar
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(0, 153, 76);
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location  = new System.Drawing.Point(15, 577);
            this.btnRegistrar.Name      = "btnRegistrar";
            this.btnRegistrar.Size      = new System.Drawing.Size(115, 42);
            this.btnRegistrar.TabIndex  = 3;
            this.btnRegistrar.Text      = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);

            // btnPagar
            this.btnPagar.BackColor = System.Drawing.Color.FromArgb(102, 0, 204);
            this.btnPagar.ForeColor = System.Drawing.Color.White;
            this.btnPagar.Location  = new System.Drawing.Point(145, 577);
            this.btnPagar.Name      = "btnPagar";
            this.btnPagar.Size      = new System.Drawing.Size(120, 42);
            this.btnPagar.TabIndex  = 4;
            this.btnPagar.Text      = "Pagar Multa";
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);

            // btnLimpiar
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(255, 165, 0);
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location  = new System.Drawing.Point(280, 581);
            this.btnLimpiar.Name      = "btnLimpiar";
            this.btnLimpiar.Size      = new System.Drawing.Size(100, 38);
            this.btnLimpiar.TabIndex  = 5;
            this.btnLimpiar.Text      = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);

            // btnCancelar
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(204, 0, 0);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location  = new System.Drawing.Point(393, 579);
            this.btnCancelar.Name      = "btnCancelar";
            this.btnCancelar.Size      = new System.Drawing.Size(100, 41);
            this.btnCancelar.TabIndex  = 6;
            this.btnCancelar.Text      = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);

            // frmMultasPendientes
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.FromArgb(255, 192, 128);
            this.ClientSize          = new System.Drawing.Size(1468, 638);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.grpDatos);
            this.Controls.Add(this.dgvMultasPendientes);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox     = false;
            this.Name            = "frmMultasPendientes";
            this.StartPosition   = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text            = "Multas Pendientes";

            this.grpDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMultasPendientes)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Label          lblTitulo;
        private System.Windows.Forms.GroupBox       grpDatos;
        private System.Windows.Forms.Label          lblIdMulta;
        private System.Windows.Forms.TextBox        txtIdMulta;
        private System.Windows.Forms.Label          lblMonto;
        private System.Windows.Forms.TextBox        txtMonto;
        private System.Windows.Forms.Label          lblTotal;
        private System.Windows.Forms.Label          lblTotalValor;
        private System.Windows.Forms.Label          lblFechaRegistro;
        private System.Windows.Forms.Label          lblFechaRegistroValor;
        private System.Windows.Forms.DataGridView   dgvMultasPendientes;
        private System.Windows.Forms.Button         btnRegistrar;
        private System.Windows.Forms.Button         btnPagar;
        private System.Windows.Forms.Button         btnLimpiar;
        private System.Windows.Forms.Button         btnCancelar;
    }
}
