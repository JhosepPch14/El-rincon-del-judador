namespace MOANSO_PF
{
    partial class OrdenPedido
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtIdPedido = new System.Windows.Forms.TextBox();
            this.lblIdPedido = new System.Windows.Forms.Label();
            this.lblPlatillo = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.chbEstadoOrden = new System.Windows.Forms.CheckBox();
            this.dgvOrden = new System.Windows.Forms.DataGridView();
            this.btnAgregarPedido = new System.Windows.Forms.Button();
            this.btnModificarDetalle = new System.Windows.Forms.Button();
            this.lblFechaPedido = new System.Windows.Forms.Label();
            this.dtpFechaOrden = new System.Windows.Forms.DateTimePicker();
            this.lblClientePedido = new System.Windows.Forms.Label();
            this.cbPlatilloPedido = new System.Windows.Forms.ComboBox();
            this.btnGuardarDetalles = new System.Windows.Forms.Button();
            this.lblMeseroPedido = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.cbTPlatillo = new System.Windows.Forms.ComboBox();
            this.gbDatosOrdenPedido = new System.Windows.Forms.GroupBox();
            this.txtNroMesa = new System.Windows.Forms.TextBox();
            this.cbMeseros = new System.Windows.Forms.ComboBox();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudCantidadPlatillo = new System.Windows.Forms.NumericUpDown();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnEliminarDetalle = new System.Windows.Forms.Button();
            this.btnDeshOrden = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrden)).BeginInit();
            this.gbDatosOrdenPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadPlatillo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdPedido
            // 
            this.txtIdPedido.Location = new System.Drawing.Point(196, 52);
            this.txtIdPedido.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdPedido.Name = "txtIdPedido";
            this.txtIdPedido.Size = new System.Drawing.Size(132, 27);
            this.txtIdPedido.TabIndex = 0;
            this.txtIdPedido.Visible = false;
            // 
            // lblIdPedido
            // 
            this.lblIdPedido.AutoSize = true;
            this.lblIdPedido.Location = new System.Drawing.Point(45, 55);
            this.lblIdPedido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdPedido.Name = "lblIdPedido";
            this.lblIdPedido.Size = new System.Drawing.Size(150, 20);
            this.lblIdPedido.TabIndex = 1;
            this.lblIdPedido.Text = "Nro de Orden Pedido";
            this.lblIdPedido.Visible = false;
            // 
            // lblPlatillo
            // 
            this.lblPlatillo.AutoSize = true;
            this.lblPlatillo.Location = new System.Drawing.Point(61, 112);
            this.lblPlatillo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlatillo.Name = "lblPlatillo";
            this.lblPlatillo.Size = new System.Drawing.Size(58, 20);
            this.lblPlatillo.TabIndex = 2;
            this.lblPlatillo.Text = "Platillo:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(61, 57);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(92, 20);
            this.lblCantidad.TabIndex = 3;
            this.lblCantidad.Text = "Tipo Platillo:";
            // 
            // chbEstadoOrden
            // 
            this.chbEstadoOrden.AutoSize = true;
            this.chbEstadoOrden.Location = new System.Drawing.Point(132, 245);
            this.chbEstadoOrden.Margin = new System.Windows.Forms.Padding(4);
            this.chbEstadoOrden.Name = "chbEstadoOrden";
            this.chbEstadoOrden.Size = new System.Drawing.Size(82, 24);
            this.chbEstadoOrden.TabIndex = 10;
            this.chbEstadoOrden.Text = "Elegido";
            this.chbEstadoOrden.UseVisualStyleBackColor = true;
            // 
            // dgvOrden
            // 
            this.dgvOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrden.Location = new System.Drawing.Point(421, 78);
            this.dgvOrden.Margin = new System.Windows.Forms.Padding(4);
            this.dgvOrden.Name = "dgvOrden";
            this.dgvOrden.ReadOnly = true;
            this.dgvOrden.RowHeadersWidth = 51;
            this.dgvOrden.Size = new System.Drawing.Size(857, 255);
            this.dgvOrden.TabIndex = 12;
            this.dgvOrden.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrden_CellContentClick);
            // 
            // btnAgregarPedido
            // 
            this.btnAgregarPedido.Location = new System.Drawing.Point(889, 358);
            this.btnAgregarPedido.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarPedido.Name = "btnAgregarPedido";
            this.btnAgregarPedido.Size = new System.Drawing.Size(176, 38);
            this.btnAgregarPedido.TabIndex = 13;
            this.btnAgregarPedido.Text = "Generar Orden";
            this.btnAgregarPedido.UseVisualStyleBackColor = true;
            this.btnAgregarPedido.Click += new System.EventHandler(this.btnAgregarPedido_Click);
            // 
            // btnModificarDetalle
            // 
            this.btnModificarDetalle.Location = new System.Drawing.Point(1301, 600);
            this.btnModificarDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificarDetalle.Name = "btnModificarDetalle";
            this.btnModificarDetalle.Size = new System.Drawing.Size(157, 44);
            this.btnModificarDetalle.TabIndex = 17;
            this.btnModificarDetalle.Text = "Modificar Detalle";
            this.btnModificarDetalle.UseVisualStyleBackColor = true;
            this.btnModificarDetalle.Click += new System.EventHandler(this.btnModificarDetalle_Click);
            // 
            // lblFechaPedido
            // 
            this.lblFechaPedido.AutoSize = true;
            this.lblFechaPedido.Location = new System.Drawing.Point(45, 110);
            this.lblFechaPedido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaPedido.Name = "lblFechaPedido";
            this.lblFechaPedido.Size = new System.Drawing.Size(47, 20);
            this.lblFechaPedido.TabIndex = 20;
            this.lblFechaPedido.Text = "Fecha";
            // 
            // dtpFechaOrden
            // 
            this.dtpFechaOrden.Location = new System.Drawing.Point(103, 102);
            this.dtpFechaOrden.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaOrden.Name = "dtpFechaOrden";
            this.dtpFechaOrden.Size = new System.Drawing.Size(265, 27);
            this.dtpFechaOrden.TabIndex = 21;
            // 
            // lblClientePedido
            // 
            this.lblClientePedido.AutoSize = true;
            this.lblClientePedido.Location = new System.Drawing.Point(39, 161);
            this.lblClientePedido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClientePedido.Name = "lblClientePedido";
            this.lblClientePedido.Size = new System.Drawing.Size(76, 20);
            this.lblClientePedido.TabIndex = 25;
            this.lblClientePedido.Text = "Nro Mesa:";
            // 
            // cbPlatilloPedido
            // 
            this.cbPlatilloPedido.FormattingEnabled = true;
            this.cbPlatilloPedido.Location = new System.Drawing.Point(155, 102);
            this.cbPlatilloPedido.Margin = new System.Windows.Forms.Padding(4);
            this.cbPlatilloPedido.Name = "cbPlatilloPedido";
            this.cbPlatilloPedido.Size = new System.Drawing.Size(160, 28);
            this.cbPlatilloPedido.TabIndex = 29;
            // 
            // btnGuardarDetalles
            // 
            this.btnGuardarDetalles.Location = new System.Drawing.Point(1082, 667);
            this.btnGuardarDetalles.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarDetalles.Name = "btnGuardarDetalles";
            this.btnGuardarDetalles.Size = new System.Drawing.Size(157, 44);
            this.btnGuardarDetalles.TabIndex = 31;
            this.btnGuardarDetalles.Text = "Guardar Detalle";
            this.btnGuardarDetalles.UseVisualStyleBackColor = true;
            this.btnGuardarDetalles.Click += new System.EventHandler(this.btnGuardarDetalles_Click);
            // 
            // lblMeseroPedido
            // 
            this.lblMeseroPedido.AutoSize = true;
            this.lblMeseroPedido.Location = new System.Drawing.Point(39, 209);
            this.lblMeseroPedido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMeseroPedido.Name = "lblMeseroPedido";
            this.lblMeseroPedido.Size = new System.Drawing.Size(61, 20);
            this.lblMeseroPedido.TabIndex = 32;
            this.lblMeseroPedido.Text = "Mesero:";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(965, 698);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(100, 41);
            this.btnConfirmar.TabIndex = 37;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(620, 698);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 41);
            this.btnCancelar.TabIndex = 36;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(25, 698);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(101, 41);
            this.btnRegresar.TabIndex = 35;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // cbTPlatillo
            // 
            this.cbTPlatillo.FormattingEnabled = true;
            this.cbTPlatillo.Location = new System.Drawing.Point(155, 47);
            this.cbTPlatillo.Margin = new System.Windows.Forms.Padding(4);
            this.cbTPlatillo.Name = "cbTPlatillo";
            this.cbTPlatillo.Size = new System.Drawing.Size(160, 28);
            this.cbTPlatillo.TabIndex = 38;
            this.cbTPlatillo.SelectedIndexChanged += new System.EventHandler(this.cbTPlatillo_SelectedIndexChanged);
            // 
            // gbDatosOrdenPedido
            // 
            this.gbDatosOrdenPedido.Controls.Add(this.txtNroMesa);
            this.gbDatosOrdenPedido.Controls.Add(this.cbMeseros);
            this.gbDatosOrdenPedido.Controls.Add(this.chbEstadoOrden);
            this.gbDatosOrdenPedido.Controls.Add(this.lblMeseroPedido);
            this.gbDatosOrdenPedido.Controls.Add(this.lblClientePedido);
            this.gbDatosOrdenPedido.Controls.Add(this.lblIdPedido);
            this.gbDatosOrdenPedido.Controls.Add(this.txtIdPedido);
            this.gbDatosOrdenPedido.Controls.Add(this.lblFechaPedido);
            this.gbDatosOrdenPedido.Controls.Add(this.dtpFechaOrden);
            this.gbDatosOrdenPedido.Location = new System.Drawing.Point(28, 66);
            this.gbDatosOrdenPedido.Margin = new System.Windows.Forms.Padding(4);
            this.gbDatosOrdenPedido.Name = "gbDatosOrdenPedido";
            this.gbDatosOrdenPedido.Padding = new System.Windows.Forms.Padding(4);
            this.gbDatosOrdenPedido.Size = new System.Drawing.Size(385, 330);
            this.gbDatosOrdenPedido.TabIndex = 39;
            this.gbDatosOrdenPedido.TabStop = false;
            this.gbDatosOrdenPedido.Text = "Datos Orden de Pedido";
            // 
            // txtNroMesa
            // 
            this.txtNroMesa.Location = new System.Drawing.Point(123, 151);
            this.txtNroMesa.Margin = new System.Windows.Forms.Padding(4);
            this.txtNroMesa.Name = "txtNroMesa";
            this.txtNroMesa.Size = new System.Drawing.Size(132, 27);
            this.txtNroMesa.TabIndex = 42;
            // 
            // cbMeseros
            // 
            this.cbMeseros.FormattingEnabled = true;
            this.cbMeseros.Location = new System.Drawing.Point(104, 199);
            this.cbMeseros.Margin = new System.Windows.Forms.Padding(4);
            this.cbMeseros.Name = "cbMeseros";
            this.cbMeseros.Size = new System.Drawing.Size(160, 28);
            this.cbMeseros.TabIndex = 41;
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Location = new System.Drawing.Point(28, 407);
            this.dgvDetalles.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.RowHeadersWidth = 51;
            this.dgvDetalles.Size = new System.Drawing.Size(1037, 267);
            this.dgvDetalles.TabIndex = 40;
            this.dgvDetalles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalles_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudCantidadPlatillo);
            this.groupBox1.Controls.Add(this.cbPlatilloPedido);
            this.groupBox1.Controls.Add(this.lblPlatillo);
            this.groupBox1.Controls.Add(this.lblCantidad);
            this.groupBox1.Controls.Add(this.cbTPlatillo);
            this.groupBox1.Location = new System.Drawing.Point(1073, 407);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(385, 185);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles:";
            // 
            // nudCantidadPlatillo
            // 
            this.nudCantidadPlatillo.Location = new System.Drawing.Point(197, 135);
            this.nudCantidadPlatillo.Margin = new System.Windows.Forms.Padding(4);
            this.nudCantidadPlatillo.Name = "nudCantidadPlatillo";
            this.nudCantidadPlatillo.Size = new System.Drawing.Size(79, 27);
            this.nudCantidadPlatillo.TabIndex = 45;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(1301, 667);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(157, 44);
            this.btnRegistrar.TabIndex = 42;
            this.btnRegistrar.Text = "Registrar Detalles";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnEliminarDetalle
            // 
            this.btnEliminarDetalle.Location = new System.Drawing.Point(1082, 600);
            this.btnEliminarDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarDetalle.Name = "btnEliminarDetalle";
            this.btnEliminarDetalle.Size = new System.Drawing.Size(157, 44);
            this.btnEliminarDetalle.TabIndex = 43;
            this.btnEliminarDetalle.Text = "Eliminar Detalle";
            this.btnEliminarDetalle.UseVisualStyleBackColor = true;
            this.btnEliminarDetalle.Click += new System.EventHandler(this.btnEliminarDetalle_Click);
            // 
            // btnDeshOrden
            // 
            this.btnDeshOrden.Location = new System.Drawing.Point(421, 359);
            this.btnDeshOrden.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeshOrden.Name = "btnDeshOrden";
            this.btnDeshOrden.Size = new System.Drawing.Size(125, 37);
            this.btnDeshOrden.TabIndex = 44;
            this.btnDeshOrden.Text = "Deshabilitar Orden";
            this.btnDeshOrden.UseVisualStyleBackColor = true;
            this.btnDeshOrden.Click += new System.EventHandler(this.btnDeshOrden_Click);
            // 
            // OrdenPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(237)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(1483, 780);
            this.Controls.Add(this.btnDeshOrden);
            this.Controls.Add(this.btnEliminarDetalle);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDetalles);
            this.Controls.Add(this.gbDatosOrdenPedido);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnGuardarDetalles);
            this.Controls.Add(this.btnModificarDetalle);
            this.Controls.Add(this.btnAgregarPedido);
            this.Controls.Add(this.dgvOrden);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OrdenPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Pedido";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrden)).EndInit();
            this.gbDatosOrdenPedido.ResumeLayout(false);
            this.gbDatosOrdenPedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadPlatillo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdPedido;
        private System.Windows.Forms.Label lblIdPedido;
        private System.Windows.Forms.Label lblPlatillo;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.CheckBox chbEstadoOrden;
        private System.Windows.Forms.DataGridView dgvOrden;
        private System.Windows.Forms.Button btnAgregarPedido;
        private System.Windows.Forms.Button btnModificarDetalle;
        private System.Windows.Forms.Label lblFechaPedido;
        private System.Windows.Forms.DateTimePicker dtpFechaOrden;
        private System.Windows.Forms.Label lblClientePedido;
        private System.Windows.Forms.ComboBox cbPlatilloPedido;
        private System.Windows.Forms.Button btnGuardarDetalles;
        private System.Windows.Forms.Label lblMeseroPedido;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.ComboBox cbTPlatillo;
        private System.Windows.Forms.GroupBox gbDatosOrdenPedido;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.ComboBox cbMeseros;
        private System.Windows.Forms.TextBox txtNroMesa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudCantidadPlatillo;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnEliminarDetalle;
        private System.Windows.Forms.Button btnDeshOrden;
    }
}

