namespace BiblioTech.Views.Perfil
{
    partial class FrmVerPrestamosPerfil
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

            this.lblTitulo    = new System.Windows.Forms.Label();
            this.dgvPrestamos = new System.Windows.Forms.DataGridView();
            this.colId        = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLibro     = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInicio    = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLimite    = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado    = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblContador  = new System.Windows.Forms.Label();
            this.btnCerrar    = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).BeginInit();
            this.SuspendLayout();

            // lblTitulo
            this.lblTitulo.Font      = new System.Drawing.Font("Lucida Handwriting", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location  = new System.Drawing.Point(18, 20);
            this.lblTitulo.Name      = "lblTitulo";
            this.lblTitulo.Size      = new System.Drawing.Size(870, 50);
            this.lblTitulo.TabIndex  = 0;
            this.lblTitulo.Text      = "MIS PRÉSTAMOS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // dgvPrestamos
            this.dgvPrestamos.AllowUserToAddRows    = false;
            this.dgvPrestamos.AllowUserToDeleteRows = false;
            this.dgvPrestamos.ReadOnly              = true;
            altRowStyle.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvPrestamos.AlternatingRowsDefaultCellStyle = altRowStyle;
            this.dgvPrestamos.AutoSizeColumnsMode             = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrestamos.BackgroundColor                 = System.Drawing.Color.White;
            headerStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            headerStyle.BackColor = System.Drawing.Color.Peru;
            headerStyle.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            headerStyle.ForeColor = System.Drawing.Color.White;
            headerStyle.WrapMode  = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrestamos.ColumnHeadersDefaultCellStyle = headerStyle;
            this.dgvPrestamos.ColumnHeadersHeight           = 30;
            this.dgvPrestamos.EnableHeadersVisualStyles     = false;
            this.dgvPrestamos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colId, this.colLibro, this.colInicio, this.colLimite, this.colEstado });
            this.dgvPrestamos.Location        = new System.Drawing.Point(18, 80);
            this.dgvPrestamos.MultiSelect     = false;
            this.dgvPrestamos.Name            = "dgvPrestamos";
            this.dgvPrestamos.RowHeadersWidth = 30;
            this.dgvPrestamos.SelectionMode   = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrestamos.Size            = new System.Drawing.Size(870, 520);
            this.dgvPrestamos.TabIndex        = 1;

            // Columnas
            this.colId.HeaderText    = "# Préstamo";
            this.colId.Name          = "colId";
            this.colId.ReadOnly      = true;
            this.colId.Width         = 100;

            this.colLibro.HeaderText = "Libro";
            this.colLibro.Name       = "colLibro";
            this.colLibro.ReadOnly   = true;

            this.colInicio.HeaderText = "Fecha inicio";
            this.colInicio.Name       = "colInicio";
            this.colInicio.ReadOnly   = true;
            this.colInicio.Width      = 110;

            this.colLimite.HeaderText = "Fecha límite";
            this.colLimite.Name       = "colLimite";
            this.colLimite.ReadOnly   = true;
            this.colLimite.Width      = 110;

            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name       = "colEstado";
            this.colEstado.ReadOnly   = true;
            this.colEstado.Width      = 100;

            // lblContador
            this.lblContador.Font      = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Italic);
            this.lblContador.ForeColor = System.Drawing.Color.DarkGray;
            this.lblContador.Location  = new System.Drawing.Point(18, 610);
            this.lblContador.Name      = "lblContador";
            this.lblContador.Size      = new System.Drawing.Size(400, 28);
            this.lblContador.Text      = "Total: 0";

            // btnCerrar
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(204, 0, 0);
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Font      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.Location  = new System.Drawing.Point(758, 608);
            this.btnCerrar.Name      = "btnCerrar";
            this.btnCerrar.Size      = new System.Drawing.Size(130, 40);
            this.btnCerrar.TabIndex  = 2;
            this.btnCerrar.Text      = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);

            // FrmVerPrestamosPerfil
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.SandyBrown;
            this.ClientSize          = new System.Drawing.Size(908, 665);
            this.FormBorderStyle     = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox         = false;
            this.Name                = "FrmVerPrestamosPerfil";
            this.StartPosition       = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text                = "Mis préstamos";
            this.Load               += new System.EventHandler(this.FrmVerPrestamosPerfil_Load);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvPrestamos);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.btnCerrar);

            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label                     lblTitulo;
        private System.Windows.Forms.DataGridView              dgvPrestamos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLimite;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.Label                     lblContador;
        private System.Windows.Forms.Button                    btnCerrar;
    }
}
