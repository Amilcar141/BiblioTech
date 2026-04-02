namespace BiblioTech
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.grpPrincipal = new System.Windows.Forms.GroupBox();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.lblRegistro = new System.Windows.Forms.LinkLabel();
            this.lblContrasenia = new System.Windows.Forms.Label();
            this.lblCuenta = new System.Windows.Forms.Label();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.lblPregunta = new System.Windows.Forms.Label();
            this.grpPrincipal.SuspendLayout();
            this.pnlPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPrincipal
            // 
            this.grpPrincipal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grpPrincipal.BackgroundImage")));
            this.grpPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grpPrincipal.Controls.Add(this.pnlPrincipal);
            this.grpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.grpPrincipal.Name = "grpPrincipal";
            this.grpPrincipal.Size = new System.Drawing.Size(762, 458);
            this.grpPrincipal.TabIndex = 0;
            this.grpPrincipal.TabStop = false;
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlPrincipal.BackColor = System.Drawing.Color.BurlyWood;
            this.pnlPrincipal.Controls.Add(this.lblPregunta);
            this.pnlPrincipal.Controls.Add(this.txtContrasenia);
            this.pnlPrincipal.Controls.Add(this.txtCuenta);
            this.pnlPrincipal.Controls.Add(this.btnIniciarSesion);
            this.pnlPrincipal.Controls.Add(this.lblRegistro);
            this.pnlPrincipal.Controls.Add(this.lblContrasenia);
            this.pnlPrincipal.Controls.Add(this.lblCuenta);
            this.pnlPrincipal.Controls.Add(this.lblBienvenido);
            this.pnlPrincipal.Location = new System.Drawing.Point(107, 36);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(559, 383);
            this.pnlPrincipal.TabIndex = 0;
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.BackColor = System.Drawing.Color.White;
            this.txtContrasenia.Location = new System.Drawing.Point(226, 175);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.PasswordChar = '●';
            this.txtContrasenia.Size = new System.Drawing.Size(244, 20);
            this.txtContrasenia.TabIndex = 6;
            // 
            // txtCuenta
            // 
            this.txtCuenta.BackColor = System.Drawing.Color.White;
            this.txtCuenta.Location = new System.Drawing.Point(226, 116);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(244, 20);
            this.txtCuenta.TabIndex = 5;
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnIniciarSesion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIniciarSesion.Location = new System.Drawing.Point(238, 232);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(82, 39);
            this.btnIniciarSesion.TabIndex = 4;
            this.btnIniciarSesion.Text = "Iniciar Sesión";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.LinkColor = System.Drawing.Color.SaddleBrown;
            this.lblRegistro.Location = new System.Drawing.Point(244, 344);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(57, 13);
            this.lblRegistro.TabIndex = 3;
            this.lblRegistro.TabStop = true;
            this.lblRegistro.Text = "Regístrate";
            this.lblRegistro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblRegistro_LinkClicked);
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.Location = new System.Drawing.Point(101, 178);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(64, 13);
            this.lblContrasenia.TabIndex = 2;
            this.lblContrasenia.Text = "Contraseña:";
            // 
            // lblCuenta
            // 
            this.lblCuenta.AutoSize = true;
            this.lblCuenta.Location = new System.Drawing.Point(101, 123);
            this.lblCuenta.Name = "lblCuenta";
            this.lblCuenta.Size = new System.Drawing.Size(44, 13);
            this.lblCuenta.TabIndex = 1;
            this.lblCuenta.Text = "Cuenta:";
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblBienvenido.Location = new System.Drawing.Point(155, 30);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(273, 18);
            this.lblBienvenido.TabIndex = 0;
            this.lblBienvenido.Text = "¡BIENVENIDOS A BIBLIOTECH!";
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblPregunta.Location = new System.Drawing.Point(207, 318);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(141, 13);
            this.lblPregunta.TabIndex = 7;
            this.lblPregunta.Text = "¿Aún no tienes una cuenta?";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(762, 458);
            this.Controls.Add(this.grpPrincipal);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Principal";
            this.grpPrincipal.ResumeLayout(false);
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPrincipal;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.TextBox txtCuenta;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.LinkLabel lblRegistro;
        private System.Windows.Forms.Label lblContrasenia;
        private System.Windows.Forms.Label lblCuenta;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.Label lblPregunta;
    }
}