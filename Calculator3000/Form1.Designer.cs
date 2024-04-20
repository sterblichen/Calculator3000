namespace Calculator3000
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Title_1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title_1
            // 
            this.Title_1.AutoSize = true;
            this.Title_1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Title_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Title_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_1.Location = new System.Drawing.Point(161, 37);
            this.Title_1.Name = "Title_1";
            this.Title_1.Size = new System.Drawing.Size(165, 27);
            this.Title_1.TabIndex = 0;
            this.Title_1.Text = "Calculator.3000";
            this.Title_1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            ""});
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Items.AddRange(new object[] {
            "Suma",
            "Resta",
            "Multiplicacion",
            "Division"});
            this.comboBox1.Location = new System.Drawing.Point(179, 109);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // confirm
            // 
            this.confirm.AutoSize = true;
            this.confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm.Location = new System.Drawing.Point(203, 252);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(75, 37);
            this.confirm.TabIndex = 2;
            this.confirm.Text = "Aceptar";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Title_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(500, 400);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Label Title_1;
    }
}

