namespace MOANSO_PF
{
    partial class TipoBebida
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
            this.label3 = new System.Windows.Forms.Label();
            this.dgvTipoBebidas = new System.Windows.Forms.DataGridView();
            this.gbDatosTBebida = new System.Windows.Forms.GroupBox();
            this.chbEstadoTBebida = new System.Windows.Forms.CheckBox();
            this.btnInhabilitarTBebida = new System.Windows.Forms.Button();
            this.btnModificarTBebida = new System.Windows.Forms.Button();
            this.btnAgregarTBebida = new System.Windows.Forms.Button();
            this.txtNombreTBebida = new System.Windows.Forms.TextBox();
            this.txtIdTipo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNuevoTipo = new System.Windows.Forms.Button();
            this.btnDatosTipo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoBebidas)).BeginInit();
            this.gbDatosTBebida.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 314);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipos de Bebida";
            // 
            // dgvTipoBebidas
            // 
            this.dgvTipoBebidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoBebidas.Location = new System.Drawing.Point(38, 348);
            this.dgvTipoBebidas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTipoBebidas.Name = "dgvTipoBebidas";
            this.dgvTipoBebidas.RowHeadersWidth = 51;
            this.dgvTipoBebidas.RowTemplate.Height = 24;
            this.dgvTipoBebidas.Size = new System.Drawing.Size(382, 161);
            this.dgvTipoBebidas.TabIndex = 4;
            this.dgvTipoBebidas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTipoBebidas_CellContentClick);
            // 
            // gbDatosTBebida
            // 
            this.gbDatosTBebida.Controls.Add(this.chbEstadoTBebida);
            this.gbDatosTBebida.Controls.Add(this.btnInhabilitarTBebida);
            this.gbDatosTBebida.Controls.Add(this.btnModificarTBebida);
            this.gbDatosTBebida.Controls.Add(this.btnAgregarTBebida);
            this.gbDatosTBebida.Controls.Add(this.txtNombreTBebida);
            this.gbDatosTBebida.Controls.Add(this.txtIdTipo);
            this.gbDatosTBebida.Controls.Add(this.label2);
            this.gbDatosTBebida.Controls.Add(this.label1);
            this.gbDatosTBebida.Location = new System.Drawing.Point(46, 11);
            this.gbDatosTBebida.Margin = new System.Windows.Forms.Padding(2);
            this.gbDatosTBebida.Name = "gbDatosTBebida";
            this.gbDatosTBebida.Padding = new System.Windows.Forms.Padding(2);
            this.gbDatosTBebida.Size = new System.Drawing.Size(364, 234);
            this.gbDatosTBebida.TabIndex = 3;
            this.gbDatosTBebida.TabStop = false;
            this.gbDatosTBebida.Text = "Datos de Bebida";
            // 
            // chbEstadoTBebida
            // 
            this.chbEstadoTBebida.AutoSize = true;
            this.chbEstadoTBebida.Location = new System.Drawing.Point(24, 118);
            this.chbEstadoTBebida.Margin = new System.Windows.Forms.Padding(2);
            this.chbEstadoTBebida.Name = "chbEstadoTBebida";
            this.chbEstadoTBebida.Size = new System.Drawing.Size(76, 24);
            this.chbEstadoTBebida.TabIndex = 3;
            this.chbEstadoTBebida.Text = "Estado";
            this.chbEstadoTBebida.UseVisualStyleBackColor = true;
            // 
            // btnInhabilitarTBebida
            // 
            this.btnInhabilitarTBebida.Location = new System.Drawing.Point(239, 176);
            this.btnInhabilitarTBebida.Margin = new System.Windows.Forms.Padding(2);
            this.btnInhabilitarTBebida.Name = "btnInhabilitarTBebida";
            this.btnInhabilitarTBebida.Size = new System.Drawing.Size(92, 28);
            this.btnInhabilitarTBebida.TabIndex = 6;
            this.btnInhabilitarTBebida.Text = "Inhabilitar";
            this.btnInhabilitarTBebida.UseVisualStyleBackColor = true;
            this.btnInhabilitarTBebida.Click += new System.EventHandler(this.btnInhabilitarTBebida_Click);
            // 
            // btnModificarTBebida
            // 
            this.btnModificarTBebida.Location = new System.Drawing.Point(143, 176);
            this.btnModificarTBebida.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarTBebida.Name = "btnModificarTBebida";
            this.btnModificarTBebida.Size = new System.Drawing.Size(77, 28);
            this.btnModificarTBebida.TabIndex = 5;
            this.btnModificarTBebida.Text = "Modificar";
            this.btnModificarTBebida.UseVisualStyleBackColor = true;
            this.btnModificarTBebida.Click += new System.EventHandler(this.btnModificarTBebida_Click);
            // 
            // btnAgregarTBebida
            // 
            this.btnAgregarTBebida.Location = new System.Drawing.Point(45, 176);
            this.btnAgregarTBebida.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarTBebida.Name = "btnAgregarTBebida";
            this.btnAgregarTBebida.Size = new System.Drawing.Size(79, 28);
            this.btnAgregarTBebida.TabIndex = 4;
            this.btnAgregarTBebida.Text = "Agregar";
            this.btnAgregarTBebida.UseVisualStyleBackColor = true;
            this.btnAgregarTBebida.Click += new System.EventHandler(this.btnAgregarTBebida_Click);
            // 
            // txtNombreTBebida
            // 
            this.txtNombreTBebida.Location = new System.Drawing.Point(144, 32);
            this.txtNombreTBebida.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreTBebida.Name = "txtNombreTBebida";
            this.txtNombreTBebida.Size = new System.Drawing.Size(76, 27);
            this.txtNombreTBebida.TabIndex = 3;
            // 
            // txtIdTipo
            // 
            this.txtIdTipo.Location = new System.Drawing.Point(144, 74);
            this.txtIdTipo.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdTipo.Name = "txtIdTipo";
            this.txtIdTipo.Size = new System.Drawing.Size(76, 27);
            this.txtIdTipo.TabIndex = 2;
            this.txtIdTipo.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Tipo Bebida:";
            this.label1.Visible = false;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(22, 514);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(80, 33);
            this.btnRegresar.TabIndex = 17;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(364, 514);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(84, 33);
            this.btnConfirmar.TabIndex = 20;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(210, 514);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 33);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnNuevoTipo
            // 
            this.btnNuevoTipo.Location = new System.Drawing.Point(112, 250);
            this.btnNuevoTipo.Name = "btnNuevoTipo";
            this.btnNuevoTipo.Size = new System.Drawing.Size(80, 34);
            this.btnNuevoTipo.TabIndex = 29;
            this.btnNuevoTipo.Text = "Nuevo Tipo";
            this.btnNuevoTipo.UseVisualStyleBackColor = true;
            this.btnNuevoTipo.Click += new System.EventHandler(this.btnNuevoTBebida_Click);
            // 
            // btnDatosTipo
            // 
            this.btnDatosTipo.Location = new System.Drawing.Point(260, 250);
            this.btnDatosTipo.Name = "btnDatosTipo";
            this.btnDatosTipo.Size = new System.Drawing.Size(76, 34);
            this.btnDatosTipo.TabIndex = 28;
            this.btnDatosTipo.Text = "Editar Datos";
            this.btnDatosTipo.UseVisualStyleBackColor = true;
            this.btnDatosTipo.Click += new System.EventHandler(this.btnDatosTBebida_Click);
            // 
            // TipoBebida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(237)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(471, 559);
            this.Controls.Add(this.btnNuevoTipo);
            this.Controls.Add(this.btnDatosTipo);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvTipoBebidas);
            this.Controls.Add(this.gbDatosTBebida);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "TipoBebida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipos de Bebida";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoBebidas)).EndInit();
            this.gbDatosTBebida.ResumeLayout(false);
            this.gbDatosTBebida.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvTipoBebidas;
        private System.Windows.Forms.GroupBox gbDatosTBebida;
        private System.Windows.Forms.CheckBox chbEstadoTBebida;
        private System.Windows.Forms.Button btnInhabilitarTBebida;
        private System.Windows.Forms.Button btnModificarTBebida;
        private System.Windows.Forms.Button btnAgregarTBebida;
        private System.Windows.Forms.TextBox txtNombreTBebida;
        private System.Windows.Forms.TextBox txtIdTipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNuevoTipo;
        private System.Windows.Forms.Button btnDatosTipo;
    }
}