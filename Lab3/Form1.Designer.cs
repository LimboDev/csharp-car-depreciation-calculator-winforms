namespace Lab3
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbError = new System.Windows.Forms.Label();
            this.btInfo = new System.Windows.Forms.Button();
            this.tbCosto = new System.Windows.Forms.TextBox();
            this.tbAño = new System.Windows.Forms.TextBox();
            this.tbModelo = new System.Windows.Forms.TextBox();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agencia El Buen Auto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marca del Auto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Modelo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Año de Fabricación:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 165);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Costo Original:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbError);
            this.groupBox1.Controls.Add(this.btInfo);
            this.groupBox1.Controls.Add(this.tbCosto);
            this.groupBox1.Controls.Add(this.tbAño);
            this.groupBox1.Controls.Add(this.tbModelo);
            this.groupBox1.Controls.Add(this.tbMarca);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 116);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(868, 341);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese los Datos de su Auto:";
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.Location = new System.Drawing.Point(475, 49);
            this.lbError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(0, 22);
            this.lbError.TabIndex = 10;
            // 
            // btInfo
            // 
            this.btInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btInfo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btInfo.Location = new System.Drawing.Point(240, 226);
            this.btInfo.Margin = new System.Windows.Forms.Padding(4);
            this.btInfo.Name = "btInfo";
            this.btInfo.Size = new System.Drawing.Size(133, 54);
            this.btInfo.TabIndex = 9;
            this.btInfo.Text = "Guardar Información";
            this.btInfo.UseVisualStyleBackColor = true;
            this.btInfo.Click += new System.EventHandler(this.btInfo_Click);
            // 
            // tbCosto
            // 
            this.tbCosto.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbCosto.Location = new System.Drawing.Point(240, 165);
            this.tbCosto.Margin = new System.Windows.Forms.Padding(4);
            this.tbCosto.MaxLength = 10;
            this.tbCosto.Name = "tbCosto";
            this.tbCosto.Size = new System.Drawing.Size(132, 27);
            this.tbCosto.TabIndex = 8;
            this.tbCosto.TextChanged += new System.EventHandler(this.tbCosto_TextChanged);
            // 
            // tbAño
            // 
            this.tbAño.Location = new System.Drawing.Point(240, 123);
            this.tbAño.Margin = new System.Windows.Forms.Padding(4);
            this.tbAño.MaxLength = 4;
            this.tbAño.Name = "tbAño";
            this.tbAño.Size = new System.Drawing.Size(132, 27);
            this.tbAño.TabIndex = 7;
            this.tbAño.TextChanged += new System.EventHandler(this.tbAño_TextChanged);
            // 
            // tbModelo
            // 
            this.tbModelo.Location = new System.Drawing.Point(240, 82);
            this.tbModelo.Margin = new System.Windows.Forms.Padding(4);
            this.tbModelo.MaxLength = 20;
            this.tbModelo.Name = "tbModelo";
            this.tbModelo.Size = new System.Drawing.Size(132, 27);
            this.tbModelo.TabIndex = 6;
            this.tbModelo.TextChanged += new System.EventHandler(this.tbModelo_TextChanged);
            // 
            // tbMarca
            // 
            this.tbMarca.Location = new System.Drawing.Point(240, 47);
            this.tbMarca.Margin = new System.Windows.Forms.Padding(4);
            this.tbMarca.MaxLength = 30;
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(132, 27);
            this.tbMarca.TabIndex = 5;
            this.tbMarca.TextChanged += new System.EventHandler(this.tbMarca_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Agencia de auto";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbCosto;
        private System.Windows.Forms.TextBox tbAño;
        private System.Windows.Forms.TextBox tbModelo;
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.Button btInfo;
        private System.Windows.Forms.Label lbError;
    }
}

