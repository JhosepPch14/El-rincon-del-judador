namespace MOANSO_PF
{
    partial class MantenedorPlatillo
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
            this.chbEstadoPlatillo = new System.Windows.Forms.CheckBox();
            this.txtIdPlatillo = new System.Windows.Forms.TextBox();
            this.txtNombrePlatillo = new System.Windows.Forms.TextBox();
            this.txtPrecioPlatillo = new System.Windows.Forms.TextBox();
            this.dgvPlatillo = new System.Windows.Forms.DataGridView();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnAgregarPlatillo = new System.Windows.Forms.Button();
            this.btnModificarPlatillo = new System.Windows.Forms.Button();
            this.btnInhabilitarPlatillo = new System.Windows.Forms.Button();
            this.gbDatosPlatillo = new System.Windows.Forms.GroupBox();
            this.cbTPlatillo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevoPlatillo = new System.Windows.Forms.Button();
            this.btnDatosPlatillo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlatillo)).BeginInit();
            this.gbDatosPlatillo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Platillo:";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio:";
            // 
            // chbEstadoPlatillo
            // 
            this.chbEstadoPlatillo.AutoSize = true;
            this.chbEstadoPlatillo.Location = new System.Drawing.Point(24, 218);
            this.chbEstadoPlatillo.Name = "chbEstadoPlatillo";
            this.chbEstadoPlatillo.Size = new System.Drawing.Size(76, 24);
            this.chbEstadoPlatillo.TabIndex = 4;
            this.chbEstadoPlatillo.Text = "Estado";
            this.chbEstadoPlatillo.UseVisualStyleBackColor = true;
            // 
            // txtIdPlatillo
            // 
            this.txtIdPlatillo.Location = new System.Drawing.Point(110, 80);
            this.txtIdPlatillo.Name = "txtIdPlatillo";
            this.txtIdPlatillo.Size = new System.Drawing.Size(100, 27);
            this.txtIdPlatillo.TabIndex = 5;
            this.txtIdPlatillo.Visible = false;
            // 
            // txtNombrePlatillo
            // 
            this.txtNombrePlatillo.Location = new System.Drawing.Point(110, 119);
            this.txtNombrePlatillo.Name = "txtNombrePlatillo";
            this.txtNombrePlatillo.Size = new System.Drawing.Size(100, 27);
            this.txtNombrePlatillo.TabIndex = 6;
            // 
            // txtPrecioPlatillo
            // 
            this.txtPrecioPlatillo.Location = new System.Drawing.Point(110, 160);
            this.txtPrecioPlatillo.Name = "txtPrecioPlatillo";
            this.txtPrecioPlatillo.Size = new System.Drawing.Size(100, 27);
            this.txtPrecioPlatillo.TabIndex = 7;
            // 
            // dgvPlatillo
            // 
            this.dgvPlatillo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlatillo.Location = new System.Drawing.Point(341, 42);
            this.dgvPlatillo.Name = "dgvPlatillo";
            this.dgvPlatillo.RowHeadersWidth = 51;
            this.dgvPlatillo.Size = new System.Drawing.Size(342, 296);
            this.dgvPlatillo.TabIndex = 8;
            this.dgvPlatillo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlatillo_CellContentClick);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(18, 443);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(80, 28);
            this.btnRegresar.TabIndex = 9;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(416, 442);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 29);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(616, 442);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(86, 29);
            this.btnConfirmar.TabIndex = 11;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // btnAgregarPlatillo
            // 
            this.btnAgregarPlatillo.Location = new System.Drawing.Point(59, 315);
            this.btnAgregarPlatillo.Name = "btnAgregarPlatillo";
            this.btnAgregarPlatillo.Size = new System.Drawing.Size(88, 32);
            this.btnAgregarPlatillo.TabIndex = 12;
            this.btnAgregarPlatillo.Text = "Agregar";
            this.btnAgregarPlatillo.UseVisualStyleBackColor = true;
            this.btnAgregarPlatillo.Click += new System.EventHandler(this.btnAgregarPlatillo_Click);
            // 
            // btnModificarPlatillo
            // 
            this.btnModificarPlatillo.Location = new System.Drawing.Point(206, 315);
            this.btnModificarPlatillo.Name = "btnModificarPlatillo";
            this.btnModificarPlatillo.Size = new System.Drawing.Size(85, 32);
            this.btnModificarPlatillo.TabIndex = 13;
            this.btnModificarPlatillo.Text = "Modificar";
            this.btnModificarPlatillo.UseVisualStyleBackColor = true;
            this.btnModificarPlatillo.Click += new System.EventHandler(this.btnModificarPlatillo_Click);
            // 
            // btnInhabilitarPlatillo
            // 
            this.btnInhabilitarPlatillo.Location = new System.Drawing.Point(135, 353);
            this.btnInhabilitarPlatillo.Name = "btnInhabilitarPlatillo";
            this.btnInhabilitarPlatillo.Size = new System.Drawing.Size(87, 33);
            this.btnInhabilitarPlatillo.TabIndex = 14;
            this.btnInhabilitarPlatillo.Text = "Inhabilitar";
            this.btnInhabilitarPlatillo.UseVisualStyleBackColor = true;
            this.btnInhabilitarPlatillo.Click += new System.EventHandler(this.btnInhabilitarPlatillo_Click);
            // 
            // gbDatosPlatillo
            // 
            this.gbDatosPlatillo.Controls.Add(this.cbTPlatillo);
            this.gbDatosPlatillo.Controls.Add(this.label1);
            this.gbDatosPlatillo.Controls.Add(this.label2);
            this.gbDatosPlatillo.Controls.Add(this.label3);
            this.gbDatosPlatillo.Controls.Add(this.label4);
            this.gbDatosPlatillo.Controls.Add(this.chbEstadoPlatillo);
            this.gbDatosPlatillo.Controls.Add(this.txtIdPlatillo);
            this.gbDatosPlatillo.Controls.Add(this.txtNombrePlatillo);
            this.gbDatosPlatillo.Controls.Add(this.txtPrecioPlatillo);
            this.gbDatosPlatillo.Location = new System.Drawing.Point(25, 42);
            this.gbDatosPlatillo.Name = "gbDatosPlatillo";
            this.gbDatosPlatillo.Size = new System.Drawing.Size(310, 267);
            this.gbDatosPlatillo.TabIndex = 15;
            this.gbDatosPlatillo.TabStop = false;
            this.gbDatosPlatillo.Text = "Datos del Platillo";
            // 
            // cbTPlatillo
            // 
            this.cbTPlatillo.FormattingEnabled = true;
            this.cbTPlatillo.Location = new System.Drawing.Point(139, 37);
            this.cbTPlatillo.Name = "cbTPlatillo";
            this.cbTPlatillo.Size = new System.Drawing.Size(121, 28);
            this.cbTPlatillo.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tipo de Platillo:";
            // 
            // btnNuevoPlatillo
            // 
            this.btnNuevoPlatillo.Location = new System.Drawing.Point(377, 353);
            this.btnNuevoPlatillo.Name = "btnNuevoPlatillo";
            this.btnNuevoPlatillo.Size = new System.Drawing.Size(128, 33);
            this.btnNuevoPlatillo.TabIndex = 25;
            this.btnNuevoPlatillo.Text = "Nuevo Platillo";
            this.btnNuevoPlatillo.UseVisualStyleBackColor = true;
            this.btnNuevoPlatillo.Click += new System.EventHandler(this.btnNuevoPlatillo_Click);
            // 
            // btnDatosPlatillo
            // 
            this.btnDatosPlatillo.Location = new System.Drawing.Point(533, 353);
            this.btnDatosPlatillo.Name = "btnDatosPlatillo";
            this.btnDatosPlatillo.Size = new System.Drawing.Size(118, 33);
            this.btnDatosPlatillo.TabIndex = 24;
            this.btnDatosPlatillo.Text = "Editar Datos";
            this.btnDatosPlatillo.UseVisualStyleBackColor = true;
            this.btnDatosPlatillo.Click += new System.EventHandler(this.btnDatosPlatillo_Click);
            // 
            // MantenedorPlatillo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(237)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(730, 483);
            this.Controls.Add(this.btnNuevoPlatillo);
            this.Controls.Add(this.btnDatosPlatillo);
            this.Controls.Add(this.gbDatosPlatillo);
            this.Controls.Add(this.btnInhabilitarPlatillo);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnModificarPlatillo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnAgregarPlatillo);
            this.Controls.Add(this.dgvPlatillo);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "MantenedorPlatillo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Platos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlatillo)).EndInit();
            this.gbDatosPlatillo.ResumeLayout(false);
            this.gbDatosPlatillo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chbEstadoPlatillo;
        private System.Windows.Forms.TextBox txtIdPlatillo;
        private System.Windows.Forms.TextBox txtNombrePlatillo;
        private System.Windows.Forms.TextBox txtPrecioPlatillo;
        private System.Windows.Forms.DataGridView dgvPlatillo;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnAgregarPlatillo;
        private System.Windows.Forms.Button btnModificarPlatillo;
        private System.Windows.Forms.Button btnInhabilitarPlatillo;
        private System.Windows.Forms.GroupBox gbDatosPlatillo;
        private System.Windows.Forms.ComboBox cbTPlatillo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNuevoPlatillo;
        private System.Windows.Forms.Button btnDatosPlatillo;
    }
}