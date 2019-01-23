namespace NHSAnagram
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
            this.button1 = new System.Windows.Forms.Button();
            this.Word1 = new System.Windows.Forms.TextBox();
            this.Word2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(434, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 135);
            this.button1.TabIndex = 0;
            this.button1.Text = "Test Anagram";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Word1
            // 
            this.Word1.BackColor = System.Drawing.SystemColors.Control;
            this.Word1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Word1.Location = new System.Drawing.Point(204, 83);
            this.Word1.Name = "Word1";
            this.Word1.Size = new System.Drawing.Size(226, 31);
            this.Word1.TabIndex = 1;
            this.Word1.TextChanged += new System.EventHandler(this.Word1_TextChanged);
            // 
            // Word2
            // 
            this.Word2.BackColor = System.Drawing.SystemColors.Control;
            this.Word2.Location = new System.Drawing.Point(630, 83);
            this.Word2.Name = "Word2";
            this.Word2.Size = new System.Drawing.Size(242, 31);
            this.Word2.TabIndex = 2;
            this.Word2.TextChanged += new System.EventHandler(this.Word2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(308, 227);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(419, 31);
            this.textBox1.TabIndex = 3;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 715);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Word2);
            this.Controls.Add(this.Word1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Word1;
        private System.Windows.Forms.TextBox Word2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

