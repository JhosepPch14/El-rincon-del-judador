namespace MOANSO_PF
{
    partial class MantenedorEncargardoAlmacen
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
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnDatos = new System.Windows.Forms.Button();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.lblIdCliente = new System.Windows.Forms.Label();
            this.chbEstadoEnAlmacen = new System.Windows.Forms.CheckBox();
            this.lblDNICliente = new System.Windows.Forms.Label();
            this.dtpFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumeroEnAlmacen = new System.Windows.Forms.TextBox();
            this.txtNombreEnAlmacen = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtDNIEnAlmacen = new System.Windows.Forms.TextBox();
            this.txtIDEnAlmacen = new System.Windows.Forms.TextBox();
            this.dgvEnAlmacen = new System.Windows.Forms.DataGridView();
            this.btnInhabilitar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.gbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnAlmacen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(357, 346);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(80, 30);
            this.btnNuevo.TabIndex = 33;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnDatos
            // 
            this.btnDatos.Location = new System.Drawing.Point(505, 346);
            this.btnDatos.Name = "btnDatos";
            this.btnDatos.Size = new System.Drawing.Size(78, 30);
            this.btnDatos.TabIndex = 32;
            this.btnDatos.Text = "Editar Datos";
            this.btnDatos.UseVisualStyleBackColor = true;
            this.btnDatos.Click += new System.EventHandler(this.btnDatos_Click);
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.lblIdCliente);
            this.gbDatos.Controls.Add(this.chbEstadoEnAlmacen);
            this.gbDatos.Controls.Add(this.lblDNICliente);
            this.gbDatos.Controls.Add(this.dtpFechaRegistro);
            this.gbDatos.Controls.Add(this.lblNombre);
            this.gbDatos.Controls.Add(this.lblNumero);
            this.gbDatos.Controls.Add(this.txtNumeroEnAlmacen);
            this.gbDatos.Controls.Add(this.txtNombreEnAlmacen);
            this.gbDatos.Controls.Add(this.lblFecha);
            this.gbDatos.Controls.Add(this.txtDNIEnAlmacen);
            this.gbDatos.Controls.Add(this.txtIDEnAlmacen);
            this.gbDatos.Location = new System.Drawing.Point(31, 26);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(308, 255);
            this.gbDatos.TabIndex = 31;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos del Encargado:";
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.Location = new System.Drawing.Point(43, 38);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(27, 20);
            this.lblIdCliente.TabIndex = 1;
            this.lblIdCliente.Text = "ID:";
            this.lblIdCliente.Visible = false;
            // 
            // chbEstadoEnAlmacen
            // 
            this.chbEstadoEnAlmacen.AutoSize = true;
            this.chbEstadoEnAlmacen.Location = new System.Drawing.Point(7, 218);
            this.chbEstadoEnAlmacen.Name = "chbEstadoEnAlmacen";
            this.chbEstadoEnAlmacen.Size = new System.Drawing.Size(76, 24);
            this.chbEstadoEnAlmacen.TabIndex = 20;
            this.chbEstadoEnAlmacen.Text = "Estado";
            this.chbEstadoEnAlmacen.UseVisualStyleBackColor = true;
            // 
            // lblDNICliente
            // 
            this.lblDNICliente.AutoSize = true;
            this.lblDNICliente.Location = new System.Drawing.Point(32, 77);
            this.lblDNICliente.Name = "lblDNICliente";
            this.lblDNICliente.Size = new System.Drawing.Size(38, 20);
            this.lblDNICliente.TabIndex = 2;
            this.lblDNICliente.Text = "DNI:";
            // 
            // dtpFechaRegistro
            // 
            this.dtpFechaRegistro.Location = new System.Drawing.Point(97, 180);
            this.dtpFechaRegistro.Name = "dtpFechaRegistro";
            this.dtpFechaRegistro.Size = new System.Drawing.Size(200, 27);
            this.dtpFechaRegistro.TabIndex = 19;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(7, 113);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(67, 20);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(7, 148);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(66, 20);
            this.lblNumero.TabIndex = 4;
            this.lblNumero.Text = "Numero:";
            // 
            // txtNumeroEnAlmacen
            // 
            this.txtNumeroEnAlmacen.Location = new System.Drawing.Point(97, 145);
            this.txtNumeroEnAlmacen.Name = "txtNumeroEnAlmacen";
            this.txtNumeroEnAlmacen.Size = new System.Drawing.Size(100, 27);
            this.txtNumeroEnAlmacen.TabIndex = 17;
            // 
            // txtNombreEnAlmacen
            // 
            this.txtNombreEnAlmacen.Location = new System.Drawing.Point(97, 110);
            this.txtNombreEnAlmacen.Name = "txtNombreEnAlmacen";
            this.txtNombreEnAlmacen.Size = new System.Drawing.Size(100, 27);
            this.txtNombreEnAlmacen.TabIndex = 16;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(7, 183);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(50, 20);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "Fecha:";
            // 
            // txtDNIEnAlmacen
            // 
            this.txtDNIEnAlmacen.Location = new System.Drawing.Point(97, 77);
            this.txtDNIEnAlmacen.Name = "txtDNIEnAlmacen";
            this.txtDNIEnAlmacen.Size = new System.Drawing.Size(100, 27);
            this.txtDNIEnAlmacen.TabIndex = 15;
            // 
            // txtIDEnAlmacen
            // 
            this.txtIDEnAlmacen.Location = new System.Drawing.Point(97, 35);
            this.txtIDEnAlmacen.Name = "txtIDEnAlmacen";
            this.txtIDEnAlmacen.Size = new System.Drawing.Size(100, 27);
            this.txtIDEnAlmacen.TabIndex = 14;
            this.txtIDEnAlmacen.Visible = false;
            // 
            // dgvEnAlmacen
            // 
            this.dgvEnAlmacen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnAlmacen.Location = new System.Drawing.Point(357, 26);
            this.dgvEnAlmacen.Name = "dgvEnAlmacen";
            this.dgvEnAlmacen.ReadOnly = true;
            this.dgvEnAlmacen.RowHeadersWidth = 51;
            this.dgvEnAlmacen.Size = new System.Drawing.Size(470, 296);
            this.dgvEnAlmacen.TabIndex = 30;
            this.dgvEnAlmacen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEnAlmacen_CellContentClick);
            // 
            // btnInhabilitar
            // 
            this.btnInhabilitar.Location = new System.Drawing.Point(221, 340);
            this.btnInhabilitar.Name = "btnInhabilitar";
            this.btnInhabilitar.Size = new System.Drawing.Size(86, 36);
            this.btnInhabilitar.TabIndex = 29;
            this.btnInhabilitar.Text = "Inhabilitar";
            this.btnInhabilitar.UseVisualStyleBackColor = true;
            this.btnInhabilitar.Click += new System.EventHandler(this.btnInhabilitar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(29, 340);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(85, 36);
            this.btnModificar.TabIndex = 28;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(120, 340);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(85, 36);
            this.btnAgregar.TabIndex = 27;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(740, 430);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(87, 38);
            this.btnConfirmar.TabIndex = 26;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(390, 430);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(82, 38);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(20, 430);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(81, 38);
            this.btnRegresar.TabIndex = 24;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // MantenedorEncargardoAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(237)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(850, 480);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnDatos);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.dgvEnAlmacen);
            this.Controls.Add(this.btnInhabilitar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegresar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "MantenedorEncargardoAlmacen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Almacén";
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnAlmacen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnDatos;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Label lblIdCliente;
        private System.Windows.Forms.CheckBox chbEstadoEnAlmacen;
        private System.Windows.Forms.Label lblDNICliente;
        private System.Windows.Forms.DateTimePicker dtpFechaRegistro;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumeroEnAlmacen;
        private System.Windows.Forms.TextBox txtNombreEnAlmacen;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtDNIEnAlmacen;
        private System.Windows.Forms.TextBox txtIDEnAlmacen;
        private System.Windows.Forms.DataGridView dgvEnAlmacen;
        private System.Windows.Forms.Button btnInhabilitar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegresar;
    }
}