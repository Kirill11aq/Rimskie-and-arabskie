namespace Rimskie_and_arabskie
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
            btnConvertToRoman_Click = new Button();
            btnConvertToArabic_Click = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // btnConvertToRoman_Click
            // 
            btnConvertToRoman_Click.Location = new Point(88, 46);
            btnConvertToRoman_Click.Name = "btnConvertToRoman_Click";
            btnConvertToRoman_Click.Size = new Size(119, 76);
            btnConvertToRoman_Click.TabIndex = 0;
            btnConvertToRoman_Click.Text = "rimskie";
            btnConvertToRoman_Click.UseVisualStyleBackColor = true;
            btnConvertToRoman_Click.Click += button1_Click;
            // 
            // btnConvertToArabic_Click
            // 
            btnConvertToArabic_Click.Location = new Point(383, 46);
            btnConvertToArabic_Click.Name = "btnConvertToArabic_Click";
            btnConvertToArabic_Click.Size = new Size(119, 76);
            btnConvertToArabic_Click.TabIndex = 0;
            btnConvertToArabic_Click.Text = "arabskie";
            btnConvertToArabic_Click.UseVisualStyleBackColor = true;
            btnConvertToArabic_Click.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(153, 249);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(294, 232);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(304, 23);
            textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(btnConvertToArabic_Click);
            Controls.Add(btnConvertToRoman_Click);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConvertToRoman_Click;
        private Button btnConvertToArabic_Click;
        private Label label1;
        private TextBox textBox1;
    }
}