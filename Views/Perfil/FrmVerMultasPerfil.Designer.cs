namespace BiblioTech.Views.Perfil
{
    partial class FrmVerMultasPerfil
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
            System.Windows.Forms.DataGridViewCellStyle headerStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle altRowStyle  = new System.Windows.Forms.DataGridViewCellStyle();

            this.lblTitulo      = new System.Windows.Forms.Label();
            this.dgvMultas      = new System.Windows.Forms.DataGridView();
            this.colId          = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLibro       = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMonto       = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDias        = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha       = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado      = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblContador    = new System.Windows.Forms.Label();
            this.btnCerrar      = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvMultas)).BeginInit();
            this.SuspendLayout();

            // lblTitulo
            this.lblTitulo.Font      = new System.Drawing.Font("Lucida Handwriting", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location  = new System.Drawing.Point(18, 20);
            this.lblTitulo.Name      = "lblTitulo";
            this.lblTitulo.Size      = new System.Drawing.Size(870, 50);
            this.lblTitulo.TabIndex  = 0;
            this.lblTitulo.Text      = "MIS MULTAS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // dgvMultas
            this.dgvMultas.AllowUserToAddRows    = false;
            this.dgvMultas.AllowUserToDeleteRows = false;
            this.dgvMultas.ReadOnly              = true;
            altRowStyle.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvMultas.AlternatingRowsDefaultCellStyle = altRowStyle;
            this.dgvMultas.AutoSizeColumnsMode             = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMultas.BackgroundColor                 = System.Drawing.Color.White;
            headerStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            headerStyle.BackColor = System.Drawing.Color.Peru;
            headerStyle.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            headerStyle.ForeColor = System.Drawing.Color.White;
            headerStyle.WrapMode  = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMultas.ColumnHeadersDefaultCellStyle = headerStyle;
            this.dgvMultas.ColumnHeadersHeight           = 30;
            this.dgvMultas.EnableHeadersVisualStyles     = false;
            this.dgvMultas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colId, this.colLibro, this.colMonto, this.colDias, this.colFecha, this.colEstado });
            this.dgvMultas.Location        = new System.Drawing.Point(18, 80);
            this.dgvMultas.MultiSelect     = false;
            this.dgvMultas.Name            = "dgvMultas";
            this.dgvMultas.RowHeadersWidth = 30;
            this.dgvMultas.SelectionMode   = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMultas.Size            = new System.Drawing.Size(870, 520);
            this.dgvMultas.TabIndex        = 1;

            // Columnas
            this.colId.HeaderText    = "# Multa";
            this.colId.Name          = "colId";
            this.colId.ReadOnly      = true;

            this.colLibro.HeaderText = "Descripción";
            this.colLibro.Name       = "colLibro";
            this.colLibro.ReadOnly   = true;

            this.colMonto.HeaderText = "Monto Lps.";
            this.colMonto.Name       = "colMonto";
            this.colMonto.ReadOnly   = true;

            this.colDias.HeaderText  = "Días mora";
            this.colDias.Name        = "colDias";
            this.colDias.ReadOnly    = true;

            this.colFecha.HeaderText = "Fecha";
            this.colFecha.Name       = "colFecha";
            this.colFecha.ReadOnly   = true;

            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name       = "colEstado";
            this.colEstado.ReadOnly   = true;

            // lblContador
            this.lblContador.Font      = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Italic);
            this.lblContador.ForeColor = System.Drawing.Color.DarkGray;
            this.lblContador.Location  = new System.Drawing.Point(18, 610);
            this.lblContador.Name      = "lblContador";
            this.lblContador.Size      = new System.Drawing.Size(620, 28);
            this.lblContador.TabIndex  = 2;
            this.lblContador.Text      = "Total: 0";

            // btnCerrar
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(204, 0, 0);
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Font      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.Location  = new System.Drawing.Point(758, 608);
            this.btnCerrar.Name      = "btnCerrar";
            this.btnCerrar.Size      = new System.Drawing.Size(130, 40);
            this.btnCerrar.TabIndex  = 3;
            this.btnCerrar.Text      = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);

            // FrmVerMultasPerfil
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.SandyBrown;
            this.ClientSize          = new System.Drawing.Size(908, 665);
            this.FormBorderStyle     = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox         = false;
            this.Name                = "FrmVerMultasPerfil";
            this.StartPosition       = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text                = "Mis multas";
            this.Load               += new System.EventHandler(this.FrmVerMultasPerfil_Load);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvMultas);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.btnCerrar);

            ((System.ComponentModel.ISupportInitialize)(this.dgvMultas)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label                     lblTitulo;
        private System.Windows.Forms.DataGridView              dgvMultas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDias;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.Label                     lblContador;
        private System.Windows.Forms.Button                    btnCerrar;
    }
}
