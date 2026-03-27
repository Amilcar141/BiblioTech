namespace BiblioTech.Views
{
    partial class FrmAgregarLibro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarLibro));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.lstCategorias = new System.Windows.Forms.ListBox();
            this.lstEditoriales = new System.Windows.Forms.ListBox();
            this.lstAutores = new System.Windows.Forms.ListBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
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
            this.lblFechaRegistro = new System.Windows.Forms.Label();
            this.lblFechaRegistroValor = new System.Windows.Forms.Label();
            this.dgvLibros = new System.Windows.Forms.DataGridView();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaPub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paginas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Lucida Handwriting", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(410, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(528, 65);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "REGISTRO DE LIBROS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpDatos
            // 
            this.grpDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(133)))), ((int)(((byte)(82)))));
            this.grpDatos.Controls.Add(this.lstCategorias);
            this.grpDatos.Controls.Add(this.lstEditoriales);
            this.grpDatos.Controls.Add(this.lstAutores);
            this.grpDatos.Controls.Add(this.lblPrecio);
            this.grpDatos.Controls.Add(this.txtPrecio);
            this.grpDatos.Controls.Add(this.lblISBN);
            this.grpDatos.Controls.Add(this.txtISBN);
            this.grpDatos.Controls.Add(this.lblNombreLibro);
            this.grpDatos.Controls.Add(this.txtNombreLibro);
            this.grpDatos.Controls.Add(this.btnLimpiar);
            this.grpDatos.Controls.Add(this.btnNuevo);
            this.grpDatos.Controls.Add(this.btnGuardar);
            this.grpDatos.Controls.Add(this.lblAutor);
            this.grpDatos.Controls.Add(this.txtAutor);
            this.grpDatos.Controls.Add(this.lblCategoria);
            this.grpDatos.Controls.Add(this.btnCancelar);
            this.grpDatos.Controls.Add(this.txtCategoria);
            this.grpDatos.Controls.Add(this.lblFechaPublicacion);
            this.grpDatos.Controls.Add(this.dtpFechaPublicacion);
            this.grpDatos.Controls.Add(this.lblNumeroPaginas);
            this.grpDatos.Controls.Add(this.txtNumeroPaginas);
            this.grpDatos.Controls.Add(this.lblEditorial);
            this.grpDatos.Controls.Add(this.txtEditorial);
            this.grpDatos.Controls.Add(this.lblFechaRegistro);
            this.grpDatos.Controls.Add(this.lblFechaRegistroValor);
            this.grpDatos.Location = new System.Drawing.Point(48, 77);
            this.grpDatos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpDatos.Size = new System.Drawing.Size(1146, 275);
            this.grpDatos.TabIndex = 1;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos del Libro";
            // 
            // lstCategorias
            // 
            this.lstCategorias.FormattingEnabled = true;
            this.lstCategorias.ItemHeight = 20;
            this.lstCategorias.Location = new System.Drawing.Point(158, 54);
            this.lstCategorias.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstCategorias.Name = "lstCategorias";
            this.lstCategorias.Size = new System.Drawing.Size(230, 104);
            this.lstCategorias.TabIndex = 22;
            this.lstCategorias.Visible = false;
            this.lstCategorias.SelectedIndexChanged += new System.EventHandler(this.lstCategorias_SelectedIndexChanged);
            // 
            // lstEditoriales
            // 
            this.lstEditoriales.FormattingEnabled = true;
            this.lstEditoriales.ItemHeight = 20;
            this.lstEditoriales.Location = new System.Drawing.Point(650, 165);
            this.lstEditoriales.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstEditoriales.Name = "lstEditoriales";
            this.lstEditoriales.Size = new System.Drawing.Size(230, 104);
            this.lstEditoriales.TabIndex = 21;
            this.lstEditoriales.Visible = false;
            this.lstEditoriales.SelectedIndexChanged += new System.EventHandler(this.lstEditoriales_SelectedIndexChanged);
            // 
            // lstAutores
            // 
            this.lstAutores.FormattingEnabled = true;
            this.lstAutores.ItemHeight = 20;
            this.lstAutores.Location = new System.Drawing.Point(158, 158);
            this.lstAutores.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstAutores.Name = "lstAutores";
            this.lstAutores.Size = new System.Drawing.Size(230, 104);
            this.lstAutores.TabIndex = 20;
            this.lstAutores.Visible = false;
            this.lstAutores.SelectedIndexChanged += new System.EventHandler(this.lstAutores_SelectedIndexChanged);
            // 
            // lblPrecio
            // 
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPrecio.Location = new System.Drawing.Point(532, 178);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(94, 31);
            this.lblPrecio.TabIndex = 18;
            this.lblPrecio.Text = "Precio:";
            this.lblPrecio.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(651, 175);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(216, 26);
            this.txtPrecio.TabIndex = 19;
            // 
            // lblISBN
            // 
            this.lblISBN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblISBN.Location = new System.Drawing.Point(10, 34);
            this.lblISBN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(69, 31);
            this.lblISBN.TabIndex = 0;
            this.lblISBN.Text = "ISBN:";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(158, 34);
            this.txtISBN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(254, 26);
            this.txtISBN.TabIndex = 1;
            // 
            // lblNombreLibro
            // 
            this.lblNombreLibro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNombreLibro.Location = new System.Drawing.Point(10, 80);
            this.lblNombreLibro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreLibro.Name = "lblNombreLibro";
            this.lblNombreLibro.Size = new System.Drawing.Size(140, 31);
            this.lblNombreLibro.TabIndex = 2;
            this.lblNombreLibro.Text = "Nombre Libro:";
            // 
            // txtNombreLibro
            // 
            this.txtNombreLibro.Location = new System.Drawing.Point(158, 80);
            this.txtNombreLibro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombreLibro.Name = "txtNombreLibro";
            this.txtNombreLibro.Size = new System.Drawing.Size(254, 26);
            this.txtNombreLibro.TabIndex = 3;
            // 
            // lblAutor
            // 
            this.lblAutor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAutor.Location = new System.Drawing.Point(10, 126);
            this.lblAutor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(69, 31);
            this.lblAutor.TabIndex = 4;
            this.lblAutor.Text = "Autor:";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(158, 126);
            this.txtAutor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(254, 26);
            this.txtAutor.TabIndex = 5;
            this.txtAutor.TextChanged += new System.EventHandler(this.txtAutor_TextChanged);
            // 
            // lblCategoria
            // 
            this.lblCategoria.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCategoria.Location = new System.Drawing.Point(10, 169);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(105, 31);
            this.lblCategoria.TabIndex = 6;
            this.lblCategoria.Text = "Categoría:";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(158, 169);
            this.txtCategoria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(254, 26);
            this.txtCategoria.TabIndex = 7;
            this.txtCategoria.TextChanged += new System.EventHandler(this.txtCategoria_TextChanged);
            // 
            // lblFechaPublicacion
            // 
            this.lblFechaPublicacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFechaPublicacion.Location = new System.Drawing.Point(470, 32);
            this.lblFechaPublicacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaPublicacion.Name = "lblFechaPublicacion";
            this.lblFechaPublicacion.Size = new System.Drawing.Size(171, 31);
            this.lblFechaPublicacion.TabIndex = 8;
            this.lblFechaPublicacion.Text = "Fecha Publicación:";
            // 
            // dtpFechaPublicacion
            // 
            this.dtpFechaPublicacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaPublicacion.Location = new System.Drawing.Point(662, 31);
            this.dtpFechaPublicacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFechaPublicacion.Name = "dtpFechaPublicacion";
            this.dtpFechaPublicacion.Size = new System.Drawing.Size(202, 26);
            this.dtpFechaPublicacion.TabIndex = 9;
            // 
            // lblNumeroPaginas
            // 
            this.lblNumeroPaginas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNumeroPaginas.Location = new System.Drawing.Point(519, 88);
            this.lblNumeroPaginas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroPaginas.Name = "lblNumeroPaginas";
            this.lblNumeroPaginas.Size = new System.Drawing.Size(122, 31);
            this.lblNumeroPaginas.TabIndex = 10;
            this.lblNumeroPaginas.Text = "N° Páginas:";
            // 
            // txtNumeroPaginas
            // 
            this.txtNumeroPaginas.Location = new System.Drawing.Point(652, 85);
            this.txtNumeroPaginas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumeroPaginas.Name = "txtNumeroPaginas";
            this.txtNumeroPaginas.Size = new System.Drawing.Size(212, 26);
            this.txtNumeroPaginas.TabIndex = 11;
            // 
            // lblEditorial
            // 
            this.lblEditorial.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEditorial.Location = new System.Drawing.Point(546, 138);
            this.lblEditorial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEditorial.Name = "lblEditorial";
            this.lblEditorial.Size = new System.Drawing.Size(94, 31);
            this.lblEditorial.TabIndex = 12;
            this.lblEditorial.Text = "Editorial:";
            // 
            // txtEditorial
            // 
            this.txtEditorial.Location = new System.Drawing.Point(650, 129);
            this.txtEditorial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEditorial.Name = "txtEditorial";
            this.txtEditorial.Size = new System.Drawing.Size(216, 26);
            this.txtEditorial.TabIndex = 13;
            this.txtEditorial.TextChanged += new System.EventHandler(this.txtEditorial_TextChanged);
            // 
            // lblFechaRegistro
            // 
            this.lblFechaRegistro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFechaRegistro.Location = new System.Drawing.Point(225, 234);
            this.lblFechaRegistro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaRegistro.Name = "lblFechaRegistro";
            this.lblFechaRegistro.Size = new System.Drawing.Size(152, 31);
            this.lblFechaRegistro.TabIndex = 16;
            this.lblFechaRegistro.Text = "Fecha Registro:";
            // 
            // lblFechaRegistroValor
            // 
            this.lblFechaRegistroValor.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblFechaRegistroValor.Location = new System.Drawing.Point(166, 402);
            this.lblFechaRegistroValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaRegistroValor.Name = "lblFechaRegistroValor";
            this.lblFechaRegistroValor.Size = new System.Drawing.Size(224, 31);
            this.lblFechaRegistroValor.TabIndex = 17;
            this.lblFechaRegistroValor.Text = "-";
            // 
            // dgvLibros
            // 
            this.dgvLibros.AllowUserToAddRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvLibros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLibros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLibros.BackgroundColor = System.Drawing.Color.White;
            this.dgvLibros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLibros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLibros.ColumnHeadersHeight = 34;
            this.dgvLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ISBN,
            this.colTitulo,
            this.Autor,
            this.Categoria,
            this.Editorial,
            this.FechaPub,
            this.Paginas,
            this.colPrecio});
            this.dgvLibros.EnableHeadersVisualStyles = false;
            this.dgvLibros.Location = new System.Drawing.Point(48, 362);
            this.dgvLibros.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.ReadOnly = true;
            this.dgvLibros.RowHeadersWidth = 62;
            this.dgvLibros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLibros.Size = new System.Drawing.Size(1146, 374);
            this.dgvLibros.TabIndex = 2;
            // 
            // ISBN
            // 
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.MinimumWidth = 8;
            this.ISBN.Name = "ISBN";
            this.ISBN.ReadOnly = true;
            // 
            // colTitulo
            // 
            this.colTitulo.HeaderText = "Titulo";
            this.colTitulo.MinimumWidth = 8;
            this.colTitulo.Name = "colTitulo";
            this.colTitulo.ReadOnly = true;
            // 
            // Autor
            // 
            this.Autor.HeaderText = "Autor";
            this.Autor.MinimumWidth = 8;
            this.Autor.Name = "Autor";
            this.Autor.ReadOnly = true;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoría";
            this.Categoria.MinimumWidth = 8;
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // Editorial
            // 
            this.Editorial.HeaderText = "Editorial";
            this.Editorial.MinimumWidth = 8;
            this.Editorial.Name = "Editorial";
            this.Editorial.ReadOnly = true;
            // 
            // FechaPub
            // 
            this.FechaPub.HeaderText = "Fecha Pub.";
            this.FechaPub.MinimumWidth = 8;
            this.FechaPub.Name = "FechaPub";
            this.FechaPub.ReadOnly = true;
            // 
            // Paginas
            // 
            this.Paginas.HeaderText = "Páginas";
            this.Paginas.MinimumWidth = 8;
            this.Paginas.Name = "Paginas";
            this.Paginas.ReadOnly = true;
            // 
            // colPrecio
            // 
            this.colPrecio.HeaderText = "Precio";
            this.colPrecio.MinimumWidth = 8;
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 286;
            this.pictureBox1.TabStop = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Image = global::BiblioTech.Properties.Resources.escoba__1_;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(948, 138);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(116, 38);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Image = global::BiblioTech.Properties.Resources.actualizar___copia;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(948, 29);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(116, 38);
            this.btnNuevo.TabIndex = 4;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(76)))));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = global::BiblioTech.Properties.Resources.guardar_el_archivo__1_;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(948, 80);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(116, 42);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Image = global::BiblioTech.Properties.Resources.eliminar__1_;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(948, 192);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(116, 42);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmAgregarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1575, 1000);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.grpDatos);
            this.Controls.Add(this.dgvLibros);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmAgregarLibro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Libro";
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label lblNombreLibro;
        private System.Windows.Forms.TextBox txtNombreLibro;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblFechaPublicacion;
        private System.Windows.Forms.DateTimePicker dtpFechaPublicacion;
        private System.Windows.Forms.Label lblNumeroPaginas;
        private System.Windows.Forms.TextBox txtNumeroPaginas;
        private System.Windows.Forms.Label lblEditorial;
        private System.Windows.Forms.Label lblFechaRegistro;
        private System.Windows.Forms.Label lblFechaRegistroValor;
        private System.Windows.Forms.DataGridView dgvLibros;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaPub;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaginas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEditorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAlias;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.TextBox txtEditorial;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Editorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaPub;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paginas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.ListBox lstCategorias;
        private System.Windows.Forms.ListBox lstEditoriales;
        private System.Windows.Forms.ListBox lstAutores;
    }
}
