namespace BiblioTech.Views.Perfil
{
    partial class FrmVerLibrosPerfil
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
            this.dgvLibros    = new System.Windows.Forms.DataGridView();
            this.colTitulo    = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAutor     = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEditorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado    = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblContador  = new System.Windows.Forms.Label();
            this.btnCerrar    = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            this.SuspendLayout();

            // lblTitulo
            this.lblTitulo.Font      = new System.Drawing.Font("Lucida Handwriting", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location  = new System.Drawing.Point(18, 20);
            this.lblTitulo.Name      = "lblTitulo";
            this.lblTitulo.Size      = new System.Drawing.Size(870, 50);
            this.lblTitulo.TabIndex  = 0;
            this.lblTitulo.Text      = "CATÁLOGO DE LIBROS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // dgvLibros
            this.dgvLibros.AllowUserToAddRows    = false;
            this.dgvLibros.AllowUserToDeleteRows = false;
            this.dgvLibros.ReadOnly              = true;
            altRowStyle.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvLibros.AlternatingRowsDefaultCellStyle = altRowStyle;
            this.dgvLibros.AutoSizeColumnsMode             = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLibros.BackgroundColor                 = System.Drawing.Color.White;
            headerStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            headerStyle.BackColor = System.Drawing.Color.Peru;
            headerStyle.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            headerStyle.ForeColor = System.Drawing.Color.White;
            headerStyle.WrapMode  = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLibros.ColumnHeadersDefaultCellStyle = headerStyle;
            this.dgvLibros.ColumnHeadersHeight           = 30;
            this.dgvLibros.EnableHeadersVisualStyles     = false;
            this.dgvLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colTitulo, this.colAutor, this.colCategoria, this.colEditorial, this.colEstado });
            this.dgvLibros.Location        = new System.Drawing.Point(18, 80);
            this.dgvLibros.MultiSelect     = false;
            this.dgvLibros.Name            = "dgvLibros";
            this.dgvLibros.RowHeadersWidth = 30;
            this.dgvLibros.SelectionMode   = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLibros.Size            = new System.Drawing.Size(870, 520);
            this.dgvLibros.TabIndex        = 1;

            // Columnas
            this.colTitulo.HeaderText    = "Título";
            this.colTitulo.Name          = "colTitulo";
            this.colTitulo.ReadOnly      = true;

            this.colAutor.HeaderText     = "Autor";
            this.colAutor.Name           = "colAutor";
            this.colAutor.ReadOnly       = true;

            this.colCategoria.HeaderText = "Categoría";
            this.colCategoria.Name       = "colCategoria";
            this.colCategoria.ReadOnly   = true;

            this.colEditorial.HeaderText = "Editorial";
            this.colEditorial.Name       = "colEditorial";
            this.colEditorial.ReadOnly   = true;

            this.colEstado.HeaderText    = "Disponibilidad";
            this.colEstado.Name          = "colEstado";
            this.colEstado.ReadOnly      = true;

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

            // FrmVerLibrosPerfil
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.SandyBrown;
            this.ClientSize          = new System.Drawing.Size(908, 665);
            this.FormBorderStyle     = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox         = false;
            this.Name                = "FrmVerLibrosPerfil";
            this.StartPosition       = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text                = "Ver libros";
            this.Load               += new System.EventHandler(this.FrmVerLibrosPerfil_Load);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvLibros);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.btnCerrar);

            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label                     lblTitulo;
        private System.Windows.Forms.DataGridView              dgvLibros;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEditorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.Label                     lblContador;
        private System.Windows.Forms.Button                    btnCerrar;
    }
}
