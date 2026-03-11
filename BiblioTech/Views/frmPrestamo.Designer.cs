namespace BiblioTech.Views
{
    partial class frmPrestamo
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
            this.grpPrestamo = new System.Windows.Forms.GroupBox();
            this.lblSeleccionLibro = new System.Windows.Forms.Label();
            this.txtIdLibro = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.grpUsuario = new System.Windows.Forms.GroupBox();
            this.lblSeleccionUsuario = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.grpDetallesPrestamo = new System.Windows.Forms.GroupBox();
            this.lblFechaEntrega = new System.Windows.Forms.Label();
            this.dtFechaLimite = new System.Windows.Forms.DateTimePicker();
            this.rchComentarios = new System.Windows.Forms.RichTextBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.grpAcciones = new System.Windows.Forms.GroupBox();
            this.btnGuardarPrestamo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpPrestamo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpUsuario.SuspendLayout();
            this.grpDetallesPrestamo.SuspendLayout();
            this.grpAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPrestamo
            // 
            this.grpPrestamo.BackColor = System.Drawing.Color.Transparent;
            this.grpPrestamo.Controls.Add(this.comboBox2);
            this.grpPrestamo.Controls.Add(this.txtIdUsuario);
            this.grpPrestamo.Controls.Add(this.lblSeleccionUsuario);
            this.grpPrestamo.Controls.Add(this.grpUsuario);
            this.grpPrestamo.Controls.Add(this.groupBox1);
            this.grpPrestamo.Controls.Add(this.comboBox1);
            this.grpPrestamo.Controls.Add(this.txtIdLibro);
            this.grpPrestamo.Controls.Add(this.lblSeleccionLibro);
            this.grpPrestamo.Location = new System.Drawing.Point(7, 6);
            this.grpPrestamo.Name = "grpPrestamo";
            this.grpPrestamo.Size = new System.Drawing.Size(314, 438);
            this.grpPrestamo.TabIndex = 0;
            this.grpPrestamo.TabStop = false;
            this.grpPrestamo.Text = "Datos de Identificación";
            // 
            // lblSeleccionLibro
            // 
            this.lblSeleccionLibro.AutoSize = true;
            this.lblSeleccionLibro.Location = new System.Drawing.Point(16, 30);
            this.lblSeleccionLibro.Name = "lblSeleccionLibro";
            this.lblSeleccionLibro.Size = new System.Drawing.Size(109, 13);
            this.lblSeleccionLibro.TabIndex = 0;
            this.lblSeleccionLibro.Text = "Seleccionar Libro (ID)";
            // 
            // txtIdLibro
            // 
            this.txtIdLibro.Location = new System.Drawing.Point(21, 56);
            this.txtIdLibro.Name = "txtIdLibro";
            this.txtIdLibro.Size = new System.Drawing.Size(60, 20);
            this.txtIdLibro.TabIndex = 1;
            this.txtIdLibro.Leave += new System.EventHandler(this.txtIdLibro_Leave);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(101, 55);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(197, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAutor);
            this.groupBox1.Controls.Add(this.txtTitulo);
            this.groupBox1.Controls.Add(this.lblAutor);
            this.groupBox1.Controls.Add(this.lblTitulo);
            this.groupBox1.Location = new System.Drawing.Point(15, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 107);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Libro";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(16, 34);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(41, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Título: ";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(19, 71);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(35, 13);
            this.lblAutor.TabIndex = 1;
            this.lblAutor.Text = "Autor:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(76, 36);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(184, 20);
            this.txtTitulo.TabIndex = 2;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(76, 71);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(184, 20);
            this.txtAutor.TabIndex = 3;
            // 
            // grpUsuario
            // 
            this.grpUsuario.Controls.Add(this.textBox1);
            this.grpUsuario.Controls.Add(this.lblApellido);
            this.grpUsuario.Controls.Add(this.lblNombre);
            this.grpUsuario.Controls.Add(this.txtNombre);
            this.grpUsuario.Location = new System.Drawing.Point(15, 291);
            this.grpUsuario.Name = "grpUsuario";
            this.grpUsuario.Size = new System.Drawing.Size(272, 141);
            this.grpUsuario.TabIndex = 4;
            this.grpUsuario.TabStop = false;
            this.grpUsuario.Text = "Datos del Usuario";
            // 
            // lblSeleccionUsuario
            // 
            this.lblSeleccionUsuario.AutoSize = true;
            this.lblSeleccionUsuario.Location = new System.Drawing.Point(16, 234);
            this.lblSeleccionUsuario.Name = "lblSeleccionUsuario";
            this.lblSeleccionUsuario.Size = new System.Drawing.Size(145, 13);
            this.lblSeleccionUsuario.TabIndex = 5;
            this.lblSeleccionUsuario.Text = "Seleccionar Usuario (Cuenta)";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(86, 31);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(174, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(19, 31);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Location = new System.Drawing.Point(19, 265);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(62, 20);
            this.txtIdUsuario.TabIndex = 6;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(101, 265);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(197, 21);
            this.comboBox2.TabIndex = 7;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(22, 71);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 20);
            this.textBox1.TabIndex = 3;
            // 
            // grpDetallesPrestamo
            // 
            this.grpDetallesPrestamo.Controls.Add(this.lblObservaciones);
            this.grpDetallesPrestamo.Controls.Add(this.rchComentarios);
            this.grpDetallesPrestamo.Controls.Add(this.dtFechaLimite);
            this.grpDetallesPrestamo.Controls.Add(this.lblFechaEntrega);
            this.grpDetallesPrestamo.Location = new System.Drawing.Point(338, 13);
            this.grpDetallesPrestamo.Name = "grpDetallesPrestamo";
            this.grpDetallesPrestamo.Size = new System.Drawing.Size(244, 240);
            this.grpDetallesPrestamo.TabIndex = 1;
            this.grpDetallesPrestamo.TabStop = false;
            this.grpDetallesPrestamo.Text = "Detalles del Préstamo";
            // 
            // lblFechaEntrega
            // 
            this.lblFechaEntrega.AutoSize = true;
            this.lblFechaEntrega.Location = new System.Drawing.Point(7, 22);
            this.lblFechaEntrega.Name = "lblFechaEntrega";
            this.lblFechaEntrega.Size = new System.Drawing.Size(127, 13);
            this.lblFechaEntrega.TabIndex = 0;
            this.lblFechaEntrega.Text = "Fecha de Entrega Límite:";
            // 
            // dtFechaLimite
            // 
            this.dtFechaLimite.Location = new System.Drawing.Point(14, 48);
            this.dtFechaLimite.Name = "dtFechaLimite";
            this.dtFechaLimite.Size = new System.Drawing.Size(220, 20);
            this.dtFechaLimite.TabIndex = 0;
            // 
            // rchComentarios
            // 
            this.rchComentarios.Location = new System.Drawing.Point(14, 120);
            this.rchComentarios.Name = "rchComentarios";
            this.rchComentarios.Size = new System.Drawing.Size(214, 100);
            this.rchComentarios.TabIndex = 1;
            this.rchComentarios.Text = "";
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(14, 101);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(127, 13);
            this.lblObservaciones.TabIndex = 2;
            this.lblObservaciones.Text = "Observaciones (opcional)";
            // 
            // grpAcciones
            // 
            this.grpAcciones.Controls.Add(this.btnCancelar);
            this.grpAcciones.Controls.Add(this.btnGuardarPrestamo);
            this.grpAcciones.Location = new System.Drawing.Point(338, 349);
            this.grpAcciones.Name = "grpAcciones";
            this.grpAcciones.Size = new System.Drawing.Size(244, 89);
            this.grpAcciones.TabIndex = 2;
            this.grpAcciones.TabStop = false;
            // 
            // btnGuardarPrestamo
            // 
            this.btnGuardarPrestamo.Location = new System.Drawing.Point(6, 25);
            this.btnGuardarPrestamo.Name = "btnGuardarPrestamo";
            this.btnGuardarPrestamo.Size = new System.Drawing.Size(107, 30);
            this.btnGuardarPrestamo.TabIndex = 0;
            this.btnGuardarPrestamo.Text = "Guardar Préstamo";
            this.btnGuardarPrestamo.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(127, 25);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 30);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 456);
            this.Controls.Add(this.grpAcciones);
            this.Controls.Add(this.grpDetallesPrestamo);
            this.Controls.Add(this.grpPrestamo);
            this.Name = "frmPrestamo";
            this.Text = "Prestamo";
            this.TransparencyKey = System.Drawing.Color.Silver;
            this.grpPrestamo.ResumeLayout(false);
            this.grpPrestamo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpUsuario.ResumeLayout(false);
            this.grpUsuario.PerformLayout();
            this.grpDetallesPrestamo.ResumeLayout(false);
            this.grpDetallesPrestamo.PerformLayout();
            this.grpAcciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPrestamo;
        private System.Windows.Forms.TextBox txtIdLibro;
        private System.Windows.Forms.Label lblSeleccionLibro;
        private System.Windows.Forms.GroupBox grpUsuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblSeleccionUsuario;
        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.GroupBox grpDetallesPrestamo;
        private System.Windows.Forms.Label lblFechaEntrega;
        private System.Windows.Forms.RichTextBox rchComentarios;
        private System.Windows.Forms.DateTimePicker dtFechaLimite;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.GroupBox grpAcciones;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardarPrestamo;
    }
}