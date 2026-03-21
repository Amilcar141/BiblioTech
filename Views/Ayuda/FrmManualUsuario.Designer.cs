namespace BiblioTech.Views.Ayuda
{
    partial class FrmManualUsuario
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
            this.rtbManual = new System.Windows.Forms.RichTextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(760, 38);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "MANUAL DE USUARIO - BiblioTech";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtbManual
            // 
            this.rtbManual.BackColor = System.Drawing.Color.FloralWhite;
            this.rtbManual.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rtbManual.Location = new System.Drawing.Point(12, 55);
            this.rtbManual.Name = "rtbManual";
            this.rtbManual.ReadOnly = true;
            this.rtbManual.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbManual.Size = new System.Drawing.Size(760, 440);
            this.rtbManual.TabIndex = 1;
            this.rtbManual.Text = "";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(698, 503);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(74, 35);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FrmManualUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(784, 550);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.rtbManual);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmManualUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manual de Usuario";
            this.Load += new System.EventHandler(this.FrmManualUsuario_Load);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.RichTextBox rtbManual;
        private System.Windows.Forms.Button btnCerrar;
    }
}
