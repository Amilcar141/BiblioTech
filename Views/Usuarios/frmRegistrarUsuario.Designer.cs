namespace BiblioTech.Views.Usuarios
{
    partial class frmRegistrarUsuario
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlDatos = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnVerPassword = new System.Windows.Forms.Button();
            this.gbxRol = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rbtnLector = new System.Windows.Forms.RadioButton();
            this.rbtnAdministrador = new System.Windows.Forms.RadioButton();
            this.gbxEstado = new System.Windows.Forms.GroupBox();
            this.rbtnActivo = new System.Windows.Forms.RadioButton();
            this.rbtnInactivo = new System.Windows.Forms.RadioButton();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnlDatos.SuspendLayout();
            this.gbxRol.SuspendLayout();
            this.gbxEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Lucida Handwriting", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(143, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(462, 65);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "REGISTRAR USUARIO";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlDatos
            // 
            this.pnlDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(133)))), ((int)(((byte)(82)))));
            this.pnlDatos.Controls.Add(this.label3);
            this.pnlDatos.Controls.Add(this.txtNombre);
            this.pnlDatos.Controls.Add(this.label4);
            this.pnlDatos.Controls.Add(this.txtApellidos);
            this.pnlDatos.Controls.Add(this.label5);
            this.pnlDatos.Controls.Add(this.txtCorreo);
            this.pnlDatos.Controls.Add(this.label6);
            this.pnlDatos.Controls.Add(this.txtPassword);
            this.pnlDatos.Controls.Add(this.btnVerPassword);
            this.pnlDatos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.pnlDatos.ForeColor = System.Drawing.Color.White;
            this.pnlDatos.Location = new System.Drawing.Point(18, 92);
            this.pnlDatos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlDatos.Size = new System.Drawing.Size(660, 347);
            this.pnlDatos.TabIndex = 1;
            this.pnlDatos.TabStop = false;
            this.pnlDatos.Text = "Datos de la Cuenta";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(15, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 34);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(165, 43);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(463, 31);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(15, 108);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 34);
            this.label4.TabIndex = 2;
            this.label4.Text = "Apellidos:";
            // 
            // txtApellidos
            // 
            this.txtApellidos.BackColor = System.Drawing.Color.White;
            this.txtApellidos.Location = new System.Drawing.Point(165, 105);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(463, 31);
            this.txtApellidos.TabIndex = 3;
            this.txtApellidos.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(15, 169);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 34);
            this.label5.TabIndex = 4;
            this.label5.Text = "Correo:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.White;
            this.txtCorreo.Location = new System.Drawing.Point(165, 166);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(463, 31);
            this.txtCorreo.TabIndex = 5;
            this.txtCorreo.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(15, 238);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 34);
            this.label6.TabIndex = 6;
            this.label6.Text = "Contrasena:";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(165, 235);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(358, 31);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // btnVerPassword
            // 
            this.btnVerPassword.BackColor = System.Drawing.Color.Chocolate;
            this.btnVerPassword.ForeColor = System.Drawing.Color.White;
            this.btnVerPassword.Location = new System.Drawing.Point(537, 232);
            this.btnVerPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVerPassword.Name = "btnVerPassword";
            this.btnVerPassword.Size = new System.Drawing.Size(93, 40);
            this.btnVerPassword.TabIndex = 8;
            this.btnVerPassword.Text = "○";
            this.btnVerPassword.UseVisualStyleBackColor = false;
            this.btnVerPassword.Click += new System.EventHandler(this.btnVerPassword_Click);
            // 
            // gbxRol
            // 
            this.gbxRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(160)))), ((int)(((byte)(100)))));
            this.gbxRol.Controls.Add(this.label8);
            this.gbxRol.Controls.Add(this.rbtnLector);
            this.gbxRol.Controls.Add(this.rbtnAdministrador);
            this.gbxRol.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gbxRol.ForeColor = System.Drawing.Color.White;
            this.gbxRol.Location = new System.Drawing.Point(15, 308);
            this.gbxRol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbxRol.Name = "gbxRol";
            this.gbxRol.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbxRol.Size = new System.Drawing.Size(630, 131);
            this.gbxRol.TabIndex = 9;
            this.gbxRol.TabStop = false;
            this.gbxRol.Text = "Rol del Usuario";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(15, 34);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 34);
            this.label8.TabIndex = 0;
            this.label8.Text = "Rol:";
            // 
            // rbtnLector
            // 
            this.rbtnLector.AutoSize = true;
            this.rbtnLector.Checked = true;
            this.rbtnLector.ForeColor = System.Drawing.Color.White;
            this.rbtnLector.Location = new System.Drawing.Point(135, 31);
            this.rbtnLector.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtnLector.Name = "rbtnLector";
            this.rbtnLector.Size = new System.Drawing.Size(90, 29);
            this.rbtnLector.TabIndex = 1;
            this.rbtnLector.TabStop = true;
            this.rbtnLector.Text = "Lector";
            // 
            // rbtnAdministrador
            // 
            this.rbtnAdministrador.AutoSize = true;
            this.rbtnAdministrador.ForeColor = System.Drawing.Color.White;
            this.rbtnAdministrador.Location = new System.Drawing.Point(300, 31);
            this.rbtnAdministrador.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtnAdministrador.Name = "rbtnAdministrador";
            this.rbtnAdministrador.Size = new System.Drawing.Size(159, 29);
            this.rbtnAdministrador.TabIndex = 2;
            this.rbtnAdministrador.Text = "Administrador";
            // 
            // gbxEstado
            // 
            this.gbxEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(133)))), ((int)(((byte)(82)))));
            this.gbxEstado.Controls.Add(this.rbtnActivo);
            this.gbxEstado.Controls.Add(this.rbtnInactivo);
            this.gbxEstado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gbxEstado.ForeColor = System.Drawing.Color.White;
            this.gbxEstado.Location = new System.Drawing.Point(705, 92);
            this.gbxEstado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbxEstado.Name = "gbxEstado";
            this.gbxEstado.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbxEstado.Size = new System.Drawing.Size(360, 131);
            this.gbxEstado.TabIndex = 3;
            this.gbxEstado.TabStop = false;
            this.gbxEstado.Text = "Estado";
            // 
            // rbtnActivo
            // 
            this.rbtnActivo.AutoSize = true;
            this.rbtnActivo.Checked = true;
            this.rbtnActivo.ForeColor = System.Drawing.Color.White;
            this.rbtnActivo.Location = new System.Drawing.Point(22, 43);
            this.rbtnActivo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtnActivo.Name = "rbtnActivo";
            this.rbtnActivo.Size = new System.Drawing.Size(92, 29);
            this.rbtnActivo.TabIndex = 0;
            this.rbtnActivo.TabStop = true;
            this.rbtnActivo.Text = "Activo";
            // 
            // rbtnInactivo
            // 
            this.rbtnInactivo.AutoSize = true;
            this.rbtnInactivo.ForeColor = System.Drawing.Color.White;
            this.rbtnInactivo.Location = new System.Drawing.Point(150, 43);
            this.rbtnInactivo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtnInactivo.Name = "rbtnInactivo";
            this.rbtnInactivo.Size = new System.Drawing.Size(106, 29);
            this.rbtnInactivo.TabIndex = 1;
            this.rbtnInactivo.Text = "Inactivo";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(76)))));
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = global::BiblioTech.Properties.Resources.guardar_el_archivo;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(18, 469);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(165, 58);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Image = global::BiblioTech.Properties.Resources.updates_16;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(201, 469);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(165, 58);
            this.btnNuevo.TabIndex = 11;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Image = global::BiblioTech.Properties.Resources.escoba;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(384, 469);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(165, 58);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Image = global::BiblioTech.Properties.Resources.eliminar;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(567, 469);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(165, 58);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmRegistrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1176, 546);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.gbxEstado);
            this.Controls.Add(this.gbxRol);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmRegistrarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Usuario";
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            this.gbxRol.ResumeLayout(false);
            this.gbxRol.PerformLayout();
            this.gbxEstado.ResumeLayout(false);
            this.gbxEstado.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox pnlDatos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnVerPassword;
        private System.Windows.Forms.GroupBox gbxRol;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rbtnLector;
        private System.Windows.Forms.RadioButton rbtnAdministrador;
        private System.Windows.Forms.GroupBox gbxEstado;
        private System.Windows.Forms.RadioButton rbtnActivo;
        private System.Windows.Forms.RadioButton rbtnInactivo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
