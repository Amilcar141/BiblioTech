namespace BiblioTech.Views
{
    partial class frmFavoritos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFavoritos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpFavoritos = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtAliasUsuario = new System.Windows.Forms.TextBox();
            this.lblIdUsuario = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.lblIdLibro = new System.Windows.Forms.Label();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblAnio = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblAutor = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvFavoritos = new System.Windows.Forms.DataGridView();
            this.IdFavorito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAnio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFavoritos = new System.Windows.Forms.Label();
            this.grpFavoritos.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFavoritos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpFavoritos
            // 
            this.grpFavoritos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grpFavoritos.BackgroundImage")));
            this.grpFavoritos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grpFavoritos.Controls.Add(this.panel2);
            this.grpFavoritos.Controls.Add(this.panel1);
            this.grpFavoritos.Location = new System.Drawing.Point(3, 8);
            this.grpFavoritos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpFavoritos.Name = "grpFavoritos";
            this.grpFavoritos.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpFavoritos.Size = new System.Drawing.Size(1058, 680);
            this.grpFavoritos.TabIndex = 0;
            this.grpFavoritos.TabStop = false;
            this.grpFavoritos.Enter += new System.EventHandler(this.grpFavoritos_Enter);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SandyBrown;
            this.panel2.Controls.Add(this.btnLimpiar);
            this.panel2.Controls.Add(this.dtpFecha);
            this.panel2.Controls.Add(this.txtAliasUsuario);
            this.panel2.Controls.Add(this.lblIdUsuario);
            this.panel2.Controls.Add(this.txtISBN);
            this.panel2.Controls.Add(this.lblIdLibro);
            this.panel2.Controls.Add(this.txtGenero);
            this.panel2.Controls.Add(this.lblGenero);
            this.panel2.Controls.Add(this.lblAnio);
            this.panel2.Controls.Add(this.txtAutor);
            this.panel2.Controls.Add(this.btnEliminar);
            this.panel2.Controls.Add(this.btnAgregar);
            this.panel2.Controls.Add(this.lblAutor);
            this.panel2.Controls.Add(this.txtTitulo);
            this.panel2.Controls.Add(this.lblTitulo);
            this.panel2.Controls.Add(this.dgvFavoritos);
            this.panel2.Location = new System.Drawing.Point(21, 177);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1002, 483);
            this.panel2.TabIndex = 1;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnLimpiar.Image = global::BiblioTech.Properties.Resources.updates_16;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(361, 374);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(107, 40);
            this.btnLimpiar.TabIndex = 20;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(757, 225);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 26);
            this.dtpFecha.TabIndex = 19;
            // 
            // txtAliasUsuario
            // 
            this.txtAliasUsuario.Location = new System.Drawing.Point(757, 296);
            this.txtAliasUsuario.Name = "txtAliasUsuario";
            this.txtAliasUsuario.Size = new System.Drawing.Size(100, 26);
            this.txtAliasUsuario.TabIndex = 18;
            // 
            // lblIdUsuario
            // 
            this.lblIdUsuario.AutoSize = true;
            this.lblIdUsuario.Location = new System.Drawing.Point(632, 302);
            this.lblIdUsuario.Name = "lblIdUsuario";
            this.lblIdUsuario.Size = new System.Drawing.Size(110, 20);
            this.lblIdUsuario.TabIndex = 17;
            this.lblIdUsuario.Text = "Alias Usuario :";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(454, 293);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(100, 26);
            this.txtISBN.TabIndex = 16;
            // 
            // lblIdLibro
            // 
            this.lblIdLibro.AutoSize = true;
            this.lblIdLibro.Location = new System.Drawing.Point(376, 296);
            this.lblIdLibro.Name = "lblIdLibro";
            this.lblIdLibro.Size = new System.Drawing.Size(47, 20);
            this.lblIdLibro.TabIndex = 15;
            this.lblIdLibro.Text = "ISBN";
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(101, 293);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(189, 26);
            this.txtGenero.TabIndex = 14;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(29, 290);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(71, 20);
            this.lblGenero.TabIndex = 13;
            this.lblGenero.Text = "Genero :";
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(709, 227);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(42, 20);
            this.lblAnio.TabIndex = 11;
            this.lblAnio.Text = "Año:";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(454, 230);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(182, 26);
            this.txtAutor.TabIndex = 10;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Image = global::BiblioTech.Properties.Resources.borrar;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(212, 372);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(113, 42);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Lime;
            this.btnAgregar.Image = global::BiblioTech.Properties.Resources.salvar;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(76, 372);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(109, 42);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(367, 230);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(56, 20);
            this.lblAutor.TabIndex = 6;
            this.lblAutor.Text = "Autor :";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(101, 227);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(201, 26);
            this.txtTitulo.TabIndex = 5;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(29, 227);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(55, 20);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Titulo :";
            // 
            // dgvFavoritos
            // 
            this.dgvFavoritos.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvFavoritos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFavoritos.BackgroundColor = System.Drawing.Color.White;
            this.dgvFavoritos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFavoritos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFavoritos.ColumnHeadersHeight = 34;
            this.dgvFavoritos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdFavorito,
            this.colIdLibro,
            this.colIdUsuario,
            this.colTitulo,
            this.colAutor,
            this.colAnio,
            this.colGenero});
            this.dgvFavoritos.EnableHeadersVisualStyles = false;
            this.dgvFavoritos.Location = new System.Drawing.Point(33, 47);
            this.dgvFavoritos.Name = "dgvFavoritos";
            this.dgvFavoritos.ReadOnly = true;
            this.dgvFavoritos.RowHeadersWidth = 62;
            this.dgvFavoritos.RowTemplate.Height = 28;
            this.dgvFavoritos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFavoritos.Size = new System.Drawing.Size(894, 147);
            this.dgvFavoritos.TabIndex = 2;
            // 
            // IdFavorito
            // 
            this.IdFavorito.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.IdFavorito.HeaderText = "ID Favoritos";
            this.IdFavorito.MinimumWidth = 8;
            this.IdFavorito.Name = "IdFavorito";
            this.IdFavorito.ReadOnly = true;
            this.IdFavorito.Width = 150;
            // 
            // colIdLibro
            // 
            this.colIdLibro.HeaderText = "ISBN";
            this.colIdLibro.MinimumWidth = 8;
            this.colIdLibro.Name = "colIdLibro";
            this.colIdLibro.ReadOnly = true;
            this.colIdLibro.Width = 114;
            // 
            // colIdUsuario
            // 
            this.colIdUsuario.HeaderText = "AliasUsuario";
            this.colIdUsuario.MinimumWidth = 8;
            this.colIdUsuario.Name = "colIdUsuario";
            this.colIdUsuario.ReadOnly = true;
            this.colIdUsuario.Width = 113;
            // 
            // colTitulo
            // 
            this.colTitulo.HeaderText = "Titulo";
            this.colTitulo.MinimumWidth = 8;
            this.colTitulo.Name = "colTitulo";
            this.colTitulo.ReadOnly = true;
            this.colTitulo.Width = 114;
            // 
            // colAutor
            // 
            this.colAutor.HeaderText = "Autor";
            this.colAutor.MinimumWidth = 8;
            this.colAutor.Name = "colAutor";
            this.colAutor.ReadOnly = true;
            this.colAutor.Width = 114;
            // 
            // colAnio
            // 
            this.colAnio.HeaderText = "Año";
            this.colAnio.MinimumWidth = 8;
            this.colAnio.Name = "colAnio";
            this.colAnio.ReadOnly = true;
            this.colAnio.Width = 113;
            // 
            // colGenero
            // 
            this.colGenero.HeaderText = "Genero";
            this.colGenero.MinimumWidth = 8;
            this.colGenero.Name = "colGenero";
            this.colGenero.ReadOnly = true;
            this.colGenero.Width = 114;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Peru;
            this.panel1.Controls.Add(this.lblFavoritos);
            this.panel1.Location = new System.Drawing.Point(39, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(951, 55);
            this.panel1.TabIndex = 0;
            // 
            // lblFavoritos
            // 
            this.lblFavoritos.AutoSize = true;
            this.lblFavoritos.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFavoritos.ForeColor = System.Drawing.Color.Black;
            this.lblFavoritos.Location = new System.Drawing.Point(237, 18);
            this.lblFavoritos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFavoritos.Name = "lblFavoritos";
            this.lblFavoritos.Size = new System.Drawing.Size(455, 35);
            this.lblFavoritos.TabIndex = 0;
            this.lblFavoritos.Text = "FAVORITOS DE BIBLIOTECH";
            this.lblFavoritos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmFavoritos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 680);
            this.Controls.Add(this.grpFavoritos);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmFavoritos";
            this.Text = "Favoritos";
            this.Load += new System.EventHandler(this.frmFavoritos_Load);
            this.grpFavoritos.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFavoritos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFavoritos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFavoritos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvFavoritos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.Label lblIdUsuario;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label lblIdLibro;
        private System.Windows.Forms.TextBox txtAliasUsuario;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdFavorito;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAnio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGenero;
    }
}