namespace MOANSO_PF
{
    partial class CompraInsumos
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
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRegistrarCompra = new System.Windows.Forms.Button();
            this.btnAnularReq = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.dgvCompraReq = new System.Windows.Forms.DataGridView();
            this.dtpFechaCompra = new System.Windows.Forms.DateTimePicker();
            this.txtIDCompra = new System.Windows.Forms.TextBox();
            this.txtEncargado = new System.Windows.Forms.TextBox();
            this.txtMontoTotal = new System.Windows.Forms.TextBox();
            this.txtMetodoPago = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbIDReq = new System.Windows.Forms.ComboBox();
            this.cbIDProveedor = new System.Windows.Forms.ComboBox();
            this.gbDatosCompra = new System.Windows.Forms.GroupBox();
            this.chbEstadoCompra = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompraReq)).BeginInit();
            this.gbDatosCompra.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(337, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(262, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Compra de Requerimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(652, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID:";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID Requerimiento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "ID Proveedor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(271, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Encargado:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(271, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Fecha de Compra:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(657, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Monto Total:";
            // 
            // btnRegistrarCompra
            // 
            this.btnRegistrarCompra.Location = new System.Drawing.Point(747, 393);
            this.btnRegistrarCompra.Name = "btnRegistrarCompra";
            this.btnRegistrarCompra.Size = new System.Drawing.Size(100, 30);
            this.btnRegistrarCompra.TabIndex = 13;
            this.btnRegistrarCompra.Text = "Registrar Compra";
            this.btnRegistrarCompra.UseVisualStyleBackColor = true;
            this.btnRegistrarCompra.Click += new System.EventHandler(this.btnRegistrarCompra_Click);
            // 
            // btnAnularReq
            // 
            this.btnAnularReq.Location = new System.Drawing.Point(747, 243);
            this.btnAnularReq.Name = "btnAnularReq";
            this.btnAnularReq.Size = new System.Drawing.Size(100, 30);
            this.btnAnularReq.TabIndex = 14;
            this.btnAnularReq.Text = "Anular Compra";
            this.btnAnularReq.UseVisualStyleBackColor = true;
            this.btnAnularReq.Click += new System.EventHandler(this.btnAnularReq_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(44, 442);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 30);
            this.btnRegresar.TabIndex = 15;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(499, 442);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 30);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(626, 442);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(84, 30);
            this.btnConfirmar.TabIndex = 17;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // dgvCompraReq
            // 
            this.dgvCompraReq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompraReq.Location = new System.Drawing.Point(29, 226);
            this.dgvCompraReq.Name = "dgvCompraReq";
            this.dgvCompraReq.ReadOnly = true;
            this.dgvCompraReq.RowHeadersWidth = 51;
            this.dgvCompraReq.Size = new System.Drawing.Size(712, 210);
            this.dgvCompraReq.TabIndex = 18;
            this.dgvCompraReq.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompraReq_CellContentClick);
            // 
            // dtpFechaCompra
            // 
            this.dtpFechaCompra.Location = new System.Drawing.Point(405, 64);
            this.dtpFechaCompra.Name = "dtpFechaCompra";
            this.dtpFechaCompra.Size = new System.Drawing.Size(200, 27);
            this.dtpFechaCompra.TabIndex = 19;
            // 
            // txtIDCompra
            // 
            this.txtIDCompra.Location = new System.Drawing.Point(700, 47);
            this.txtIDCompra.Name = "txtIDCompra";
            this.txtIDCompra.Size = new System.Drawing.Size(100, 27);
            this.txtIDCompra.TabIndex = 20;
            this.txtIDCompra.Visible = false;
            // 
            // txtEncargado
            // 
            this.txtEncargado.Location = new System.Drawing.Point(405, 35);
            this.txtEncargado.Name = "txtEncargado";
            this.txtEncargado.Size = new System.Drawing.Size(100, 27);
            this.txtEncargado.TabIndex = 23;
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.Location = new System.Drawing.Point(786, 66);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.Size = new System.Drawing.Size(100, 27);
            this.txtMontoTotal.TabIndex = 24;
            // 
            // txtMetodoPago
            // 
            this.txtMetodoPago.Location = new System.Drawing.Point(786, 37);
            this.txtMetodoPago.Name = "txtMetodoPago";
            this.txtMetodoPago.Size = new System.Drawing.Size(100, 27);
            this.txtMetodoPago.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(657, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Metodo de Pago:";
            // 
            // cbIDReq
            // 
            this.cbIDReq.FormattingEnabled = true;
            this.cbIDReq.Location = new System.Drawing.Point(146, 33);
            this.cbIDReq.Name = "cbIDReq";
            this.cbIDReq.Size = new System.Drawing.Size(121, 28);
            this.cbIDReq.TabIndex = 27;
            // 
            // cbIDProveedor
            // 
            this.cbIDProveedor.FormattingEnabled = true;
            this.cbIDProveedor.Location = new System.Drawing.Point(144, 63);
            this.cbIDProveedor.Name = "cbIDProveedor";
            this.cbIDProveedor.Size = new System.Drawing.Size(121, 28);
            this.cbIDProveedor.TabIndex = 28;
            // 
            // gbDatosCompra
            // 
            this.gbDatosCompra.Controls.Add(this.chbEstadoCompra);
            this.gbDatosCompra.Controls.Add(this.label3);
            this.gbDatosCompra.Controls.Add(this.cbIDProveedor);
            this.gbDatosCompra.Controls.Add(this.label5);
            this.gbDatosCompra.Controls.Add(this.cbIDReq);
            this.gbDatosCompra.Controls.Add(this.label6);
            this.gbDatosCompra.Controls.Add(this.txtMetodoPago);
            this.gbDatosCompra.Controls.Add(this.label7);
            this.gbDatosCompra.Controls.Add(this.label9);
            this.gbDatosCompra.Controls.Add(this.label8);
            this.gbDatosCompra.Controls.Add(this.txtMontoTotal);
            this.gbDatosCompra.Controls.Add(this.dtpFechaCompra);
            this.gbDatosCompra.Controls.Add(this.txtEncargado);
            this.gbDatosCompra.Location = new System.Drawing.Point(29, 73);
            this.gbDatosCompra.Name = "gbDatosCompra";
            this.gbDatosCompra.Size = new System.Drawing.Size(901, 147);
            this.gbDatosCompra.TabIndex = 29;
            this.gbDatosCompra.TabStop = false;
            this.gbDatosCompra.Text = "Datos de Compra";
            // 
            // chbEstadoCompra
            // 
            this.chbEstadoCompra.AutoSize = true;
            this.chbEstadoCompra.Location = new System.Drawing.Point(405, 107);
            this.chbEstadoCompra.Name = "chbEstadoCompra";
            this.chbEstadoCompra.Size = new System.Drawing.Size(133, 24);
            this.chbEstadoCompra.TabIndex = 29;
            this.chbEstadoCompra.Text = "Estado Compra";
            this.chbEstadoCompra.UseVisualStyleBackColor = true;
            // 
            // CompraInsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(237)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(959, 517);
            this.Controls.Add(this.gbDatosCompra);
            this.Controls.Add(this.txtIDCompra);
            this.Controls.Add(this.dgvCompraReq);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnAnularReq);
            this.Controls.Add(this.btnRegistrarCompra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "CompraInsumos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compra de Insumos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompraReq)).EndInit();
            this.gbDatosCompra.ResumeLayout(false);
            this.gbDatosCompra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRegistrarCompra;
        private System.Windows.Forms.Button btnAnularReq;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.DataGridView dgvCompraReq;
        private System.Windows.Forms.DateTimePicker dtpFechaCompra;
        private System.Windows.Forms.TextBox txtIDCompra;
        private System.Windows.Forms.TextBox txtEncargado;
        private System.Windows.Forms.TextBox txtMontoTotal;
        private System.Windows.Forms.TextBox txtMetodoPago;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbIDReq;
        private System.Windows.Forms.ComboBox cbIDProveedor;
        private System.Windows.Forms.GroupBox gbDatosCompra;
        private System.Windows.Forms.CheckBox chbEstadoCompra;
    }
}