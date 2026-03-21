namespace BiblioTech.Views.Prestamos
{
    partial class FrmRegistrarPrestamo
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
            this.grpLibro = new System.Windows.Forms.GroupBox();
            this.lblLibro = new System.Windows.Forms.Label();
            this.cmbLibro = new System.Windows.Forms.ComboBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.lblEditorial = new System.Windows.Forms.Label();
            this.txtEditorial = new System.Windows.Forms.TextBox();
            this.grpUsuario = new System.Windows.Forms.GroupBox();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.grpFecha = new System.Windows.Forms.GroupBox();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblFechaInicioVal = new System.Windows.Forms.Label();
            this.lblFechaLimite = new System.Windows.Forms.Label();
            this.dtpFechaLimite = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpLibro.SuspendLayout();
            this.grpUsuario.SuspendLayout();
            this.grpFecha.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Lucida Handwriting", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(18, 14);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(840, 65);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "REGISTRAR PRESTAMO";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpLibro
            // 
            this.grpLibro.BackColor = System.Drawing.Color.SaddleBrown;
            this.grpLibro.Controls.Add(this.lblLibro);
            this.grpLibro.Controls.Add(this.cmbLibro);
            this.grpLibro.Controls.Add(this.lblISBN);
            this.grpLibro.Controls.Add(this.txtISBN);
            this.grpLibro.Controls.Add(this.lblAutor);
            this.grpLibro.Controls.Add(this.txtAutor);
            this.grpLibro.Controls.Add(this.lblCategoria);
            this.grpLibro.Controls.Add(this.txtCategoria);
            this.grpLibro.Controls.Add(this.lblEditorial);
            this.grpLibro.Controls.Add(this.txtEditorial);
            this.grpLibro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpLibro.Location = new System.Drawing.Point(18, 92);
            this.grpLibro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpLibro.Name = "grpLibro";
            this.grpLibro.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpLibro.Size = new System.Drawing.Size(840, 308);
            this.grpLibro.TabIndex = 1;
            this.grpLibro.TabStop = false;
            this.grpLibro.Text = "Datos del Libro";
            // 
            // lblLibro
            // 
            this.lblLibro.Location = new System.Drawing.Point(15, 38);
            this.lblLibro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLibro.Name = "lblLibro";
            this.lblLibro.Size = new System.Drawing.Size(172, 34);
            this.lblLibro.TabIndex = 0;
            this.lblLibro.Text = "Libro:";
            // 
            // cmbLibro
            // 
            this.cmbLibro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLibro.Location = new System.Drawing.Point(195, 35);
            this.cmbLibro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbLibro.Name = "cmbLibro";
            this.cmbLibro.Size = new System.Drawing.Size(620, 33);
            this.cmbLibro.TabIndex = 1;
            this.cmbLibro.SelectedIndexChanged += new System.EventHandler(this.cmbLibro_SelectedIndexChanged);
            // 
            // lblISBN
            // 
            this.lblISBN.Location = new System.Drawing.Point(15, 89);
            this.lblISBN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(172, 34);
            this.lblISBN.TabIndex = 2;
            this.lblISBN.Text = "ISBN:";
            // 
            // txtISBN
            // 
            this.txtISBN.BackColor = System.Drawing.Color.LightGray;
            this.txtISBN.Location = new System.Drawing.Point(195, 86);
            this.txtISBN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.ReadOnly = true;
            this.txtISBN.Size = new System.Drawing.Size(620, 31);
            this.txtISBN.TabIndex = 3;
            // 
            // lblAutor
            // 
            this.lblAutor.Location = new System.Drawing.Point(15, 143);
            this.lblAutor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(172, 34);
            this.lblAutor.TabIndex = 4;
            this.lblAutor.Text = "Autor:";
            // 
            // txtAutor
            // 
            this.txtAutor.BackColor = System.Drawing.Color.LightGray;
            this.txtAutor.Location = new System.Drawing.Point(195, 140);
            this.txtAutor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.ReadOnly = true;
            this.txtAutor.Size = new System.Drawing.Size(620, 31);
            this.txtAutor.TabIndex = 5;
            // 
            // lblCategoria
            // 
            this.lblCategoria.Location = new System.Drawing.Point(15, 197);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(172, 34);
            this.lblCategoria.TabIndex = 6;
            this.lblCategoria.Text = "Categoria:";
            // 
            // txtCategoria
            // 
            this.txtCategoria.BackColor = System.Drawing.Color.LightGray;
            this.txtCategoria.Location = new System.Drawing.Point(195, 194);
            this.txtCategoria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.ReadOnly = true;
            this.txtCategoria.Size = new System.Drawing.Size(298, 31);
            this.txtCategoria.TabIndex = 7;
            // 
            // lblEditorial
            // 
            this.lblEditorial.Location = new System.Drawing.Point(518, 197);
            this.lblEditorial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEditorial.Name = "lblEditorial";
            this.lblEditorial.Size = new System.Drawing.Size(120, 34);
            this.lblEditorial.TabIndex = 8;
            this.lblEditorial.Text = "Editorial:";
            // 
            // txtEditorial
            // 
            this.txtEditorial.BackColor = System.Drawing.Color.LightGray;
            this.txtEditorial.Location = new System.Drawing.Point(645, 194);
            this.txtEditorial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEditorial.Name = "txtEditorial";
            this.txtEditorial.ReadOnly = true;
            this.txtEditorial.Size = new System.Drawing.Size(170, 31);
            this.txtEditorial.TabIndex = 9;
            // 
            // grpUsuario
            // 
            this.grpUsuario.BackColor = System.Drawing.Color.SaddleBrown;
            this.grpUsuario.Controls.Add(this.lblNombreUsuario);
            this.grpUsuario.Controls.Add(this.txtNombreUsuario);
            this.grpUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpUsuario.Location = new System.Drawing.Point(18, 418);
            this.grpUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpUsuario.Name = "grpUsuario";
            this.grpUsuario.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpUsuario.Size = new System.Drawing.Size(840, 100);
            this.grpUsuario.TabIndex = 2;
            this.grpUsuario.TabStop = false;
            this.grpUsuario.Text = "Usuario (Nombre completo)";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Location = new System.Drawing.Point(15, 43);
            this.lblNombreUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(172, 34);
            this.lblNombreUsuario.TabIndex = 0;
            this.lblNombreUsuario.Text = "Nombre:";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(195, 40);
            this.txtNombreUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(620, 31);
            this.txtNombreUsuario.TabIndex = 1;
            // 
            // grpFecha
            // 
            this.grpFecha.BackColor = System.Drawing.Color.SaddleBrown;
            this.grpFecha.Controls.Add(this.lblFechaInicio);
            this.grpFecha.Controls.Add(this.lblFechaInicioVal);
            this.grpFecha.Controls.Add(this.lblFechaLimite);
            this.grpFecha.Controls.Add(this.dtpFechaLimite);
            this.grpFecha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpFecha.Location = new System.Drawing.Point(18, 537);
            this.grpFecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpFecha.Name = "grpFecha";
            this.grpFecha.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpFecha.Size = new System.Drawing.Size(840, 123);
            this.grpFecha.TabIndex = 3;
            this.grpFecha.TabStop = false;
            this.grpFecha.Text = "Fechas del Prestamo";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.Location = new System.Drawing.Point(15, 43);
            this.lblFechaInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(172, 34);
            this.lblFechaInicio.TabIndex = 0;
            this.lblFechaInicio.Text = "Fecha Inicio:";
            // 
            // lblFechaInicioVal
            // 
            this.lblFechaInicioVal.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblFechaInicioVal.Location = new System.Drawing.Point(195, 43);
            this.lblFechaInicioVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaInicioVal.Name = "lblFechaInicioVal";
            this.lblFechaInicioVal.Size = new System.Drawing.Size(300, 34);
            this.lblFechaInicioVal.TabIndex = 1;
            this.lblFechaInicioVal.Text = "21/03/2026";
            // 
            // lblFechaLimite
            // 
            this.lblFechaLimite.Location = new System.Drawing.Point(15, 82);
            this.lblFechaLimite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaLimite.Name = "lblFechaLimite";
            this.lblFechaLimite.Size = new System.Drawing.Size(172, 34);
            this.lblFechaLimite.TabIndex = 2;
            this.lblFechaLimite.Text = "Fecha Limite:";
            // 
            // dtpFechaLimite
            // 
            this.dtpFechaLimite.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaLimite.Location = new System.Drawing.Point(195, 78);
            this.dtpFechaLimite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFechaLimite.Name = "dtpFechaLimite";
            this.dtpFechaLimite.Size = new System.Drawing.Size(298, 31);
            this.dtpFechaLimite.TabIndex = 3;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(76)))));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = global::BiblioTech.Properties.Resources.guardar_el_archivo;
            this.btnGuardar.Location = new System.Drawing.Point(18, 685);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(180, 58);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Image = global::BiblioTech.Properties.Resources.escoba;
            this.btnLimpiar.Location = new System.Drawing.Point(218, 685);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(180, 58);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Image = global::BiblioTech.Properties.Resources.eliminar;
            this.btnCancelar.Location = new System.Drawing.Point(417, 685);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(180, 58);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmRegistrarPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(876, 765);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.grpLibro);
            this.Controls.Add(this.grpUsuario);
            this.Controls.Add(this.grpFecha);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmRegistrarPrestamo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Prestamo";
            this.Load += new System.EventHandler(this.FrmRegistrarPrestamo_Load);
            this.grpLibro.ResumeLayout(false);
            this.grpLibro.PerformLayout();
            this.grpUsuario.ResumeLayout(false);
            this.grpUsuario.PerformLayout();
            this.grpFecha.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grpLibro;
        private System.Windows.Forms.Label lblLibro;
        private System.Windows.Forms.ComboBox cmbLibro;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label lblEditorial;
        private System.Windows.Forms.TextBox txtEditorial;
        private System.Windows.Forms.GroupBox grpUsuario;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.GroupBox grpFecha;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblFechaInicioVal;
        private System.Windows.Forms.Label lblFechaLimite;
        private System.Windows.Forms.DateTimePicker dtpFechaLimite;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
