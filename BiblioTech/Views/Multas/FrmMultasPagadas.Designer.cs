namespace BiblioTech.Views.Multas
{
    partial class FrmMultasPagadas
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
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvMultasPagadas = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiasRetraso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMontoRecibido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTotalMultas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMultasPagadas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.SandyBrown;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.Location = new System.Drawing.Point(508, 95);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(105, 13);
            this.txtTotal.TabIndex = 16;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(619, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Lps";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(372, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Total Recaudado:";
            // 
            // dgvMultasPagadas
            // 
            this.dgvMultasPagadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMultasPagadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMultasPagadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colLector,
            this.colFechaPago,
            this.colDiasRetraso,
            this.colMontoRecibido});
            this.dgvMultasPagadas.Location = new System.Drawing.Point(36, 132);
            this.dgvMultasPagadas.Name = "dgvMultasPagadas";
            this.dgvMultasPagadas.Size = new System.Drawing.Size(636, 281);
            this.dgvMultasPagadas.TabIndex = 13;
            // 
            // colId
            // 
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colLector
            // 
            this.colLector.HeaderText = "Usuario";
            this.colLector.Name = "colLector";
            this.colLector.ReadOnly = true;
            // 
            // colFechaPago
            // 
            this.colFechaPago.HeaderText = "Fecha de Pago";
            this.colFechaPago.Name = "colFechaPago";
            this.colFechaPago.ReadOnly = true;
            // 
            // colDiasRetraso
            // 
            this.colDiasRetraso.HeaderText = "Dias de Retraso";
            this.colDiasRetraso.Name = "colDiasRetraso";
            this.colDiasRetraso.ReadOnly = true;
            // 
            // colMontoRecibido
            // 
            this.colMontoRecibido.HeaderText = "Monto Recibido";
            this.colMontoRecibido.Name = "colMontoRecibido";
            this.colMontoRecibido.ReadOnly = true;
            // 
            // txtTotalMultas
            // 
            this.txtTotalMultas.BackColor = System.Drawing.Color.SandyBrown;
            this.txtTotalMultas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalMultas.Location = new System.Drawing.Point(172, 99);
            this.txtTotalMultas.Name = "txtTotalMultas";
            this.txtTotalMultas.Size = new System.Drawing.Size(56, 13);
            this.txtTotalMultas.TabIndex = 19;
            this.txtTotalMultas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Lps";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Multas Totales:";
            // 
            // FrmMultasPagadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(710, 450);
            this.Controls.Add(this.txtTotalMultas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvMultasPagadas);
            this.Name = "FrmMultasPagadas";
            this.Text = "Multas Pagadas";
            this.Load += new System.EventHandler(this.FrmMultasPagadas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMultasPagadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvMultasPagadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLector;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiasRetraso;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMontoRecibido;
        private System.Windows.Forms.TextBox txtTotalMultas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}