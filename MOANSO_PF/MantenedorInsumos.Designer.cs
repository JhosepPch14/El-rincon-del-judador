namespace MOANSO_PF
{
    partial class MantenedorInsumos
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
            this.txtIDInsumo = new System.Windows.Forms.TextBox();
            this.txtNombreInsumo = new System.Windows.Forms.TextBox();
            this.chbEstadoInsumo = new System.Windows.Forms.CheckBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnAgregarInsumo = new System.Windows.Forms.Button();
            this.btnModificarInsumo = new System.Windows.Forms.Button();
            this.btnInhabilitarInsumo = new System.Windows.Forms.Button();
            this.dgvInsumos = new System.Windows.Forms.DataGridView();
            this.txtCantidadInsumo = new System.Windows.Forms.TextBox();
            this.gbDatosInsumo = new System.Windows.Forms.GroupBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnDatos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumos)).BeginInit();
            this.gbDatosInsumo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Insumo:";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre del Insumo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad :";
            // 
            // txtIDInsumo
            // 
            this.txtIDInsumo.Location = new System.Drawing.Point(114, 116);
            this.txtIDInsumo.Name = "txtIDInsumo";
            this.txtIDInsumo.Size = new System.Drawing.Size(104, 27);
            this.txtIDInsumo.TabIndex = 4;
            this.txtIDInsumo.Visible = false;
            // 
            // txtNombreInsumo
            // 
            this.txtNombreInsumo.Location = new System.Drawing.Point(18, 75);
            this.txtNombreInsumo.Name = "txtNombreInsumo";
            this.txtNombreInsumo.Size = new System.Drawing.Size(200, 27);
            this.txtNombreInsumo.TabIndex = 5;
            // 
            // chbEstadoInsumo
            // 
            this.chbEstadoInsumo.AutoSize = true;
            this.chbEstadoInsumo.Location = new System.Drawing.Point(10, 198);
            this.chbEstadoInsumo.Name = "chbEstadoInsumo";
            this.chbEstadoInsumo.Size = new System.Drawing.Size(76, 24);
            this.chbEstadoInsumo.TabIndex = 7;
            this.chbEstadoInsumo.Text = "Estado";
            this.chbEstadoInsumo.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(49, 406);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(85, 32);
            this.btnRegresar.TabIndex = 8;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(530, 406);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(82, 32);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(683, 406);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(80, 32);
            this.btnConfirmar.TabIndex = 10;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnAgregarInsumo
            // 
            this.btnAgregarInsumo.Location = new System.Drawing.Point(59, 292);
            this.btnAgregarInsumo.Name = "btnAgregarInsumo";
            this.btnAgregarInsumo.Size = new System.Drawing.Size(75, 33);
            this.btnAgregarInsumo.TabIndex = 11;
            this.btnAgregarInsumo.Text = "Agregar";
            this.btnAgregarInsumo.UseVisualStyleBackColor = true;
            this.btnAgregarInsumo.Click += new System.EventHandler(this.btnAgregarInsumo_Click);
            // 
            // btnModificarInsumo
            // 
            this.btnModificarInsumo.Location = new System.Drawing.Point(199, 292);
            this.btnModificarInsumo.Name = "btnModificarInsumo";
            this.btnModificarInsumo.Size = new System.Drawing.Size(80, 33);
            this.btnModificarInsumo.TabIndex = 12;
            this.btnModificarInsumo.Text = "Modificar";
            this.btnModificarInsumo.UseVisualStyleBackColor = true;
            this.btnModificarInsumo.Click += new System.EventHandler(this.btnModificarInsumo_Click);
            // 
            // btnInhabilitarInsumo
            // 
            this.btnInhabilitarInsumo.Location = new System.Drawing.Point(128, 343);
            this.btnInhabilitarInsumo.Name = "btnInhabilitarInsumo";
            this.btnInhabilitarInsumo.Size = new System.Drawing.Size(85, 31);
            this.btnInhabilitarInsumo.TabIndex = 13;
            this.btnInhabilitarInsumo.Text = "Inhabilitar";
            this.btnInhabilitarInsumo.UseVisualStyleBackColor = true;
            this.btnInhabilitarInsumo.Click += new System.EventHandler(this.btnInhabilitarInsumo_Click);
            // 
            // dgvInsumos
            // 
            this.dgvInsumos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInsumos.Location = new System.Drawing.Point(299, 41);
            this.dgvInsumos.Name = "dgvInsumos";
            this.dgvInsumos.RowHeadersWidth = 51;
            this.dgvInsumos.Size = new System.Drawing.Size(464, 251);
            this.dgvInsumos.TabIndex = 14;
            this.dgvInsumos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInsumos_CellContentClick);
            // 
            // txtCantidadInsumo
            // 
            this.txtCantidadInsumo.Location = new System.Drawing.Point(114, 154);
            this.txtCantidadInsumo.Name = "txtCantidadInsumo";
            this.txtCantidadInsumo.Size = new System.Drawing.Size(104, 27);
            this.txtCantidadInsumo.TabIndex = 15;
            // 
            // gbDatosInsumo
            // 
            this.gbDatosInsumo.Controls.Add(this.chbEstadoInsumo);
            this.gbDatosInsumo.Controls.Add(this.txtCantidadInsumo);
            this.gbDatosInsumo.Controls.Add(this.label2);
            this.gbDatosInsumo.Controls.Add(this.label3);
            this.gbDatosInsumo.Controls.Add(this.label4);
            this.gbDatosInsumo.Controls.Add(this.txtIDInsumo);
            this.gbDatosInsumo.Controls.Add(this.txtNombreInsumo);
            this.gbDatosInsumo.Location = new System.Drawing.Point(49, 41);
            this.gbDatosInsumo.Name = "gbDatosInsumo";
            this.gbDatosInsumo.Size = new System.Drawing.Size(244, 228);
            this.gbDatosInsumo.TabIndex = 16;
            this.gbDatosInsumo.TabStop = false;
            this.gbDatosInsumo.Text = "Datos del Insumo:";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(360, 298);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(82, 27);
            this.btnNuevo.TabIndex = 25;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnDatos
            // 
            this.btnDatos.Location = new System.Drawing.Point(508, 298);
            this.btnDatos.Name = "btnDatos";
            this.btnDatos.Size = new System.Drawing.Size(77, 27);
            this.btnDatos.TabIndex = 24;
            this.btnDatos.Text = "Editar Datos";
            this.btnDatos.UseVisualStyleBackColor = true;
            this.btnDatos.Click += new System.EventHandler(this.btnDatos_Click);
            // 
            // MantenedorInsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(237)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(813, 450);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnDatos);
            this.Controls.Add(this.gbDatosInsumo);
            this.Controls.Add(this.dgvInsumos);
            this.Controls.Add(this.btnInhabilitarInsumo);
            this.Controls.Add(this.btnModificarInsumo);
            this.Controls.Add(this.btnAgregarInsumo);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegresar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "MantenedorInsumos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insumos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumos)).EndInit();
            this.gbDatosInsumo.ResumeLayout(false);
            this.gbDatosInsumo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIDInsumo;
        private System.Windows.Forms.TextBox txtNombreInsumo;
        private System.Windows.Forms.CheckBox chbEstadoInsumo;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnAgregarInsumo;
        private System.Windows.Forms.Button btnModificarInsumo;
        private System.Windows.Forms.Button btnInhabilitarInsumo;
        private System.Windows.Forms.DataGridView dgvInsumos;
        private System.Windows.Forms.TextBox txtCantidadInsumo;
        private System.Windows.Forms.GroupBox gbDatosInsumo;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnDatos;
    }
}