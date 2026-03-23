namespace BiblioTech.Views.Ayuda
{
    partial class FrmAcercaDe
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblTecnoTitulo = new System.Windows.Forms.Label();
            this.lblTecno = new System.Windows.Forms.Label();
            this.lblEquipo = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.SaddleBrown;
            this.pnlHeader.Controls.Add(this.lblNombre);
            this.pnlHeader.Controls.Add(this.lblVersion);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(720, 154);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(0, 15);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(720, 65);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "BiblioTech";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVersion
            // 
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblVersion.ForeColor = System.Drawing.Color.Wheat;
            this.lblVersion.Location = new System.Drawing.Point(0, 92);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(720, 46);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "Version 1.0  |  Sistema de Gestion de Biblioteca\r\n";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDesc
            // 
            this.lblDesc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDesc.Location = new System.Drawing.Point(30, 177);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(660, 62);
            this.lblDesc.TabIndex = 1;
            this.lblDesc.Text = "Aplicacion para gestionar libros \r\n\r\n";
            // 
            // lblTecnoTitulo
            // 
            this.lblTecnoTitulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTecnoTitulo.Location = new System.Drawing.Point(30, 254);
            this.lblTecnoTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTecnoTitulo.Name = "lblTecnoTitulo";
            this.lblTecnoTitulo.Size = new System.Drawing.Size(300, 34);
            this.lblTecnoTitulo.TabIndex = 2;
            this.lblTecnoTitulo.Text = "Desarrollado:";
            // 
            // lblTecno
            // 
            this.lblTecno.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTecno.Location = new System.Drawing.Point(30, 292);
            this.lblTecno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTecno.Name = "lblTecno";
            this.lblTecno.Size = new System.Drawing.Size(660, 92);
            this.lblTecno.TabIndex = 3;
            this.lblTecno.Text = "Grupo de programadores de poo\r\n";
            // 
            // lblEquipo
            // 
            this.lblEquipo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblEquipo.ForeColor = System.Drawing.Color.Gray;
            this.lblEquipo.Location = new System.Drawing.Point(30, 400);
            this.lblEquipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEquipo.Name = "lblEquipo";
            this.lblEquipo.Size = new System.Drawing.Size(660, 34);
            this.lblEquipo.TabIndex = 4;
            this.lblEquipo.Text = "Proyecto Parcial  -  POO";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(285, 462);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(150, 54);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FrmAcercaDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(720, 535);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblTecnoTitulo);
            this.Controls.Add(this.lblTecno);
            this.Controls.Add(this.lblEquipo);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmAcercaDe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acerca de BiblioTech";
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblTecnoTitulo;
        private System.Windows.Forms.Label lblTecno;
        private System.Windows.Forms.Label lblEquipo;
        private System.Windows.Forms.Button btnCerrar;
    }
}
