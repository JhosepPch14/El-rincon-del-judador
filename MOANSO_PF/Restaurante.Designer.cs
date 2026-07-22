namespace MOANSO_PF
{
    partial class Restaurante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Restaurante));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCore = new System.Windows.Forms.Button();
            this.btnMantenedor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "BIENVENIDOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(10, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(603, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "Restaurante \"El Rincón Del Jugador\"";
            // 
            // btnCore
            // 
            this.btnCore.BackColor = System.Drawing.Color.FromArgb(139, 111, 71);
            this.btnCore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCore.ForeColor = System.Drawing.Color.White;
            this.btnCore.Location = new System.Drawing.Point(10, 200);
            this.btnCore.Margin = new System.Windows.Forms.Padding(4);
            this.btnCore.Name = "btnCore";
            this.btnCore.Size = new System.Drawing.Size(180, 70);
            this.btnCore.TabIndex = 2;
            this.btnCore.Text = "ÓRDENES";
            this.btnCore.UseVisualStyleBackColor = false;
            this.btnCore.Click += new System.EventHandler(this.btnCore_Click);
            // 
            // btnMantenedor
            // 
            this.btnMantenedor.BackColor = System.Drawing.Color.FromArgb(139, 111, 71);
            this.btnMantenedor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnMantenedor.ForeColor = System.Drawing.Color.White;
            this.btnMantenedor.Location = new System.Drawing.Point(220, 200);
            this.btnMantenedor.Margin = new System.Windows.Forms.Padding(4);
            this.btnMantenedor.Name = "btnMantenedor";
            this.btnMantenedor.Size = new System.Drawing.Size(180, 70);
            this.btnMantenedor.TabIndex = 3;
            this.btnMantenedor.Text = "ADMINISTRACIÓN";
            this.btnMantenedor.UseVisualStyleBackColor = false;
            this.btnMantenedor.Click += new System.EventHandler(this.btnMantenedor_Click);
            // 
            // Restaurante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(237)))), ((int)(((byte)(214)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(647, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCore);
            this.Controls.Add(this.btnMantenedor);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Restaurante";
            this.Text = "Restaurante El Rincón Del Jugador";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Restaurante_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCore;
        private System.Windows.Forms.Button btnMantenedor;
    }
}