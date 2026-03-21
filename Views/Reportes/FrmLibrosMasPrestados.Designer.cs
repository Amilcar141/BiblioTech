namespace BiblioTech.Views.Reportes
{
    partial class FrmLibrosMasPrestados
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvLibros = new System.Windows.Forms.DataGridView();
            this.colLMPos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLMTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLMAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLMConteo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblContador = new System.Windows.Forms.Label();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Lucida Handwriting", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(18, 14);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(1140, 65);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "LIBROS MAS PRESTADOS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvLibros
            // 
            this.dgvLibros.AllowUserToAddRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvLibros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLibros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLibros.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLibros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLibros.ColumnHeadersHeight = 30;
            this.dgvLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLMPos,
            this.colLMTitulo,
            this.colLMAutor,
            this.colLMConteo});
            this.dgvLibros.EnableHeadersVisualStyles = false;
            this.dgvLibros.Location = new System.Drawing.Point(18, 92);
            this.dgvLibros.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.ReadOnly = true;
            this.dgvLibros.RowHeadersWidth = 30;
            this.dgvLibros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLibros.Size = new System.Drawing.Size(1140, 585);
            this.dgvLibros.TabIndex = 1;
            // 
            // colLMPos
            // 
            this.colLMPos.HeaderText = "#";
            this.colLMPos.MinimumWidth = 8;
            this.colLMPos.Name = "colLMPos";
            this.colLMPos.ReadOnly = true;
            // 
            // colLMTitulo
            // 
            this.colLMTitulo.HeaderText = "Titulo del Libro";
            this.colLMTitulo.MinimumWidth = 8;
            this.colLMTitulo.Name = "colLMTitulo";
            this.colLMTitulo.ReadOnly = true;
            // 
            // colLMAutor
            // 
            this.colLMAutor.HeaderText = "Autor";
            this.colLMAutor.MinimumWidth = 8;
            this.colLMAutor.Name = "colLMAutor";
            this.colLMAutor.ReadOnly = true;
            // 
            // colLMConteo
            // 
            this.colLMConteo.HeaderText = "Veces Prestado";
            this.colLMConteo.MinimumWidth = 8;
            this.colLMConteo.Name = "colLMConteo";
            this.colLMConteo.ReadOnly = true;
            // 
            // lblContador
            // 
            this.lblContador.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Italic);
            this.lblContador.ForeColor = System.Drawing.Color.DarkGray;
            this.lblContador.Location = new System.Drawing.Point(18, 689);
            this.lblContador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(600, 34);
            this.lblContador.TabIndex = 2;
            this.lblContador.Text = "Libros distintos prestados: 0";
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnRefrescar.ForeColor = System.Drawing.Color.White;
            this.btnRefrescar.Location = new System.Drawing.Point(885, 682);
            this.btnRefrescar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(132, 54);
            this.btnRefrescar.TabIndex = 3;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = false;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(1029, 682);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(129, 54);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FrmLibrosMasPrestados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1176, 754);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvLibros);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmLibrosMasPrestados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Libros mas Prestados";
            this.Load += new System.EventHandler(this.FrmLibrosMasPrestados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvLibros;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLMPos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLMTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLMAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLMConteo;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Button btnCerrar;
    }
}
