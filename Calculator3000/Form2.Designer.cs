﻿namespace Calculator3000
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSuma_1 = new System.Windows.Forms.TextBox();
            this.tbSuma_2 = new System.Windows.Forms.TextBox();
            this.btSumarNumero = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero 1: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero 2: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbSuma_1
            // 
            this.tbSuma_1.Location = new System.Drawing.Point(192, 93);
            this.tbSuma_1.Name = "tbSuma_1";
            this.tbSuma_1.Size = new System.Drawing.Size(100, 20);
            this.tbSuma_1.TabIndex = 2;
            // 
            // tbSuma_2
            // 
            this.tbSuma_2.Location = new System.Drawing.Point(192, 189);
            this.tbSuma_2.Name = "tbSuma_2";
            this.tbSuma_2.Size = new System.Drawing.Size(100, 20);
            this.tbSuma_2.TabIndex = 3;
            // 
            // btSumarNumero
            // 
            this.btSumarNumero.AutoSize = true;
            this.btSumarNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSumarNumero.Location = new System.Drawing.Point(192, 287);
            this.btSumarNumero.Name = "btSumarNumero";
            this.btSumarNumero.Size = new System.Drawing.Size(75, 30);
            this.btSumarNumero.TabIndex = 4;
            this.btSumarNumero.Text = "Sumar";
            this.btSumarNumero.UseVisualStyleBackColor = true;
            this.btSumarNumero.Click += new System.EventHandler(this.btSumarNumero_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(198, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Suma";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btSumarNumero);
            this.Controls.Add(this.tbSuma_2);
            this.Controls.Add(this.tbSuma_1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(500, 400);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSuma_1;
        private System.Windows.Forms.TextBox tbSuma_2;
        private System.Windows.Forms.Button btSumarNumero;
        private System.Windows.Forms.Label label3;
    }
}