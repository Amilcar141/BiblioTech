namespace BiblioTech.Views.Multas
{
    partial class frmMultasPendientes
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
            this.dgvMultasPendientes = new System.Windows.Forms.DataGridView();
            this.colLector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaLimite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiasMora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalMulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMultasPendientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMultasPendientes
            // 
            this.dgvMultasPendientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMultasPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMultasPendientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLector,
            this.colFechaLimite,
            this.colDiasMora,
            this.colTotalMulta});
            this.dgvMultasPendientes.Location = new System.Drawing.Point(24, 103);
            this.dgvMultasPendientes.Name = "dgvMultasPendientes";
            this.dgvMultasPendientes.Size = new System.Drawing.Size(607, 255);
            this.dgvMultasPendientes.TabIndex = 0;
            // 
            // colLector
            // 
            this.colLector.HeaderText = "Usuario";
            this.colLector.Name = "colLector";
            this.colLector.ReadOnly = true;
            // 
            // colFechaLimite
            // 
            this.colFechaLimite.HeaderText = "Fecha Limite";
            this.colFechaLimite.Name = "colFechaLimite";
            this.colFechaLimite.ReadOnly = true;
            // 
            // colDiasMora
            // 
            this.colDiasMora.HeaderText = "Dias Mora";
            this.colDiasMora.Name = "colDiasMora";
            this.colDiasMora.ReadOnly = true;
            // 
            // colTotalMulta
            // 
            this.colTotalMulta.HeaderText = "Total Multa";
            this.colTotalMulta.Name = "colTotalMulta";
            this.colTotalMulta.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar Usuario:";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(163, 38);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(155, 20);
            this.txtBusqueda.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(371, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Total a Cobrar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(599, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Lps";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.SandyBrown;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.Location = new System.Drawing.Point(488, 374);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(105, 13);
            this.txtTotal.TabIndex = 12;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Gray;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.Coral;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(323, 32);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(30, 26);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // frmMultasPendientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(723, 450);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMultasPendientes);
            this.Name = "frmMultasPendientes";
            this.Text = "Multas Pendientes";
            this.Load += new System.EventHandler(this.frmMultasPendientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMultasPendientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMultasPendientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLector;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaLimite;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiasMora;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalMulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotal;
    }
}