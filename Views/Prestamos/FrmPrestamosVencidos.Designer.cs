namespace BiblioTech.Views.Prestamos
{
    partial class FrmPrestamosVencidos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvVencidos = new System.Windows.Forms.DataGridView();
            this.colVId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVLector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVLimite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVDias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVMulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblContador = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVencidos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Lucida Handwriting", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(148, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(593, 65);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "PRESTAMOS VENCIDOS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvVencidos
            // 
            this.dgvVencidos.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.dgvVencidos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVencidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVencidos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVencidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVencidos.ColumnHeadersHeight = 32;
            this.dgvVencidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colVId,
            this.colVLector,
            this.colVLibro,
            this.colVLimite,
            this.colVDias,
            this.colVMulta});
            this.dgvVencidos.EnableHeadersVisualStyles = false;
            this.dgvVencidos.Location = new System.Drawing.Point(18, 92);
            this.dgvVencidos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvVencidos.Name = "dgvVencidos";
            this.dgvVencidos.ReadOnly = true;
            this.dgvVencidos.RowHeadersWidth = 30;
            this.dgvVencidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVencidos.Size = new System.Drawing.Size(925, 489);
            this.dgvVencidos.TabIndex = 1;
            // 
            // colVId
            // 
            this.colVId.HeaderText = "ID";
            this.colVId.MinimumWidth = 8;
            this.colVId.Name = "colVId";
            this.colVId.ReadOnly = true;
            this.colVId.Visible = false;
            // 
            // colVLector
            // 
            this.colVLector.HeaderText = "Usuario";
            this.colVLector.MinimumWidth = 8;
            this.colVLector.Name = "colVLector";
            this.colVLector.ReadOnly = true;
            // 
            // colVLibro
            // 
            this.colVLibro.HeaderText = "Libro";
            this.colVLibro.MinimumWidth = 8;
            this.colVLibro.Name = "colVLibro";
            this.colVLibro.ReadOnly = true;
            // 
            // colVLimite
            // 
            this.colVLimite.HeaderText = "Fecha Limite";
            this.colVLimite.MinimumWidth = 8;
            this.colVLimite.Name = "colVLimite";
            this.colVLimite.ReadOnly = true;
            // 
            // colVDias
            // 
            this.colVDias.HeaderText = "Dias Retraso";
            this.colVDias.MinimumWidth = 8;
            this.colVDias.Name = "colVDias";
            this.colVDias.ReadOnly = true;
            // 
            // colVMulta
            // 
            this.colVMulta.HeaderText = "Multa Estimada";
            this.colVMulta.MinimumWidth = 8;
            this.colVMulta.Name = "colVMulta";
            this.colVMulta.ReadOnly = true;
            // 
            // lblContador
            // 
            this.lblContador.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Italic);
            this.lblContador.ForeColor = System.Drawing.Color.DarkGray;
            this.lblContador.Location = new System.Drawing.Point(14, 586);
            this.lblContador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(450, 34);
            this.lblContador.TabIndex = 2;
            this.lblContador.Text = "Total vencidos: 0";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Image = global::BiblioTech.Properties.Resources.eliminar;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(772, 586);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(120, 54);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnRefrescar.ForeColor = System.Drawing.Color.White;
            this.btnRefrescar.Image = global::BiblioTech.Properties.Resources.actualizar;
            this.btnRefrescar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefrescar.Location = new System.Drawing.Point(632, 586);
            this.btnRefrescar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(132, 54);
            this.btnRefrescar.TabIndex = 3;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = false;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // FrmPrestamosVencidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(981, 663);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvVencidos);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmPrestamosVencidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prestamos Vencidos";
            this.Load += new System.EventHandler(this.FrmPrestamosVencidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVencidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvVencidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVLector;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVLimite;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVDias;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVMulta;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Button btnCerrar;
    }
}
