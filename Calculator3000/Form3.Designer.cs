namespace Calculator3000
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btRestarNumero = new System.Windows.Forms.Button();
            this.tbResta_1 = new System.Windows.Forms.TextBox();
            this.tbResta_2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero 2:";
            // 
            // btRestarNumero
            // 
            this.btRestarNumero.AutoSize = true;
            this.btRestarNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRestarNumero.Location = new System.Drawing.Point(192, 287);
            this.btRestarNumero.Name = "btRestarNumero";
            this.btRestarNumero.Size = new System.Drawing.Size(75, 30);
            this.btRestarNumero.TabIndex = 2;
            this.btRestarNumero.Text = "Restar";
            this.btRestarNumero.UseVisualStyleBackColor = true;
            this.btRestarNumero.Click += new System.EventHandler(this.btRestarNumero_Click);
            // 
            // tbResta_1
            // 
            this.tbResta_1.Location = new System.Drawing.Point(192, 93);
            this.tbResta_1.Name = "tbResta_1";
            this.tbResta_1.Size = new System.Drawing.Size(100, 20);
            this.tbResta_1.TabIndex = 3;
            this.tbResta_1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbResta_2
            // 
            this.tbResta_2.Location = new System.Drawing.Point(192, 189);
            this.tbResta_2.Name = "tbResta_2";
            this.tbResta_2.Size = new System.Drawing.Size(100, 20);
            this.tbResta_2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(198, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Resta";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbResta_2);
            this.Controls.Add(this.tbResta_1);
            this.Controls.Add(this.btRestarNumero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(500, 400);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btRestarNumero;
        private System.Windows.Forms.TextBox tbResta_1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbResta_2;
    }
}