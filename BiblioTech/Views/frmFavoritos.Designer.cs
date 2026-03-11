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
            this.grpFavoritos = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFavoritos = new System.Windows.Forms.Label();
            this.grpFavoritos.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpFavoritos
            // 
            this.grpFavoritos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grpFavoritos.BackgroundImage")));
            this.grpFavoritos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grpFavoritos.Controls.Add(this.panel1);
            this.grpFavoritos.Location = new System.Drawing.Point(2, 5);
            this.grpFavoritos.Name = "grpFavoritos";
            this.grpFavoritos.Size = new System.Drawing.Size(685, 359);
            this.grpFavoritos.TabIndex = 0;
            this.grpFavoritos.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Peru;
            this.panel1.Controls.Add(this.lblFavoritos);
            this.panel1.Location = new System.Drawing.Point(26, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 36);
            this.panel1.TabIndex = 0;
            // 
            // lblFavoritos
            // 
            this.lblFavoritos.AutoSize = true;
            this.lblFavoritos.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFavoritos.ForeColor = System.Drawing.Color.Black;
            this.lblFavoritos.Location = new System.Drawing.Point(158, 12);
            this.lblFavoritos.Name = "lblFavoritos";
            this.lblFavoritos.Size = new System.Drawing.Size(306, 24);
            this.lblFavoritos.TabIndex = 0;
            this.lblFavoritos.Text = "FAVORITOS DE BIBLIOTECH";
            this.lblFavoritos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmFavoritos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 368);
            this.Controls.Add(this.grpFavoritos);
            this.Name = "frmFavoritos";
            this.Text = "Favoritos";
            this.grpFavoritos.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFavoritos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFavoritos;
    }
}