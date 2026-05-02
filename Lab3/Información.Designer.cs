namespace Lab3
{
    partial class Información
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbPrecioFinal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCosto = new System.Windows.Forms.Label();
            this.lbAño = new System.Windows.Forms.Label();
            this.lbModelo = new System.Windows.Forms.Label();
            this.lbMarca = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbPrecioFinal);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbCosto);
            this.groupBox1.Controls.Add(this.lbAño);
            this.groupBox1.Controls.Add(this.lbModelo);
            this.groupBox1.Controls.Add(this.lbMarca);
            this.groupBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(37, 57);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(875, 388);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información del auto y costo final";
            // 
            // lbPrecioFinal
            // 
            this.lbPrecioFinal.AutoSize = true;
            this.lbPrecioFinal.Location = new System.Drawing.Point(503, 128);
            this.lbPrecioFinal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPrecioFinal.Name = "lbPrecioFinal";
            this.lbPrecioFinal.Size = new System.Drawing.Size(142, 29);
            this.lbPrecioFinal.TabIndex = 5;
            this.lbPrecioFinal.Text = "Precio final";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(373, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "El Precio Final de su auto es de:";
            // 
            // lbCosto
            // 
            this.lbCosto.AutoSize = true;
            this.lbCosto.Location = new System.Drawing.Point(36, 228);
            this.lbCosto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCosto.Name = "lbCosto";
            this.lbCosto.Size = new System.Drawing.Size(181, 29);
            this.lbCosto.TabIndex = 3;
            this.lbCosto.Text = "Costo Original";
            // 
            // lbAño
            // 
            this.lbAño.AutoSize = true;
            this.lbAño.Location = new System.Drawing.Point(36, 178);
            this.lbAño.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAño.Name = "lbAño";
            this.lbAño.Size = new System.Drawing.Size(239, 29);
            this.lbAño.TabIndex = 2;
            this.lbAño.Text = "Año de Fabricación";
            // 
            // lbModelo
            // 
            this.lbModelo.AutoSize = true;
            this.lbModelo.Location = new System.Drawing.Point(36, 128);
            this.lbModelo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbModelo.Name = "lbModelo";
            this.lbModelo.Size = new System.Drawing.Size(98, 29);
            this.lbModelo.TabIndex = 1;
            this.lbModelo.Text = "Modelo";
            // 
            // lbMarca
            // 
            this.lbMarca.AutoSize = true;
            this.lbMarca.Location = new System.Drawing.Point(36, 71);
            this.lbMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(84, 29);
            this.lbMarca.TabIndex = 0;
            this.lbMarca.Text = "Marca";
            // 
            // Información
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Información";
            this.Text = "Información";
            this.Load += new System.EventHandler(this.Información_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbCosto;
        private System.Windows.Forms.Label lbAño;
        private System.Windows.Forms.Label lbModelo;
        private System.Windows.Forms.Label lbMarca;
        private System.Windows.Forms.Label lbPrecioFinal;
        private System.Windows.Forms.Label label1;
    }
}