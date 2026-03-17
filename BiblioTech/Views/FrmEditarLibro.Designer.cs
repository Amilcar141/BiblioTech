namespace BiblioTech.Views
{
    partial class FrmEditarLibro
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
            this.lblHint = new System.Windows.Forms.Label();
            this.dgvLibros = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpEdicion = new System.Windows.Forms.GroupBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.lblNombreLibro = new System.Windows.Forms.Label();
            this.txtNombreLibro = new System.Windows.Forms.TextBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.lblFechaPublicacion = new System.Windows.Forms.Label();
            this.dtpFechaPublicacion = new System.Windows.Forms.DateTimePicker();
            this.lblNumeroPaginas = new System.Windows.Forms.Label();
            this.txtNumeroPaginas = new System.Windows.Forms.TextBox();
            this.lblEditorial = new System.Windows.Forms.Label();
            this.txtEditorial = new System.Windows.Forms.TextBox();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pnlBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            this.grpEdicion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(191, 7);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(469, 58);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "EDITAR LIBRO";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBuscar
            // 
            this.pnlBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(90)))), ((int)(((byte)(60)))));
            this.pnlBuscar.Controls.Add(this.lblBuscar);
            this.pnlBuscar.Controls.Add(this.txtBuscar);
            this.pnlBuscar.Controls.Add(this.lblHint);
            this.pnlBuscar.Location = new System.Drawing.Point(76, 83);
            this.pnlBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBuscar.Name = "pnlBuscar";
            this.pnlBuscar.Size = new System.Drawing.Size(778, 74);
            this.pnlBuscar.TabIndex = 1;
            // 
            // lblBuscar
            // 
            this.lblBuscar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBuscar.Location = new System.Drawing.Point(13, 24);
            this.lblBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(77, 30);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(96, 22);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(359, 26);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // lblHint
            // 
            this.lblHint.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblHint.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblHint.Location = new System.Drawing.Point(476, 20);
            this.lblHint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(319, 26);
            this.lblHint.TabIndex = 2;
            this.lblHint.Text = "Doble clic en la fila para cargar el libro";
            // 
            // dgvLibros
            // 
            this.dgvLibros.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvLibros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLibros.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLibros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLibros.ColumnHeadersHeight = 34;
            this.dgvLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ISBN,
            this.Nombre,
            this.Autor,
            this.Categoria,
            this.Editorial});
            this.dgvLibros.EnableHeadersVisualStyles = false;
            this.dgvLibros.Location = new System.Drawing.Point(15, 176);
            this.dgvLibros.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.ReadOnly = true;
            this.dgvLibros.RowHeadersWidth = 62;
            this.dgvLibros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLibros.Size = new System.Drawing.Size(862, 306);
            this.dgvLibros.TabIndex = 2;
            this.dgvLibros.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLibros_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 50;
            // 
            // ISBN
            // 
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.MinimumWidth = 8;
            this.ISBN.Name = "ISBN";
            this.ISBN.ReadOnly = true;
            this.ISBN.Width = 120;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre Libro";
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 230;
            // 
            // Autor
            // 
            this.Autor.HeaderText = "Autor";
            this.Autor.MinimumWidth = 8;
            this.Autor.Name = "Autor";
            this.Autor.ReadOnly = true;
            this.Autor.Width = 170;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoría";
            this.Categoria.MinimumWidth = 8;
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Width = 150;
            // 
            // Editorial
            // 
            this.Editorial.HeaderText = "Editorial";
            this.Editorial.MinimumWidth = 8;
            this.Editorial.Name = "Editorial";
            this.Editorial.ReadOnly = true;
            this.Editorial.Width = 175;
            // 
            // grpEdicion
            // 
            this.grpEdicion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(90)))), ((int)(((byte)(60)))));
            this.grpEdicion.Controls.Add(this.lblISBN);
            this.grpEdicion.Controls.Add(this.txtISBN);
            this.grpEdicion.Controls.Add(this.lblNombreLibro);
            this.grpEdicion.Controls.Add(this.txtNombreLibro);
            this.grpEdicion.Controls.Add(this.lblAutor);
            this.grpEdicion.Controls.Add(this.txtAutor);
            this.grpEdicion.Controls.Add(this.lblCategoria);
            this.grpEdicion.Controls.Add(this.txtCategoria);
            this.grpEdicion.Controls.Add(this.lblFechaPublicacion);
            this.grpEdicion.Controls.Add(this.dtpFechaPublicacion);
            this.grpEdicion.Controls.Add(this.lblNumeroPaginas);
            this.grpEdicion.Controls.Add(this.txtNumeroPaginas);
            this.grpEdicion.Controls.Add(this.lblEditorial);
            this.grpEdicion.Controls.Add(this.txtEditorial);
            this.grpEdicion.Controls.Add(this.btnGuardarCambios);
            this.grpEdicion.Controls.Add(this.btnCancelar);
            this.grpEdicion.Controls.Add(this.btnCerrar);
            this.grpEdicion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpEdicion.Location = new System.Drawing.Point(13, 490);
            this.grpEdicion.Margin = new System.Windows.Forms.Padding(4);
            this.grpEdicion.Name = "grpEdicion";
            this.grpEdicion.Padding = new System.Windows.Forms.Padding(4);
            this.grpEdicion.Size = new System.Drawing.Size(864, 299);
            this.grpEdicion.TabIndex = 3;
            this.grpEdicion.TabStop = false;
            this.grpEdicion.Text = "Editar datos del libro  (doble clic en la tabla para cargar)";
            // 
            // lblISBN
            // 
            this.lblISBN.Location = new System.Drawing.Point(13, 42);
            this.lblISBN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(62, 30);
            this.lblISBN.TabIndex = 0;
            this.lblISBN.Text = "ISBN:";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(96, 40);
            this.txtISBN.Margin = new System.Windows.Forms.Padding(4);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(180, 31);
            this.txtISBN.TabIndex = 1;
            // 
            // lblNombreLibro
            // 
            this.lblNombreLibro.Location = new System.Drawing.Point(13, 194);
            this.lblNombreLibro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreLibro.Name = "lblNombreLibro";
            this.lblNombreLibro.Size = new System.Drawing.Size(132, 30);
            this.lblNombreLibro.TabIndex = 2;
            this.lblNombreLibro.Text = "Nombre Libro:";
            // 
            // txtNombreLibro
            // 
            this.txtNombreLibro.Location = new System.Drawing.Point(147, 194);
            this.txtNombreLibro.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreLibro.Name = "txtNombreLibro";
            this.txtNombreLibro.Size = new System.Drawing.Size(305, 31);
            this.txtNombreLibro.TabIndex = 3;
            // 
            // lblAutor
            // 
            this.lblAutor.Location = new System.Drawing.Point(13, 94);
            this.lblAutor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(62, 30);
            this.lblAutor.TabIndex = 4;
            this.lblAutor.Text = "Autor:";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(87, 91);
            this.txtAutor.Margin = new System.Windows.Forms.Padding(4);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(293, 31);
            this.txtAutor.TabIndex = 5;
            // 
            // lblCategoria
            // 
            this.lblCategoria.Location = new System.Drawing.Point(399, 35);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(98, 30);
            this.lblCategoria.TabIndex = 6;
            this.lblCategoria.Text = "Categoría:";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(504, 33);
            this.txtCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(205, 31);
            this.txtCategoria.TabIndex = 7;
            // 
            // lblFechaPublicacion
            // 
            this.lblFechaPublicacion.Location = new System.Drawing.Point(13, 144);
            this.lblFechaPublicacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaPublicacion.Name = "lblFechaPublicacion";
            this.lblFechaPublicacion.Size = new System.Drawing.Size(108, 30);
            this.lblFechaPublicacion.TabIndex = 8;
            this.lblFechaPublicacion.Text = "Fecha Pub.:";
            // 
            // dtpFechaPublicacion
            // 
            this.dtpFechaPublicacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaPublicacion.Location = new System.Drawing.Point(147, 144);
            this.dtpFechaPublicacion.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaPublicacion.Name = "dtpFechaPublicacion";
            this.dtpFechaPublicacion.Size = new System.Drawing.Size(185, 31);
            this.dtpFechaPublicacion.TabIndex = 9;
            // 
            // lblNumeroPaginas
            // 
            this.lblNumeroPaginas.Location = new System.Drawing.Point(399, 86);
            this.lblNumeroPaginas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroPaginas.Name = "lblNumeroPaginas";
            this.lblNumeroPaginas.Size = new System.Drawing.Size(106, 30);
            this.lblNumeroPaginas.TabIndex = 10;
            this.lblNumeroPaginas.Text = "N° Páginas:";
            // 
            // txtNumeroPaginas
            // 
            this.txtNumeroPaginas.Location = new System.Drawing.Point(504, 86);
            this.txtNumeroPaginas.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumeroPaginas.Name = "txtNumeroPaginas";
            this.txtNumeroPaginas.Size = new System.Drawing.Size(138, 31);
            this.txtNumeroPaginas.TabIndex = 11;
            // 
            // lblEditorial
            // 
            this.lblEditorial.Location = new System.Drawing.Point(399, 130);
            this.lblEditorial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEditorial.Name = "lblEditorial";
            this.lblEditorial.Size = new System.Drawing.Size(98, 30);
            this.lblEditorial.TabIndex = 14;
            this.lblEditorial.Text = "Editorial:";
            // 
            // txtEditorial
            // 
            this.txtEditorial.Location = new System.Drawing.Point(504, 135);
            this.txtEditorial.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditorial.Name = "txtEditorial";
            this.txtEditorial.Size = new System.Drawing.Size(203, 31);
            this.txtEditorial.TabIndex = 15;
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(76)))));
            this.btnGuardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCambios.ForeColor = System.Drawing.Color.White;
            this.btnGuardarCambios.Location = new System.Drawing.Point(13, 236);
            this.btnGuardarCambios.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(108, 35);
            this.btnGuardarCambios.TabIndex = 16;
            this.btnGuardarCambios.Text = "Guardar Cambios";
            this.btnGuardarCambios.UseVisualStyleBackColor = false;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(129, 236);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 35);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(274, 236);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(106, 34);
            this.btnCerrar.TabIndex = 18;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FrmEditarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(896, 810);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnlBuscar);
            this.Controls.Add(this.dgvLibros);
            this.Controls.Add(this.grpEdicion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmEditarLibro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Libro";
            this.pnlBuscar.ResumeLayout(false);
            this.pnlBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            this.grpEdicion.ResumeLayout(false);
            this.grpEdicion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.DataGridView dgvLibros;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEditorial;
        private System.Windows.Forms.GroupBox grpEdicion;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label lblNombreLibro;
        private System.Windows.Forms.TextBox txtNombreLibro;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label lblFechaPublicacion;
        private System.Windows.Forms.DateTimePicker dtpFechaPublicacion;
        private System.Windows.Forms.Label lblNumeroPaginas;
        private System.Windows.Forms.TextBox txtNumeroPaginas;
        private System.Windows.Forms.Label lblEditorial;
        private System.Windows.Forms.TextBox txtEditorial;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Editorial;
    }
}
