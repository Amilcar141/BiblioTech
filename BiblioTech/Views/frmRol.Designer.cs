namespace BiblioTech.Views
{
    partial class frmRol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRol));
            this.grpRoles = new System.Windows.Forms.GroupBox();
            this.pnlRoles = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBibliotecario = new System.Windows.Forms.Label();
            this.lblAdministrador = new System.Windows.Forms.Label();
            this.lblInstrucciones = new System.Windows.Forms.Label();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.picLector = new System.Windows.Forms.PictureBox();
            this.picBibliotecario = new System.Windows.Forms.PictureBox();
            this.picAdmin = new System.Windows.Forms.PictureBox();
            this.grpRoles.SuspendLayout();
            this.pnlRoles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBibliotecario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // grpRoles
            // 
            this.grpRoles.BackColor = System.Drawing.Color.PeachPuff;
            this.grpRoles.Controls.Add(this.pnlRoles);
            this.grpRoles.Controls.Add(this.lblInstrucciones);
            this.grpRoles.Controls.Add(this.lblBienvenida);
            this.grpRoles.Location = new System.Drawing.Point(12, 12);
            this.grpRoles.Name = "grpRoles";
            this.grpRoles.Size = new System.Drawing.Size(781, 412);
            this.grpRoles.TabIndex = 0;
            this.grpRoles.TabStop = false;
            this.grpRoles.Text = "Selecciona un Rol para continuar";
            this.grpRoles.Enter += new System.EventHandler(this.grpRoles_Enter);
            // 
            // pnlRoles
            // 
            this.pnlRoles.BackColor = System.Drawing.Color.Bisque;
            this.pnlRoles.Controls.Add(this.picLector);
            this.pnlRoles.Controls.Add(this.picBibliotecario);
            this.pnlRoles.Controls.Add(this.picAdmin);
            this.pnlRoles.Controls.Add(this.label3);
            this.pnlRoles.Controls.Add(this.lblBibliotecario);
            this.pnlRoles.Controls.Add(this.lblAdministrador);
            this.pnlRoles.Location = new System.Drawing.Point(55, 127);
            this.pnlRoles.Name = "pnlRoles";
            this.pnlRoles.Size = new System.Drawing.Size(683, 248);
            this.pnlRoles.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(550, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 11);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lector";
            // 
            // lblBibliotecario
            // 
            this.lblBibliotecario.AutoSize = true;
            this.lblBibliotecario.Font = new System.Drawing.Font("Mongolian Baiti", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBibliotecario.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblBibliotecario.Location = new System.Drawing.Point(315, 18);
            this.lblBibliotecario.Name = "lblBibliotecario";
            this.lblBibliotecario.Size = new System.Drawing.Size(64, 11);
            this.lblBibliotecario.TabIndex = 1;
            this.lblBibliotecario.Text = "Bibliotecario";
            // 
            // lblAdministrador
            // 
            this.lblAdministrador.AutoSize = true;
            this.lblAdministrador.Font = new System.Drawing.Font("Mongolian Baiti", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdministrador.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblAdministrador.Location = new System.Drawing.Point(80, 18);
            this.lblAdministrador.Name = "lblAdministrador";
            this.lblAdministrador.Size = new System.Drawing.Size(72, 11);
            this.lblAdministrador.TabIndex = 0;
            this.lblAdministrador.Text = "Administrador";
            // 
            // lblInstrucciones
            // 
            this.lblInstrucciones.AutoSize = true;
            this.lblInstrucciones.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstrucciones.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblInstrucciones.Location = new System.Drawing.Point(293, 75);
            this.lblInstrucciones.Name = "lblInstrucciones";
            this.lblInstrucciones.Size = new System.Drawing.Size(267, 16);
            this.lblInstrucciones.TabIndex = 1;
            this.lblInstrucciones.Text = "Para ingresar selecciona una opción";
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblBienvenida.Location = new System.Drawing.Point(341, 34);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(145, 23);
            this.lblBienvenida.TabIndex = 0;
            this.lblBienvenida.Text = "BIBLIOTECH";
            // 
            // picLector
            // 
            this.picLector.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLector.Image = global::BiblioTech.Properties.Resources.Lector;
            this.picLector.Location = new System.Drawing.Point(520, 64);
            this.picLector.Name = "picLector";
            this.picLector.Size = new System.Drawing.Size(105, 152);
            this.picLector.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLector.TabIndex = 5;
            this.picLector.TabStop = false;
            // 
            // picBibliotecario
            // 
            this.picBibliotecario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBibliotecario.Image = global::BiblioTech.Properties.Resources.Bibliotecario;
            this.picBibliotecario.Location = new System.Drawing.Point(290, 64);
            this.picBibliotecario.Name = "picBibliotecario";
            this.picBibliotecario.Size = new System.Drawing.Size(106, 150);
            this.picBibliotecario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBibliotecario.TabIndex = 4;
            this.picBibliotecario.TabStop = false;
            // 
            // picAdmin
            // 
            this.picAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAdmin.Image = ((System.Drawing.Image)(resources.GetObject("picAdmin.Image")));
            this.picAdmin.Location = new System.Drawing.Point(61, 61);
            this.picAdmin.Name = "picAdmin";
            this.picAdmin.Size = new System.Drawing.Size(108, 153);
            this.picAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAdmin.TabIndex = 3;
            this.picAdmin.TabStop = false;
            // 
            // frmRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 436);
            this.Controls.Add(this.grpRoles);
            this.Name = "frmRol";
            this.Text = "Roles";
            this.grpRoles.ResumeLayout(false);
            this.grpRoles.PerformLayout();
            this.pnlRoles.ResumeLayout(false);
            this.pnlRoles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBibliotecario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdmin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRoles;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Label lblInstrucciones;
        private System.Windows.Forms.Panel pnlRoles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBibliotecario;
        private System.Windows.Forms.Label lblAdministrador;
        private System.Windows.Forms.PictureBox picLector;
        private System.Windows.Forms.PictureBox picBibliotecario;
        private System.Windows.Forms.PictureBox picAdmin;
    }
}