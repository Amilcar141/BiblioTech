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
            this.components = new System.ComponentModel.Container();
            this.grpMenu = new System.Windows.Forms.GroupBox();
            this.pnlBuscar = new System.Windows.Forms.Panel();
            this.picBuscar = new System.Windows.Forms.PictureBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.mStripMenu = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archivoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.categoríasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.préstamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarPréstamoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarDevoluciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renovarPréstamoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.préstamosVencidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.librosMásSolicitadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioDelSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.permisosYRolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiaDeSeguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verMiPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.grpMenu.SuspendLayout();
            this.pnlBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscar)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.mStripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMenu
            // 
            this.grpMenu.BackgroundImage = global::BiblioTech.Properties.Resources.Biblioteca;
            this.grpMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grpMenu.Controls.Add(this.pnlBuscar);
            this.grpMenu.Controls.Add(this.pnlMenu);
            this.grpMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpMenu.Location = new System.Drawing.Point(0, 0);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(756, 466);
            this.grpMenu.TabIndex = 0;
            this.grpMenu.TabStop = false;
            // 
            // pnlBuscar
            // 
            this.pnlBuscar.BackColor = System.Drawing.Color.Peru;
            this.pnlBuscar.Controls.Add(this.picBuscar);
            this.pnlBuscar.Controls.Add(this.lblBuscar);
            this.pnlBuscar.Controls.Add(this.txtBuscar);
            this.pnlBuscar.Location = new System.Drawing.Point(118, 120);
            this.pnlBuscar.Name = "pnlBuscar";
            this.pnlBuscar.Size = new System.Drawing.Size(503, 105);
            this.pnlBuscar.TabIndex = 1;
            // 
            // picBuscar
            // 
            this.picBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBuscar.Image = global::BiblioTech.Properties.Resources.busqueda;
            this.picBuscar.Location = new System.Drawing.Point(438, 32);
            this.picBuscar.Name = "picBuscar";
            this.picBuscar.Size = new System.Drawing.Size(39, 44);
            this.picBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBuscar.TabIndex = 2;
            this.picBuscar.TabStop = false;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblBuscar.Location = new System.Drawing.Point(57, 41);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(91, 25);
            this.lblBuscar.TabIndex = 1;
            this.lblBuscar.Text = "Buscar: ";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(194, 47);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(211, 20);
            this.txtBuscar.TabIndex = 0;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.SaddleBrown;
            this.pnlMenu.Controls.Add(this.mStripMenu);
            this.pnlMenu.Location = new System.Drawing.Point(12, 12);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(732, 47);
            this.pnlMenu.TabIndex = 0;
            // 
            // mStripMenu
            // 
            this.mStripMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.mStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.archivoToolStripMenuItem1,
            this.catálogoToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.préstamosToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.configuraciónToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem,
            this.perfilToolStripMenuItem});
            this.mStripMenu.Location = new System.Drawing.Point(36, 13);
            this.mStripMenu.Name = "mStripMenu";
            this.mStripMenu.Size = new System.Drawing.Size(650, 24);
            this.mStripMenu.TabIndex = 0;
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.archivoToolStripMenuItem.Text = "Volver";
            // 
            // archivoToolStripMenuItem1
            // 
            this.archivoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoPréstamoToolStripMenuItem,
            this.devolverLibroToolStripMenuItem,
            this.renovarPréstamoToolStripMenuItem,
            this.historialDePréstamosToolStripMenuItem});
            this.archivoToolStripMenuItem1.Name = "archivoToolStripMenuItem1";
            this.archivoToolStripMenuItem1.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem1.Text = "Archivo";
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
            this.categoríasToolStripMenuItem});
            this.catálogoToolStripMenuItem.Name = "catálogoToolStripMenuItem";
            this.catálogoToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.catálogoToolStripMenuItem.Text = "Libro";
            // 
            // buscarLibroToolStripMenuItem
            // 
            this.buscarLibroToolStripMenuItem.Name = "buscarLibroToolStripMenuItem";
            this.buscarLibroToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.buscarLibroToolStripMenuItem.Text = "Buscar Libros";
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
            // categoríasToolStripMenuItem
            // 
            this.categoríasToolStripMenuItem.Name = "categoríasToolStripMenuItem";
            this.categoríasToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.categoríasToolStripMenuItem.Text = "Categorías";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoUsuarioToolStripMenuItem,
            this.buscarUsuarioToolStripMenuItem,
            this.editarDatosToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
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
            this.registrarPréstamoToolStripMenuItem,
            this.registrarDevoluciónToolStripMenuItem,
            this.renovarPréstamoToolStripMenuItem1,
            this.préstamosVencidosToolStripMenuItem});
            this.préstamosToolStripMenuItem.Name = "préstamosToolStripMenuItem";
            this.préstamosToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.préstamosToolStripMenuItem.Text = "Préstamos";
            // 
            // registrarPréstamoToolStripMenuItem
            // 
            this.registrarPréstamoToolStripMenuItem.Name = "registrarPréstamoToolStripMenuItem";
            this.registrarPréstamoToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.registrarPréstamoToolStripMenuItem.Text = "Registrar Préstamo";
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
            this.librosMásSolicitadosToolStripMenuItem,
            this.inventarioToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // librosMásSolicitadosToolStripMenuItem
            // 
            this.librosMásSolicitadosToolStripMenuItem.Name = "librosMásSolicitadosToolStripMenuItem";
            this.librosMásSolicitadosToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.librosMásSolicitadosToolStripMenuItem.Text = "Libros Más Solicitados";
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioDelSistemaToolStripMenuItem,
            this.permisosYRolesToolStripMenuItem,
            this.copiaDeSeguridadToolStripMenuItem});
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
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
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
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
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            // 
            // perfilToolStripMenuItem
            // 
            this.perfilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verMiPerfilToolStripMenuItem,
            this.configuraciónToolStripMenuItem1});
            this.perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            this.perfilToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.perfilToolStripMenuItem.Text = "Perfil";
            // 
            // verMiPerfilToolStripMenuItem
            // 
            this.verMiPerfilToolStripMenuItem.Name = "verMiPerfilToolStripMenuItem";
            this.verMiPerfilToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.verMiPerfilToolStripMenuItem.Text = "Ver mi Perfil";
            // 
            // configuraciónToolStripMenuItem1
            // 
            this.configuraciónToolStripMenuItem1.Name = "configuraciónToolStripMenuItem1";
            this.configuraciónToolStripMenuItem1.Size = new System.Drawing.Size(150, 22);
            this.configuraciónToolStripMenuItem1.Text = "Configuración";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 466);
            this.Controls.Add(this.grpMenu);
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.grpMenu.ResumeLayout(false);
            this.pnlBuscar.ResumeLayout(false);
            this.pnlBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscar)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.mStripMenu.ResumeLayout(false);
            this.mStripMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.GroupBox grpMenu;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.MenuStrip mStripMenu;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem préstamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
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
        private System.Windows.Forms.ToolStripMenuItem categoríasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarPréstamoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarDevoluciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renovarPréstamoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem préstamosVencidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem librosMásSolicitadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioDelSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem permisosYRolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiaDeSeguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verMiPerfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem1;
        private System.Windows.Forms.Panel pnlBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.PictureBox picBuscar;
    }
}