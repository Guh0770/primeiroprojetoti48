namespace primeiroprojetoti48
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Calculado = new System.Windows.Forms.Label();
            this.AD = new System.Windows.Forms.Button();
            this.SUB = new System.Windows.Forms.Button();
            this.MUL = new System.Windows.Forms.Button();
            this.DIV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(78, 230);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 40);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(479, 230);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(196, 40);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(103, 358);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(562, 47);
            this.textBox3.TabIndex = 3;
            // 
            // Calculado
            // 
            this.Calculado.AutoSize = true;
            this.Calculado.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculado.Location = new System.Drawing.Point(205, 78);
            this.Calculado.Name = "Calculado";
            this.Calculado.Size = new System.Drawing.Size(375, 73);
            this.Calculado.TabIndex = 4;
            this.Calculado.Text = "Calculadora";
            // 
            // AD
            // 
            this.AD.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AD.Location = new System.Drawing.Point(218, 449);
            this.AD.Name = "AD";
            this.AD.Size = new System.Drawing.Size(56, 52);
            this.AD.TabIndex = 5;
            this.AD.Text = "+";
            this.AD.UseVisualStyleBackColor = true;
            this.AD.Click += new System.EventHandler(this.AD_Click);
            // 
            // SUB
            // 
            this.SUB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SUB.Location = new System.Drawing.Point(297, 449);
            this.SUB.Name = "SUB";
            this.SUB.Size = new System.Drawing.Size(56, 52);
            this.SUB.TabIndex = 5;
            this.SUB.Text = "-";
            this.SUB.UseVisualStyleBackColor = true;
            this.SUB.Click += new System.EventHandler(this.SUB_Click);
            // 
            // MUL
            // 
            this.MUL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MUL.Location = new System.Drawing.Point(375, 449);
            this.MUL.Name = "MUL";
            this.MUL.Size = new System.Drawing.Size(56, 52);
            this.MUL.TabIndex = 5;
            this.MUL.Text = "X";
            this.MUL.UseVisualStyleBackColor = true;
            this.MUL.Click += new System.EventHandler(this.MUL_Click);
            // 
            // DIV
            // 
            this.DIV.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DIV.Location = new System.Drawing.Point(456, 449);
            this.DIV.Name = "DIV";
            this.DIV.Size = new System.Drawing.Size(56, 52);
            this.DIV.TabIndex = 5;
            this.DIV.Text = "/";
            this.DIV.UseVisualStyleBackColor = true;
            this.DIV.Click += new System.EventHandler(this.DIV_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 529);
            this.Controls.Add(this.DIV);
            this.Controls.Add(this.MUL);
            this.Controls.Add(this.SUB);
            this.Controls.Add(this.AD);
            this.Controls.Add(this.Calculado);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "f";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label Calculado;
        private System.Windows.Forms.Button AD;
        private System.Windows.Forms.Button SUB;
        private System.Windows.Forms.Button MUL;
        private System.Windows.Forms.Button DIV;
    }
}

