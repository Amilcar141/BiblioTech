namespace BiblioTech.Views.Perfil
{
    partial class FrmPerfil
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitulo       = new System.Windows.Forms.Label();
            this.pnlDatos        = new System.Windows.Forms.Panel();
            this.lblNombre       = new System.Windows.Forms.Label();
            this.lblNombreVal    = new System.Windows.Forms.Label();
            this.lblCorreo       = new System.Windows.Forms.Label();
            this.lblCorreoVal    = new System.Windows.Forms.Label();
            this.lblRol          = new System.Windows.Forms.Label();
            this.lblRolVal       = new System.Windows.Forms.Label();
            this.lblEstado       = new System.Windows.Forms.Label();
            this.lblEstadoVal    = new System.Windows.Forms.Label();
            this.lblMenuTitulo   = new System.Windows.Forms.Label();
            this.btnEditarDatos  = new System.Windows.Forms.Button();
            this.btnVerLibros    = new System.Windows.Forms.Button();
            this.btnVerPrestamos = new System.Windows.Forms.Button();
            this.btnVerMultas    = new System.Windows.Forms.Button();
            this.btnCerrar       = new System.Windows.Forms.Button();
            this.btnFavoritos    = new System.Windows.Forms.Button();
            this.pnlDatos.SuspendLayout();
            this.SuspendLayout();

            // lblTitulo
            this.lblTitulo.Font      = new System.Drawing.Font("Lucida Handwriting", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location  = new System.Drawing.Point(30, 20);
            this.lblTitulo.Name      = "lblTitulo";
            this.lblTitulo.Size      = new System.Drawing.Size(540, 55);
            this.lblTitulo.TabIndex  = 0;
            this.lblTitulo.Text      = "MI PERFIL";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // pnlDatos
            this.pnlDatos.BackColor = System.Drawing.Color.Peru;
            this.pnlDatos.Controls.Add(this.lblNombre);
            this.pnlDatos.Controls.Add(this.lblNombreVal);
            this.pnlDatos.Controls.Add(this.lblCorreo);
            this.pnlDatos.Controls.Add(this.lblCorreoVal);
            this.pnlDatos.Controls.Add(this.lblRol);
            this.pnlDatos.Controls.Add(this.lblRolVal);
            this.pnlDatos.Controls.Add(this.lblEstado);
            this.pnlDatos.Controls.Add(this.lblEstadoVal);
            this.pnlDatos.Location = new System.Drawing.Point(18, 85);
            this.pnlDatos.Name     = "pnlDatos";
            this.pnlDatos.Size     = new System.Drawing.Size(580, 200);
            this.pnlDatos.TabIndex = 1;

            // lblNombre
            this.lblNombre.Font      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location  = new System.Drawing.Point(20, 25);
            this.lblNombre.Name      = "lblNombre";
            this.lblNombre.Size      = new System.Drawing.Size(90, 30);
            this.lblNombre.TabIndex  = 0;
            this.lblNombre.Text      = "Nombre:";

            // lblNombreVal
            this.lblNombreVal.Font      = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNombreVal.ForeColor = System.Drawing.Color.White;
            this.lblNombreVal.Location  = new System.Drawing.Point(120, 25);
            this.lblNombreVal.Name      = "lblNombreVal";
            this.lblNombreVal.Size      = new System.Drawing.Size(440, 30);
            this.lblNombreVal.TabIndex  = 1;
            this.lblNombreVal.Text      = "---";

            // lblCorreo
            this.lblCorreo.Font      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCorreo.ForeColor = System.Drawing.Color.White;
            this.lblCorreo.Location  = new System.Drawing.Point(20, 75);
            this.lblCorreo.Name      = "lblCorreo";
            this.lblCorreo.Size      = new System.Drawing.Size(90, 30);
            this.lblCorreo.TabIndex  = 2;
            this.lblCorreo.Text      = "Correo:";

            // lblCorreoVal
            this.lblCorreoVal.Font      = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCorreoVal.ForeColor = System.Drawing.Color.White;
            this.lblCorreoVal.Location  = new System.Drawing.Point(120, 75);
            this.lblCorreoVal.Name      = "lblCorreoVal";
            this.lblCorreoVal.Size      = new System.Drawing.Size(440, 30);
            this.lblCorreoVal.TabIndex  = 3;
            this.lblCorreoVal.Text      = "---";

            // lblRol
            this.lblRol.Font      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblRol.ForeColor = System.Drawing.Color.White;
            this.lblRol.Location  = new System.Drawing.Point(20, 125);
            this.lblRol.Name      = "lblRol";
            this.lblRol.Size      = new System.Drawing.Size(90, 30);
            this.lblRol.TabIndex  = 4;
            this.lblRol.Text      = "Rol:";

            // lblRolVal
            this.lblRolVal.Font      = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRolVal.ForeColor = System.Drawing.Color.White;
            this.lblRolVal.Location  = new System.Drawing.Point(120, 125);
            this.lblRolVal.Name      = "lblRolVal";
            this.lblRolVal.Size      = new System.Drawing.Size(200, 30);
            this.lblRolVal.TabIndex  = 5;
            this.lblRolVal.Text      = "---";

            // lblEstado
            this.lblEstado.Font      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblEstado.ForeColor = System.Drawing.Color.White;
            this.lblEstado.Location  = new System.Drawing.Point(320, 125);
            this.lblEstado.Name      = "lblEstado";
            this.lblEstado.Size      = new System.Drawing.Size(80, 30);
            this.lblEstado.TabIndex  = 6;
            this.lblEstado.Text      = "Estado:";

            // lblEstadoVal
            this.lblEstadoVal.Font      = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEstadoVal.ForeColor = System.Drawing.Color.White;
            this.lblEstadoVal.Location  = new System.Drawing.Point(410, 125);
            this.lblEstadoVal.Name      = "lblEstadoVal";
            this.lblEstadoVal.Size      = new System.Drawing.Size(150, 30);
            this.lblEstadoVal.TabIndex  = 7;
            this.lblEstadoVal.Text      = "---";

            // lblMenuTitulo
            this.lblMenuTitulo.Font      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMenuTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblMenuTitulo.Location  = new System.Drawing.Point(18, 305);
            this.lblMenuTitulo.Name      = "lblMenuTitulo";
            this.lblMenuTitulo.Size      = new System.Drawing.Size(580, 28);
            this.lblMenuTitulo.TabIndex  = 2;
            this.lblMenuTitulo.Text      = "Menu";

            // btnEditarDatos
            this.btnEditarDatos.BackColor = System.Drawing.Color.FromArgb(0, 153, 76);
            this.btnEditarDatos.Font      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEditarDatos.ForeColor = System.Drawing.Color.White;
            this.btnEditarDatos.Location  = new System.Drawing.Point(18, 345);
            this.btnEditarDatos.Name      = "btnEditarDatos";
            this.btnEditarDatos.Size      = new System.Drawing.Size(580, 48);
            this.btnEditarDatos.TabIndex  = 2;
            this.btnEditarDatos.Text      = "Editar mis datos";
            this.btnEditarDatos.UseVisualStyleBackColor = false;
            this.btnEditarDatos.Click += new System.EventHandler(this.btnEditarDatos_Click);

            // btnVerLibros
            this.btnVerLibros.BackColor = System.Drawing.Color.FromArgb(255, 165, 0);
            this.btnVerLibros.Font      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnVerLibros.ForeColor = System.Drawing.Color.White;
            this.btnVerLibros.Location  = new System.Drawing.Point(18, 405);
            this.btnVerLibros.Name      = "btnVerLibros";
            this.btnVerLibros.Size      = new System.Drawing.Size(580, 48);
            this.btnVerLibros.TabIndex  = 3;
            this.btnVerLibros.Text      = "Ver libros";
            this.btnVerLibros.UseVisualStyleBackColor = false;
            this.btnVerLibros.Click += new System.EventHandler(this.btnVerLibros_Click);

            // btnVerPrestamos
            this.btnVerPrestamos.BackColor = System.Drawing.Color.FromArgb(0, 102, 204);
            this.btnVerPrestamos.Font      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnVerPrestamos.ForeColor = System.Drawing.Color.White;
            this.btnVerPrestamos.Location  = new System.Drawing.Point(18, 465);
            this.btnVerPrestamos.Name      = "btnVerPrestamos";
            this.btnVerPrestamos.Size      = new System.Drawing.Size(580, 48);
            this.btnVerPrestamos.TabIndex  = 4;
            this.btnVerPrestamos.Text      = "Ver préstamos";
            this.btnVerPrestamos.UseVisualStyleBackColor = false;
            this.btnVerPrestamos.Click += new System.EventHandler(this.btnVerPrestamos_Click);

            // btnVerMultas
            this.btnVerMultas.BackColor = System.Drawing.Color.FromArgb(204, 0, 0);
            this.btnVerMultas.Font      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnVerMultas.ForeColor = System.Drawing.Color.White;
            this.btnVerMultas.Location  = new System.Drawing.Point(18, 525);
            this.btnVerMultas.Name      = "btnVerMultas";
            this.btnVerMultas.Size      = new System.Drawing.Size(580, 48);
            this.btnVerMultas.TabIndex  = 5;
            this.btnVerMultas.Text      = "Ver multas";
            this.btnVerMultas.UseVisualStyleBackColor = false;
            this.btnVerMultas.Click += new System.EventHandler(this.btnVerMultas_Click);

            // btnCerrar
            this.btnCerrar.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnCerrar.Font      = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location  = new System.Drawing.Point(18, 656);
            this.btnCerrar.Name      = "btnCerrar";
            this.btnCerrar.Size      = new System.Drawing.Size(580, 40);
            this.btnCerrar.TabIndex  = 6;
            this.btnCerrar.Text      = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);

            // btnFavoritos
            this.btnFavoritos.BackColor = System.Drawing.Color.FromArgb(255, 128, 0);
            this.btnFavoritos.Font      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnFavoritos.ForeColor = System.Drawing.Color.White;
            this.btnFavoritos.Location  = new System.Drawing.Point(23, 592);
            this.btnFavoritos.Name      = "btnFavoritos";
            this.btnFavoritos.Size      = new System.Drawing.Size(575, 45);
            this.btnFavoritos.TabIndex  = 7;
            this.btnFavoritos.Text      = "Ver Favoritos";
            this.btnFavoritos.UseVisualStyleBackColor = false;
            this.btnFavoritos.Click += new System.EventHandler(this.btnFavoritos_Click);

            // FrmPerfil
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.SandyBrown;
            this.ClientSize          = new System.Drawing.Size(618, 708);
            this.Controls.Add(this.btnFavoritos);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.lblMenuTitulo);
            this.Controls.Add(this.btnEditarDatos);
            this.Controls.Add(this.btnVerLibros);
            this.Controls.Add(this.btnVerPrestamos);
            this.Controls.Add(this.btnVerMultas);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox     = false;
            this.Name            = "FrmPerfil";
            this.StartPosition   = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text            = "Mi Perfil";
            this.Load           += new System.EventHandler(this.FrmPerfil_Load);
            this.pnlDatos.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label  lblTitulo;
        private System.Windows.Forms.Panel  pnlDatos;
        private System.Windows.Forms.Label  lblNombre;
        private System.Windows.Forms.Label  lblNombreVal;
        private System.Windows.Forms.Label  lblCorreo;
        private System.Windows.Forms.Label  lblCorreoVal;
        private System.Windows.Forms.Label  lblRol;
        private System.Windows.Forms.Label  lblRolVal;
        private System.Windows.Forms.Label  lblEstado;
        private System.Windows.Forms.Label  lblEstadoVal;
        private System.Windows.Forms.Label  lblMenuTitulo;
        private System.Windows.Forms.Button btnEditarDatos;
        private System.Windows.Forms.Button btnVerLibros;
        private System.Windows.Forms.Button btnVerPrestamos;
        private System.Windows.Forms.Button btnVerMultas;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnFavoritos;
    }
}
