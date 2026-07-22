namespace MOANSO_PF
{
    partial class MantenedorTipoPlatillo
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
            this.gbDatosTPlatillo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chbEstadoTPlatillo = new System.Windows.Forms.CheckBox();
            this.txtIdTPlatillo = new System.Windows.Forms.TextBox();
            this.txtNombreTPlatillo = new System.Windows.Forms.TextBox();
            this.btnInhabilitarTPlatillo = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnModificarTPlatillo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnAgregarTPlatillo = new System.Windows.Forms.Button();
            this.dgvTPlatillo = new System.Windows.Forms.DataGridView();
            this.btnNuevoTipo = new System.Windows.Forms.Button();
            this.btnDatosTipo = new System.Windows.Forms.Button();
            this.gbDatosTPlatillo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTPlatillo)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDatosTPlatillo
            // 
            this.gbDatosTPlatillo.Controls.Add(this.label1);
            this.gbDatosTPlatillo.Controls.Add(this.label2);
            this.gbDatosTPlatillo.Controls.Add(this.chbEstadoTPlatillo);
            this.gbDatosTPlatillo.Controls.Add(this.txtIdTPlatillo);
            this.gbDatosTPlatillo.Controls.Add(this.txtNombreTPlatillo);
            this.gbDatosTPlatillo.Location = new System.Drawing.Point(26, 38);
            this.gbDatosTPlatillo.Name = "gbDatosTPlatillo";
            this.gbDatosTPlatillo.Size = new System.Drawing.Size(294, 189);
            this.gbDatosTPlatillo.TabIndex = 23;
            this.gbDatosTPlatillo.TabStop = false;
            this.gbDatosTPlatillo.Text = "Datos del Tipo de Platillo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre del Tipo de Platillo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Tipo de Platillo:";
            this.label2.Visible = false;
            // 
            // chbEstadoTPlatillo
            // 
            this.chbEstadoTPlatillo.AutoSize = true;
            this.chbEstadoTPlatillo.Location = new System.Drawing.Point(24, 148);
            this.chbEstadoTPlatillo.Name = "chbEstadoTPlatillo";
            this.chbEstadoTPlatillo.Size = new System.Drawing.Size(76, 24);
            this.chbEstadoTPlatillo.TabIndex = 4;
            this.chbEstadoTPlatillo.Text = "Estado";
            this.chbEstadoTPlatillo.UseVisualStyleBackColor = true;
            // 
            // txtIdTPlatillo
            // 
            this.txtIdTPlatillo.Location = new System.Drawing.Point(172, 101);
            this.txtIdTPlatillo.Name = "txtIdTPlatillo";
            this.txtIdTPlatillo.Size = new System.Drawing.Size(100, 27);
            this.txtIdTPlatillo.TabIndex = 5;
            this.txtIdTPlatillo.Visible = false;
            // 
            // txtNombreTPlatillo
            // 
            this.txtNombreTPlatillo.Location = new System.Drawing.Point(24, 55);
            this.txtNombreTPlatillo.Name = "txtNombreTPlatillo";
            this.txtNombreTPlatillo.Size = new System.Drawing.Size(189, 27);
            this.txtNombreTPlatillo.TabIndex = 6;
            // 
            // btnInhabilitarTPlatillo
            // 
            this.btnInhabilitarTPlatillo.Location = new System.Drawing.Point(135, 281);
            this.btnInhabilitarTPlatillo.Name = "btnInhabilitarTPlatillo";
            this.btnInhabilitarTPlatillo.Size = new System.Drawing.Size(84, 27);
            this.btnInhabilitarTPlatillo.TabIndex = 22;
            this.btnInhabilitarTPlatillo.Text = "Inhabilitar";
            this.btnInhabilitarTPlatillo.UseVisualStyleBackColor = true;
            this.btnInhabilitarTPlatillo.Click += new System.EventHandler(this.btnInhabilitarTPlatillo_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(582, 370);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(86, 35);
            this.btnConfirmar.TabIndex = 19;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // btnModificarTPlatillo
            // 
            this.btnModificarTPlatillo.Location = new System.Drawing.Point(198, 233);
            this.btnModificarTPlatillo.Name = "btnModificarTPlatillo";
            this.btnModificarTPlatillo.Size = new System.Drawing.Size(83, 30);
            this.btnModificarTPlatillo.TabIndex = 21;
            this.btnModificarTPlatillo.Text = "Modificar";
            this.btnModificarTPlatillo.UseVisualStyleBackColor = true;
            this.btnModificarTPlatillo.Click += new System.EventHandler(this.btnModificarTPlatillo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(445, 370);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 35);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(54, 370);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(85, 35);
            this.btnRegresar.TabIndex = 17;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnAgregarTPlatillo
            // 
            this.btnAgregarTPlatillo.Location = new System.Drawing.Point(69, 233);
            this.btnAgregarTPlatillo.Name = "btnAgregarTPlatillo";
            this.btnAgregarTPlatillo.Size = new System.Drawing.Size(83, 30);
            this.btnAgregarTPlatillo.TabIndex = 20;
            this.btnAgregarTPlatillo.Text = "Agregar";
            this.btnAgregarTPlatillo.UseVisualStyleBackColor = true;
            this.btnAgregarTPlatillo.Click += new System.EventHandler(this.btnAgregarTPlatillo_Click);
            // 
            // dgvTPlatillo
            // 
            this.dgvTPlatillo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTPlatillo.Location = new System.Drawing.Point(326, 12);
            this.dgvTPlatillo.Name = "dgvTPlatillo";
            this.dgvTPlatillo.RowHeadersWidth = 51;
            this.dgvTPlatillo.Size = new System.Drawing.Size(342, 296);
            this.dgvTPlatillo.TabIndex = 16;
            this.dgvTPlatillo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTPlatillo_CellContentClick);
            // 
            // btnNuevoTipo
            // 
            this.btnNuevoTipo.Location = new System.Drawing.Point(349, 314);
            this.btnNuevoTipo.Name = "btnNuevoTipo";
            this.btnNuevoTipo.Size = new System.Drawing.Size(62, 28);
            this.btnNuevoTipo.TabIndex = 27;
            this.btnNuevoTipo.Text = "Nuevo Tipo";
            this.btnNuevoTipo.UseVisualStyleBackColor = true;
            this.btnNuevoTipo.Click += new System.EventHandler(this.btnNuevoTipo_Click);
            // 
            // btnDatosTipo
            // 
            this.btnDatosTipo.Location = new System.Drawing.Point(561, 314);
            this.btnDatosTipo.Name = "btnDatosTipo";
            this.btnDatosTipo.Size = new System.Drawing.Size(81, 28);
            this.btnDatosTipo.TabIndex = 26;
            this.btnDatosTipo.Text = "Editar Datos";
            this.btnDatosTipo.UseVisualStyleBackColor = true;
            this.btnDatosTipo.Click += new System.EventHandler(this.btnDatosTipo_Click);
            // 
            // MantenedorTipoPlatillo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(237)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(703, 417);
            this.Controls.Add(this.btnNuevoTipo);
            this.Controls.Add(this.btnDatosTipo);
            this.Controls.Add(this.gbDatosTPlatillo);
            this.Controls.Add(this.btnInhabilitarTPlatillo);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnModificarTPlatillo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnAgregarTPlatillo);
            this.Controls.Add(this.dgvTPlatillo);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "MantenedorTipoPlatillo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipos de Plato";
            this.gbDatosTPlatillo.ResumeLayout(false);
            this.gbDatosTPlatillo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTPlatillo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatosTPlatillo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chbEstadoTPlatillo;
        private System.Windows.Forms.TextBox txtIdTPlatillo;
        private System.Windows.Forms.TextBox txtNombreTPlatillo;
        private System.Windows.Forms.Button btnInhabilitarTPlatillo;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnModificarTPlatillo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnAgregarTPlatillo;
        private System.Windows.Forms.DataGridView dgvTPlatillo;
        private System.Windows.Forms.Button btnNuevoTipo;
        private System.Windows.Forms.Button btnDatosTipo;
    }
}