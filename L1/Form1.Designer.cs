namespace L1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            customTextBox1 = new Library.CustomTextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // customTextBox1
            // 
            customTextBox1.BackColor = Color.Red;
            customTextBox1.Location = new Point(12, 12);
            customTextBox1.MaxValue = 5F;
            customTextBox1.MinValue = 0F;
            customTextBox1.Name = "customTextBox1";
            customTextBox1.Size = new Size(125, 27);
            customTextBox1.TabIndex = 0;
            customTextBox1.InvalidValue += customTextBox1_InvalidValue;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(158, 15);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 1;
            label1.Text = "Error";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += customTextBox1_InvalidValue;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(customTextBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Library.CustomTextBox customTextBox1;
        private Label label1;
        private TextBox textBox1;
    }
}
