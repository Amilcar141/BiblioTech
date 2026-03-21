namespace BiblioTech.Views.Reportes
{
    partial class FrmInventario
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
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.colInvISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvEditorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvPaginas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblContador = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pnlBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Lucida Handwriting", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(161, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(657, 65);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "INVENTARIO DE LIBROS";
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
            this.pnlBuscar.Size = new System.Drawing.Size(726, 77);
            this.pnlBuscar.TabIndex = 1;
            // 
            // lblBuscar
            // 
            this.lblBuscar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBuscar.ForeColor = System.Drawing.Color.White;
            this.lblBuscar.Location = new System.Drawing.Point(15, 22);
            this.lblBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(87, 34);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(108, 20);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(523, 26);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // dgvInventario
            // 
            this.dgvInventario.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvInventario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventario.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInventario.ColumnHeadersHeight = 32;
            this.dgvInventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colInvISBN,
            this.colInvNombre,
            this.colInvAutor,
            this.colInvCategoria,
            this.colInvEditorial,
            this.colInvFecha,
            this.colInvPaginas,
            this.colInvEstado});
            this.dgvInventario.EnableHeadersVisualStyles = false;
            this.dgvInventario.Location = new System.Drawing.Point(18, 185);
            this.dgvInventario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.ReadOnly = true;
            this.dgvInventario.RowHeadersWidth = 30;
            this.dgvInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventario.Size = new System.Drawing.Size(1129, 547);
            this.dgvInventario.TabIndex = 2;
            // 
            // colInvISBN
            // 
            this.colInvISBN.HeaderText = "ISBN";
            this.colInvISBN.MinimumWidth = 8;
            this.colInvISBN.Name = "colInvISBN";
            this.colInvISBN.ReadOnly = true;
            // 
            // colInvNombre
            // 
            this.colInvNombre.HeaderText = "Nombre Libro";
            this.colInvNombre.MinimumWidth = 8;
            this.colInvNombre.Name = "colInvNombre";
            this.colInvNombre.ReadOnly = true;
            // 
            // colInvAutor
            // 
            this.colInvAutor.HeaderText = "Autor";
            this.colInvAutor.MinimumWidth = 8;
            this.colInvAutor.Name = "colInvAutor";
            this.colInvAutor.ReadOnly = true;
            // 
            // colInvCategoria
            // 
            this.colInvCategoria.HeaderText = "Categoria";
            this.colInvCategoria.MinimumWidth = 8;
            this.colInvCategoria.Name = "colInvCategoria";
            this.colInvCategoria.ReadOnly = true;
            // 
            // colInvEditorial
            // 
            this.colInvEditorial.HeaderText = "Editorial";
            this.colInvEditorial.MinimumWidth = 8;
            this.colInvEditorial.Name = "colInvEditorial";
            this.colInvEditorial.ReadOnly = true;
            // 
            // colInvFecha
            // 
            this.colInvFecha.HeaderText = "Publicacion";
            this.colInvFecha.MinimumWidth = 8;
            this.colInvFecha.Name = "colInvFecha";
            this.colInvFecha.ReadOnly = true;
            // 
            // colInvPaginas
            // 
            this.colInvPaginas.HeaderText = "Paginas";
            this.colInvPaginas.MinimumWidth = 8;
            this.colInvPaginas.Name = "colInvPaginas";
            this.colInvPaginas.ReadOnly = true;
            // 
            // colInvEstado
            // 
            this.colInvEstado.HeaderText = "Estado";
            this.colInvEstado.MinimumWidth = 8;
            this.colInvEstado.Name = "colInvEstado";
            this.colInvEstado.ReadOnly = true;
            // 
            // lblContador
            // 
            this.lblContador.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Italic);
            this.lblContador.ForeColor = System.Drawing.Color.DarkGray;
            this.lblContador.Location = new System.Drawing.Point(14, 737);
            this.lblContador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(750, 34);
            this.lblContador.TabIndex = 3;
            this.lblContador.Text = "Total: 0";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(778, 104);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(105, 54);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(911, 104);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(96, 54);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FrmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1181, 796);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnlBuscar);
            this.Controls.Add(this.dgvInventario);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario de Libros";
            this.Load += new System.EventHandler(this.FrmInventario_Load);
            this.pnlBuscar.ResumeLayout(false);
            this.pnlBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvEditorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvPaginas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvEstado;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCerrar;
    }
}
