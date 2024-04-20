namespace Calculator3000
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDividir_1 = new System.Windows.Forms.TextBox();
            this.tbDividir_2 = new System.Windows.Forms.TextBox();
            this.btDividirNumero = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Division";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero 2:";
            // 
            // tbDividir_1
            // 
            this.tbDividir_1.Location = new System.Drawing.Point(192, 93);
            this.tbDividir_1.Name = "tbDividir_1";
            this.tbDividir_1.Size = new System.Drawing.Size(100, 20);
            this.tbDividir_1.TabIndex = 3;
            // 
            // tbDividir_2
            // 
            this.tbDividir_2.Location = new System.Drawing.Point(192, 189);
            this.tbDividir_2.Name = "tbDividir_2";
            this.tbDividir_2.Size = new System.Drawing.Size(100, 20);
            this.tbDividir_2.TabIndex = 4;
            // 
            // btDividirNumero
            // 
            this.btDividirNumero.AutoSize = true;
            this.btDividirNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDividirNumero.Location = new System.Drawing.Point(192, 287);
            this.btDividirNumero.Name = "btDividirNumero";
            this.btDividirNumero.Size = new System.Drawing.Size(75, 30);
            this.btDividirNumero.TabIndex = 5;
            this.btDividirNumero.Text = "Dividir";
            this.btDividirNumero.UseVisualStyleBackColor = true;
            this.btDividirNumero.Click += new System.EventHandler(this.btDividirNumero_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.btDividirNumero);
            this.Controls.Add(this.tbDividir_2);
            this.Controls.Add(this.tbDividir_1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(500, 400);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDividir_1;
        private System.Windows.Forms.TextBox tbDividir_2;
        private System.Windows.Forms.Button btDividirNumero;
    }
}