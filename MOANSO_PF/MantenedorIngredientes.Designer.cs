namespace MOANSO_PF
{
    partial class MantenedorIngredientes
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDIngrediente = new System.Windows.Forms.TextBox();
            this.txtNombreIngrediente = new System.Windows.Forms.TextBox();
            this.chbEstadoIngrediente = new System.Windows.Forms.CheckBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnAgregarIngrediente = new System.Windows.Forms.Button();
            this.btnModificarIngrediente = new System.Windows.Forms.Button();
            this.btnInhabilitarIngrediente = new System.Windows.Forms.Button();
            this.dgvIngredientes = new System.Windows.Forms.DataGridView();
            this.txtCantidadIngrediente = new System.Windows.Forms.TextBox();
            this.gbDatosIngredientes = new System.Windows.Forms.GroupBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnDatos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredientes)).BeginInit();
            this.gbDatosIngredientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Ingrediente:";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre del Ingrediente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cantidad :";
            // 
            // txtIDIngrediente
            // 
            this.txtIDIngrediente.Location = new System.Drawing.Point(114, 116);
            this.txtIDIngrediente.Name = "txtIDIngrediente";
            this.txtIDIngrediente.Size = new System.Drawing.Size(104, 27);
            this.txtIDIngrediente.TabIndex = 4;
            this.txtIDIngrediente.Visible = false;
            // 
            // txtNombreIngrediente
            // 
            this.txtNombreIngrediente.Location = new System.Drawing.Point(18, 75);
            this.txtNombreIngrediente.Name = "txtNombreIngrediente";
            this.txtNombreIngrediente.Size = new System.Drawing.Size(200, 27);
            this.txtNombreIngrediente.TabIndex = 5;
            // 
            // chbEstadoIngrediente
            // 
            this.chbEstadoIngrediente.AutoSize = true;
            this.chbEstadoIngrediente.Location = new System.Drawing.Point(10, 198);
            this.chbEstadoIngrediente.Name = "chbEstadoIngrediente";
            this.chbEstadoIngrediente.Size = new System.Drawing.Size(76, 24);
            this.chbEstadoIngrediente.TabIndex = 7;
            this.chbEstadoIngrediente.Text = "Estado";
            this.chbEstadoIngrediente.UseVisualStyleBackColor = true;
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
            // btnAgregarIngrediente
            // 
            this.btnAgregarIngrediente.Location = new System.Drawing.Point(59, 292);
            this.btnAgregarIngrediente.Name = "btnAgregarIngrediente";
            this.btnAgregarIngrediente.Size = new System.Drawing.Size(75, 33);
            this.btnAgregarIngrediente.TabIndex = 11;
            this.btnAgregarIngrediente.Text = "Agregar";
            this.btnAgregarIngrediente.UseVisualStyleBackColor = true;
            this.btnAgregarIngrediente.Click += new System.EventHandler(this.btnAgregarIngrediente_Click);
            // 
            // btnModificarIngrediente
            // 
            this.btnModificarIngrediente.Location = new System.Drawing.Point(199, 292);
            this.btnModificarIngrediente.Name = "btnModificarIngrediente";
            this.btnModificarIngrediente.Size = new System.Drawing.Size(80, 33);
            this.btnModificarIngrediente.TabIndex = 12;
            this.btnModificarIngrediente.Text = "Modificar";
            this.btnModificarIngrediente.UseVisualStyleBackColor = true;
            this.btnModificarIngrediente.Click += new System.EventHandler(this.btnModificarIngrediente_Click);
            // 
            // btnInhabilitarIngrediente
            // 
            this.btnInhabilitarIngrediente.Location = new System.Drawing.Point(128, 343);
            this.btnInhabilitarIngrediente.Name = "btnInhabilitarIngrediente";
            this.btnInhabilitarIngrediente.Size = new System.Drawing.Size(85, 31);
            this.btnInhabilitarIngrediente.TabIndex = 13;
            this.btnInhabilitarIngrediente.Text = "Inhabilitar";
            this.btnInhabilitarIngrediente.UseVisualStyleBackColor = true;
            this.btnInhabilitarIngrediente.Click += new System.EventHandler(this.btnInhabilitarIngrediente_Click);
            // 
            // dgvIngredientes
            // 
            this.dgvIngredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngredientes.Location = new System.Drawing.Point(299, 41);
            this.dgvIngredientes.Name = "dgvIngredientes";
            this.dgvIngredientes.RowHeadersWidth = 51;
            this.dgvIngredientes.Size = new System.Drawing.Size(464, 251);
            this.dgvIngredientes.TabIndex = 14;
            this.dgvIngredientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIngredientes_CellContentClick);
            // 
            // txtCantidadIngrediente
            // 
            this.txtCantidadIngrediente.Location = new System.Drawing.Point(114, 154);
            this.txtCantidadIngrediente.Name = "txtCantidadIngrediente";
            this.txtCantidadIngrediente.Size = new System.Drawing.Size(104, 27);
            this.txtCantidadIngrediente.TabIndex = 15;
            // 
            // gbDatosIngredientes
            // 
            this.gbDatosIngredientes.Controls.Add(this.chbEstadoIngrediente);
            this.gbDatosIngredientes.Controls.Add(this.txtCantidadIngrediente);
            this.gbDatosIngredientes.Controls.Add(this.label1);
            this.gbDatosIngredientes.Controls.Add(this.label2);
            this.gbDatosIngredientes.Controls.Add(this.label3);
            this.gbDatosIngredientes.Controls.Add(this.txtIDIngrediente);
            this.gbDatosIngredientes.Controls.Add(this.txtNombreIngrediente);
            this.gbDatosIngredientes.Location = new System.Drawing.Point(49, 41);
            this.gbDatosIngredientes.Name = "gbDatosIngredientes";
            this.gbDatosIngredientes.Size = new System.Drawing.Size(244, 228);
            this.gbDatosIngredientes.TabIndex = 16;
            this.gbDatosIngredientes.TabStop = false;
            this.gbDatosIngredientes.Text = "Datos del Ingrediente:";
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
            // MantenedorIngredientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 237, 214);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnDatos);
            this.Controls.Add(this.gbDatosIngredientes);
            this.Controls.Add(this.dgvIngredientes);
            this.Controls.Add(this.btnInhabilitarIngrediente);
            this.Controls.Add(this.btnModificarIngrediente);
            this.Controls.Add(this.btnAgregarIngrediente);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegresar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "MantenedorIngredientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingredientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredientes)).EndInit();
            this.gbDatosIngredientes.ResumeLayout(false);
            this.gbDatosIngredientes.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDIngrediente;
        private System.Windows.Forms.TextBox txtNombreIngrediente;
        private System.Windows.Forms.CheckBox chbEstadoIngrediente;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnAgregarIngrediente;
        private System.Windows.Forms.Button btnModificarIngrediente;
        private System.Windows.Forms.Button btnInhabilitarIngrediente;
        private System.Windows.Forms.DataGridView dgvIngredientes;
        private System.Windows.Forms.TextBox txtCantidadIngrediente;
        private System.Windows.Forms.GroupBox gbDatosIngredientes;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnDatos;
    }
}
