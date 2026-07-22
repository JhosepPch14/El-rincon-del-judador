namespace MOANSO_PF
{
    partial class MantenedorMesero
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
            this.gbDatosMesero = new System.Windows.Forms.GroupBox();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chbEstadoMesero = new System.Windows.Forms.CheckBox();
            this.txtIdMesero = new System.Windows.Forms.TextBox();
            this.txtNombreMesero = new System.Windows.Forms.TextBox();
            this.txtDNIMesero = new System.Windows.Forms.TextBox();
            this.btnInhabilitarMesero = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnModificarMesero = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnAgregarMesero = new System.Windows.Forms.Button();
            this.dgvMesero = new System.Windows.Forms.DataGridView();
            this.gbDatosMesero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesero)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDatosMesero
            // 
            this.gbDatosMesero.Controls.Add(this.dtpFechaIngreso);
            this.gbDatosMesero.Controls.Add(this.label5);
            this.gbDatosMesero.Controls.Add(this.label1);
            this.gbDatosMesero.Controls.Add(this.txtTelefono);
            this.gbDatosMesero.Controls.Add(this.label2);
            this.gbDatosMesero.Controls.Add(this.label3);
            this.gbDatosMesero.Controls.Add(this.label4);
            this.gbDatosMesero.Controls.Add(this.chbEstadoMesero);
            this.gbDatosMesero.Controls.Add(this.txtIdMesero);
            this.gbDatosMesero.Controls.Add(this.txtNombreMesero);
            this.gbDatosMesero.Controls.Add(this.txtDNIMesero);
            this.gbDatosMesero.Location = new System.Drawing.Point(40, 26);
            this.gbDatosMesero.Margin = new System.Windows.Forms.Padding(4);
            this.gbDatosMesero.Name = "gbDatosMesero";
            this.gbDatosMesero.Padding = new System.Windows.Forms.Padding(4);
            this.gbDatosMesero.Size = new System.Drawing.Size(472, 329);
            this.gbDatosMesero.TabIndex = 23;
            this.gbDatosMesero.TabStop = false;
            this.gbDatosMesero.Text = "Datos del Mesero";
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Location = new System.Drawing.Point(160, 215);
            this.dtpFechaIngreso.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(265, 27);
            this.dtpFechaIngreso.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 220);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fecha de Ingreso:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 178);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Telefono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(160, 171);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(132, 27);
            this.txtTelefono.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Mesero:";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre Mesero:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 127);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "DNI Mesero:";
            // 
            // chbEstadoMesero
            // 
            this.chbEstadoMesero.AutoSize = true;
            this.chbEstadoMesero.Location = new System.Drawing.Point(24, 279);
            this.chbEstadoMesero.Margin = new System.Windows.Forms.Padding(4);
            this.chbEstadoMesero.Name = "chbEstadoMesero";
            this.chbEstadoMesero.Size = new System.Drawing.Size(76, 24);
            this.chbEstadoMesero.TabIndex = 4;
            this.chbEstadoMesero.Text = "Estado";
            this.chbEstadoMesero.UseVisualStyleBackColor = true;
            // 
            // txtIdMesero
            // 
            this.txtIdMesero.Location = new System.Drawing.Point(160, 81);
            this.txtIdMesero.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdMesero.Name = "txtIdMesero";
            this.txtIdMesero.Size = new System.Drawing.Size(132, 27);
            this.txtIdMesero.TabIndex = 5;
            this.txtIdMesero.Visible = false;
            // 
            // txtNombreMesero
            // 
            this.txtNombreMesero.Location = new System.Drawing.Point(160, 37);
            this.txtNombreMesero.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreMesero.Name = "txtNombreMesero";
            this.txtNombreMesero.Size = new System.Drawing.Size(132, 27);
            this.txtNombreMesero.TabIndex = 6;
            // 
            // txtDNIMesero
            // 
            this.txtDNIMesero.Location = new System.Drawing.Point(160, 120);
            this.txtDNIMesero.Margin = new System.Windows.Forms.Padding(4);
            this.txtDNIMesero.Name = "txtDNIMesero";
            this.txtDNIMesero.Size = new System.Drawing.Size(132, 27);
            this.txtDNIMesero.TabIndex = 7;
            // 
            // btnInhabilitarMesero
            // 
            this.btnInhabilitarMesero.Location = new System.Drawing.Point(232, 408);
            this.btnInhabilitarMesero.Margin = new System.Windows.Forms.Padding(4);
            this.btnInhabilitarMesero.Name = "btnInhabilitarMesero";
            this.btnInhabilitarMesero.Size = new System.Drawing.Size(100, 30);
            this.btnInhabilitarMesero.TabIndex = 22;
            this.btnInhabilitarMesero.Text = "Inhabilitar";
            this.btnInhabilitarMesero.UseVisualStyleBackColor = true;
            this.btnInhabilitarMesero.Click += new System.EventHandler(this.btnInhabilitarMesero_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(757, 459);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(100, 28);
            this.btnConfirmar.TabIndex = 19;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnModificarMesero
            // 
            this.btnModificarMesero.Location = new System.Drawing.Point(311, 363);
            this.btnModificarMesero.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificarMesero.Name = "btnModificarMesero";
            this.btnModificarMesero.Size = new System.Drawing.Size(100, 28);
            this.btnModificarMesero.TabIndex = 21;
            this.btnModificarMesero.Text = "Modificar";
            this.btnModificarMesero.UseVisualStyleBackColor = true;
            this.btnModificarMesero.Click += new System.EventHandler(this.btnModificarMesero_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(402, 459);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(13, 459);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(100, 28);
            this.btnRegresar.TabIndex = 17;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnAgregarMesero
            // 
            this.btnAgregarMesero.Location = new System.Drawing.Point(151, 363);
            this.btnAgregarMesero.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarMesero.Name = "btnAgregarMesero";
            this.btnAgregarMesero.Size = new System.Drawing.Size(100, 28);
            this.btnAgregarMesero.TabIndex = 20;
            this.btnAgregarMesero.Text = "Agregar";
            this.btnAgregarMesero.UseVisualStyleBackColor = true;
            this.btnAgregarMesero.Click += new System.EventHandler(this.btnAgregarMesero_Click);
            // 
            // dgvMesero
            // 
            this.dgvMesero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMesero.Location = new System.Drawing.Point(530, 26);
            this.dgvMesero.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMesero.Name = "dgvMesero";
            this.dgvMesero.RowHeadersWidth = 51;
            this.dgvMesero.Size = new System.Drawing.Size(310, 364);
            this.dgvMesero.TabIndex = 16;
            this.dgvMesero.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMesero_CellContentClick);
            // 
            // MantenedorMesero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(237)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(870, 500);
            this.Controls.Add(this.gbDatosMesero);
            this.Controls.Add(this.btnInhabilitarMesero);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnModificarMesero);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnAgregarMesero);
            this.Controls.Add(this.dgvMesero);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MantenedorMesero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meseros";
            this.gbDatosMesero.ResumeLayout(false);
            this.gbDatosMesero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesero)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatosMesero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chbEstadoMesero;
        private System.Windows.Forms.TextBox txtIdMesero;
        private System.Windows.Forms.TextBox txtNombreMesero;
        private System.Windows.Forms.TextBox txtDNIMesero;
        private System.Windows.Forms.Button btnInhabilitarMesero;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnModificarMesero;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnAgregarMesero;
        private System.Windows.Forms.DataGridView dgvMesero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
    }
}