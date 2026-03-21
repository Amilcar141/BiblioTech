namespace BiblioTech.Views.Reportes
{
    partial class FrmReporte
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlResumen = new System.Windows.Forms.Panel();
            this.grpLibros = new System.Windows.Forms.GroupBox();
            this.lblDLibros = new System.Windows.Forms.Label();
            this.lblResLibros = new System.Windows.Forms.Label();
            this.lblDDisp = new System.Windows.Forms.Label();
            this.lblResDisp = new System.Windows.Forms.Label();
            this.lblDPrest = new System.Windows.Forms.Label();
            this.lblResPrest = new System.Windows.Forms.Label();
            this.grpPrestamos = new System.Windows.Forms.GroupBox();
            this.lblDPrestTot = new System.Windows.Forms.Label();
            this.lblResPrestTot = new System.Windows.Forms.Label();
            this.lblDVenc = new System.Windows.Forms.Label();
            this.lblResVenc = new System.Windows.Forms.Label();
            this.grpMultas = new System.Windows.Forms.GroupBox();
            this.lblDMultas = new System.Windows.Forms.Label();
            this.lblResMultas = new System.Windows.Forms.Label();
            this.lblDTotalMul = new System.Windows.Forms.Label();
            this.lblResTotalMul = new System.Windows.Forms.Label();
            this.rtbReporte = new System.Windows.Forms.RichTextBox();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pnlResumen.SuspendLayout();
            this.grpLibros.SuspendLayout();
            this.grpPrestamos.SuspendLayout();
            this.grpMultas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Lucida Handwriting", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(346, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(851, 65);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "REPORTE GENERAL DEL SISTEMA";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlResumen
            // 
            this.pnlResumen.BackColor = System.Drawing.Color.Transparent;
            this.pnlResumen.Controls.Add(this.grpLibros);
            this.pnlResumen.Controls.Add(this.grpMultas);
            this.pnlResumen.Location = new System.Drawing.Point(18, 92);
            this.pnlResumen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlResumen.Name = "pnlResumen";
            this.pnlResumen.Size = new System.Drawing.Size(1337, 183);
            this.pnlResumen.TabIndex = 1;
            // 
            // grpLibros
            // 
            this.grpLibros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(133)))), ((int)(((byte)(82)))));
            this.grpLibros.Controls.Add(this.lblDLibros);
            this.grpLibros.Controls.Add(this.lblResLibros);
            this.grpLibros.Controls.Add(this.lblDDisp);
            this.grpLibros.Controls.Add(this.lblResDisp);
            this.grpLibros.Controls.Add(this.lblDPrest);
            this.grpLibros.Controls.Add(this.lblResPrest);
            this.grpLibros.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpLibros.ForeColor = System.Drawing.Color.White;
            this.grpLibros.Location = new System.Drawing.Point(0, 0);
            this.grpLibros.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpLibros.Name = "grpLibros";
            this.grpLibros.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpLibros.Size = new System.Drawing.Size(423, 183);
            this.grpLibros.TabIndex = 0;
            this.grpLibros.TabStop = false;
            this.grpLibros.Text = "Catalogo de Libros";
            // 
            // lblDLibros
            // 
            this.lblDLibros.Location = new System.Drawing.Point(15, 38);
            this.lblDLibros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDLibros.Name = "lblDLibros";
            this.lblDLibros.Size = new System.Drawing.Size(232, 34);
            this.lblDLibros.TabIndex = 0;
            this.lblDLibros.Text = "Total libros:";
            // 
            // lblResLibros
            // 
            this.lblResLibros.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblResLibros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(200)))));
            this.lblResLibros.Location = new System.Drawing.Point(255, 38);
            this.lblResLibros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResLibros.Name = "lblResLibros";
            this.lblResLibros.Size = new System.Drawing.Size(232, 34);
            this.lblResLibros.TabIndex = 1;
            this.lblResLibros.Text = "0";
            // 
            // lblDDisp
            // 
            this.lblDDisp.Location = new System.Drawing.Point(15, 85);
            this.lblDDisp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDDisp.Name = "lblDDisp";
            this.lblDDisp.Size = new System.Drawing.Size(232, 34);
            this.lblDDisp.TabIndex = 2;
            this.lblDDisp.Text = "Disponibles:";
            // 
            // lblResDisp
            // 
            this.lblResDisp.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblResDisp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(200)))));
            this.lblResDisp.Location = new System.Drawing.Point(255, 85);
            this.lblResDisp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResDisp.Name = "lblResDisp";
            this.lblResDisp.Size = new System.Drawing.Size(232, 34);
            this.lblResDisp.TabIndex = 3;
            this.lblResDisp.Text = "0";
            // 
            // lblDPrest
            // 
            this.lblDPrest.Location = new System.Drawing.Point(15, 131);
            this.lblDPrest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDPrest.Name = "lblDPrest";
            this.lblDPrest.Size = new System.Drawing.Size(232, 34);
            this.lblDPrest.TabIndex = 4;
            this.lblDPrest.Text = "Prestados:";
            // 
            // lblResPrest
            // 
            this.lblResPrest.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblResPrest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(200)))));
            this.lblResPrest.Location = new System.Drawing.Point(255, 131);
            this.lblResPrest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResPrest.Name = "lblResPrest";
            this.lblResPrest.Size = new System.Drawing.Size(232, 34);
            this.lblResPrest.TabIndex = 5;
            this.lblResPrest.Text = "0";
            // 
            // grpPrestamos
            // 
            this.grpPrestamos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(133)))), ((int)(((byte)(82)))));
            this.grpPrestamos.Controls.Add(this.lblDPrestTot);
            this.grpPrestamos.Controls.Add(this.lblResPrestTot);
            this.grpPrestamos.Controls.Add(this.lblDVenc);
            this.grpPrestamos.Controls.Add(this.lblResVenc);
            this.grpPrestamos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpPrestamos.ForeColor = System.Drawing.Color.White;
            this.grpPrestamos.Location = new System.Drawing.Point(476, 92);
            this.grpPrestamos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpPrestamos.Name = "grpPrestamos";
            this.grpPrestamos.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpPrestamos.Size = new System.Drawing.Size(425, 183);
            this.grpPrestamos.TabIndex = 1;
            this.grpPrestamos.TabStop = false;
            this.grpPrestamos.Text = "Prestamos";
            // 
            // lblDPrestTot
            // 
            this.lblDPrestTot.Location = new System.Drawing.Point(15, 38);
            this.lblDPrestTot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDPrestTot.Name = "lblDPrestTot";
            this.lblDPrestTot.Size = new System.Drawing.Size(232, 34);
            this.lblDPrestTot.TabIndex = 0;
            this.lblDPrestTot.Text = "Total prestamos:";
            // 
            // lblResPrestTot
            // 
            this.lblResPrestTot.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblResPrestTot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(200)))));
            this.lblResPrestTot.Location = new System.Drawing.Point(255, 38);
            this.lblResPrestTot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResPrestTot.Name = "lblResPrestTot";
            this.lblResPrestTot.Size = new System.Drawing.Size(232, 34);
            this.lblResPrestTot.TabIndex = 1;
            this.lblResPrestTot.Text = "0";
            // 
            // lblDVenc
            // 
            this.lblDVenc.Location = new System.Drawing.Point(15, 85);
            this.lblDVenc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDVenc.Name = "lblDVenc";
            this.lblDVenc.Size = new System.Drawing.Size(232, 34);
            this.lblDVenc.TabIndex = 2;
            this.lblDVenc.Text = "Vencidos sin devolver:";
            // 
            // lblResVenc
            // 
            this.lblResVenc.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblResVenc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(200)))));
            this.lblResVenc.Location = new System.Drawing.Point(255, 85);
            this.lblResVenc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResVenc.Name = "lblResVenc";
            this.lblResVenc.Size = new System.Drawing.Size(232, 34);
            this.lblResVenc.TabIndex = 3;
            this.lblResVenc.Text = "0";
            // 
            // grpMultas
            // 
            this.grpMultas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(133)))), ((int)(((byte)(82)))));
            this.grpMultas.Controls.Add(this.lblDMultas);
            this.grpMultas.Controls.Add(this.lblResMultas);
            this.grpMultas.Controls.Add(this.lblDTotalMul);
            this.grpMultas.Controls.Add(this.lblResTotalMul);
            this.grpMultas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpMultas.ForeColor = System.Drawing.Color.White;
            this.grpMultas.Location = new System.Drawing.Point(923, 0);
            this.grpMultas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpMultas.Name = "grpMultas";
            this.grpMultas.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpMultas.Size = new System.Drawing.Size(414, 183);
            this.grpMultas.TabIndex = 2;
            this.grpMultas.TabStop = false;
            this.grpMultas.Text = "Multas";
            // 
            // lblDMultas
            // 
            this.lblDMultas.Location = new System.Drawing.Point(15, 38);
            this.lblDMultas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDMultas.Name = "lblDMultas";
            this.lblDMultas.Size = new System.Drawing.Size(232, 34);
            this.lblDMultas.TabIndex = 0;
            this.lblDMultas.Text = "Pendientes:";
            // 
            // lblResMultas
            // 
            this.lblResMultas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblResMultas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(200)))));
            this.lblResMultas.Location = new System.Drawing.Point(255, 38);
            this.lblResMultas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResMultas.Name = "lblResMultas";
            this.lblResMultas.Size = new System.Drawing.Size(232, 34);
            this.lblResMultas.TabIndex = 1;
            this.lblResMultas.Text = "0";
            // 
            // lblDTotalMul
            // 
            this.lblDTotalMul.Location = new System.Drawing.Point(15, 85);
            this.lblDTotalMul.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDTotalMul.Name = "lblDTotalMul";
            this.lblDTotalMul.Size = new System.Drawing.Size(232, 34);
            this.lblDTotalMul.TabIndex = 2;
            this.lblDTotalMul.Text = "Total pendiente:";
            // 
            // lblResTotalMul
            // 
            this.lblResTotalMul.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblResTotalMul.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(200)))));
            this.lblResTotalMul.Location = new System.Drawing.Point(255, 85);
            this.lblResTotalMul.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResTotalMul.Name = "lblResTotalMul";
            this.lblResTotalMul.Size = new System.Drawing.Size(232, 34);
            this.lblResTotalMul.TabIndex = 3;
            this.lblResTotalMul.Text = "0.00 Lps";
            // 
            // rtbReporte
            // 
            this.rtbReporte.BackColor = System.Drawing.Color.FloralWhite;
            this.rtbReporte.Font = new System.Drawing.Font("Courier New", 10F);
            this.rtbReporte.Location = new System.Drawing.Point(18, 308);
            this.rtbReporte.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbReporte.Name = "rtbReporte";
            this.rtbReporte.ReadOnly = true;
            this.rtbReporte.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbReporte.Size = new System.Drawing.Size(1337, 513);
            this.rtbReporte.TabIndex = 2;
            this.rtbReporte.Text = "";
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnRefrescar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRefrescar.ForeColor = System.Drawing.Color.White;
            this.btnRefrescar.Location = new System.Drawing.Point(927, 831);
            this.btnRefrescar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(150, 58);
            this.btnRefrescar.TabIndex = 3;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = false;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(1113, 831);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(139, 58);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FrmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1375, 895);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.grpPrestamos);
            this.Controls.Add(this.pnlResumen);
            this.Controls.Add(this.rtbReporte);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmReporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte General";
            this.Load += new System.EventHandler(this.FrmReporte_Load);
            this.pnlResumen.ResumeLayout(false);
            this.grpLibros.ResumeLayout(false);
            this.grpPrestamos.ResumeLayout(false);
            this.grpMultas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label      lblTitulo;
        private System.Windows.Forms.Panel      pnlResumen;
        private System.Windows.Forms.GroupBox   grpLibros;
        private System.Windows.Forms.Label      lblDLibros;
        private System.Windows.Forms.Label      lblResLibros;
        private System.Windows.Forms.Label      lblDDisp;
        private System.Windows.Forms.Label      lblResDisp;
        private System.Windows.Forms.Label      lblDPrest;
        private System.Windows.Forms.Label      lblResPrest;
        private System.Windows.Forms.GroupBox   grpPrestamos;
        private System.Windows.Forms.Label      lblDPrestTot;
        private System.Windows.Forms.Label      lblResPrestTot;
        private System.Windows.Forms.Label      lblDVenc;
        private System.Windows.Forms.Label      lblResVenc;
        private System.Windows.Forms.GroupBox   grpMultas;
        private System.Windows.Forms.Label      lblDMultas;
        private System.Windows.Forms.Label      lblResMultas;
        private System.Windows.Forms.Label      lblDTotalMul;
        private System.Windows.Forms.Label      lblResTotalMul;
        private System.Windows.Forms.RichTextBox rtbReporte;
        private System.Windows.Forms.Button     btnRefrescar;
        private System.Windows.Forms.Button     btnCerrar;
    }
}
