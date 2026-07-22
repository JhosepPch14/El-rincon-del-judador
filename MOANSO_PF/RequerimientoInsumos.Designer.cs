namespace MOANSO_PF
{
    partial class RequerimientoInsumos
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.chbEstadoReq = new System.Windows.Forms.CheckBox();
            this.btnAgregarDetalle = new System.Windows.Forms.Button();
            this.dgvReqInsum = new System.Windows.Forms.DataGridView();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnListo = new System.Windows.Forms.Button();
            this.cbInsumos = new System.Windows.Forms.ComboBox();
            this.gbDatosReq = new System.Windows.Forms.GroupBox();
            this.btnEliminarDetalle = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnAnular = new System.Windows.Forms.Button();
            this.dtpFRegistro = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvDetalleReq = new System.Windows.Forms.DataGridView();
            this.btnRDetalle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDRequerimiento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbEnAlmacen = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReqInsum)).BeginInit();
            this.gbDatosReq.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleReq)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Insumo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(231, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(262, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Requerimiento de Compra";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(117, 80);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(121, 27);
            this.txtCantidad.TabIndex = 5;
            // 
            // chbEstadoReq
            // 
            this.chbEstadoReq.AutoSize = true;
            this.chbEstadoReq.Location = new System.Drawing.Point(695, 178);
            this.chbEstadoReq.Name = "chbEstadoReq";
            this.chbEstadoReq.Size = new System.Drawing.Size(76, 24);
            this.chbEstadoReq.TabIndex = 6;
            this.chbEstadoReq.Text = "Estado";
            this.chbEstadoReq.UseVisualStyleBackColor = true;
            // 
            // btnAgregarDetalle
            // 
            this.btnAgregarDetalle.Location = new System.Drawing.Point(151, 429);
            this.btnAgregarDetalle.Name = "btnAgregarDetalle";
            this.btnAgregarDetalle.Size = new System.Drawing.Size(75, 50);
            this.btnAgregarDetalle.TabIndex = 8;
            this.btnAgregarDetalle.Text = "Agregar Detalle";
            this.btnAgregarDetalle.UseVisualStyleBackColor = true;
            this.btnAgregarDetalle.Click += new System.EventHandler(this.btnAgregarDetalle_Click);
            // 
            // dgvReqInsum
            // 
            this.dgvReqInsum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReqInsum.Location = new System.Drawing.Point(111, 79);
            this.dgvReqInsum.Name = "dgvReqInsum";
            this.dgvReqInsum.ReadOnly = true;
            this.dgvReqInsum.RowHeadersWidth = 51;
            this.dgvReqInsum.Size = new System.Drawing.Size(485, 172);
            this.dgvReqInsum.TabIndex = 14;
            this.dgvReqInsum.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReqInsum_CellContentClick);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(29, 522);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 30);
            this.btnRegresar.TabIndex = 15;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(475, 522);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(76, 30);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnListo
            // 
            this.btnListo.Location = new System.Drawing.Point(728, 522);
            this.btnListo.Name = "btnListo";
            this.btnListo.Size = new System.Drawing.Size(83, 30);
            this.btnListo.TabIndex = 17;
            this.btnListo.Text = "Confirmar";
            this.btnListo.UseVisualStyleBackColor = true;
            // 
            // cbInsumos
            // 
            this.cbInsumos.FormattingEnabled = true;
            this.cbInsumos.Location = new System.Drawing.Point(117, 32);
            this.cbInsumos.Name = "cbInsumos";
            this.cbInsumos.Size = new System.Drawing.Size(121, 28);
            this.cbInsumos.TabIndex = 18;
            // 
            // gbDatosReq
            // 
            this.gbDatosReq.Controls.Add(this.label2);
            this.gbDatosReq.Controls.Add(this.cbInsumos);
            this.gbDatosReq.Controls.Add(this.label3);
            this.gbDatosReq.Controls.Add(this.txtCantidad);
            this.gbDatosReq.Location = new System.Drawing.Point(29, 268);
            this.gbDatosReq.Name = "gbDatosReq";
            this.gbDatosReq.Size = new System.Drawing.Size(326, 155);
            this.gbDatosReq.TabIndex = 19;
            this.gbDatosReq.TabStop = false;
            this.gbDatosReq.Text = "Insumos Requeridos";
            // 
            // btnEliminarDetalle
            // 
            this.btnEliminarDetalle.Location = new System.Drawing.Point(29, 429);
            this.btnEliminarDetalle.Name = "btnEliminarDetalle";
            this.btnEliminarDetalle.Size = new System.Drawing.Size(75, 50);
            this.btnEliminarDetalle.TabIndex = 20;
            this.btnEliminarDetalle.Text = "Eliminar Detalle";
            this.btnEliminarDetalle.UseVisualStyleBackColor = true;
            this.btnEliminarDetalle.Click += new System.EventHandler(this.btnEliminarDetalle_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(607, 219);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(82, 32);
            this.btnRegistrar.TabIndex = 21;
            this.btnRegistrar.Text = "Generar Requerimiento";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnAnular
            // 
            this.btnAnular.Location = new System.Drawing.Point(607, 83);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(82, 27);
            this.btnAnular.TabIndex = 22;
            this.btnAnular.Text = "Anular Requerimiento";
            this.btnAnular.UseVisualStyleBackColor = true;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // dtpFRegistro
            // 
            this.dtpFRegistro.Location = new System.Drawing.Point(466, 50);
            this.dtpFRegistro.Name = "dtpFRegistro";
            this.dtpFRegistro.Size = new System.Drawing.Size(200, 27);
            this.dtpFRegistro.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(318, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Fecha de Registro:";
            // 
            // dgvDetalleReq
            // 
            this.dgvDetalleReq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleReq.Location = new System.Drawing.Point(361, 268);
            this.dgvDetalleReq.Name = "dgvDetalleReq";
            this.dgvDetalleReq.ReadOnly = true;
            this.dgvDetalleReq.RowHeadersWidth = 51;
            this.dgvDetalleReq.Size = new System.Drawing.Size(475, 222);
            this.dgvDetalleReq.TabIndex = 25;
            this.dgvDetalleReq.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalleReq_CellContentClick);
            // 
            // btnRDetalle
            // 
            this.btnRDetalle.Location = new System.Drawing.Point(273, 429);
            this.btnRDetalle.Name = "btnRDetalle";
            this.btnRDetalle.Size = new System.Drawing.Size(82, 50);
            this.btnRDetalle.TabIndex = 26;
            this.btnRDetalle.Text = "Registrar Detalle";
            this.btnRDetalle.UseVisualStyleBackColor = true;
            this.btnRDetalle.Click += new System.EventHandler(this.btnRDetalle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "ID Requerimiento:";
            this.label1.Visible = false;
            // 
            // txtIDRequerimiento
            // 
            this.txtIDRequerimiento.Location = new System.Drawing.Point(219, 50);
            this.txtIDRequerimiento.Name = "txtIDRequerimiento";
            this.txtIDRequerimiento.Size = new System.Drawing.Size(78, 27);
            this.txtIDRequerimiento.TabIndex = 28;
            this.txtIDRequerimiento.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(614, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Encargado Almacen ";
            // 
            // cbEnAlmacen
            // 
            this.cbEnAlmacen.FormattingEnabled = true;
            this.cbEnAlmacen.Location = new System.Drawing.Point(766, 127);
            this.cbEnAlmacen.Name = "cbEnAlmacen";
            this.cbEnAlmacen.Size = new System.Drawing.Size(121, 28);
            this.cbEnAlmacen.TabIndex = 30;
            // 
            // RequerimientoInsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(237)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(917, 564);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbEnAlmacen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIDRequerimiento);
            this.Controls.Add(this.btnRDetalle);
            this.Controls.Add(this.dgvDetalleReq);
            this.Controls.Add(this.dtpFRegistro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chbEstadoReq);
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnEliminarDetalle);
            this.Controls.Add(this.gbDatosReq);
            this.Controls.Add(this.btnListo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.dgvReqInsum);
            this.Controls.Add(this.btnAgregarDetalle);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "RequerimientoInsumos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedido de Insumos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReqInsum)).EndInit();
            this.gbDatosReq.ResumeLayout(false);
            this.gbDatosReq.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleReq)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.CheckBox chbEstadoReq;
        private System.Windows.Forms.Button btnAgregarDetalle;
        private System.Windows.Forms.DataGridView dgvReqInsum;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnListo;
        private System.Windows.Forms.ComboBox cbInsumos;
        private System.Windows.Forms.GroupBox gbDatosReq;
        private System.Windows.Forms.Button btnEliminarDetalle;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.DateTimePicker dtpFRegistro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvDetalleReq;
        private System.Windows.Forms.Button btnRDetalle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDRequerimiento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbEnAlmacen;
    }
}