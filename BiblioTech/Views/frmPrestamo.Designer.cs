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
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.lblSeleccionUsuario = new System.Windows.Forms.Label();
            this.grpUsuario = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtIdLibro = new System.Windows.Forms.TextBox();
            this.lblSeleccionLibro = new System.Windows.Forms.Label();
            this.grpDetallesPrestamo = new System.Windows.Forms.GroupBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.rchComentarios = new System.Windows.Forms.RichTextBox();
            this.dtFechaLimite = new System.Windows.Forms.DateTimePicker();
            this.lblFechaEntrega = new System.Windows.Forms.Label();
            this.grpAcciones = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardarPrestamo = new System.Windows.Forms.Button();
            this.grpPrestamo.SuspendLayout();
            this.grpUsuario.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.grpPrestamo.Location = new System.Drawing.Point(10, 9);
            this.grpPrestamo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpPrestamo.Name = "grpPrestamo";
            this.grpPrestamo.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpPrestamo.Size = new System.Drawing.Size(471, 674);
            this.grpPrestamo.TabIndex = 0;
            this.grpPrestamo.TabStop = false;
            this.grpPrestamo.Text = "Datos de Identificación";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(152, 408);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(294, 28);
            this.comboBox2.TabIndex = 7;
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Location = new System.Drawing.Point(28, 408);
            this.txtIdUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(91, 26);
            this.txtIdUsuario.TabIndex = 6;
            // 
            // lblSeleccionUsuario
            // 
            this.lblSeleccionUsuario.AutoSize = true;
            this.lblSeleccionUsuario.Location = new System.Drawing.Point(24, 360);
            this.lblSeleccionUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeleccionUsuario.Name = "lblSeleccionUsuario";
            this.lblSeleccionUsuario.Size = new System.Drawing.Size(217, 20);
            this.lblSeleccionUsuario.TabIndex = 5;
            this.lblSeleccionUsuario.Text = "Seleccionar Usuario (Cuenta)";
            // 
            // grpUsuario
            // 
            this.grpUsuario.Controls.Add(this.textBox1);
            this.grpUsuario.Controls.Add(this.lblApellido);
            this.grpUsuario.Controls.Add(this.lblNombre);
            this.grpUsuario.Controls.Add(this.txtNombre);
            this.grpUsuario.Location = new System.Drawing.Point(22, 448);
            this.grpUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpUsuario.Name = "grpUsuario";
            this.grpUsuario.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpUsuario.Size = new System.Drawing.Size(408, 217);
            this.grpUsuario.TabIndex = 4;
            this.grpUsuario.TabStop = false;
            this.grpUsuario.Text = "Datos del Usuario";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(129, 109);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(259, 26);
            this.textBox1.TabIndex = 3;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(33, 109);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(69, 20);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(28, 48);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 20);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(129, 48);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(259, 26);
            this.txtNombre.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAutor);
            this.groupBox1.Controls.Add(this.txtTitulo);
            this.groupBox1.Controls.Add(this.lblAutor);
            this.groupBox1.Controls.Add(this.lblTitulo);
            this.groupBox1.Location = new System.Drawing.Point(22, 143);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(408, 165);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Libro";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(114, 109);
            this.txtAutor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(274, 26);
            this.txtAutor.TabIndex = 3;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(114, 55);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(274, 26);
            this.txtTitulo.TabIndex = 2;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(28, 109);
            this.lblAutor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(52, 20);
            this.lblAutor.TabIndex = 1;
            this.lblAutor.Text = "Autor:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(24, 52);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(55, 20);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Título: ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(152, 85);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(294, 28);
            this.comboBox1.TabIndex = 2;
            // 
            // txtIdLibro
            // 
            this.txtIdLibro.Location = new System.Drawing.Point(32, 86);
            this.txtIdLibro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdLibro.Name = "txtIdLibro";
            this.txtIdLibro.Size = new System.Drawing.Size(88, 26);
            this.txtIdLibro.TabIndex = 1;
            this.txtIdLibro.Leave += new System.EventHandler(this.txtIdLibro_Leave);
            // 
            // lblSeleccionLibro
            // 
            this.lblSeleccionLibro.AutoSize = true;
            this.lblSeleccionLibro.Location = new System.Drawing.Point(24, 46);
            this.lblSeleccionLibro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeleccionLibro.Name = "lblSeleccionLibro";
            this.lblSeleccionLibro.Size = new System.Drawing.Size(162, 20);
            this.lblSeleccionLibro.TabIndex = 0;
            this.lblSeleccionLibro.Text = "Seleccionar Libro (ID)";
            // 
            // grpDetallesPrestamo
            // 
            this.grpDetallesPrestamo.Controls.Add(this.lblObservaciones);
            this.grpDetallesPrestamo.Controls.Add(this.rchComentarios);
            this.grpDetallesPrestamo.Controls.Add(this.dtFechaLimite);
            this.grpDetallesPrestamo.Controls.Add(this.lblFechaEntrega);
            this.grpDetallesPrestamo.Location = new System.Drawing.Point(507, 20);
            this.grpDetallesPrestamo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpDetallesPrestamo.Name = "grpDetallesPrestamo";
            this.grpDetallesPrestamo.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpDetallesPrestamo.Size = new System.Drawing.Size(366, 369);
            this.grpDetallesPrestamo.TabIndex = 1;
            this.grpDetallesPrestamo.TabStop = false;
            this.grpDetallesPrestamo.Text = "Detalles del Préstamo";
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(21, 155);
            this.lblObservaciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(187, 20);
            this.lblObservaciones.TabIndex = 2;
            this.lblObservaciones.Text = "Observaciones (opcional)";
            // 
            // rchComentarios
            // 
            this.rchComentarios.Location = new System.Drawing.Point(21, 185);
            this.rchComentarios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rchComentarios.Name = "rchComentarios";
            this.rchComentarios.Size = new System.Drawing.Size(319, 152);
            this.rchComentarios.TabIndex = 1;
            this.rchComentarios.Text = "";
            // 
            // dtFechaLimite
            // 
            this.dtFechaLimite.Location = new System.Drawing.Point(21, 74);
            this.dtFechaLimite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtFechaLimite.Name = "dtFechaLimite";
            this.dtFechaLimite.Size = new System.Drawing.Size(328, 26);
            this.dtFechaLimite.TabIndex = 0;
            // 
            // lblFechaEntrega
            // 
            this.lblFechaEntrega.AutoSize = true;
            this.lblFechaEntrega.Location = new System.Drawing.Point(10, 34);
            this.lblFechaEntrega.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaEntrega.Name = "lblFechaEntrega";
            this.lblFechaEntrega.Size = new System.Drawing.Size(187, 20);
            this.lblFechaEntrega.TabIndex = 0;
            this.lblFechaEntrega.Text = "Fecha de Entrega Límite:";
            // 
            // grpAcciones
            // 
            this.grpAcciones.Controls.Add(this.btnCancelar);
            this.grpAcciones.Controls.Add(this.btnGuardarPrestamo);
            this.grpAcciones.Location = new System.Drawing.Point(507, 537);
            this.grpAcciones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpAcciones.Name = "grpAcciones";
            this.grpAcciones.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpAcciones.Size = new System.Drawing.Size(366, 137);
            this.grpAcciones.TabIndex = 2;
            this.grpAcciones.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(190, 38);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(152, 46);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardarPrestamo
            // 
            this.btnGuardarPrestamo.Location = new System.Drawing.Point(9, 38);
            this.btnGuardarPrestamo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardarPrestamo.Name = "btnGuardarPrestamo";
            this.btnGuardarPrestamo.Size = new System.Drawing.Size(160, 46);
            this.btnGuardarPrestamo.TabIndex = 0;
            this.btnGuardarPrestamo.Text = "Guardar Préstamo";
            this.btnGuardarPrestamo.UseVisualStyleBackColor = true;
            // 
            // frmPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 702);
            this.Controls.Add(this.grpAcciones);
            this.Controls.Add(this.grpDetallesPrestamo);
            this.Controls.Add(this.grpPrestamo);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPrestamo";
            this.Text = "Prestamo";
            this.TransparencyKey = System.Drawing.Color.Silver;
            this.Load += new System.EventHandler(this.frmPrestamo_Load);
            this.grpPrestamo.ResumeLayout(false);
            this.grpPrestamo.PerformLayout();
            this.grpUsuario.ResumeLayout(false);
            this.grpUsuario.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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