namespace MOANSO_PF
{
    partial class Core
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
            this.btnFormOrdPedido = new System.Windows.Forms.Button();
            this.btnCompVenta = new System.Windows.Forms.Button();
            this.btnReqInsumos = new System.Windows.Forms.Button();
            this.btnCompraReq = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFormOrdPedido
            // 
            this.btnFormOrdPedido.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnFormOrdPedido.ForeColor = System.Drawing.Color.White;
            this.btnFormOrdPedido.BackColor = System.Drawing.Color.FromArgb(139, 111, 71);
            this.btnFormOrdPedido.Location = new System.Drawing.Point(165, 125);
            this.btnFormOrdPedido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFormOrdPedido.Name = "btnFormOrdPedido";
            this.btnFormOrdPedido.Size = new System.Drawing.Size(180, 70);
            this.btnFormOrdPedido.TabIndex = 0;
            this.btnFormOrdPedido.Text = "Nuevo Pedido";
            this.btnFormOrdPedido.UseVisualStyleBackColor = false;
            this.btnFormOrdPedido.Click += new System.EventHandler(this.btnFormOrdPedido_Click);
            // 
            // btnCompVenta
            // 
            this.btnCompVenta.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCompVenta.ForeColor = System.Drawing.Color.White;
            this.btnCompVenta.BackColor = System.Drawing.Color.FromArgb(139, 111, 71);
            this.btnCompVenta.Location = new System.Drawing.Point(375, 125);
            this.btnCompVenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCompVenta.Name = "btnCompVenta";
            this.btnCompVenta.Size = new System.Drawing.Size(180, 70);
            this.btnCompVenta.TabIndex = 1;
            this.btnCompVenta.Text = "Facturación";
            this.btnCompVenta.UseVisualStyleBackColor = false;
            this.btnCompVenta.Click += new System.EventHandler(this.btnCompVenta_Click);
            // 
            // btnReqInsumos
            // 
            this.btnReqInsumos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnReqInsumos.ForeColor = System.Drawing.Color.White;
            this.btnReqInsumos.BackColor = System.Drawing.Color.FromArgb(139, 111, 71);
            this.btnReqInsumos.Location = new System.Drawing.Point(165, 225);
            this.btnReqInsumos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReqInsumos.Name = "btnReqInsumos";
            this.btnReqInsumos.Size = new System.Drawing.Size(180, 70);
            this.btnReqInsumos.TabIndex = 2;
            this.btnReqInsumos.Text = "Pedido de Insumos";
            this.btnReqInsumos.UseVisualStyleBackColor = false;
            this.btnReqInsumos.Click += new System.EventHandler(this.btnReqInsumos_Click);
            // 
            // btnCompraReq
            // 
            this.btnCompraReq.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCompraReq.ForeColor = System.Drawing.Color.White;
            this.btnCompraReq.BackColor = System.Drawing.Color.FromArgb(139, 111, 71);
            this.btnCompraReq.Location = new System.Drawing.Point(375, 225);
            this.btnCompraReq.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCompraReq.Name = "btnCompraReq";
            this.btnCompraReq.Size = new System.Drawing.Size(180, 70);
            this.btnCompraReq.TabIndex = 3;
            this.btnCompraReq.Text = "Compra de Insumos";
            this.btnCompraReq.UseVisualStyleBackColor = false;
            this.btnCompraReq.Click += new System.EventHandler(this.btnCompraReq_Click);
            // 
            // Core
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(237)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(720, 420);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Controls.Add(this.btnCompraReq);
            this.Controls.Add(this.btnReqInsumos);
            this.Controls.Add(this.btnCompVenta);
            this.Controls.Add(this.btnFormOrdPedido);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Core";
            this.Text = "Órdenes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFormOrdPedido;
        private System.Windows.Forms.Button btnCompVenta;
        private System.Windows.Forms.Button btnReqInsumos;
        private System.Windows.Forms.Button btnCompraReq;
    }
}