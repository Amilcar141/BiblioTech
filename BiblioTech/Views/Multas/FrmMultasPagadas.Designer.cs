namespace BiblioTech.Views.Multas
{
    partial class FrmMultasPagadas
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
            this.lblFechaRegistro      = new System.Windows.Forms.Label();
            this.lblFechaRegistroValor = new System.Windows.Forms.Label();
            this.dgvMultasPagadas      = new System.Windows.Forms.DataGridView();
            this.btnCancelar           = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvMultasPagadas)).BeginInit();
            this.SuspendLayout();

            this.lblTitulo.Font      = new System.Drawing.Font("Lucida Handwriting", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location  = new System.Drawing.Point(410, 9);
            this.lblTitulo.Name      = "lblTitulo";
            this.lblTitulo.Size      = new System.Drawing.Size(580, 64);
            this.lblTitulo.TabIndex  = 0;
            this.lblTitulo.Text      = "MULTAS PAGADAS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblFechaRegistro.Font     = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFechaRegistro.Location = new System.Drawing.Point(15, 90);
            this.lblFechaRegistro.Name     = "lblFechaRegistro";
            this.lblFechaRegistro.Size     = new System.Drawing.Size(151, 26);
            this.lblFechaRegistro.TabIndex = 0;
            this.lblFechaRegistro.Text     = "Fecha Consulta:";

            this.lblFechaRegistroValor.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblFechaRegistroValor.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFechaRegistroValor.Location  = new System.Drawing.Point(175, 90);
            this.lblFechaRegistroValor.Name      = "lblFechaRegistroValor";
            this.lblFechaRegistroValor.Size      = new System.Drawing.Size(223, 26);
            this.lblFechaRegistroValor.TabIndex  = 1;
            this.lblFechaRegistroValor.Text      = "-";

            this.dgvMultasPagadas.AllowUserToAddRows       = false;
            this.dgvMultasPagadas.BackgroundColor           = System.Drawing.Color.White;
            this.dgvMultasPagadas.BorderStyle               = System.Windows.Forms.BorderStyle.None;
            this.dgvMultasPagadas.ReadOnly                  = true;
            this.dgvMultasPagadas.SelectionMode             = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMultasPagadas.EnableHeadersVisualStyles = false;
            this.dgvMultasPagadas.RowHeadersWidth           = 62;
            this.dgvMultasPagadas.Location                  = new System.Drawing.Point(15, 130);
            this.dgvMultasPagadas.Name                      = "dgvMultasPagadas";
            this.dgvMultasPagadas.Size                      = new System.Drawing.Size(1446, 460);
            this.dgvMultasPagadas.TabIndex                  = 2;

            dgvAltStyle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvMultasPagadas.AlternatingRowsDefaultCellStyle = dgvAltStyle;
            dgvHeaderStyle.BackColor = System.Drawing.Color.FromArgb(255, 128, 0);
            dgvHeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dgvHeaderStyle.ForeColor = System.Drawing.Color.White;
            dgvHeaderStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dgvHeaderStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvMultasPagadas.ColumnHeadersDefaultCellStyle = dgvHeaderStyle;
            this.dgvMultasPagadas.ColumnHeadersHeight            = 34;

            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(204, 0, 0);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location  = new System.Drawing.Point(15, 602);
            this.btnCancelar.Name      = "btnCancelar";
            this.btnCancelar.Size      = new System.Drawing.Size(100, 41);
            this.btnCancelar.TabIndex  = 3;
            this.btnCancelar.Text      = "Cerrar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.FromArgb(255, 192, 128);
            this.ClientSize          = new System.Drawing.Size(1468, 660);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblFechaRegistro);
            this.Controls.Add(this.lblFechaRegistroValor);
            this.Controls.Add(this.dgvMultasPagadas);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox     = false;
            this.Name            = "FrmMultasPagadas";
            this.StartPosition   = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text            = "Multas Pagadas";

            ((System.ComponentModel.ISupportInitialize)(this.dgvMultasPagadas)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Label          lblTitulo;
        private System.Windows.Forms.Label          lblFechaRegistro;
        private System.Windows.Forms.Label          lblFechaRegistroValor;
        private System.Windows.Forms.DataGridView   dgvMultasPagadas;
        private System.Windows.Forms.Button         btnCancelar;
    }
}
