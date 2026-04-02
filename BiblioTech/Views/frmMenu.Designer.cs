namespace BiblioTech.Views
{
    partial class frmMenu
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mnuMenu = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoPréstamoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devolverLibroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renovarPréstamoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialDePréstamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catálogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarLibroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarLibroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarLibroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarLibroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verDisponibilidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónCategoríaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.préstamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRegistrarPrestamo = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarDevoluciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renovarPréstamoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.préstamosVencidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.librosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioDelSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.permisosYRolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiaDeSeguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.mnuMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Tan;
            this.pnlMenu.Controls.Add(this.label1);
            this.pnlMenu.Controls.Add(this.pictureBox1);
            this.pnlMenu.Location = new System.Drawing.Point(0, 25);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(664, 440);
            this.pnlMenu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MingLiU_MSCS-ExtB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(198, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "¡BIENVENIDO A BIBLIOTECH!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BiblioTech.Properties.Resources.Biblioteca;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(658, 381);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.mnuMenu);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(663, 27);
            this.panel2.TabIndex = 1;
            // 
            // mnuMenu
            // 
            this.mnuMenu.BackColor = System.Drawing.Color.Peru;
            this.mnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.catálogoToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.préstamosToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.configuraciónToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.btnCerrarSesion});
            this.mnuMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.Padding = new System.Windows.Forms.Padding(35, 2, 0, 5);
            this.mnuMenu.Size = new System.Drawing.Size(663, 26);
            this.mnuMenu.TabIndex = 3;
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoPréstamoToolStripMenuItem,
            this.devolverLibroToolStripMenuItem,
            this.renovarPréstamoToolStripMenuItem,
            this.historialDePréstamosToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 19);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoPréstamoToolStripMenuItem
            // 
            this.nuevoPréstamoToolStripMenuItem.Name = "nuevoPréstamoToolStripMenuItem";
            this.nuevoPréstamoToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.nuevoPréstamoToolStripMenuItem.Text = "Nuevo Préstamo";
            // 
            // devolverLibroToolStripMenuItem
            // 
            this.devolverLibroToolStripMenuItem.Name = "devolverLibroToolStripMenuItem";
            this.devolverLibroToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.devolverLibroToolStripMenuItem.Text = "Devolver Libro";
            // 
            // renovarPréstamoToolStripMenuItem
            // 
            this.renovarPréstamoToolStripMenuItem.Name = "renovarPréstamoToolStripMenuItem";
            this.renovarPréstamoToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.renovarPréstamoToolStripMenuItem.Text = "Renovar Préstamo";
            // 
            // historialDePréstamosToolStripMenuItem
            // 
            this.historialDePréstamosToolStripMenuItem.Name = "historialDePréstamosToolStripMenuItem";
            this.historialDePréstamosToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.historialDePréstamosToolStripMenuItem.Text = "Historial de Préstamos";
            // 
            // catálogoToolStripMenuItem
            // 
            this.catálogoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarLibroToolStripMenuItem,
            this.agregarLibroToolStripMenuItem,
            this.editarLibroToolStripMenuItem,
            this.eliminarLibroToolStripMenuItem,
            this.verDisponibilidadToolStripMenuItem,
            this.gestiónCategoríaToolStripMenuItem});
            this.catálogoToolStripMenuItem.Name = "catálogoToolStripMenuItem";
            this.catálogoToolStripMenuItem.Size = new System.Drawing.Size(67, 19);
            this.catálogoToolStripMenuItem.Text = "Catálogo";
            // 
            // buscarLibroToolStripMenuItem
            // 
            this.buscarLibroToolStripMenuItem.Name = "buscarLibroToolStripMenuItem";
            this.buscarLibroToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.buscarLibroToolStripMenuItem.Text = "Buscar Libro";
            // 
            // agregarLibroToolStripMenuItem
            // 
            this.agregarLibroToolStripMenuItem.Name = "agregarLibroToolStripMenuItem";
            this.agregarLibroToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.agregarLibroToolStripMenuItem.Text = "Agregar Libro";
            // 
            // editarLibroToolStripMenuItem
            // 
            this.editarLibroToolStripMenuItem.Name = "editarLibroToolStripMenuItem";
            this.editarLibroToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.editarLibroToolStripMenuItem.Text = "Editar Libro";
            // 
            // eliminarLibroToolStripMenuItem
            // 
            this.eliminarLibroToolStripMenuItem.Name = "eliminarLibroToolStripMenuItem";
            this.eliminarLibroToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.eliminarLibroToolStripMenuItem.Text = "Eliminar Libro";
            // 
            // verDisponibilidadToolStripMenuItem
            // 
            this.verDisponibilidadToolStripMenuItem.Name = "verDisponibilidadToolStripMenuItem";
            this.verDisponibilidadToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.verDisponibilidadToolStripMenuItem.Text = "Ver Disponibilidad";
            // 
            // gestiónCategoríaToolStripMenuItem
            // 
            this.gestiónCategoríaToolStripMenuItem.Name = "gestiónCategoríaToolStripMenuItem";
            this.gestiónCategoríaToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.gestiónCategoríaToolStripMenuItem.Text = "Gestión Categoría";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoUsuarioToolStripMenuItem,
            this.buscarUsuarioToolStripMenuItem,
            this.editarDatosToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(64, 19);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // nuevoUsuarioToolStripMenuItem
            // 
            this.nuevoUsuarioToolStripMenuItem.Name = "nuevoUsuarioToolStripMenuItem";
            this.nuevoUsuarioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nuevoUsuarioToolStripMenuItem.Text = "Nuevo Usuario";
            // 
            // buscarUsuarioToolStripMenuItem
            // 
            this.buscarUsuarioToolStripMenuItem.Name = "buscarUsuarioToolStripMenuItem";
            this.buscarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.buscarUsuarioToolStripMenuItem.Text = "Buscar Usuario";
            // 
            // editarDatosToolStripMenuItem
            // 
            this.editarDatosToolStripMenuItem.Name = "editarDatosToolStripMenuItem";
            this.editarDatosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editarDatosToolStripMenuItem.Text = "Editar Datos";
            // 
            // préstamosToolStripMenuItem
            // 
            this.préstamosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRegistrarPrestamo,
            this.registrarDevoluciónToolStripMenuItem,
            this.renovarPréstamoToolStripMenuItem1,
            this.préstamosVencidosToolStripMenuItem});
            this.préstamosToolStripMenuItem.Name = "préstamosToolStripMenuItem";
            this.préstamosToolStripMenuItem.Size = new System.Drawing.Size(74, 19);
            this.préstamosToolStripMenuItem.Text = "Préstamos";
            // 
            // tsmiRegistrarPrestamo
            // 
            this.tsmiRegistrarPrestamo.Name = "tsmiRegistrarPrestamo";
            this.tsmiRegistrarPrestamo.Size = new System.Drawing.Size(183, 22);
            this.tsmiRegistrarPrestamo.Text = "Registrar Préstamo";
            this.tsmiRegistrarPrestamo.Click += new System.EventHandler(this.tsmiRegistrarPrestamo_Click);
            // 
            // registrarDevoluciónToolStripMenuItem
            // 
            this.registrarDevoluciónToolStripMenuItem.Name = "registrarDevoluciónToolStripMenuItem";
            this.registrarDevoluciónToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.registrarDevoluciónToolStripMenuItem.Text = "Registrar Devolución";
            // 
            // renovarPréstamoToolStripMenuItem1
            // 
            this.renovarPréstamoToolStripMenuItem1.Name = "renovarPréstamoToolStripMenuItem1";
            this.renovarPréstamoToolStripMenuItem1.Size = new System.Drawing.Size(183, 22);
            this.renovarPréstamoToolStripMenuItem1.Text = "Renovar Préstamo";
            // 
            // préstamosVencidosToolStripMenuItem
            // 
            this.préstamosVencidosToolStripMenuItem.Name = "préstamosVencidosToolStripMenuItem";
            this.préstamosVencidosToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.préstamosVencidosToolStripMenuItem.Text = "Préstamos Vencidos";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.librosToolStripMenuItem,
            this.inventarioToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 19);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // librosToolStripMenuItem
            // 
            this.librosToolStripMenuItem.Name = "librosToolStripMenuItem";
            this.librosToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.librosToolStripMenuItem.Text = "Libros más Prestados";
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioDelSistemaToolStripMenuItem,
            this.permisosYRolesToolStripMenuItem,
            this.copiaDeSeguridadToolStripMenuItem});
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(95, 19);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            // 
            // usuarioDelSistemaToolStripMenuItem
            // 
            this.usuarioDelSistemaToolStripMenuItem.Name = "usuarioDelSistemaToolStripMenuItem";
            this.usuarioDelSistemaToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.usuarioDelSistemaToolStripMenuItem.Text = "Usuario del Sistema";
            // 
            // permisosYRolesToolStripMenuItem
            // 
            this.permisosYRolesToolStripMenuItem.Name = "permisosYRolesToolStripMenuItem";
            this.permisosYRolesToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.permisosYRolesToolStripMenuItem.Text = "Permisos y Roles";
            // 
            // copiaDeSeguridadToolStripMenuItem
            // 
            this.copiaDeSeguridadToolStripMenuItem.Name = "copiaDeSeguridadToolStripMenuItem";
            this.copiaDeSeguridadToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.copiaDeSeguridadToolStripMenuItem.Text = "Copia de Seguridad";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualDeUsuarioToolStripMenuItem,
            this.acercaDeToolStripMenuItem,
            this.soporteToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 19);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // manualDeUsuarioToolStripMenuItem
            // 
            this.manualDeUsuarioToolStripMenuItem.Name = "manualDeUsuarioToolStripMenuItem";
            this.manualDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.manualDeUsuarioToolStripMenuItem.Text = "Manual de Usuario";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            // 
            // soporteToolStripMenuItem
            // 
            this.soporteToolStripMenuItem.Name = "soporteToolStripMenuItem";
            this.soporteToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.soporteToolStripMenuItem.Text = "Soporte";
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(88, 19);
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 464);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlMenu);
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.mnuMenu.ResumeLayout(false);
            this.mnuMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip mnuMenu;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoPréstamoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devolverLibroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renovarPréstamoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialDePréstamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catálogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarLibroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarLibroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarLibroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarLibroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verDisponibilidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónCategoríaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem préstamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiRegistrarPrestamo;
        private System.Windows.Forms.ToolStripMenuItem registrarDevoluciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renovarPréstamoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem préstamosVencidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem librosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioDelSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem permisosYRolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiaDeSeguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnCerrarSesion;
    }
}