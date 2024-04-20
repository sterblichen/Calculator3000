namespace Calculator3000
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btMultiplicarNumero = new System.Windows.Forms.Button();
            this.tbMultiplicacion_2 = new System.Windows.Forms.TextBox();
            this.tbMultiplicacion_1 = new System.Windows.Forms.TextBox();
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
            this.label1.Size = new System.Drawing.Size(145, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Multiplicacion";
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
            // btMultiplicarNumero
            // 
            this.btMultiplicarNumero.AutoSize = true;
            this.btMultiplicarNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMultiplicarNumero.Location = new System.Drawing.Point(192, 287);
            this.btMultiplicarNumero.Name = "btMultiplicarNumero";
            this.btMultiplicarNumero.Size = new System.Drawing.Size(89, 30);
            this.btMultiplicarNumero.TabIndex = 3;
            this.btMultiplicarNumero.Text = "Multiplicar";
            this.btMultiplicarNumero.UseVisualStyleBackColor = true;
            this.btMultiplicarNumero.Click += new System.EventHandler(this.btMultiplicarNumero_Click);
            // 
            // tbMultiplicacion_2
            // 
            this.tbMultiplicacion_2.Location = new System.Drawing.Point(192, 189);
            this.tbMultiplicacion_2.Name = "tbMultiplicacion_2";
            this.tbMultiplicacion_2.Size = new System.Drawing.Size(100, 20);
            this.tbMultiplicacion_2.TabIndex = 4;
            // 
            // tbMultiplicacion_1
            // 
            this.tbMultiplicacion_1.Location = new System.Drawing.Point(192, 93);
            this.tbMultiplicacion_1.Name = "tbMultiplicacion_1";
            this.tbMultiplicacion_1.Size = new System.Drawing.Size(100, 20);
            this.tbMultiplicacion_1.TabIndex = 5;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.tbMultiplicacion_1);
            this.Controls.Add(this.tbMultiplicacion_2);
            this.Controls.Add(this.btMultiplicarNumero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(500, 400);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btMultiplicarNumero;
        private System.Windows.Forms.TextBox tbMultiplicacion_2;
        private System.Windows.Forms.TextBox tbMultiplicacion_1;
    }
}