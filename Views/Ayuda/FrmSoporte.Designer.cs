namespace BiblioTech.Views.Ayuda
{
    partial class FrmSoporte
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
            this.grpContacto = new System.Windows.Forms.GroupBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.lblWeb = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.grpContacto.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblTitulo.Location = new System.Drawing.Point(18, 14);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(684, 55);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "SOPORTE TECNICO";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpContacto
            // 
            this.grpContacto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(180)))));
            this.grpContacto.Controls.Add(this.lblCorreo);
            this.grpContacto.Controls.Add(this.lblTelefono);
            this.grpContacto.Controls.Add(this.lblHorario);
            this.grpContacto.Controls.Add(this.lblWeb);
            this.grpContacto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpContacto.Location = new System.Drawing.Point(18, 85);
            this.grpContacto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpContacto.Name = "grpContacto";
            this.grpContacto.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpContacto.Size = new System.Drawing.Size(684, 331);
            this.grpContacto.TabIndex = 1;
            this.grpContacto.TabStop = false;
            this.grpContacto.Text = "Informacion de Contacto";
            // 
            // lblCorreo
            // 
            this.lblCorreo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCorreo.Location = new System.Drawing.Point(22, 46);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(630, 34);
            this.lblCorreo.TabIndex = 0;
            this.lblCorreo.Text = "Correo:    kric@bibliotech.edu";
            // 
            // lblTelefono
            // 
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTelefono.Location = new System.Drawing.Point(22, 100);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(630, 34);
            this.lblTelefono.TabIndex = 1;
            this.lblTelefono.Text = "Telefono:  +504 1522-3379";
            // 
            // lblHorario
            // 
            this.lblHorario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblHorario.Location = new System.Drawing.Point(22, 154);
            this.lblHorario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(630, 34);
            this.lblHorario.TabIndex = 2;
            this.lblHorario.Text = "Horario:   Lunes a Viernes  8:00 - 17:00";
            // 
            // lblWeb
            // 
            this.lblWeb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblWeb.Location = new System.Drawing.Point(22, 208);
            this.lblWeb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWeb.Name = "lblWeb";
            this.lblWeb.Size = new System.Drawing.Size(630, 34);
            this.lblWeb.TabIndex = 3;
            this.lblWeb.Text = "Web:       www.bibliotech.edu/soporte";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(276, 438);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(150, 54);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FrmSoporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(720, 515);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.grpContacto);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmSoporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Soporte Tecnico";
            this.grpContacto.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grpContacto;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Label lblWeb;
        private System.Windows.Forms.Button btnCerrar;
    }
}
